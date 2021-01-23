using System.Numerics;
using Xe.BinaryMapper;

namespace OpenKh.Common
{
    public static class BinaryMapperExtensions
    {
        public static MappingConfiguration ForTypeVector2(this MappingConfiguration cfg) =>
            cfg.ForType<Vector2>(x => new Vector2(
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle()),
                x =>
                {
                    var vector = (Vector2)x.Item;
                    x.Writer.Write(vector.X);
                    x.Writer.Write(vector.Y);
                });

        public static MappingConfiguration ForTypeVector3(this MappingConfiguration cfg) =>
            cfg.ForType<Vector3>(x => new Vector3(
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle()),
                x =>
                {
                    var vector = (Vector3)x.Item;
                    x.Writer.Write(vector.X);
                    x.Writer.Write(vector.Y);
                    x.Writer.Write(vector.Z);
                });

        public static MappingConfiguration ForTypeVector4(this MappingConfiguration cfg) =>
            cfg.ForType<Vector4>(x => new Vector4(
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle()),
                x =>
                {
                    var vector = (Vector4)x.Item;
                    x.Writer.Write(vector.X);
                    x.Writer.Write(vector.Y);
                    x.Writer.Write(vector.Z);
                    x.Writer.Write(vector.W);
                });

        public static MappingConfiguration ForTypeMatrix4x4(this MappingConfiguration cfg) =>
            cfg.ForType<Matrix4x4>(x => new Matrix4x4(
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle(),
                x.Reader.ReadSingle()),
                x =>
                {
                    var matrix = (Matrix4x4)x.Item;
                    x.Writer.Write(matrix.M11);
                    x.Writer.Write(matrix.M12);
                    x.Writer.Write(matrix.M13);
                    x.Writer.Write(matrix.M14);
                    x.Writer.Write(matrix.M21);
                    x.Writer.Write(matrix.M22);
                    x.Writer.Write(matrix.M23);
                    x.Writer.Write(matrix.M24);
                    x.Writer.Write(matrix.M31);
                    x.Writer.Write(matrix.M32);
                    x.Writer.Write(matrix.M33);
                    x.Writer.Write(matrix.M34);
                    x.Writer.Write(matrix.M41);
                    x.Writer.Write(matrix.M42);
                    x.Writer.Write(matrix.M43);
                    x.Writer.Write(matrix.M44);
                });
    }
}
