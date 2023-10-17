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
// Rework arrays so they work with random number gen to pick vowels and constinents.
// look into testing your code and unit testing. (Priority)
// Rework that things into classes.

//Rebuild with Inheretance
using System;
using System.Timers;

namespace program
{
    class Countdown{
        constructor(){

        }
        private static void setTimerWord()
        {
            Timer.Stop();
            Console.WriteLine("What do you got, what is your best word?");
            string word = Console.ReadLine();
            Console.WriteLine(word);

            }

            public static bool dictionary()
            {
                // method to check the if a word exist in dictonary
                // if doesnt exist word invalid
                if (word == dictionary)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public int wordgamescore(int wordscore)
            {
                // Only award points if word exist in a dictonary 

                if(dictionary){
                    return wordscore = word.length; 
                }else {
                    return wordscore = 0;
                }

            }   

    }
    class Numbergame : Countdown{
        constructor(){

        }
    int[3] bignumbers = { 25, 10, 50, 100 };
    int[9] smallnumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Random targetnumber = new Random();
    // randomly pick  2-4 big or small numbers total is 6
    //generate number between 100 and 999.
    // target number 3 digit random generated number
    // set timer only if number is generated.
    int targetnumber = targetnumber.Next(100, 1000);      
    Console.WriteLine("Your targetnumber is:" + " " + targetnumber);
    // checks if you have a target number if true set timer
    if (targetnumber == true){
            setTimer();
            Console.WriteLine("1 minute on the clock");
        }
        stopTimer();
            Console.WriteLine("dundu dumde dunn");
            int yournumber = Console.ReadLine();
        // ultimate check with a dictionary if word exist
        public  int numbergamescore(int targetnumber, int yournumber){
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

                Console.WriteLine(numberscore);
        }
        // work out how to work with timers in depth.
        private static void SetTimerNumber(){
                Timer = new System.Timers.Timer(60); // set timer to 60s 
            }
        }

         class WordGame : Countdown{   
            // make it the symbols or letters, change it all make it random gen the vowels and constenants. enter number of vowels
            //char[42] symbols = {",", ".", "'", ";", "\ ", "]", "[", "`", "-", "=", "/", "*", "+", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "~", "<", ">", "?", "{", "}", "_", ":","", "|"}; 
            char[4] vowels = {"a", "e", "i", "o", "u"};
            char[19] constenant = {"q", "w", "r", "t", "y", "p", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "b", "n", "m"};
            Console.Writeline("How many vowels & constenants would you like?");
            int vowelinput = Console.ReadLine(); // number for how many vowels need to be selected at random
            int constinput = Console.ReadLine(); // number for how many constenant need to be selected at random
            Random constnumber = new Random();
            Random vowelnumber = new Random();
            int constnumber = constnumber.Next(0, 20);
            int vowelnumber = vowelnumber.next(0, 5);
            // generate random numbers then print what is picked
            // loops for printing to the number from input
            // checi if input doesnt go overmax create random numbers to the max set then prints the letters.
            if(vowelinput <= 4){
                if(constinput <= 4){
                    for(int i = 0; i < vowelinput; i++){
                        console.WriteLine(vowelnumber);
                    }
                    for(int j = 0; j < constinput; j++){
                        console.WriteLine(constnumber);
                    }
                }
            }
               
            
            string[7] letters = {}; // make this a string instead of array maybe
            Console.WriteLine("Your letters are!" + " " + letters);
           
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

        }   
}