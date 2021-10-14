using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
//Version Summall version 2(12 thread)
namespace OS
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


        //--------------------------------------------------------------------------------//
        static long Sum_Global17   = 0;
        static long Sum_Global18  = 0;
        static long Sum_Global19  = 0;
        static long Sum_Global20  = 0;
        static long Sum_Global21  = 0;
        static long Sum_Global22  = 0;
        static long Sum_Global23  = 0;
        static long Sum_Global24  = 0;
        static long Sum_Global25  = 0;
        static long Sum_Global26  = 0;
        static long Sum_Global27 = 0;
        static long Sum_Global28 = 0;
        static long Sum_Global29 = 0;
        static long Sum_Global30 = 0;
        static long Sum_Global31 = 0;
        static long Sum_Global32 = 0;
        
        static long Sum_Global33   = 0;
        static long Sum_Global34  = 0;
        static long Sum_Global35  = 0;
        static long Sum_Global36  = 0;
        static long Sum_Global37  = 0;
        static long Sum_Global38  = 0;
        static long Sum_Global39  = 0;
        static long Sum_Global40  = 0;
        static long Sum_Global41  = 0;
        static long Sum_Global42  = 0;
        static long Sum_Global43 = 0;
        static long Sum_Global44 = 0;
        static long Sum_Global45 = 0;
        static long Sum_Global46 = 0;
        static long Sum_Global47 = 0;
        static long Sum_Global48 = 0;

        static long Sum_Global49   = 0;
        static long Sum_Global50  = 0;
        static long Sum_Global51  = 0;
        static long Sum_Global52  = 0;
        static long Sum_Global53  = 0;
        static long Sum_Global54  = 0;
        static long Sum_Global55  = 0;
        static long Sum_Global56  = 0;
        static long Sum_Global57  = 0;
        static long Sum_Global58  = 0;
        static long Sum_Global59 = 0;
        static long Sum_Global60 = 0;
        static long Sum_Global61 = 0;
        static long Sum_Global62 = 0;
        static long Sum_Global63 = 0;
        static long Sum_Global64 = 0;
        static uint divideInt = 1000000000/64;
        // static long[] Sum_part = new long[33];
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
// -----------------------------------------------------------------------------------------//
        static void summ17(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global17 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global17 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global17 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global17 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ18(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global18 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global18 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global18 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global18 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ19(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global19 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global19 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global19 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global19 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ20(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global20 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global20 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global20 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global20 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ21(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global21 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global21 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global21 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global21 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ22(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global22 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global22 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global22 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global22 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ23(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global23 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global23 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global23 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global23 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ24(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global24 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global24 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global24 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global24 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }

        static void summ25(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global25 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global25 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global25 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global25 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ26(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global26 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global26 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global26 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global26 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ27(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global27 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global27 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global27 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global27 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ28(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global28 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global28 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global28 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global28 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ29(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global29 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global29 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global29 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global29 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ30(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global30 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global30 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global30 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global30 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ31(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global31 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global31 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global31 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global31 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ32(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global32 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global32 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global32 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global32 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        //////////////////////////////////////////
        static void summ33(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global33 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global33 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global33 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global33 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ34(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global34 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global34 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global34 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global34 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ35(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global35 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global35 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global35 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global35 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ36(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global36 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global36 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global36 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global36 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ37(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global37 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global37 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global37 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global37 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ38(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global38 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global38 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global38 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global38 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ39(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global39 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global39 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global39 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global39 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ40(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global40 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global40 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global40 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global40 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ41(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global41 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global41 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global41 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global41 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ42(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global42 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global42 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global42 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global42 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ43(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global43 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global43 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global43 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global43 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ44(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global44 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global44 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global44 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global44 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ45(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global45 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global45 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global45 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global45 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ46(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global46 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global46 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global46 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global46 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ47(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global47 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global47 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global47 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global47 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ48(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global48 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global48 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global48 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global48 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        //////////
        static void summ49(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global49 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global49 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global49 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global49 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ50(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global50 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global50 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global50 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global50 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ51(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global51 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global51 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global51 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global51 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ52(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global52 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global52 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global52 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global52 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ53(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global53 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global53 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global53 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global53 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ54(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global54 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global54 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global54 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global54 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ55(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global55 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global55 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global55 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global55 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ56(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global56 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global56 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global56 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global56 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ57(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global57 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global57 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global57 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global57 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ58(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global58 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global58 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global58 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global58 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ59(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global59 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global59 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global59 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global59 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ60(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global60 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global60 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global60 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global60 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ61(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global61 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global61 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global61 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global61 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ62(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global62 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global62 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global62 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global62 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ63(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global63 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global63 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global63 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global63 += (Data_Global[k] / 3);
            }
            Data_Global[k] = 0;
        }
        static void summ64(uint k)
        {
            if (Data_Global[k] % 2 == 0)
            {
                Sum_Global64 -= Data_Global[k];
            }
            else if (Data_Global[k] % 3 == 0)
            {
                Sum_Global64 += (Data_Global[k]*2);
            }
            else if (Data_Global[k] % 5 == 0)
            {
                Sum_Global64 += (Data_Global[k] / 2);
            }
            else if (Data_Global[k] %7 == 0)
            {
                Sum_Global64 += (Data_Global[k] / 3);
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
            for (y = 0; y < divideInt; y++)
        summ1(y);
            
        }
        static void TestThread2()
        {
            uint y;
            for (y = divideInt; y < divideInt*2; y++)
            summ2(y);
            
        }
        static void TestThread3()
        {
            uint y;
            for (y = divideInt*2; y < divideInt*3; y++)
            summ3(y);
            
        }
        static void TestThread4()
        {
            uint y;
            for (y = divideInt*3; y < divideInt*4; y++)
            summ4(y);
            
        }
        static void TestThread5()
        {
            uint y;
            for (y = divideInt*4; y < divideInt*5; y++)
            summ5(y);
            
        }
        static void TestThread6()
        {
            uint y;
            for (y = divideInt*5; y < divideInt*6; y++)
            summ6(y);
            
        }
        static void TestThread7()
        {
            uint y;
            for (y = divideInt*6; y < divideInt*7; y++)
            summ7(y);
            
        }
        static void TestThread8()
        {
            uint y;
            for (y = divideInt*7; y < divideInt*8; y++)
            summ8(y);
            
        }
         static void TestThread9()
        {
            uint y;
            for (y = divideInt*8; y < divideInt*9; y++)
            summ9(y);
            
        }
         static void TestThread10()
        {
            uint y;
            for (y = divideInt*9; y < divideInt*10; y++)
             summ10(y);
            
        }
         static void TestThread11()
        {
            uint y;
            for (y = divideInt*10; y < divideInt*11; y++)
             summ11(y);
            
        }
         static void TestThread12()
        {
            uint y;
            for (y = divideInt*11; y < divideInt*12; y++)
             summ12(y);
            
        }
        static void TestThread13()
        {
            uint y;
            for (y = divideInt*12; y < divideInt*13; y++)
             summ13(y);
            
        }
        static void TestThread14()
        {
            uint y;
            for (y = divideInt*13; y < divideInt*14; y++)
             summ14(y);
            
        }
        static void TestThread15()
        {
            uint y;
            for (y = divideInt*14; y < divideInt*15; y++)
             summ15(y);
            
        }
        static void TestThread16()
        {
            uint y;
            for (y = divideInt*15; y < divideInt*16; y++)
             summ16(y);
            
        }
//-------------------------------------------------------------------------------------------------//
       static void TestThread17()
        {
            uint y;
            for (y = divideInt*16; y < divideInt*17; y++)
             summ17(y);
            
        }
        static void TestThread18()
        {
            uint y;
            for (y = divideInt*17; y < divideInt*18; y++)
             summ18(y);
            
        }
        static void TestThread19()
        {
            uint y;
            for (y = divideInt*18; y < divideInt*19; y++)
             summ19(y);
            
        }
        static void TestThread20()
        {
            uint y;
            for (y = divideInt*19; y < divideInt*20; y++)
             summ20(y);
            
        }
        static void TestThread21()
        {
            uint y;
            for (y = divideInt*20; y < divideInt*21; y++)
             summ21(y);
            
        }
        static void TestThread22()
        {
            uint y;
            for (y = divideInt*21; y < divideInt*22; y++)
             summ22(y);
            
        }
        static void TestThread23()
        {
            uint y;
            for (y = divideInt*22; y < divideInt*23; y++)
             summ23(y);
            
        }
        static void TestThread24()
        {
            uint y;
            for (y = divideInt*23; y < divideInt*24; y++)
             summ24(y);
            
        }
         static void TestThread25()
        {
            uint y;
            for (y = divideInt*24; y < divideInt*25; y++)
             summ25(y);
            
        }
         static void TestThread26()
        {
            uint y;
            for (y = divideInt*25; y < divideInt*26; y++)
             summ26(y);
            
        }
         static void TestThread27()
        {
            uint y;
            for (y = divideInt*26; y < divideInt*27; y++)
             summ27(y);
            
        }
         static void TestThread28()
        {
            uint y;
            for (y = divideInt*27; y < divideInt*28; y++)
             summ28(y);
            
        }
        static void TestThread29()
        {
            uint y;
            for (y = divideInt*28; y < divideInt*29; y++)
             summ29(y);
            
        }
        static void TestThread30()
        {
            uint y;
            for (y = divideInt*29; y < divideInt*30; y++)
             summ30(y);
            
        }
        static void TestThread31()
        {
            uint y;
            for (y = divideInt*30; y < divideInt*31; y++)
             summ31(y);
            
        }
        static void TestThread32()
        {
            uint y;
            for (y = divideInt*31; y < divideInt*32; y++)
             summ32(y);
            
        }
        ///////////////////////
        static void TestThread33()
        {
            uint y;
            for (y = divideInt*32; y < divideInt*33; y++)
             summ33(y);
            
        }
        static void TestThread34()
        {
            uint y;
            for (y = divideInt*33; y < divideInt*34; y++)
             summ34(y);
            
        }
        static void TestThread35()
        {
            uint y;
            for (y = divideInt*34; y < divideInt*35; y++)
             summ35(y);
            
        }
        static void TestThread36()
        {
            uint y;
            for (y = divideInt*35; y < divideInt*36; y++)
             summ36(y);
            
        }
        static void TestThread37()
        {
            uint y;
            for (y = divideInt*36; y < divideInt*37; y++)
             summ37(y);
            
        }
        static void TestThread38()
        {
            uint y;
            for (y = divideInt*37; y < divideInt*38; y++)
             summ38(y);
            
        }
        static void TestThread39()
        {
            uint y;
            for (y = divideInt*38; y < divideInt*39; y++)
             summ39(y);
            
        }
        static void TestThread40()
        {
            uint y;
            for (y = divideInt*39; y < divideInt*40; y++)
             summ40(y);
            
        }
        static void TestThread41()
        {
            uint y;
            for (y = divideInt*40; y < divideInt*41; y++)
             summ41(y);
            
        }
        static void TestThread42()
        {
            uint y;
            for (y = divideInt*41; y < divideInt*42; y++)
             summ42(y);
            
        }
        static void TestThread43()
        {
            uint y;
            for (y = divideInt*42; y < divideInt*43; y++)
             summ43(y);
            
        }
        static void TestThread44()
        {
            uint y;
            for (y = divideInt*43; y < divideInt*44; y++)
             summ44(y);
            
        }
        static void TestThread45()
        {
            uint y;
            for (y = divideInt*44; y < divideInt*45; y++)
             summ45(y);
            
        }
        static void TestThread46()
        {
            uint y;
            for (y = divideInt*45; y < divideInt*46; y++)
             summ46(y);
            
        }
        static void TestThread47()
        {
            uint y;
            for (y = divideInt*46; y < divideInt*47; y++)
             summ47(y);
            
        }
        static void TestThread48()
        {
            uint y;
            for (y = divideInt*47; y < divideInt*48; y++)
             summ48(y);
            
        }
        /////////////////////
        static void TestThread49()
        {
            uint y;
            for (y = divideInt*48; y < divideInt*49; y++)
             summ49(y);
            
        }
        static void TestThread50()
        {
            uint y;
            for (y = divideInt*49; y < divideInt*50; y++)
             summ50(y);
            
        }
        static void TestThread51()
        {
            uint y;
            for (y = divideInt*50; y < divideInt*51; y++)
             summ51(y);
            
        }
        static void TestThread52()
        {
            uint y;
            for (y = divideInt*51; y < divideInt*52; y++)
             summ52(y);
            
        }
        static void TestThread53()
        {
            uint y;
            for (y = divideInt*52; y < divideInt*53; y++)
             summ53(y);
            
        }
        static void TestThread54()
        {
            uint y;
            for (y = divideInt*53; y < divideInt*54; y++)
             summ54(y);
            
        }
        static void TestThread55()
        {
            uint y;
            for (y = divideInt*54; y < divideInt*55; y++)
             summ55(y);
            
        }
        static void TestThread56()
        {
            uint y;
            for (y = divideInt*55; y < divideInt*56; y++)
             summ56(y);
            
        }
        static void TestThread57()
        {
            uint y;
            for (y = divideInt*56; y < divideInt*57; y++)
             summ57(y);
            
        }
        static void TestThread58()
        {
            uint y;
            for (y = divideInt*57; y < divideInt*58; y++)
             summ58(y);
            
        }
        static void TestThread59()
        {
            uint y;
            for (y = divideInt*58; y < divideInt*59; y++)
             summ59(y);
            
        }
        static void TestThread60()
        {
            uint y;
            for (y = divideInt*59; y < divideInt*60; y++)
             summ60(y);
            
        }
        static void TestThread61()
        {
            uint y;
            for (y = divideInt*60; y < divideInt*61; y++)
             summ61(y);
            
        }
        static void TestThread62()
        {
            uint y;
            for (y = divideInt*61; y < divideInt*62; y++)
             summ62(y);
            
        }
        static void TestThread63()
        {
            uint y;
            for (y = divideInt*62; y < divideInt*63; y++)
             summ63(y);
            
        }
        static void TestThread64()
        {
            uint y;
            for (y = divideInt*63; y < divideInt*64; y++)
             summ64(y);
            
        }

        
        // static void TestThreadAll(uint x,uint y){
        //     uint z;
        //     long Sum_Sum = 0;
        //     for (z = divideInt*x; z < divideInt*y; z++)
        //      {
        //          Sum_Sum += summall(z);
        //      }
        //      Sum_Global += Sum_Sum;
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
            Thread th9 = new Thread(TestThread9);
            Thread th10 = new Thread(TestThread10);
            Thread th11 = new Thread(TestThread11);
            Thread th12 = new Thread(TestThread12);
            Thread th13 = new Thread(TestThread13);
            Thread th14 = new Thread(TestThread14);
            Thread th15 = new Thread(TestThread15);
            Thread th16 = new Thread(TestThread16);

            Thread th17 = new Thread(TestThread17);
            Thread th18 = new Thread(TestThread18);
            Thread th19 = new Thread(TestThread19);
            Thread th20 = new Thread(TestThread20);
            Thread th21 = new Thread(TestThread21);
            Thread th22 = new Thread(TestThread22);
            Thread th23 = new Thread(TestThread23);
            Thread th24 = new Thread(TestThread24);
            Thread th25 = new Thread(TestThread25);
            Thread th26 = new Thread(TestThread26);
            Thread th27 = new Thread(TestThread27);
            Thread th28 = new Thread(TestThread28);
            Thread th29 = new Thread(TestThread29);
            Thread th30 = new Thread(TestThread30);
            Thread th31 = new Thread(TestThread31);
            Thread th32 = new Thread(TestThread32);

            Thread th33 = new Thread(TestThread33);
            Thread th34 = new Thread(TestThread34);
            Thread th35 = new Thread(TestThread35);
            Thread th36 = new Thread(TestThread36);
            Thread th37 = new Thread(TestThread37);
            Thread th38 = new Thread(TestThread38);
            Thread th39 = new Thread(TestThread39);
            Thread th40 = new Thread(TestThread40);
            Thread th41 = new Thread(TestThread41);
            Thread th42 = new Thread(TestThread42);
            Thread th43 = new Thread(TestThread43);
            Thread th44 = new Thread(TestThread44);
            Thread th45 = new Thread(TestThread45);
            Thread th46 = new Thread(TestThread46);
            Thread th47 = new Thread(TestThread47);
            Thread th48 = new Thread(TestThread48);

            Thread th49 = new Thread(TestThread49);
            Thread th50 = new Thread(TestThread50);
            Thread th51 = new Thread(TestThread51);
            Thread th52 = new Thread(TestThread52);
            Thread th53 = new Thread(TestThread53);
            Thread th54 = new Thread(TestThread54);
            Thread th55 = new Thread(TestThread55);
            Thread th56 = new Thread(TestThread56);
            Thread th57 = new Thread(TestThread57);
            Thread th58 = new Thread(TestThread58);
            Thread th59 = new Thread(TestThread59);
            Thread th60 = new Thread(TestThread60);
            Thread th61 = new Thread(TestThread61);
            Thread th62 = new Thread(TestThread62);
            Thread th63 = new Thread(TestThread63);
            Thread th64 = new Thread(TestThread64);

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


            th17.Start();
            th18.Start();
            th19.Start();
            th20.Start();
            th21.Start();
            th22.Start();
            th23.Start();
            th24.Start();
            th25.Start();
            th26.Start();
            th27.Start();
            th28.Start();
            th29.Start();
            th30.Start();
            th31.Start();
            th32.Start();

            th33.Start();
            th34.Start();
            th35.Start();
            th36.Start();
            th37.Start();
            th38.Start();
            th39.Start();
            th40.Start();
            th41.Start();
            th42.Start();
            th43.Start();
            th44.Start();
            th45.Start();
            th46.Start();
            th47.Start();
            th48.Start();

            th49.Start();
            th50.Start();
            th51.Start();
            th52.Start();
            th53.Start();
            th54.Start();
            th55.Start();
            th56.Start();
            th57.Start();
            th58.Start();
            th59.Start();
            th60.Start();
            th61.Start();
            th62.Start();
            th63.Start();
            th64.Start();
                  



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
            
            

            th17.Join();
            th18.Join();
            th19.Join();
            th20.Join();
            th21.Join();
            th22.Join();
            th23.Join();
            th24.Join();
            th25.Join();
            th26.Join();
            th27.Join();
            th28.Join();
            th29.Join();
            th30.Join();
            th31.Join();
            th32.Join();

            th33.Join();
            th34.Join();
            th35.Join();
            th36.Join();
            th37.Join();
            th38.Join();
            th39.Join();
            th40.Join();
            th41.Join();
            th42.Join();
            th43.Join();
            th44.Join();
            th45.Join();
            th46.Join();
            th47.Join();
            th48.Join();

            th49.Join();
            th50.Join();
            th51.Join();
            th52.Join();
            th53.Join();
            th54.Join();
            th55.Join();
            th56.Join();
            th57.Join();
            th58.Join();
            th59.Join();
            th60.Join();
            th61.Join();
            th62.Join();
            th63.Join();
            th64.Join();
            
           
            Sum_Global = Sum_Global1+Sum_Global2+Sum_Global3+Sum_Global4+Sum_Global5
            +Sum_Global6+Sum_Global7+Sum_Global8+Sum_Global9+Sum_Global10+Sum_Global11+Sum_Global12
            +Sum_Global13+Sum_Global14+Sum_Global15+Sum_Global16+Sum_Global17+Sum_Global18+Sum_Global19+Sum_Global20
            +Sum_Global21+Sum_Global22+Sum_Global23+Sum_Global24+Sum_Global25+Sum_Global26+Sum_Global27+Sum_Global28
            +Sum_Global29+Sum_Global30+Sum_Global31+Sum_Global32+Sum_Global33+Sum_Global34+Sum_Global35+Sum_Global36+Sum_Global37
            +Sum_Global38+Sum_Global39+Sum_Global40+Sum_Global41+Sum_Global42+Sum_Global43+Sum_Global44
            +Sum_Global45+Sum_Global46+Sum_Global47+Sum_Global48+Sum_Global49+Sum_Global50+Sum_Global51
            +Sum_Global52+Sum_Global53+Sum_Global54+Sum_Global55+Sum_Global56+Sum_Global57+Sum_Global58+Sum_Global59
            +Sum_Global60+Sum_Global61+Sum_Global62+Sum_Global63+Sum_Global64;
            
            sw.Stop();
            Console.WriteLine("Done.");

            /* Result */
            Console.WriteLine("Summation result: {0}", Sum_Global);
            
            Console.WriteLine("Time used: " + sw.ElapsedMilliseconds.ToString() + "ms");
            
        }
    }
}