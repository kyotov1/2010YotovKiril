using System;
/*
 * Name: Yotov Kiril
 * Group: БПИ2010
 * Excersice: Task from slide 29 from seminar_01
 * Program asks for 3 words and prints them in one line with exclamation mark.
 */

//Inseption namespace.
namespace Task_01
{
    /// <summary>
    /// The main class Program.
    /// Contains solution of task.
    /// </summary>
    class Program
    {
        //Entry point.
        static void Main(string[] args)
        {
            //Inicialize variable which colects words
            string st = "";
            //Reading words from console and adding exclamation mark
            st += Console.ReadLine() + "! ";
            st += Console.ReadLine() + "! ";
            st += Console.ReadLine() + "! ";
            Console.WriteLine(st);
            Console.ReadLine();
        }//End Main().
    }//End Class Program.
}//End namespace Task_01.
