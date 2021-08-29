using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
         {
            String palavraCensurada = "#@$%*!&";
            String fraseDigitada, fraseCensurada;
            Console.Write("Digite uma frase:");
                fraseDigitada = Console.ReadLine();

            
           {  
                 fraseCensurada  =  fraseDigitada

              .Replace("chata", palavraCensurada)
              .Replace("bobo", palavraCensurada)
              .Replace("boba", palavraCensurada)
              .Replace("feio", palavraCensurada)
              .Replace("feia", palavraCensurada)
              .Replace("boboca",palavraCensurada)
              .Replace("boco", palavraCensurada)
              .Replace("tonto", palavraCensurada)
              .Replace("tonta", palavraCensurada)
              .Replace("palerma", palavraCensurada)
              .Replace("paspalho", palavraCensurada)
              .Replace("paspalha", palavraCensurada)
              .Replace("tantã", palavraCensurada)
              .Replace("panaca", palavraCensurada)
              .Replace("pentelho", palavraCensurada)
              .Replace("pentenlha", palavraCensurada) 
              .Replace("burro", palavraCensurada)
              .Replace("burra", palavraCensurada)
              .Replace("besta", palavraCensurada);
              
               Console.WriteLine(fraseCensurada);
              
              
    
              
            

           }  

        
            

          }
    }
}
