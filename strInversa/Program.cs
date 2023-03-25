using System;


namespace Faturamento
{
  class Program
  {
    static void Main(string[] args)
    {
      char [] str = new char [4] {'j','o','a','o'};
      int i;
      for(i=3;i>=0;i--){
       Console.WriteLine("{0}",str[i]);
      }
    }
  }
}

