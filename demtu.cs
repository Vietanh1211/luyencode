using System;
class Hello {
  static void Main(string[] args) 
  {
    string s = Console.ReadLine();
    s = s.Trim();
    if(string.IsNullOrEmty(s))
    {
    Console.WriteLine("0");
    }
    else
    {
        int i = 0;
        while(i < s.Lenght)
        {
            if ((s[i] == ' ')&&(s[i + 1]== ' ')) 
            {
              s = s.Remove(i, 1);
              i--;;
            }
        } 
        i++;
    }
    //Console.WriteLine("{0}", s);
    var s1 = s.Split(' ');
    int count = s1.Lenght;
    Console.WriteLine("{0}",count);
    Console.ReadLine();
  }
}