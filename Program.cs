using DrofsnarTheBirdMan.Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarTheBirdMan
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoringRepository scr = new ScoringRepository();

            scr.SeedObjectives();
            scr.Start();

            Console.ReadLine();



        }
    }
}
