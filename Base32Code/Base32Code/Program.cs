using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base32Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(262143);
            int b = random.Next(262143);
            var byteA = GetByteArry(a);
            var byteB = GetByteArry(b);
            Byte[] ab = new Byte[5];
            ab[1] = byteA[2];
            ab[2] = byteA[3];
            ab[3] = byteB[2];
            ab[4] = byteB[3];
            int temp5 = (int)(byteA[1]) * 4 + (int)byteB[1];
            var arry4 = GetEachBitInt(ab[4]);
            var arry3 = GetEachBitInt(ab[3]);
            var arry2 = GetEachBitInt(ab[2]);
            var arry1 = GetEachBitInt(ab[1]);
            var arry0 = GetEachBitInt(temp5);
            int high0 = (arry0[4] + arry1[4] + arry1[7] + arry2[4] + arry2[7] + arry3[4] + arry3[7] + arry4[4] + arry4[7]) % 2;
            int high1 = (arry0[3] + arry1[3] + arry1[6] + arry2[3] + arry2[6] + arry3[3] + arry3[6] + arry4[3] + arry4[6]) % 2;
            int high2 = (arry0[2] + arry1[2] + arry1[5] + arry2[2] + arry2[5] + arry3[2] + arry3[5] + arry4[2] + arry4[5]) % 2;
            int high3 = (arry0[1] + arry1[1] + arry1[4] + arry2[1] + arry2[4] + arry3[1] + arry3[4] + arry4[1] + arry4[4]) % 2;
            temp5 = temp5 + high0 * 128 + high1 * 64 + high2 * 32 + high3 * 16;
            ab[0] = Byte.Parse(temp5.ToString());
            //Console.WriteLine("{0},{1}, {2}", a, b);
            string result = CBase32.Encode(ab);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        /// <summary>
        /// 将32为int转换为字节数组
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static byte[] GetByteArry(int n)
        {
            byte[] b = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                b[i] = (byte)(n >> (24 - i * 8));
                //Console.WriteLine("{0}, {1}, {2}", n, b[i], i);
            }
            return b;
        }

        /// <summary>
        /// 获取低8位的每一个bit
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] GetEachBitInt(int num)
        {
            int[] result = new int[8];
            result[7] = (num & 0x01) == 0x01 ? 1 : 0;
            result[6] = (num & 0x02) == 0x02 ? 1 : 0;
            result[5] = (num & 0x04) == 0x04 ? 1 : 0;
            result[4] = (num & 0x08) == 0x08 ? 1 : 0;
            result[3] = (num & 0x10) == 0x10 ? 1 : 0;
            result[2] = (num & 0x20) == 0x20 ? 1 : 0;
            result[1] = (num & 0x40) == 0x40 ? 1 : 0;
            result[0] = (num & 0x80) == 0x80 ? 1 : 0;
            return result;
        }
    }
}
