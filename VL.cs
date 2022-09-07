using System;
namespace VL14
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.Toint32(s1[0]);
            int b = Convert.Toint32(s1[1]);             
            int c = ucln(a, b);
            Console.WriteLine(c);
            Console.ReadLine;
        }
        static int ucln(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);            
            if (x == 0) && (y !=0) return y;
            if (y == 0) && (x !=0) return x;
            if (x > y) return ucln(x%y, y);
            else return ucln(x,y%x)
        }
    }
}