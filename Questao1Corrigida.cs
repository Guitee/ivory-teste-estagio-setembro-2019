using System;

  class Questao1Corrigida
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
       //o erro estava aqui. Temos que terminar a recursividade no 1 pois se terminar no 0 ira zerar toda a soma feita pela recursividade
       if (numero <= 1)
       {
        // aqui tbm muda para 1 para nao retornar o zero
         return (1);
       }
       else
       {
          resultado = numero * Calcular(numero - 1);
          return (resultado);
        }
    }//fim calcular()

 }//fim class QuestaoCorrigida

