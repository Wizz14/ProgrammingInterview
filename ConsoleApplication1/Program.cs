using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ข้อ 1
            // รับพารามิเตอร์เป็น int ชื่อ n
            // หาจำนวนเฉพาะ n ตัวแรก ยกตัวอย่างเช่น 
            // n = 10 => 2 3 5 7 11 13 17 19 23 29
            // n = 15 => 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            // เก็บค่าใส่ตัวแปร List<int> primeNumber

            // https://th.wikipedia.org/wiki/%E0%B8%88%E0%B8%B3%E0%B8%99%E0%B8%A7%E0%B8%99%E0%B9%80%E0%B8%89%E0%B8%9E%E0%B8%B2%E0%B8%B0
            // จำนวนเฉพาะ คือ จำนวนเต็มบวกที่ไม่มีเลขจำนวนเต็มบวกใดๆหารมันลงตัวยกเว้น 1 และ ตัวมันเอง

            int n = 1000;
            var primeNumber = GetPrimeNumber(n);
            Console.WriteLine("First {0} Prime number are \n[ {1} ]\n", n, String.Join(" ", primeNumber));
        }

        static List<int> GetPrimeNumber(int n)
        {
            List<int> primeNumber = new List<int>();

            // เขียนโค๊ดตรงนี้เลยจ้า

            return primeNumber;
        }
    }
}
