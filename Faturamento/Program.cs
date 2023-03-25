using System;


namespace Faturamento
{
  class Program
  {
    static void Main(string[] args)
    {
     double sp=67836.43;
     double rj=36678.66;
     double mg=29229.88;
     double es=21165.48;
     double outros=19.849;

     double total=sp+rj+mg+es+outros;

     Console.WriteLine("A porcentagem em relação ao todo de São Paulo é {0}",(sp*100)/total);
     Console.WriteLine("A porcentagem em relação ao todo do Rio de janeiro é {0}",(rj*100)/total);
     Console.WriteLine("A porcentagem em relação ao todo de Minas Gerais é {0}",(mg*100)/total);
     Console.WriteLine("A porcentagem em relação ao todo do Espirito Santo é {0}",(es*100)/total);
     Console.WriteLine("A porcentagem em relação ao todo de Outros é {0}",(outros*100)/total);

    }
  }
}
