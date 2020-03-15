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
                                      .Replace("A" , "")
                                      .Replace("E" ,"")
                                      .Replace("e" , "")
                                      .Replace("I" , "")
                                      .Replace("i" , "")
                                      .Replace("L" , "")
                                      .Replace("l" , "")
                                      .Replace("o" , "")
                                      .Replace("O" , "")
                                      .Replace("T" , "")
                                      .Replace("t" , "")
                                      .Replace("" , "")
                                      .Replace("" , "");

        }
    }
}
