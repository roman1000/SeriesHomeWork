using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSchool
{
    class Program
    {
        static void Main()
        {

        }
        public static int Series1(int[] nums)
        {
            int Result = 0;
            for (int i = 0; i < nums.Length + 1; i++)
                Result += nums[i];
            return(Result);
        }
        public static int Series2(int[] nums)
        {
            int Result = 0;
            for (int i = 0; i < nums.Length + 1; i++)
                Result *= nums[i];
            return (Result);
        }
        public static int Series3(int[] nums)
        {
            int Result = 0;
            for (int i = 0; i < nums.Length + 1; i++)
                Result += nums[i];
            Result = Result / nums.Length;
            return (Result);
        }
        public static int Series4(int[] N)
        {
            int Result1 = 0;
            int Result2 = 0;
            for (int i = 0; i < N.Length + 1; i++)
            {
                Result1 += N[i];
                Result2 *= N[i];
            }
            return(Result1);
        }
        public static int Series5(int[] N)
        {
            int Result1 = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] % 1 == 0)
                {
                    Result1 += (int)N[i];
                    Console.WriteLine(N[i]);
                }
            return (Result1);
        }
        public static double Series6(int[] N)
        {
            double Result1 = 1;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] % 1 != 0)
                {
                    Result1 *= N[i];
                    Console.WriteLine(N[i]);
                }
            return(Result1);
        }
        public static double Series7(int[] N)
        {
            double Result1 = 0;
            for (int i = 0; i < N.Length + 1; i++)
            {
                Result1 += N[i] / 1;
                Console.WriteLine(N[i] / 1);
            }
            return(Result1);
        }
        public static int Series8(int[] N)
        {
            int K = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] % 2 == 0)
                {
                    K++;
                    Console.WriteLine(N[i]);
                }
            return (K);
        }
        public static int Series9(int[] N)
        {
            int K = 0;
            for (int i = 0; i < N.Length + 1; i++, K++)
                if (N[i] % 2 != 0)
                    Console.WriteLine(K + 1);
            return (K + 1);
        }
        public static bool Series10(int[] N)
        {
            bool PositiveValueCheck = false;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] > 0)
                    PositiveValueCheck = true;
            return (PositiveValueCheck);
        }
        public static bool Series11(int[] N)
        {
            int K = 5;
            bool PositiveValueCheck = false;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] < K)
                    PositiveValueCheck = true;
            return (PositiveValueCheck);
        }
        public static int Series12(int[] N)
        {
            int Count = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] != 0)
                    Count++;
                else break;
            return (Count);
        }
        public static int Series13(int[] N)
        {
            int Result = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] > 0 && N[i] % 2 == 0)
                {
                    Result += N[i];
                }
                else if (N[i] == 0) break;
            return (Result);
        }
        public static int Series14(int[] N)
        {
            int Count = 0;
            int K = 8;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] < K)
                    Count++;
                else if (N[i] == 0) break;
            return (Count);
        }
        public static int Series15(int[] N)
        {
            int FirstNumMoreK = 0;
            int K = 3;
            for (int i = 0; i < N.Length + 1; i++)
                if (FirstNumMoreK != 0) break;
                else if (N[i] > K) FirstNumMoreK = N[i];
                else if (N[i] == 0) break;
            return (FirstNumMoreK);
        }
        public static int Series16(int[] N)
        {
            int FirstNumMoreK = 0;
            int K = 3;
            for (int i = N.Length - 1; i >= 0; i--)
                if (FirstNumMoreK != 0) break;
                else if (N[i] > K) FirstNumMoreK = N[i];
                else if (N[i] == 0) break;
            return (FirstNumMoreK);
        }
        public static string Series17(int[] N)
        {
            int B = 4;
            string Result = "";
            for (int i = 0; i < N.Length + 1; i++)
            {
                Result = N[i].ToString() + B.ToString();
                return (Result);
            }
            return "";
        }
        public static int Series18(int[] N)
        {
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] != N[i + 1])
                    return (N[i]);
            return 0;
        }
        public static int Series19(int[] N)
        {
            int K = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i + 1] < N[i])
                {
                    Console.WriteLine(N[i + 1]);
                    K++;
                }
            return (K);
        }
        public static int Series20(int[] N)
        {
            int K = 0;
            for (int i = 0; i < N.Length + 1; i++)
                if (N[i] < N[i + 1])
                {
                    Console.WriteLine(N[i]);
                    K++;
                }
            return (K);
        }
    }
}
