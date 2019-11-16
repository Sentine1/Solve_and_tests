using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_and_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var a=double.Parse( Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var solution=QuadraticEquationsSolver.Solve(a, b, c);
            if(solution.Length>1)
            Console.WriteLine(solution[0]);
            if (solution.Length > 2)
                Console.WriteLine(solution[1]);
            else Console.WriteLine("None");

            Console.ReadKey();

        }
    }
}
