using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Math
    {
        public static float Add(float[] nmbr, int size)
        {
            float addition = 0;


            for (int i = 0; i < size; i++)
            {
                addition += nmbr[i];
            }

            return addition;
        }

        public static float Add(float startNmbr, float[] nmbr, int size)
        {
            float subtraction = startNmbr;


            for (int i = 0; i < size; i++)
            {
                subtraction -= nmbr[i];
            }

            return subtraction;
        }

        public static int getRand(int low, int high)
        {
            Random r = new Random();
            int nmbr = r.Next(low, high);
            return nmbr;

        }

    }
}
