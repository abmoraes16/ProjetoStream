using System;
using System.IO;

namespace ProjetoStream
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Teste.csv",true);

            sw.WriteLine(Console.ReadLine());

            sw.Close();

            FileInfo fi = new FileInfo("Teste.csv");

            if (fi.Exists){
                Console.WriteLine("Tamanho: " +fi.Length);
                Console.WriteLine("Extensão: " +fi.Extension);
                Console.WriteLine("Nome: " +fi.FullName);
            }
            else
                Console.WriteLine("Arquivo não existe");
            
        }
    }
}
