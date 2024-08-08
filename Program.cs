namespace Part1_Task3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geeeting
            Console.WriteLine("Hello there!");

            // Ask the user to enter their mark
            Console.Write("Enter your mark (0-100): ");
            int mark = int.Parse(Console.ReadLine()); // Convert the input to an integer

            // Initialize the grade variable
            char grade;

            // Determine the grade based on the mark
            if (mark >= 70 && mark <= 100) 
            {
                grade = 'A';
            }
            else if (mark >= 60 && mark <= 69) 
            {
                grade = 'B';
            }
            else if (mark >= 50 && mark <= 59) 
            {
                grade = 'C';
            }
            else if (mark >= 40 && mark <= 49) 
            {
                grade = 'D';
            }
            else if (mark >= 30 && mark <= 39) 
            {
                grade = 'E';
            }
            else if (mark < 30 && mark >= 0)
            {
                grade = 'F';
            }
            else // Marks outside the range
            {
                grade = 'X'; 
            }

            // Now let's use a switch statement to print the results
            switch (grade)
            {
                case 'A': // You are awesome!
                case 'B': // Great job!
                case 'C': // Good effort!
                    Console.WriteLine($"Your grade is {grade}. You Have Passed.");
                    break;
                case 'D': // Fair
                case 'E': // Poor!
                    Console.WriteLine($"Your grade is {grade}. You have failed: You must resit the exam."); 
                    break;
                case 'F': // Very poor!
                    Console.WriteLine($"Your grade is {grade}. You have failed: You cannot resit the exam.");
                    break;
                default:
                    Console.WriteLine("Unknown result."); 
                    break;
            }
        }
    }
}
