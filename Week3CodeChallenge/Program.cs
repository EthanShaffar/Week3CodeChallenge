using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static bool IsPrime(int number) //Confirms if number is Prime.
        {
            var divC = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    divC += 1;
                }
            }
            if (divC == 2)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        static void FindManyPrimes(int thisMany)
        {
            int primes = 0; //This is a counter that will increment when a prime number is confirmed
            int current = 2; //This variable is the current number and will be updated as the loop continues.
            while (primes<thisMany) //While the primes counter is less than the input for the function, this will run.
            {
                if (IsPrime(current) == true)// Using the ISPrime function, this statement will add 1 to primes if true.
                {
                    primes += 1;//Level up!
                }
                current += 1;//This is where the current number increments.
            }
            current -= 1; //when loop is completed, cancels last increment.
            Console.WriteLine("The " + thisMany + " prime number is: " + current);//Display!
        }//this checks what the input's prime number is. (ex: what is the 1001st prime?)
        static void EvenFibonacciSequencer(int maxValue) // Function will perform Fibonacci sequence and add even numbers into a grand total.
        {
            int grandTotal = 0;//Even numbers will be added to this variable.
            int oneNum=0;//less recent previous number.
            int secNum = 1;//most recent previous number.
            int current=1; //The current number, Will be changed as loop continues
            while (current < maxValue) //While the current number is less than the input value, this loop will run.
            {                
                oneNum = secNum;//less recent is updated
                secNum = current;//most recent updated
                current = oneNum + secNum;//takes the NEWLY UPDATED numbers and adds them together to create new currant.
                Console.Write(current + " => ");//displays new currant with arrow to show next. (make it purty!)
                if (current % 2 == 0)//This statement checks if its an even number.
                {
                    grandTotal += current;//If even, adds it to grand total.
                }
            }
            Console.WriteLine();
            Console.WriteLine("The grand total of all even numbers in sequence is: " + grandTotal); //The final total displayed
        }
        static void LongestCollatzSequence()//This performs the collatz sequence up to 1million.
        {
            int n = 1000000; // top most value used 
            int grandCounter = 200; //This counter is used to mark highest count. Number is a checkpoint.
            long grandNum = 0; //This will be the number that has the highest chain.
            for (int i = 2; i <= n; i++) //This loop processes both numbers to conform the biggest chain
            {
                int currentNum = i;
                long current = long.Parse( i.ToString());
                int counter = 1;
                while (current != 1)
                {
                    if (current % 2 == 0)
                    {
                        current /= 2;
                        counter += 1;
                    }
                    else
                    {
                        current = (current * 3) + 1;
                        counter += 1;
                    }
                }
                if (counter > grandCounter)
                {
                    grandCounter = counter;
                    grandNum = currentNum;                 
                    Console.WriteLine("This number " + currentNum + " chained " + counter + " times.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("The biggest chain was " + grandCounter + " by the number " + grandNum);
        }
        static void Main(string[] args)
        {
            FindManyPrimes(1001);
            EvenFibonacciSequencer(2000000);
            LongestCollatzSequence();
            Console.ReadKey();
            
        }
    }
}
