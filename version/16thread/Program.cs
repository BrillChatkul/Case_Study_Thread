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
        static long Sum_Global1  = 0;
        static long Sum_Global2  = 0;
        static long Sum_Global3  = 0;
        static long Sum_Global4  = 0;
        static long Sum_Global5  = 0;
        static long Sum_Global6  = 0;
        static long Sum_Global7  = 0;
        static long Sum_Global8  = 0;
        static long Sum_Global9  = 0;
        static long Sum_Global10 = 0;
        static long Sum_Global11 = 0;
        static long Sum_Global12 = 0;
        static long Sum_Global13 = 0;
        static long Sum_Global14 = 0;
        static long Sum_Global15 = 0;
        static long Sum_Global16 = 0;
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
        static void summ9(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global9 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global9 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global9 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global9 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ10(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global10 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global10 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global10 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global10 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ11(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global11 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global11 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global11 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global11 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ12(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global12 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global12 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global12 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global12 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ13(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global13 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global13 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global13 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global13 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ14(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global14 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global14 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global14 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global14 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ15(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global15 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global15 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global15 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global15 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ16(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global16 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global16 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global16 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global16 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static int summall(uint k)
        {
            int Out = 0;
            if (Data_Global[k] % 2 == 0)
            {
                Out -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Out += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Out += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Out += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
            return Out;
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
            for (y = 0; y < 1000000000/16; y++)
            //Sum_Global1 += summall(y);
            summ1(y);
        }
        static void TestThread2()
        {
            uint y;
            for (y = 1000000000/16; y < (1000000000/16)*2; y++)
             //Sum_Global2 += summall(y);
            summ2(y);
        }
        static void TestThread3()
        {
            uint y;
            for (y = (1000000000/16)*2; y < (1000000000/16)*3; y++)
             //Sum_Global3 += summall(y);
            summ3(y);
        }
        static void TestThread4()
        {
            uint y;
            for (y = (1000000000/16)*3; y < (1000000000/16)*4; y++)
             //Sum_Global4 += summall(y);
            summ4(y);
        }
        static void TestThread5()
        {
            uint y;
            for (y = (1000000000/16)*4; y < (1000000000/16)*5; y++)
             //Sum_Global5 += summall(y);
            summ5(y);
        }
        static void TestThread6()
        {
            uint y;
            for (y = (1000000000/16)*5; y < (1000000000/16)*6; y++)
             //Sum_Global6 += summall(y);
            summ6(y);
        }
        static void TestThread7()
        {
            uint y;
            for (y = (1000000000/16)*6; y < (1000000000/16)*7; y++)
             //Sum_Global7 += summall(y);
            summ7(y);
        }
        static void TestThread8()
        {
            uint y;
            for (y = (1000000000/16)*7; y < (1000000000/16)*8; y++)
             //Sum_Global8 += summall(y);
            summ8(y);
        }
         static void TestThread9()
        {
            uint y;
            for (y = (1000000000/16)*8; y < (1000000000/16)*9; y++)
             //Sum_Global9 += summall(y);
            summ9(y);
        }
         static void TestThread10()
        {
            uint y;
            for (y = (1000000000/16)*9; y < (1000000000/16)*10; y++)
             //Sum_Global10 += summall(y);
            summ10(y);
        }
         static void TestThread11()
        {
            uint y;
            for (y = (1000000000/16)*10; y < (1000000000/16)*11; y++)
             //Sum_Global11 += summall(y);
            summ11(y);
        }
         static void TestThread12()
        {
            uint y;
            for (y = (1000000000/16)*11; y < (1000000000/16)*12; y++)
             //Sum_Global12 += summall(y);
            summ12(y);
        }
        static void TestThread13()
        {
            uint y;
            for (y = (1000000000/16)*12; y < (1000000000/16)*13; y++)
             //Sum_Global13 += summall(y);
            summ13(y);
        }
        static void TestThread14()
        {
            uint y;
            for (y = (1000000000/16)*13; y < (1000000000/16)*14; y++)
             //Sum_Global14 += summall(y);
            summ14(y);
        }
        static void TestThread15()
        {
            uint y;
            for (y = (1000000000/16)*14; y < (1000000000/16)*15; y++)
             //Sum_Global15 += summall(y);
            summ15(y);
        }
        static void TestThread16()
        {
            uint y;
            for (y = (1000000000/16)*15; y < (1000000000/16)*16; y++)
             //Sum_Global16 += summall(y);
                summ16(y);
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
            Thread th9 = new Thread(TestThread9);
            Thread th10 = new Thread(TestThread10);
            Thread th11 = new Thread(TestThread11);
            Thread th12 = new Thread(TestThread12);
            Thread th13 = new Thread(TestThread13);
            Thread th14 = new Thread(TestThread14);
            Thread th15 = new Thread(TestThread15);
            Thread th16 = new Thread(TestThread16);

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
            th9.Start();
            th10.Start();
            th11.Start();
            th12.Start();
            th13.Start();
            th14.Start();
            th15.Start();
            th16.Start();
            
            
            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
            th5.Join();
            th6.Join();
            th7.Join();
            th8.Join();
            th9.Join();
            th10.Join();
            th11.Join();
            th12.Join();
            th13.Join();
            th14.Join();
            th15.Join();
            th16.Join();
            
           
            Sum_Global = Sum_Global1+Sum_Global2+Sum_Global3+Sum_Global4+Sum_Global5+Sum_Global6+Sum_Global7+Sum_Global8+Sum_Global9+Sum_Global10+Sum_Global11+Sum_Global12+Sum_Global13+Sum_Global14+Sum_Global15+Sum_Global16;
            
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
            
        }
    }
}