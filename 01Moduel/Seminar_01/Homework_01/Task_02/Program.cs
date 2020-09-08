using System;

//Inseption namespace
namespace Task_02
{   
    /// <summary>
    /// Main class Program.
    /// Constains task solution
    /// </summary>
    class Program
    {
        //Entry point.
        static void Main(string[] args)
        {
            //Changing encoding to UTF8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Inicialize variable which colects input value.
            string st = "";
            //Loop for console input.
            for (int i = 0; i < 3; i++)
                //Saving input to st with minuses
                st += "-" + Console.ReadLine() + "-"+Environment.NewLine;
            //Printing output. 
            Console.WriteLine(st);
        }//End Main()
    }//End Class
}//End namespace
