using System;

namespace sum4

static void Main(string[] args)
{
        int t = Convert.Toint32(Console.ReadLine())
        int t1 = t;    
        int[] n = new int[t]; //n[0]....n[t-1]
        while (t > 0)
        {
            n[t-1] = Convert.Toint32(Console.ReadLine());
            t--;
        }   
        While (t1 > 0)
        {
            //Console.WriteLine(*{0}), n[t - 1];
            Console.WriteLine("{0}",S(n[t1 - 1]).ToString("0,00000000"));
            t1--;
        }
    Console.ReadLine();
}
 static double S(int n)
 {
     double tong;
     int x = 0;
     for(int i-1; i<=n; i++)
     {
         x = x + i;
         tong = tong + 1.0/ x;
     }
     return tong;
 }