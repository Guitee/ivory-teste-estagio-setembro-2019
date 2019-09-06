using System;
 
public class desafioIvory
{   
	//cria e preenche a matriz de acordo com o enunciado
    public static String[,] criarMatriz(String n)
    {  
       // o n de colunas sera 2 mais o tamanho da palavra	
       int coluna = 2 + n.Length;
       String[,] matriz = new String[3, coluna];
       // contador dos primeiros numeros
       int contP = 1;
      // contador da String
       int contS= 0;
       // contador da ultima linha
       int contU = 8 + 2 * (n.Length-1);  
       
       for(int i = 0; i < matriz.GetLength(0); i++)
       {
       	  for(int j = 0; j < matriz.GetLength(1); j++)
       	  {
            // ira preencher a primeira linha com o primeiro contador 	
            if(i == 0)
            { 
              matriz[i,j] = Convert.ToString(contP);
              contP++;
                           
            }
            // ira preencher a segunda linha 
            else if(i == 1)
            {
             	if(j == 0)
             	{
             	  // preenche o primeiro elemento da segunda linha 	 
                  matriz[i,j] = Convert.ToString(contU);
             	}
             	else if((j >1) && (j == 1) || j < coluna -1)
             	{ 
             	  //escreve a palavra na matriz, caracter por caracter 	
                  matriz[i,j] = Convert.ToString(n[contS]);
                  contS++;      
             	}
             	else
             	{
             	   //preenche a ultima coluna da segunda linha 	 
               	   matriz[i,j] = Convert.ToString(contP);
                }
             	
             }
             else
             {  
             	//preenche toda a ultima linha
             	contU--;
               	matriz[i,j] = Convert.ToString(contU);
             	
             }
                        
       	  }
       }

       return matriz;

    }// fim criarMatriz()

    //printa a matriz 
    public static void printMatriz(String [,] mat)
    {    
        Console.WriteLine("MATRIZ FORMADA");
        Console.WriteLine();

        for(int i = 0; i < mat.GetLength(0); i++)
        {
        	for (int j = 0; j < mat.GetLength(1); j++)
        	{
        	   Console.Write(string.Format("{0}\t", mat[i,j]));	
        	}
        	Console.WriteLine();
        } 
    }//fim printMatriz()

    public static void Main(string[] args)
    {
    	String name = ""; 
        Console.WriteLine ("Digite um nome qualquer:");
        name = Console.ReadLine();
        Console.WriteLine("O NOME DIGITADO FOI : " + name);
        Console.WriteLine();
        printMatriz(criarMatriz(name));

    }//fim main()
}// fim class desafioIvory
