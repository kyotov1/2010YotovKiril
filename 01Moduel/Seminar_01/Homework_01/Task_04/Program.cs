using System;
/*
 * Name: Yotov Kiril
 * Group: БПИ2010
 * Excersice: Task from slide 31 from seminar_01
 * Program asks for voltage U, resistence R and calculates power of electricity I
 * and used power P.
 */

namespace Task_04
{
    /// <summary>
    /// Main class Program.
    /// Program constains task.
    /// </summary>
    class Program
    {
        //Entry pint.
        static void Main(string[] args)
        {
            //Inicaializzationof variables which colect input value
            double U, R;
            //Check loop for input
            do Console.Write("U=");
            while (!double.TryParse(Console.ReadLine(), out U) || U<0);
            //Check loop for input
            do Console.Write("R=");
            while (!double.TryParse(Console.ReadLine(), out R) || R<0);
            //Printing in console  power of electricity
            Console.WriteLine($"I={U/R:f2}");
            //Printing used electricity
            Console.WriteLine($"P={U*U/R:f2}");

        }//end Mian().
    }//End Class
}
