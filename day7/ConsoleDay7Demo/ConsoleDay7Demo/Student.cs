using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7Demo
{
   public class Student
   {
        #region property and field
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                //Age = value;

                if (value < 0 || value > 150)
                {
                    value = 0;
                }

                _age = value;
            }

        }

        // code 
        //propfull tab

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        private int _python;

        public int Python
        {
            get { return _python; }
            set { _python = value; }
        }

        //public string Gender { get; set; }  

        private int _ccna;

        public int Ccna
        {
            get { return _ccna; }
            set { _ccna = value; }
        }

        private int _dataBase;

        public int DataBase
        {
            get { return _dataBase; }
            set { _dataBase = value; }
        }


        #endregion

        #region constructors

        public Student()
        {


        }

        public Student(string name,string gender, int age,int python, int datBase,int ccna)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Ccna = ccna;
            this.Python = python;
            this.DataBase = datBase;

        }

        public Student(string name, string gender, int age):this(name,gender,age,56,78,88)
        {

            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
        }

        public Student(string name):this(name,"B",0,0,0,0)
        {
            //this.Name = name;
        }

        #endregion

        public void Speak()
        {
            Console.WriteLine("ma name is {0}, I am {1} years old, gender: {2}",this.Name,this.Age,this.Gender);
        }

        public void ShowScore()
        {
            Console.WriteLine("my name is{0},total score is {1}, average score is {2}",this.Name,this.Python+this.Ccna+this.DataBase, (this.Python + this.Ccna + this.DataBase)/3);

        }

   }
}
