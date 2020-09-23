using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OPP_LR_1_2_
{
    class CalCulateSecondEdition
    {
        private static int N = 0;            
        private double sum = 0;
        public void InputN()
        {                   

            try
            {
                Console.WriteLine("Input N");
                N = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

        }

        public void InputArray()
        {

            double[] a = new double[N];

            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Input a[{0}]", i + 1);
                try
                {

                    a[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

                sum += a[i];
            }
        }

        public void OutputArray()
        {
        
        double[] b = new double[N];
            for (int i = 0; i<N; i++)
            {

                b[i] = sum;
                Console.WriteLine("Input b[" + (i + 1).ToString() + "] = " + b[i]);
            }
        }
    }
}
