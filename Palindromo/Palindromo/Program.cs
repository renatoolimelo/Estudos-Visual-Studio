using System;

namespace Palindromo {
    class Program {
        static void Main(string[] args) 
            {

            string word;

            Console.WriteLine("Informe a palavra: ");
            word = Console.ReadLine().ToLower();

            char[] wordnormal = word.ToCharArray();
            char[] palindrome = word.ToCharArray();

            Array.Reverse(palindrome);

            int j = wordnormal.Length - 1;

            for (int i = 0; i < wordnormal.Length; i++) {
                if (wordnormal[i] != palindrome[j]) {
                    Console.WriteLine("Palavra não é um Palindromo");
                    return;
                }
                else if(wordnormal[i] == palindrome[j] && j == 0) {
                    Console.WriteLine("Palavra é um Palindromo");
                }
                j--;
            }

        }
    }
}
