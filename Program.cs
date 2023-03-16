using System;
using System.Globalization;

namespace ICE_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int scripts;
            int questions;
            int lecturer;
            
            //enter number of scripts 
            Console.WriteLine("Enter the number of scripts that have been handed in");
            scripts = Convert.ToInt32(Console.ReadLine());

            //while loop for if users enter value that is not greater 0
            while (scripts < 1)
            {
                Console.WriteLine("Please note that the total number of scripts has to be greater than 0");
                Console.WriteLine("Enter the numbet of scripts handed out");
                scripts = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //enter number of questions in the paper
            Console.WriteLine("Enter the number of questions in the paper");
            questions = Convert.ToInt32(Console.ReadLine());

            //repeat statement if users enter a value less than and equal to 1 and greater and equal to than 10
            while (questions < 1 || questions > 11 )
            {
                Console.WriteLine("Please note that the number of questions is within a range of 1-10 inclusive");
                Console.WriteLine("Enter the numbet of scripts handed out");
                questions = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Console.WriteLine("Enter the subtotal of each question");
            int[] subtotal = new int[questions]; //creating a subtotal array to store the total of each question

            //loop will allow user to add the total of each question based on amount added in array subtotal
            for (int i = 0; i < subtotal.Length ; i++) 
            {
                Console.WriteLine($"Enter total of {i}" ); 
                subtotal[i] = Convert.ToInt32(Console.ReadLine());

                //will loop until user enters a value more than 0
                while(subtotal[i] < 0)
                {
                    Console.WriteLine("Make sure subtotal is not less than 0");
                    Console.WriteLine($"Enter total of {i}");
                    subtotal[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //arraySum is the total of the entire script 
            int arraySum = subtotal.Sum();
            Console.WriteLine($"Total of the script is {arraySum} marks ");
            Console.WriteLine("\n");

            //number of lecturers that have to mark
            Console.WriteLine("Enter the amount of lecturers who have been given marking scripts");
            lecturer = Convert.ToInt32(Console.ReadLine());

            double eachLecturer = scripts/lecturer; //calculation of how many scripts each lecturer gets to mark 
            Console.WriteLine($"The {lecturer} Lecturer/s will receive {eachLecturer} script/s each" );

            Console.WriteLine("\n");
            int markspeed = 2; //sec it takes lecturer to make a tick 
            int markingtime = (arraySum* markspeed)*scripts; //the total number of the paper x the tick speed x the amount of scripts

            int markingmin = markingtime / 60;
            int markinghrs = markingmin / 60;

            if (markingmin > 60) //if the min are greater than 60, add an hour to hours and remove 60min from minute
            {
                markinghrs++;
                markingmin = (markingtime / 60) - 60;
            }
        
                Console.WriteLine($"It will take a lecturuer {markinghrs} hrs {markingmin} min to mark the scripts");
            

            Console.ReadKey();  
        }
    }
}