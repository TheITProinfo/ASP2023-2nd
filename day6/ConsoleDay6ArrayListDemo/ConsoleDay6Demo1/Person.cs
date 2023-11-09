using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay6Demo1
{
    public class Person
    {
        #region Beginng class person

        //        //field property /method
        ////declare person class

        //        public string _name;

        //         int _age;

        //         public int Age
        //         {
        //             get { return _age;}
        //             set
        //             {
        //                 if (value < 0 || value > 150)
        //                 {
        //                     value = 0;
        //                 }

        //                 _age = value;
        //             }

        //         }


        //         public string _gender;


        //        public void Speak()
        //        {

        //            Console.WriteLine("my name is {0},age:{1},gender---{2}",this._name,this.Age,this._gender);

        //        }

        //        public void Drive()
        //        {
        //            Console.WriteLine("my name is {0}, I am driving",this._name);
        //        }

        //    } // end of class

        #endregion

        //field property /method
        //declare person class

         string _name;  // field

         public string Name // property
         {
             get { return _name;}

             set { _name = value; }
         }


         int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }

                _age = value;
            }

        }


         string _gender;

         public string Gender
         {
             get
             {
                 if (_gender != "male" && _gender != "female")
                 {
                     return _gender = "male";
                 }

                 return _gender;
             }
             set { _gender = value; }
         }




         public void Speak()
        {

            Console.WriteLine("my name is {0},age:{1},gender---{2}", this.Name, this.Age, this.Gender);

        }

        public void Drive()
        {
            Console.WriteLine("my name is {0}, I am driving", this.Name);
        }

    } // end of class



}
