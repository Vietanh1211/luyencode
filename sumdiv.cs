using System;
class Hello {
  static void Main(string[] args) 
 {
    int t = Convert.ToInt32(Console.Readline());
    int[] mang = new int[1002];
    int tl = t;
    while(t>0)
    {
        mang[t] = Convert.ToInt32(Console.ReadLine());
        t--;
    }
    while (tl > 0)
    {
        Console,WriteLine("{0}"), sumdiv(mang[tl]));
        tl--;
    }
  Console.ReadLine();
 }
 static long sumdiv(int x)
 {
     long sum = 0;
     long i = 1;
     while (i <= Math.Round(Math.Sqrt(x)))
     {
         if((x%i==0) && (if = Math.Sqrt(x)))
         {
             sum = sum + i + x/i;
         }
         if((x % i == 0) &&( i == Math.Sqrt(x))) sum = sum + i;
         i++;
         
     }