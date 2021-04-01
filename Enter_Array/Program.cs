using System;
using System.Text;

namespace Enter_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Find2Max(Enter_valuesArray(Enter_sizeArray()));
        }

        static int Enter_sizeArray ()
        {
            int size  = default;
            bool a = true;
            while (a)
            {
                try
                {
                    Console.Write("\n" + "    Please, enter size of array: ");
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size < 2)
                    {
                        Console.WriteLine("\n" + "   ENTER ERROR! Please, try again.");
                    }
                    else
                    {
                        a = false;
                    }

                }
                catch
                {
                    Console.WriteLine("\n" + "   ENTER ERROR! Please, try again.");


                }
            }
            return size;
        }
        
        static int[] Enter_valuesArray(in int size)
        {
            int[] massive = new int[size];
            int num = 0;
            while (num < size)
            {
               
                    try
                    {
                        Console.Write("\n" + $"    Please, enter value of array's element with index {num}: ");
                        massive[num] = Convert.ToInt32(Console.ReadLine());
                        num++;
                        
                    }
                    catch
                    {
                        Console.WriteLine("\n" + "   ENTER ERROR! Please, try again.");
                        
                    }
                
                
            }
            var strA = new StringBuilder();
            for (int i = 0; i <size; i++)
            {
                strA.Append($"{massive[i]} ");
            }
            Console.WriteLine("\n" + $"   Your array: ( {strA})");

            return massive;
        }
        static void Find2Max(int[] massive)
        {
            int max, second_max;
            if (massive[0] > massive[1])
            { 
                max = massive[0]; second_max = massive[1];
            }
            else
            {
                second_max = massive[0]; max = massive[1];
            }

            for (int i = 2; i < massive.Length; i++)
            {
                if (massive[i] >= max)
                {
                    second_max = max;
                    max = massive[i];
                }
                else if (massive[i] > second_max)
                {
                    second_max = massive[i];
                }
            }
            Console.WriteLine("\n" + $"Second max number in array: {second_max}");
        }
                            
    }

}
