using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hundekennel
{
    public class Dog
    {
        public int id;
        public string pedigreeNumber;
        public string name;
        public int birthday;
        public string koen;
        public string color;
        public string chipNumber;
        public string fatherssPedigeeNumber;
        public string motherssPedigeeNumber;

        public Dog(int id, string pedigreeNumber, string name, int birthday,string koen, string color, string chipNumber, string fatherssPedigeeNumber, string motherssPedigeeNumber)
        {
            this.id = id;
            this.pedigreeNumber = pedigreeNumber;   
            this.name = name;
            this.birthday = birthday;   
            this.koen = koen;
            this.color = color;
            this.chipNumber = chipNumber;
            this.fatherssPedigeeNumber = fatherssPedigeeNumber;
            this.motherssPedigeeNumber=motherssPedigeeNumber;

        }

        public int ID  
        {
            get { return id; } 
            set { id = value; } 
        }
        public string PedigreeNumber
        {
             get { return pedigreeNumber; }
             set { pedigreeNumber = value;}
        }
        public string Name
        {
            get { return name; }   
            set { name = value; }
        }

        public int BirthdayDate
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Koen
        {
            get { return koen; }
            set { koen = value; }
        }
        public string Color
        {
            get { return color; }   
            set { color = value; }  
        }
        public string ChipNumber
        {
            get { return chipNumber; }
            set { chipNumber = value; }
        }
        public string FatherssPedigeeNumber
        {
            get { return fatherssPedigeeNumber; }   
            set { fatherssPedigeeNumber = value; }
        }
        public string MotherssPedigeeNumber
        {
            get { return motherssPedigeeNumber; }
            set { motherssPedigeeNumber = value; }
        }

        public Dog()
        {


        }
        public void print()
        {
            //Console.WriteLine($" Dog´s ID is :{0}\n Dog´s PedigreeNumber is {1}\n Dog´s Name is: {2} \n Dogs Birthday is : {3} \n Dogs koen is  : {4} \n Dogs Color is:{5} \n Dogs chipNumber is: {6}\n Dogs FatherssPedigeeNumber is {7}\n Dogs MotherssPedigeeNumber is {8} ", id, PedigreeNumber, name, birthday, koen, color, chipNumber ,fatherssPedigeeNumber,motherssPedigeeNumber);

        }




    }




}
