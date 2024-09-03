using System;

class Program {
    public static void Main(string[] args){
        int n1 = 0, n2 = 1, aux;
        bool existeFib = false;
        Console.WriteLine("Informe o número a ser verificado se existe na sequência de Fibonacci:");
        if(int.TryParse(Console.ReadLine(), out int entrada)){
            while(n1 <= entrada){
                Console.Write(n1 + " ");
                aux = n1;
                n1 = n2;
                n2 += aux;
                if(n1 == entrada) existeFib = true;
            }
            if(existeFib) Console.WriteLine($"\n{entrada} está na sequência de Fibonacci");
            else Console.WriteLine($"\n{entrada} não está na sequência de Fibonacci");
        }
        else Console.WriteLine("Entrada inválida");
    }
}