using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
//Version Summall version 2(12 thread)
namespace Problem01
{
    class Program
    {
        static byte[] Data_Global = new byte[1000000000];
        static long Sum_Global   = 0;
        static int G_index = 0;
        static long[] Sum_G = new long[16];
        static uint DivideThread = 1000000000/8; 

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
        static void summall(uint k,uint a)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_G[a] -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_G[a] += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_G[a] += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_G[a] += (Data_Global[k] / 3);
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
            for (y = 0; y < DivideThread; y++)
            summall(y,0);
        }
        static void TestThread2()
        {
            uint y;
            for (y = DivideThread; y < DivideThread*2; y++)
            summall(y,1);
        }
        static void TestThread3()
        {
            uint y;
            for (y = DivideThread*2; y < DivideThread*3; y++)
            summall(y,2);
        }
        static void TestThread4()
        {
            uint y;
            for (y = DivideThread*3; y < DivideThread*4; y++)
            summall(y,3);
        }
        static void TestThread5()
        {
            uint y;
            for (y = DivideThread*4; y < DivideThread*5; y++)
            summall(y,4);
        }
        static void TestThread6()
        {
            uint y;
            for (y = DivideThread*5; y < DivideThread*6; y++)
            summall(y,5);
        }
        static void TestThread7()
        {
            uint y;
            for (y = DivideThread*6; y < DivideThread*7; y++)
            summall(y,6);
        }
        static void TestThread8()
        {
            uint y;
            for (y = DivideThread*7; y < DivideThread*8; y++)
            summall(y,7);
        }
        //  static void TestThread9()
        // {
        //     uint y;
        //     for (y = DivideThread*8; y < DivideThread*9; y++)
        //     summall(y,8);
        // }
        //  static void TestThread10()
        // {
        //     uint y;
        //     for (y = DivideThread*9; y < DivideThread*10; y++)
        //     summall(y,9);
        // }
        //  static void TestThread11()
        // {
        //     uint y;
        //     for (y = DivideThread*10; y < DivideThread*11; y++)
        //     summall(y,10);
        // }
        //  static void TestThread12()
        // {
        //     uint y;
        //     for (y = DivideThread*11; y < DivideThread*12; y++)
        //     summall(y,11);
        // }
        // static void TestThread13()
        // {
        //     uint y;
        //     for (y = DivideThread*12; y < DivideThread*13; y++)
        //     summall(y,12);
        // }
        // static void TestThread14()
        // {
        //     uint y;
        //     for (y = DivideThread*13; y < DivideThread*14; y++)
        //     summall(y,13);
        // }
        // static void TestThread15()
        // {
        //     uint y;
        //     for (y = DivideThread*14; y < DivideThread*15; y++)
        //     summall(y,14);
        // }
        // static void TestThread16()
        // {
        //     uint y;
        //     for (y = DivideThread*15; y < DivideThread*16; y++)
        //     summall(y,15);
        // }

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
            // Thread th9 = new Thread(TestThread9);
            // Thread th10 = new Thread(TestThread10);
            // Thread th11 = new Thread(TestThread11);
            // Thread th12 = new Thread(TestThread12);
            // Thread th13 = new Thread(TestThread13);
            // Thread th14 = new Thread(TestThread14);
            // Thread th15 = new Thread(TestThread15);
            // Thread th16 = new Thread(TestThread16);

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
            // th9.Start();
            // th10.Start();
            // th11.Start();
            // th12.Start();
            // th13.Start();
            // th14.Start();
            // th15.Start();
            // th16.Start();
            
            
            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th5.Join();
            th6.Join();
            th7.Join();
            th8.Join();
            // th9.Join();
            // th10.Join();
            // th11.Join();
            // th12.Join();
            // th13.Join();
            // th14.Join();
            // th15.Join();
            // th16.Join();
            
           
            // Sum_Global = Sum_Global1+Sum_Global2+Sum_Global3+Sum_Global4+Sum_Global5+Sum_Global6+Sum_Global7+Sum_Global8+Sum_Global9+Sum_Global10+Sum_Global11+Sum_Global12+Sum_Global13+Sum_Global14+Sum_Global15+Sum_Global16;
            int m;
            for(m = 0;m<8;m++){
                Sum_Global += Sum_G[m];
            }
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
            
        }
    }
}