using System;


namespace Task_01
{
    class Program
    {
        /// <summary>
        /// Method calculates value of b and returns it.
        /// </summary>
        /// <param name="b">Output parameter which saves value.</param>
        static void Degree(out double b)
        {
            b= 0;
            b = (1 + Math.Sqrt(5)) / 2;
        }
       
        /// <summary>
        /// Method is calulating Un and returning its value.
        /// </summary>
        /// <param name="n">Input parameter used for calculating Un</param>
        /// <returns></returns>
        static double Un(int n)
        {
            
            Degree(out double b);
            return (Math.Pow(b,n)-(Math.Pow(-b,-n))/(2*b-1));

        }

        static void Main(string[] args)
        {
            //variable inicialize
            int n;
            //Checking input
            do Console.Write("n=");
            while (!int.TryParse(Console.ReadLine(), out n)|| n<=0) ;
            //Priting input
            Console.WriteLine(Math.Round(Un(n)));
            
        }
    }
}
