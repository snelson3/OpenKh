using OpenKh.Engine.Motion;
using OpenKh.Ps2;
using OpenKh.Kh2;
using OpenKh.Recom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace OpenKh.Engine.Parsers
{
    public class MdlComParser : IModelMotion
    {
        private readonly Mdl _mdl;

        public MdlComParser(Mdl mdl)
        {
            _mdl = mdl;
            MeshDescriptors = mdl.Meshes
                .Select(UnstripTriangles)
                .ToList();
            InitialPose = _mdl.Bones.Select(x => x.Matrix).ToArray();
        }

        public List<MeshDescriptor> MeshDescriptors { get; }

        public List<Mdlx.Bone> Bones => new List<Mdlx.Bone>();

        public Matrix4x4[] InitialPose { get; }

        public void ApplyMotion(Matrix4x4[] matrices)
        {
            for (var i = 0; i < MeshDescriptors.Count; i++)
            {
                var meshDescriptor = MeshDescriptors[i];
                var mesh = _mdl.Meshes[i];
                if (mesh.VertexBufferStride == 0x30)
                {
                    for (var j = 0; j < mesh.Vertices.Length; j++)
                    {
                        var pos = Vector3.Transform(mesh.Vertices[j].Position.Position,
                            InitialPose[mesh.Vertices[j].Position.BoneId]);
                        meshDescriptor.Vertices[j].X = pos.X * 100f;
                        meshDescriptor.Vertices[j].Y = pos.Y * 100f;
                        meshDescriptor.Vertices[j].Z = pos.Z * 100f;
                    }
                }
            }
        }

        private static MeshDescriptor UnstripTriangles(Mdl.Mesh mesh)
        {
            var indices = new List<int>(); // TODO optimize this with an array instead
            var vertices = new PositionColoredTextured[mesh.Vertices.Length];

            for (int v = 0; v < mesh.Vertices.Length - 2; v++)
            {
                switch (mesh.Vertices[v + 2].PrimitiveType)
                {
                    case -1: // Discard triangle
                        break;
                    case 0:
                        indices.Add(v);
                        indices.Add(v + 1);
                        indices.Add(v + 2);
                        break;
                    case 0x20: // flip winding
                        indices.Add(v);
                        indices.Add(v + 2);
                        indices.Add(v + 1);
                        break;
                    default:
                        break;
                }
            }

            if (mesh.VertexBufferStride == 0x30)
            {
                for (var i = 0; i < vertices.Length; i++)
                {
                    vertices[i].X = mesh.Vertices[i].Position.Position.X * 100f;
                    vertices[i].Y = mesh.Vertices[i].Position.Position.Y * 100f;
                    vertices[i].Z = mesh.Vertices[i].Position.Position.Z * 100f;
                    vertices[i].Tu = mesh.Vertices[i].Texture.TextureUv.X;
                    vertices[i].Tv = mesh.Vertices[i].Texture.TextureUv.Y;
                    vertices[i].R = 0xFF;
                    vertices[i].G = 0xFF;
                    vertices[i].B = 0xFF;
                    vertices[i].A = 0x7F;
                }
            }

            return new MeshDescriptor
            {
                Indices = indices.ToArray(),
                Vertices = vertices,
                IsOpaque = true,
                TextureIndex = 1,
            };
        }
    }
}
