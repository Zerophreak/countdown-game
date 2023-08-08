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
        {   // make it the symbols or letters, change it all make it random gen the vowels and constenants. enter number of vowels
            //char[42] symbols = {",", ".", "'", ";", "\ ", "]", "[", "`", "-", "=", "/", "*", "+", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "~", "<", ">", "?", "{", "}", "_", ":","", "|"}; 
            char[4] vowels = {"a", "e", "i", "o", "u"};
            char[19] constenant = {"q", "w", "r", "t", "y", "p", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "b", "n", "m"};
            Console.Writeline("How many vowels & constenants would you like?");
            int vowelinput = Console.ReadLine(); // number for how many vowels need to be selected at random
            int constinput = Console.ReadLine(); // number for how many constenant need to be selected at random
            Random constnumber = new Random();
            Random vowelnumber = new Random();
            int constnumber = constnumber.Next(0, 5);
            int vowelnumber = vowelnumber.next(0, 20);
            // generate random numbers then print what is picked
            Conole.WriteLine(vowels[vowelnumber])
            Console.WriteLine("Your letters are!" + " " + letters);
            string[7] letters =  // make this a string instead of array maybe 
            // set up the random gen for picking constenants and vowels
        
            
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

            int[3] bignumbers = { 25, 10, 50, 100 };
            int[9] smallnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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