using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = { 1, 3, 5, 7, 8, 14 };

            foreach(var item in sampleArray)
            {
                Console.WriteLine("The original array elements are : {0} \n", item);
            }

            foreach(var item in Engine(sampleArray))
            {
                Console.WriteLine("The original array elements are : {0} \n", item);
            }

            Console.ReadLine();
        }

        private static int[] Engine(int[] array)
        {
            int[] newArray = new int[7];
            int insertedNum = 10;
            int poz = 4;
            bool pozBool = false;
            bool insertedNumBool = true;
            bool solvePoz = false;
            bool newArrayIndexIJumper = true;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (newArrayIndexIJumper == true)
                {
                    newArray[i] = array[i];
                }

                if (i == poz - 1)
                {
                    if(insertedNumBool == true)
                    {
                        newArray[i] = insertedNum;
                        insertedNumBool = false;
                        solvePoz = true;
                    }

                    if (solvePoz == true)
                    {
                        newArray[i + 1] = array[poz - 1];
                        pozBool = true;
                    }
                }

                if(pozBool == true)
                {
                    poz++;
                    newArrayIndexIJumper = false;
                }
            }
            return newArray;
        }
    }
}
