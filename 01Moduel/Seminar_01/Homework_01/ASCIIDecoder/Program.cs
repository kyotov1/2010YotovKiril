using System;
/*
 * Name: Yotov Kiril
 * Group: БПИ2010
 * Excersice: Task from slide 30 from seminar_01
 * Program asks for number between 32 and 127. After that trensfers number to 
 * char and prints it's value 
 */


namespace ASCIIDecoder
{
    /// <summary>
    /// Main class Program.
    /// Program contains main task.
    /// </summary>
    class Program
    {
        //Entry point.
        static void Main(string[] args)
        {
            //Variable which collects input
            int num;
            //Loop for repeating program
            do
            {   
                //Loop repeating untill condition is true
                do Console.Write("Enter integer [32,127]: ");
                while (!int.TryParse(Console.ReadLine(), out num)|| num<32 || num>127);
                //Printing in console
                Console.WriteLine($"Character in ASCII is {(char)num}");
                Console.WriteLine("To repeate enter ESCAPE and any other button to continue.");
                //Esacape for exit
            } while (Console.ReadKey(true).Key!=ConsoleKey.Escape);
            Console.ReadLine();
        }//End Mian()
    }//End class
}//End namespace
