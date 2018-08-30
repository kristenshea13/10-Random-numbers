using System;

namespace Random_numbers_for_statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ten random numbers between 0 and 100:");



            Random rnd = new Random();
           
            
            int randomTally = 0;
            //declare randomTally as int and set to 0 as a baseline

                for (randomTally = 1; randomTally <= 10; randomTally++)
                {
                    Console.WriteLine($"Random number {randomTally}: ");
                    Console.WriteLine(rnd.Next(0, 101));
                    //max number is not inclusive, if i wanted to choose between 0 and 100, had to set 101 as max
                }
                
              
             
              
            Console.ReadLine();











        }

       


    }
}
