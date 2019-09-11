using System;

  class Questao1
  {
     public static void Main(string[] args)
     {
       int numero = 5;
       int resultado = Calcular(numero);
       Console.WriteLine($"Resultado:{0}", resultado);
       Console.ReadKey();

     }//fim main()

    public static int Calcular(int numero)
    {
       int resultado = 0;
       if (numero <= 0)
       {
          return (0);
       }
       else
       {
          resultado = numero * Calcular(numero - 1);
          return (resultado);
        }
    }//fim calcular()

 }//fim class QuestaoCorrigida

