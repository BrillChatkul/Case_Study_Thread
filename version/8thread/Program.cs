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
        static long Sum_Global3 = 0;
        static long Sum_Global4 = 0;
        static long Sum_Global5 = 0;
        static long Sum_Global6 = 0;
        static long Sum_Global7 = 0;
        static long Sum_Global8 = 0;
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
        static void summ3(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global3 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global3 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global3 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global3 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }  
        static void summ4(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global4 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global4 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global4 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global4 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        
        static void summ5(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global5 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global5 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global5 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global5 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ6(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global6 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global6 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global6 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global6 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ7(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global7 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global7 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global7 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global7 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }  
        static void summ8(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global8 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global8 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global8 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global8 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
               
        
        static void TestThread0()
        {
            uint y;
            for (y = 0; y < 500000000; y++)
            sum();
        }
        static void TestThread1()
        {
            uint y;
            for (y = 0; y < 1000000000/8; y++)
            summ1(y);
        }
        static void TestThread2()
        {
            uint y;
            for (y = 1000000000/8; y < (1000000000/8)*2; y++)
            summ2(y);
        }
        static void TestThread3()
        {
            uint y;
            for (y = (1000000000/8)*2; y < (1000000000/8)*3; y++)
            summ3(y);
        }
        static void TestThread4()
        {
            uint y;
            for (y = (1000000000/8)*3; y < (1000000000/8)*4; y++)
            summ4(y);
        }
        static void TestThread5()
        {
            uint y;
            for (y = (1000000000/8)*4; y < (1000000000/8)*5; y++)
            summ5(y);
        }
        static void TestThread6()
        {
            uint y;
            for (y = (1000000000/8)*5; y < (1000000000/8)*6; y++)
            summ6(y);
        }
        static void TestThread7()
        {
            uint y;
            for (y = (1000000000/8)*6; y < (1000000000/8)*7; y++)
            summ7(y);
        }
        static void TestThread8()
        {
            uint y;
            for (y = (1000000000/8)*7; y < (1000000000/8)*8; y++)
            summ8(y);
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
            Thread th3 = new Thread(TestThread3);
            Thread th4 = new Thread(TestThread4);
            Thread th5 = new Thread(TestThread5);
            Thread th6 = new Thread(TestThread6);
            Thread th7 = new Thread(TestThread7);
            Thread th8 = new Thread(TestThread8);
            sw.Start();
            // th0.Start();
            // th0.Join();
            
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
            th5.Start();
            th6.Start();
            th7.Start();
            th8.Start();
            
            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th5.Join();
            th6.Join();
            th7.Join();
            th8.Join();
           
            Sum_Global = Sum_Global1+Sum_Global2+Sum_Global3+Sum_Global4+Sum_Global5+Sum_Global6+Sum_Global7+Sum_Global8;
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
            
        }
    }
}
