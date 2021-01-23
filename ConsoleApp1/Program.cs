using OpenKh.Common;
using OpenKh.Kh2;
using OpenKh.Recom;
using OpenKh.Tools.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
    {
        private const string Input = @"D:\Hacking\KHReCoM\models\ps4_stripped\PL0001.MDL";
        private const string Output = @"D:\Hacking\KHReCoM\models\ps4\PL0001_mod.MDL";

        static void Main(string[] args)
		{
            var mdls = File.OpenRead(Input).Using(Mdl.Read);
            var mdl = mdls.First();
            foreach (var bone in mdl.Bones)
                bone.Matrix = System.Numerics.Matrix4x4.Identity;
            mdl.Meshes2 = null;
            mdl.Meshes = mdl.Meshes.Take(10).ToList();

            File.Create(Output).Using(x =>
            {
                x.Position = 0x10;
                Mdl.Write(x, mdls);
                x.Position = 0;
                x.Write(x.Length);
            });
		}
	}
}
