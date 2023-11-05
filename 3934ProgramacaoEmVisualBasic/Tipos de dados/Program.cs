using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("TAMANHO POR TIPO DE DADOS");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("VALOR MÁXIMO POR TIPO DE DADOS");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("VALOR MÍNIMO POR TIPO DE DADOS");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DECLARAÇÃO DE VARIÁVEIS POR TIPO DE DADOS");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(byte): " + sizeof(byte));
            Console.WriteLine("byte.MinValue: " + byte.MinValue);
            Console.WriteLine("byte.MaxValue: " + byte.MaxValue);
            byte G = 15;
            Console.WriteLine("byte G = 15: " + G);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(ushort): " + sizeof(ushort));
            Console.WriteLine("ushort.MinValue: " + ushort.MinValue);
            Console.WriteLine("ushort.MaxValue: " + ushort.MaxValue);
            ushort H = 25;
            Console.WriteLine("ushort H = 25: " + H);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(uint): " + sizeof(uint));
            Console.WriteLine("uint.MinValue: " + uint.MinValue);
            Console.WriteLine("uint.MaxValue: " + uint.MaxValue);
            uint A = 35u;
            Console.WriteLine("uint A = 35u / 35U: " + A);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(ulong): " + sizeof(ulong));
            Console.WriteLine("ulong.MinValue: " + ulong.MinValue);
            Console.WriteLine("ulong.MaxValue: " + ulong.MaxValue);
            ulong C = 10ul;
            Console.WriteLine("ulong C = 10ul / 10UL: " + C);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(sbyte): " + sizeof(sbyte));
            Console.WriteLine("sbyte.MinValue: " + sbyte.MinValue);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            sbyte I = 20;
            Console.WriteLine("sbyte I = 20: " + I);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(short): " + sizeof(short));
            Console.WriteLine("short.MinValue: " + short.MinValue);
            Console.WriteLine("short.MaxValue: " + short.MaxValue);
            short J = 40;
            Console.WriteLine("short J = 40: " + J);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(int): " + sizeof(int));
            Console.WriteLine("int.MinValue: " + int.MinValue);
            Console.WriteLine("int.MaxValue: " + int.MaxValue);
            int K = 45;
            Console.WriteLine("int K = 45: " + K);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(long): " + sizeof(long));
            Console.WriteLine("long.MinValue: " + long.MinValue);
            Console.WriteLine("long.MaxValue: " + long.MaxValue);
            long B = 35l;
            Console.WriteLine("long B = 35l / 35L: " + B);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(float): " + sizeof(float));
            Console.WriteLine("float.MinValue: " + float.MinValue);
            Console.WriteLine("float.MaxValue: " + float.MaxValue);
            float D = 20.3f;
            Console.WriteLine("float D = 20.3f / 20.3F: " + D);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(double): " + sizeof(double));
            Console.WriteLine("double.MinValue: " + double.MinValue);
            Console.WriteLine("double.MaxValue: " + double.MaxValue);
            double E = 20.3d;
            Console.WriteLine("double E = 20.3d / 20.3D: " + E);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(decimal): " + sizeof(decimal));
            Console.WriteLine("decimal.MinValue: " + decimal.MinValue);
            Console.WriteLine("decimal.MaxValue: " + decimal.MaxValue);
            decimal F = 35u;
            Console.WriteLine("decimal F = 20.3m / 20.3M: " + F);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(char): " + sizeof(char));
            Console.WriteLine("char.MinValue: " + char.MinValue);
            Console.WriteLine("char.MaxValue: " + char.MaxValue);
            char L = 'A';
            Console.WriteLine("char L = 'A': " + L);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(string): - não aplicável");
            Console.WriteLine("string.MinValue: - não aplicável");
            Console.WriteLine("string.MaxValue: - não aplicável");
            string M = "Ana Sousa";
            Console.WriteLine("string M = \"Ana Sousa\": " + M);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Sizeof(bool): " + sizeof(bool));
            Console.WriteLine("bool.MinValue:  - não aplicável");
            Console.WriteLine("bool.MaxValue:  - não aplicável");
            bool N = true;
            Console.WriteLine("bool N = true: " + N);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();
        }
    }
}
