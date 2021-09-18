using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Backgroundcolorchanger
    {
        public void backGroundChanger()
        {
            Console.WriteLine("green=g , red= r, blue= b , white= w");
            char x = Convert.ToChar(Console.Read());

            while (!x.Equals('z'))
            {
                switch(x)
                {
                    
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;

                }
                Console.Clear();
                Console.WriteLine("green=g , red= r, blue= b , white= w");
                x = Convert.ToChar(Console.Read());
            }
        }
    }
}
