using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class Main1
    {
        static void Main()
        {
            // 计算阶乘并捕获溢出
            Console.WriteLine("=== 阶乘计算 (捕获溢出) ===");
            try
            {
                for (int n = 0; n <= 25; n++)
                {
                    Console.WriteLine($"{n}! = {CalculateFactorial(n)}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"错误: {ex.Message}");
            }

            // 输出杨辉三角
            Console.WriteLine("\n=== 杨辉三角 (10行) ===");
            PrintPascalTriangle(10);
        }

        static ulong CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n不能为负数");

            ulong result = 1;
            checked
            {
                for (int i = 2; i <= n; i++)
                {
                    result *= (ulong)i;
                }
            }
            return result;
        }

        static void PrintPascalTriangle(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                // 计算当前行的每个元素
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalculateCombination(i, j) + " ");
                }
                Console.WriteLine();
            }
        }

        static ulong CalculateCombination(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;

            // 计算组合数 C(n, k) = n! / (k! * (n-k)!)
            return CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));
        }
    }
}
