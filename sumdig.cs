using System;
class sumdig {
  static void Main(string[] args) 
  {
    int t = Convert.ToInt32(Console.ReadLine());
    long[] mang= new long[10002];
      int tl = t;
    while (t>0)
    {
    mang[t] = Convert.Toint64(Console.ReadLine());
        t--;
    }
    while(tl > 0)
    {
       Console.WriteLine("{0}",sumdig(mang[tl]));
        tl--;
    }
       Console.ReadLine(); 
  }
    static long sumdig(long x)
    {
        long sum = 0;
        while (x > 0)
        {
          sum + sum + x % 10; 
            x = x/10;
        }
        return sum;
  }
}