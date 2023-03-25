using System;

namespace Fibonacci
{
  class Program
  {
    static void Main(string[] args)
    {
      uint i;
      uint atual,ant1,ant2;
      uint[] fib=new uint [11] {0,1,1,2,3,5,8,13,21,34,55};
      Console.WriteLine("Diga o número de onde deseja iniciar sua sequência(exceto 0 e números maiores que 20 por questões de memória): ");
      atual=Convert.ToUInt32(Console.ReadLine());
      ant1=atual-1;
      ant2=atual-2;

      for(i=0;i<=10;i++){
        atual=ant1+ant2;
        Console.WriteLine(atual);
        ant2=ant1;
        ant1=atual;
      }

      var check=Array.Exists(fib,x =>x==atual);
      if(check==true){
        Console.WriteLine("Este número está na sequência de Fibonacci.");
      }else{
        Console.WriteLine("Este número não está na sequência de Fibonacci.");
     }
    }
  }
}
