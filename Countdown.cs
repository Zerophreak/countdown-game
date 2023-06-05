// Project: COuntdown
// Date: 20/5/2023
// Developer: R Rutten
using System;
using System.Timers;

namespace app
{
    class countdown{
        

        public static void wordgame(){
            string[4] vowels = { a, e, o, u, i };
            string[] constenants = { a, b, c, d, f, g, h, j, k, l, p, y, t, r, w, q, s, z, x, v, n, m, };
            bool vowelexist; // for checking if letters contains a vowel
            bool constexist;

            Console.WriteLine("Pick your vowels and constenants");
            string abc = Console.ReadLine();
            // input vowels and constenant up to 8 max put the input into a array
            // build logic to verify input with both const and vowels arrays. 
            string[7] letters = { };
            // outcome should be that array letters gets check if 

            if (letters.length == 8)
            {
                Console.WriteLine("Make words with these letters");
                // tell to make words with the letters 
                SetTimer();
                // start timer for 60s

            }
            else if (letters.length < 8 || letters.length > 8)
            {
                Console.WriteLine("To many or to few letters");
            }// throw away input and start over

            Console.WriteLine("What do you got, what is your best word?");
            Timer.Stop();
            string word = Console.ReadLine();
            Console.WriteLine(word);
        }

        public static void numbergame(){

            int[] bignumbers = { 25, 10, 50, 100 };
            int[] smallnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random targetnumber = new Random();

            //generate number between 100 and 999.
            // target number 3 digit random generated number
            // set timer only if number is generated.
            int targetnumber = targetnumber.Next(100, 1000); 

            Console.WriteLine(targetnumber);
            if (targetnumber == true)
            {
                setTimer();
            }

            stopTimer();
        }
        

        // ultimate check with a dictionary if word exist
        public static bool dictionary(){

            // method to check the if a word exist in dictonary
            // if doesnt exist word invalid

        }

        public static int score(){
            // counts the score wordgame score == length of word
            int totalscore = wordscore + numberscore;
            int wordscore = word.length;
            Console.WriteLine(totalscore);

        }
        // work out how to work with timers in depth.
        private static void SetTimer(){
            Timer = new System.Timers.Timer(60); // set timer to 60s 
        }

        static void Main(string[] args)
        {
            //call methods and work out the logic between

            wordgame(); // run this first before numbergame
            numbergame();

        }
    }
    
}