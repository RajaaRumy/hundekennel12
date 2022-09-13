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
            Dog[] dog = new Dog[1000];
            
            for (int i = 0; i < dog.Length; i++) {
                
                Console.WriteLine("How many dogs do you went to add, and Add a dog´s information");
                Console.ReadLine();
                Console.WriteLine("Enter a dog´s ID");
                dog[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a dog´s PedigreeNumber");
                dog[i].pedigreeNumber = Console.ReadLine();
                Console.WriteLine("Enter a dog´s name");
                dog[i].name = Console.ReadLine();
                Console.WriteLine(" Enter a dogs Birthday: Day-month- year");
                dog[i].birthday = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter a dogs Koen, H for Male and T for female");
                 dog[i].koen = Console.ReadLine();
                Console.WriteLine("Enter a dogs Color");
                dog[i].color = Console.ReadLine();
                Console.WriteLine("Enter a dogs chipNumber");
                 dog[i].chipNumber = Console.ReadLine();
                Console.WriteLine("Enter a dog´s FatherssPedigeeNumber");
                dog[i].fatherssPedigeeNumber = Console.ReadLine();
                Console.WriteLine("Enter a dogs MotherssPedigeeNumber");
                dog[i].motherssPedigeeNumber = Console.ReadLine();

                for (int j = 0; j< dog.Length; j++) {
                    
                    Console.WriteLine($" Dog´s ID is :{0}\n Dog´s PedigreeNumber is {1}\n Dog´s Name is: {2} \n Dogs Birthday is : {3} \n Dogs koen is  : {4} \n Dogs Color is:{5} \n Dogs chipNumber is: {6}\n Dogs FatherssPedigeeNumber is {7}\n Dogs MotherssPedigeeNumber is {8} ", dog[i].id, dog[i].PedigreeNumber, dog[i].name, dog[i].birthday, dog[i].koen, dog[i].color, dog[i].chipNumber, dog[i].fatherssPedigeeNumber, dog[i].motherssPedigeeNumber);


                }
                //// skrive til file
                StreamWriter writer = new StreamWriter("filskrive1.txt", true);
                writer.WriteLine($" Dog´s ID is :{0}\n Dog´s PedigreeNumber is {1}\n Dog´s Name is: {2} \n Dogs Birthday is : {3} \n Dogs koen is  : {4} \n Dogs Color is:{5} \n Dogs chipNumber is: {6}\n Dogs FatherssPedigeeNumber is {7}\n Dogs MotherssPedigeeNumber is {8} ", dog[i].id, dog[i].PedigreeNumber, dog[i].name, dog[i].birthday, dog[i].koen, dog[i].color, dog[i].chipNumber, dog[i].fatherssPedigeeNumber, dog.motherssPedigeeNumber);


                writer.Close(); // for at lukke
                Console.ReadKey();


            }

            //static void ReadFile(string path)
            //{// brug loop (for )
            //    StreamReader reader = new StreamReader(path);
            //    string FileData = reader.ReadToEnd();
            //    Console.WriteLine(FileData);
            //}
        }

    }
}
