using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericOperation
    {
        int[] intArr = { 1, 2, 3, 4, 5, 6, 7 };
        double[] doubleArr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
        public void ToPrintArray<T>(T[] intArr)
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(double[] intArr)
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(char[] intArr)
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
    

        
