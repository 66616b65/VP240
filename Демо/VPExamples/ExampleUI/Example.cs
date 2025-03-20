using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUI
{
    public class Example
    {
        private int[] array = new int[10];

        public int Length { get { return array.Length; } }

        public int this[int index]
        {
            get
            {
                if (index  < array.Length && index >= 0)
                {
                    return array[index];
                }
                 else
                {
                    throw new IndexOutOfRangeException("Вышел за пределы массива!!!!");
                }
            }
            set
            {
                if (index < array.Length && index >= 0)
                {
                    if (value % 2 == 0)
                    {
                        array[index] = value;
                    }
                    else
                    {
                        throw new Exception("Только четные числа!!!" + value);
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Вышел за пределы массива!!!!");
                }
            }
        }
    }

    public class Example2
    {
        public static void Func(Example arg)
        {
            for(int i = 0; i < arg.Length; i++)
            {
                arg[i] = DateTime.Now.Millisecond;
                Console.WriteLine(arg[i]);
            }

        }
    }
}
