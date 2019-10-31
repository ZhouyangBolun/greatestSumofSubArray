using System;

namespace ConsoleApp1
{
    class Program
    {
        /***
         * 数组的最大字串和问题方法
         * 
         * 核心思想：求和判定
         * 
         * 时间复杂度：n
         * 
         * 思路：
         * 
         * 从第一个元素开始向后方加起求和，
         * 如果之前n-1个数和小于0，就舍去从n开始做字符串求和
         * 
         * 思路提供：网易面我的大哥
         ***/

        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            Console.WriteLine("\n请输入数组数据");
            int count = 0;
            do
            {
                arrayOutput(array, arrayLength);
                array[count] = int.Parse(Console.ReadLine());
                count++;
            }
            while (count != arrayLength);
            arrayOutput(array, arrayLength);

            Console.WriteLine("\n该数组的最大字串和为：" + GreatestSumofSubArray(array).ToString());

        }

        static int GreatestSumofSubArray(int[] array)    
        {
            if(array == null || array.Length<1)
            {
                Console.WriteLine("输入数组数据异常");
                return -1;
            }

            int tem = 0;
            int max = array[0];

            foreach(int i in array)
            {
                if(tem < 0)
                    tem = i;
                else
                    tem += i;
                if (max < tem)
                    max = tem;
            }
            return max;
        }

        static void arrayOutput(int[] array, int arrayLength)
        {
            string cArrayOutput = "当前数组为[";

            for (int num = 0; num < arrayLength - 1; num++)
            {
                cArrayOutput += array[num].ToString();
                cArrayOutput += "], [";
            }
            cArrayOutput += array[arrayLength - 1].ToString();
            cArrayOutput += "]\n";

            Console.WriteLine(cArrayOutput);
        }
    }
}
