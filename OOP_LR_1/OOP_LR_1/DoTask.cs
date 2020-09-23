using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OOP_LR_1
{
    class DoTask
    {
        public static void Calculate()
        {

            int N = 0;

            
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
            

           // Console.WriteLine("Input N");           
            //N = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[N];
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Input a[" + (i + 1).ToString() + "]");
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

            double[] b = new double[N];
            for (int i = 0; i < N; i++)
            {

                b[i] = sum;
                Console.WriteLine("Input b[" + (i + 1).ToString() + "] = " + b[i]);
            }
        }
    }
}
