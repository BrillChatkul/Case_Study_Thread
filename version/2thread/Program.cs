using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Problem01
{
    class Program
    {
        static byte[] Data_Global = new byte[1000000000];
        static long Sum_Global = 0;
        static long Sum_Global1 = 0;
        static long Sum_Global2 = 0;
        static int G_index = 0;

        static int ReadData()
        {
            int returnData = 0;
            FileStream fs = new FileStream("Problem01.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try 
            {
                Data_Global = (byte[]) bf.Deserialize(fs);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Read Failed:" + se.Message);
                returnData = 1;
            }
            finally
            {
                fs.Close();
            }

            return returnData;
        }

        static void sum()
        {
            if (Data_Global[G_index] % 2 == 0)
            {
                Sum_Global -= Data_Global[G_index];
            }
            else if (Data_Global[G_index] % 3 == 0)
            {
                Sum_Global += (Data_Global[G_index]*2);
            }
            else if (Data_Global[G_index] % 5 == 0)
            {
                Sum_Global += (Data_Global[G_index] / 2);
            }
            else if (Data_Global[G_index] %7 == 0)
            {
                Sum_Global += (Data_Global[G_index] / 3);
            }
            Data_Global[G_index] = 0;
            G_index++;
               
        }
        static void summ1(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global1 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global1 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global1 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global1 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ2(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global2 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global2 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global2 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global2 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }    
               
        
        static void TestThread0()
        {
            uint y;
            for (y = 0; y < 500000000; y++)
            sum();
            // Console.WriteLine("Summation result: {0}", Sum_Global);
        }
        static void TestThread1()
        {
            uint y;
            for (y = 0; y < 1000000000/2; y++)
            summ1(y);
            // Console.WriteLine("Summation result: {0}", Sum_Global1);
        }
        static void TestThread2()
        {
            uint y;
            for (y = 1000000000/2; y < 1000000000; y++)
            summ2(y);
            // Console.WriteLine("Summation result: {0}", Sum_Global2);
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int y;
            // int i;

            /* Read data from file */
            Console.Write("Data read...");
            y = ReadData();
            if (y == 0)
            {
                Console.WriteLine("Complete.");
            }
            else
            {
                Console.WriteLine("Read Failed!");
            }

            /* Start */
            Console.Write("\n\nWorking...");
            Thread th0 = new Thread(TestThread0);
            Thread th1 = new Thread(TestThread1);
            Thread th2 = new Thread(TestThread2);
            sw.Start();
            // th0.Start();
            // th0.Join();
            // Console.WriteLine("Summation result: {0}", Data_Global[999999999]);
            th1.Start();
            th2.Start();
            // while(th1.IsAlive){}
            // while(th2.IsAlive){}
            th1.Join();
            th2.Join();
            Sum_Global = Sum_Global1+Sum_Global2;
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
            
        }
    }
}
