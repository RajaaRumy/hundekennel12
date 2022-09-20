using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace hundekennel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many dogs do you went to add, and Add a dog´s information");
            int dogcount;
             dogcount = int.Parse(Console.ReadLine());
            Dog[] dog = new Dog[dogcount];
            for (int i = 0; i < dogcount; i++) {
                dog[i] = new Dog();
                Console.WriteLine("Enter a dog´s ID");
                dog[i].ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a dog´s PedigreeNumber");
                dog[i].PedigreeNumber = Console.ReadLine();
                Console.WriteLine("Enter a dog´s name");
                dog[i].Name = Console.ReadLine();
                Console.WriteLine(" Enter a dogs Birthday: Day-month- year");
                dog[i].Birthday = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a dogs Koen, H for Male and T for female");
                 dog[i].Gender = Console.ReadLine();
                Console.WriteLine("Enter a dogs Color");
                dog[i].Color = Console.ReadLine();
                Console.WriteLine("Enter a dogs chipNumber");
                 dog[i].ChipNumber = Console.ReadLine();
                Console.WriteLine("Enter a dog´s FatherssPedigeeNumber");
                dog[i].FatherssPedigeeNumber = Console.ReadLine();
                Console.WriteLine("Enter a dogs MotherssPedigeeNumber");
                dog[i].MotherssPedigeeNumber = Console.ReadLine();
   
                Console.WriteLine($" Dog´s ID is :{dog[i].ID}\n Dog´s PedigreeNumber is {dog[i].PedigreeNumber}\n Dog´s Name is: {dog[i].Name} \n Dogs Birthday is : {dog[i].Birthday} \n Dogs koen is  : {dog[i].Gender} \n Dogs Color is:{dog[i].ChipNumber} \n Dogs chipNumber is: {dog[i].Color}\n Dogs FatherssPedigeeNumber is {dog[i].FatherssPedigeeNumber}\n Dogs MotherssPedigeeNumber is {dog[i].MotherssPedigeeNumber} ");
                  //// skrive til file
                StreamWriter writer = new StreamWriter("Fileskrive.txt", true);
                writer.WriteLine($" Dog´s ID is :{dog[i].ID}\n Dog´s PedigreeNumber is {dog[i].PedigreeNumber}\n Dog´s Name is: {dog[i].Name} \n Dogs Birthday is : {dog[i].Birthday} \n Dogs koen is  : {dog[i].Gender} \n Dogs Color is:{dog[i].ChipNumber} \n Dogs chipNumber is: {dog[i].Color}\n Dogs FatherssPedigeeNumber is {dog[i].FatherssPedigeeNumber}\n Dogs MotherssPedigeeNumber is {dog[i].MotherssPedigeeNumber} ");
                writer.Close(); // for at lukke
                Console.ReadKey();


            }

            //static void ReadFile(string path)
            //{// brug loop (for )
            //    StreamReader reader = new StreamReader(path);
            //    string FileData = reader.ReadToEnd();
            //    Console.WriteLine(FileData);
            //}Brugere,R,Skrivebord.tekst.txt"
        }

    }
}
