﻿using System;
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
            /* ข้อ 1
             * รับพารามิเตอร์เป็น int ชื่อ N
             * หาจำนวนเฉพาะที่มีค่าระหว่าง 1 - N
             * เก็บค่าใส่ตัวแปร primeNumber
             * 
             * https://th.wikipedia.org/wiki/%E0%B8%88%E0%B8%B3%E0%B8%99%E0%B8%A7%E0%B8%99%E0%B9%80%E0%B8%89%E0%B8%9E%E0%B8%B2%E0%B8%B0
             * จำนวนเฉพาะ คือ จำนวนเต็มบวกที่ไม่มีเลขจำนวนเต็มบวกใดๆหารมันลงตัวยกเว้น 1 และ ตัวมันเอง
             * ยกตัวอย่างเช่น 2 3 5 7 11 13 17 19 23 29 ...
            */
            int N = 100;
            var primeNumber = GetPrimeNumber(N);
            Console.WriteLine("Prime number between 1-{0} is \n[ {1} ]\n", N, String.Join(" ", primeNumber));
        }

        static List<int> GetPrimeNumber(int n)
        {
            List<int> primeNumber = new List<int>();

            //เขียนโค๊ดตรงนี้เลยจร้า

            return primeNumber;
        }
    }
}
