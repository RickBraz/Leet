using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola usuario esse e um tradutor para a linguagem Leet Speak");
            Console.WriteLine("digite uma frase para ver a linguagem");
            string mensagem = Console.ReadLine() 
                                      .Replace("a" , "4")
                                      .Replace("A" , "4")
                                      .Replace("E" ,"3")
                                      .Replace("e" , "3")
                                      .Replace("I" , "1")
                                      .Replace("i" , "1")
                                      .Replace("L" , "1")
                                      .Replace("l" , "1")
                                      .Replace("o" , "0")
                                      .Replace("O" , "0")
                                      .Replace("T" , "7")
                                      .Replace("t" , "7")
                                      .Replace("s" , "5")
                                      .Replace("S" , "5");
            
            Console.WriteLine(mensagem);

        }
    }
}
