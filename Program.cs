using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Coding
{
  
    class Program
    {
        static int NO_OF_CHARS = 256;

        /* Fills count array with
           frequency of characters */
        static void fillCharCounts(String str,
                                     int[] count)
        {
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
        }

        /* Print duplicates present in
        the passed string */
        static void printDups(String str)
        {

            // Create an array of size 256 and
            // fill count of every character in it
            int[] count = new int[NO_OF_CHARS];
            fillCharCounts(str, count);

            for (int i = 0; i < NO_OF_CHARS; i++)
                if (count[i] > 1)
                    Console.WriteLine((char)i + ", " +
                                  "count = " + count[i]);
        }


        static void Main(string[] args)
        {
            //FindDuplicates();
            //String str = "test string";
            //printDups(str);
            //Console.Read();

            //calculate();
            //Console.Read();

            Backgroundcolorchanger b = new Backgroundcolorchanger();
            b.backGroundChanger();
        }

        public static void FindDuplicates()
        {
            string s = "1143385563277773222";
            char[] c = s.ToCharArray();
            var duplicates = c.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);

            var duplicates2 = c.Distinct();
                                       

            Console.WriteLine(String.Join(",", duplicates));
            Console.WriteLine(duplicates2);
           Console.Read();

            
        }

        public static void  calculate()
        {
            int[] Arraya = {3,5,15,20,18,30,60,29 };
            
            for(int i=0; i<Arraya.Length; i++)
            {
                if(Arraya[i] % 3 ==0 && Arraya[i] % 5==0)
                {
                    Console.WriteLine("Rahul"+ Arraya[i] + " by both ");
                }
                else if (Arraya[i] % 3 == 0)
                {
                    Console.WriteLine("Kumar by 3"+ Arraya[i]);
                }
                else if (Arraya[i] % 5 == 0)
                {
                    Console.WriteLine("Kumar by 5" + Arraya[i]);
                }
                else
                {
                    Console.WriteLine("not by both " +Arraya[i]);
                }
            }
        }
    }
}
