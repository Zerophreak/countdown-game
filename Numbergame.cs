// Project: COuntdown
// Date: 20/5/2023
// Developer: R Rutten.

using System;
using Systems.Timers;
// basics about finnished
//later building in more check to see if  rules are followed.
// check if numbers exist in array
// see if i can make picking numbers worth it.
// last is mergin the 2 games and test
// plus is after testing build a interface not just text based.
namespace countdown
{
    class countnumbers{
        static void Main(string[] args){
            int[] bignumbers = {25, 10, 50, 100};  
            int[] smallnumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            Random targetnumber = new Random();
            int targetnumber = targetnumber.Next(100, 1000); //generate number between 100 and 999.
            // target number 3 digit random generated number
            // set timer only if number is generated.

            Console.WriteLine(targetnumber);
            if(targetnumber == true){
                setTimer();
            }

            stopTimer();      
          }
        private static void SetTimer()
        {
            Timer = new System.Timers.Timer(60); // set timer to 60s 
        }
        public int score(){
            Console.WriteLine("Did you get the target number. Enter your answer");
            int yournumber = Console.ReadLine();
            // set logic for checing and scoring

            if (targetnumber == yournumber)
            {
                numberscore += 8;
            }
            else if (targetnumber - yournumber < 25)
            {
                numberscore += 4;
            }
            else if (targetnumber - yournumber > 25)
            {
                numbersscore += 0;
            }

        }
    }
}
