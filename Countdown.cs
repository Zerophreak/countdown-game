// Project: Countdown
// Date: 20/5/2023
// Developer: R Rutten

// TO DO rework timers 
// implement Methods.
// workout for loop to check array if it contains valid values from two other arrays.
// check into blocking input keys.
// check into loop algoritms and comparing arrays to each other.
// figure out the library check (optional)
// learn how classes and method work together

using System;
using System.Timers;

namespace program
{
    class countdown{
        
        public static void wordgame()
        {
            string[25] alphabet = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
            Console.WriteLine("What vowels and constenants would you like");
            string[7] letters = Console.ReadLine(); // make this a string instead of array maybe

            // look into otherways to limit the input of any invalid keys.   
            // can you block off keyboard input to limit it only to letters and other necessary keys.
            //
            private static void checkArrays()
            {
                for(int i = 0; i < alphabet; i++){
                // check array letters if it doesnt contain any input that isnt in array alphabet.
                // if it does contain any invalid input, throw out letters.  
                for(int j = 0; j < letters; j++){

                    }

                }
            // outcome should be that array letters gets check if 
            }
            if (letters.length == 8)
            {
                Console.WriteLine("Make words with these letters " + letters);
                // tell to make words with the letters 
                SetTimer(); // rework timers.
                // start timer for 60s

            }
            else if (letters.length < 8 || letters.length > 8)
            {
                Console.WriteLine("To many or to few letters");
            }

            Timer.Stop();
            Console.WriteLine("What do you got, what is your best word?");
            string word = Console.ReadLine();
            Console.WriteLine(word);
        }

        public static void numbergame()
        {

            int[] bignumbers = { 25, 10, 50, 100 };
            int[] smallnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random targetnumber = new Random();
            // randomly pick  2-4 big or small numbers total is 6
            //generate number between 100 and 999.
            // target number 3 digit random generated number
            // set timer only if number is generated.
            int targetnumber = targetnumber.Next(100, 1000); 

            Console.WriteLine(targetnumber);
            if (targetnumber == true)
            {
                setTimer();
                Console.WriteLine("1 minute on the clock");

            }

            stopTimer();
            Console.WriteLine("dundu dumde dunn");
        }
        

        // ultimate check with a dictionary if word exist
        public static bool dictionary()
        {
            // method to check the if a word exist in dictonary
            // if doesnt exist word invalid
            if(word == dictionary){
                return true;
            } else {
                return false;
            }

        }

        public  int score()
        {
            // counts the score wordgame score == length of word
            int totalscore = wordscore + numberscore;
            int wordscore = word.length;

            // check the scoring rule

            if (targetnumber == yournumber){
                numberscore += 8;
            }
            else if (targetnumber - yournumber < 25){
                numberscore += 4;
            }
            else if (targetnumber - yournumber > 25){
                numbersscore += 0;
            }

            Console.WriteLine(totalscore);
        }
        // work out how to work with timers in depth.
        private static void SetTimer()
        {
            Timer = new System.Timers.Timer(60); // set timer to 60s 
        }

        static void dictonarycheck()
        {
            // do a dictonary check on the wordgame answers.
        }

        static void Main(string[] args)
        {
            //Work out the interactions between different parts.
            //call methods and work out the logic between

            if(wordgame()){
                setTimer();
            }

            wordgame(); // run this first before numbergame
            SetTimer();
            numbergame();

        }
    }
    
}