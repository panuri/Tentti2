using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Tentti2
{

    
    class Program
    {
        static List<Piste> lista = new List<Piste>();
     
        static void Main(string[] args)
        {
            List<Piste> lista = new List<Piste>();
            Piste p1 = new Piste("Piste_1", 12, 33);
            Piste p2 = new Piste("Piste_2", 82, 53);
            lista.Add(p1);
            lista.Add(p2);
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
          
            string output = JsonConvert.SerializeObject(lista);
            Console.WriteLine("listan pisteet JSON muodossa:");
            Console.WriteLine(output);

            LueBin();
        }

        static void LueBin()
        {                   
            FileStream stream = new FileStream(@"M:\VTentti\Tentti2\bindataTentti.bin", FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            Piste fromFilePiste;
            while (reader != null && reader.BaseStream.Position < reader.BaseStream.Length)
            {
                string n = reader.ReadString();
                double x = reader.ReadDouble();
                double y = reader.ReadDouble();
                
                Console.WriteLine("Pisteen nimi: " + n + " X: " + x + " Y: " + y);
                fromFilePiste = new Piste(n, x, y);
                lista.Add(fromFilePiste);
                //Console.WriteLine("Position: " + reader.BaseStream.Position);

            }

            Console.WriteLine("---- LISTAn sisätä OLIDEN TULOSTUS JSON muodossa -----");
           
            Console.WriteLine(JsonConvert.SerializeObject(lista));
        }
    }
}
//
// foreach (var item in lista)
// {
//    Console.WriteLine(item.ToString());
// }