using System;
/*Name: Yotov Kiril
 * Group: БПИ2010
 * Excersice: Task from slide 31 from seminar_01
 * Program asks for legs in right triangle and calculates hypotenuse.
 */
namespace Task_05
{
    /// <summary>
    /// Main class Program.
    /// Contains main task.
    /// </summary>
    class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            //Triangle sides.
            double  a, b, c;
            //Check loop for input
            do Console.Write("Enter first leg a= ");
            while (!double.TryParse(Console.ReadLine(), out a) || a < 0);
            //Loop checking input
            do Console.Write("Enter second leg b= ");
            while (!double.TryParse(Console.ReadLine(), out b) || b< 0);
            //Calculating hypotenuse
            c = a * b / 2;
            //Printing answer
            Console.WriteLine("c={0:f2}",c);
            Console.ReadLine();


        }//End Main()
    }//End class Program
}
