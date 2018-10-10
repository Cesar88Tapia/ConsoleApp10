using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class clsMatrices
    {
        private int[,] Matrix;

        public clsMatrices()
        {
            Matrix = new int[4, 2];
        }

        public void InitMatrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matrix[i, j] = 1;
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}", Matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
