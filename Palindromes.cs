  using System;
   class Palindromes{
        public static void Main(){
            Console.WriteLine("Please enter word: ");
            string inputWord = Console.ReadLine();
            string reverseWord ="";
            for (int index = inputWord.Length-1; index >=0; index--){
                reverseWord += inputWord[index];

            }
            if(inputWord==reverseWord){
                Console.WriteLine(inputWord+" is palindrome");
            }
            else{
                Console.WriteLine(inputWord+" is not palindrome");
            }
            
        }
    }