using System;

class Program {
    public static void Main(string[] args){
        string entrada;
        int contador = 0;
        Console.WriteLine("Informe a string a ser verificada");
        entrada = Console.ReadLine();
        foreach(char i in entrada){
            if(char.ToLower(i) == 'a'){
                contador++;
            }
        }
        if(contador > 0){
            Console.WriteLine($"Existem {contador} a's na palavra {entrada}");
        }
        else Console.WriteLine($"Não existem a's na palavra {entrada}");

    }
}