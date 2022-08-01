import java.util.Scanner;
import java.util.Random;
import java.util.Timer;

public class Countdown {
  
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        random rand = new Random();
        int roundcounter;

        public class wordgame(){
            //char [] constenant = {q, w, r, t, y, p, s, d, f, g, h, j, k, l, z, c, v, b, n, m};
            //char [] vowels = {a, e, o, i, u};
            int wordtotal = 8;
            System.out.println("How many vowels do you want");
            int vowelsNumber = Scanner.nextInt();
            System.out.println("How many constenants do you want");
            int constenantNumber = Scanner.nextInt();
            String yourWord;

            if(vowelsNumber < 4 && constenantNumber < 4 && wordtotal == 8){
                // select random vowels and constenant then print vowels and constenant
                // print create a word with these then start a 60s timer
                // what your word after timer
                System.out.println("What is your word");
                yourWord = Scanner.nextLine();
            } else if(){

            }  else {
                System.out.println("Error to many vowels and constenant");
                return wordgame;

            }
        }

        public class numbergame{
           int smallnumber [] = {1, 2, 3, 4,5,6,7,8,9}
            int bignumber [] = {10,25,50,75,100}
            int totalnumber = smallcount + bigcount;
            int targetnumber =rand.nextInt(100,999); // random genrated number between 100-999 
            System.out.println("How many small numbers");
            int smallcount = Scanner.nextInt();
            System.out.println("How many big numbers");
            int bigcount
            if(totalnumber == 6){
                //small number random between

            }
        }
       
        public static int score(){

        }
    }
}