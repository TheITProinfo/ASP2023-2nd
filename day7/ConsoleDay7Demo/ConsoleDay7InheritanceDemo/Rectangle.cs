using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay7InheritanceDemo
{
    public class Rectangle:Shape
    {
        public int GetArea()
        {

            return Height * Width;
        }

    }
}
