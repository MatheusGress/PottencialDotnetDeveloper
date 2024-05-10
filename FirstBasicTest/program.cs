using System;

class DIO {
        
    static void Main(string[] args){
      
        int contador = 0;
        int ProdutoDigitos = 1;
        int SomaDigitos = 0;
      
        // Lê o número inteiro da entrada do usuário
        string input = Console.ReadLine()
        // Converte a entrada em números inteiros e calcula o produto e a soma
            int[] num = new int[input.Length];
        
        while (contador < input.Length)
        {
            int.TryParse(input.Substring(contador, 1), out num[contador]); 
            ProdutoDigitos *= num[contador];
            SomaDigitos += num[contador];
            contador++;
        }
        
        // Calcula a diferença entre o produto e a soma
        int Resultado = ProdutoDigitos - SomaDigitos;
      
        Console.WriteLine(Resultado);
    }
}
