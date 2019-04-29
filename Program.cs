using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muliMapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiMap<int, string> multiMap = new MultiMap<int, string>();
            multiMap.Add(1, "AUDI");
            multiMap.Add(1, "BMW");
            multiMap.Add(2, "LADA");
            multiMap.Add(3, "OPEL");
            multiMap.Add(1, "HONDA");
            multiMap.Add(3, "JEEP");

            foreach (int item in multiMap.Keys)
            {

                foreach (string val in multiMap[item])
                {


                    Console.WriteLine(item + "   " + val);

                }


            }
            multiMap.Remove(1);
            foreach (int item in multiMap.Keys)
            {

                foreach (string val in multiMap[item])
                {


                    Console.WriteLine(item + "   " + val);

                }


            }
        }
    }
}
