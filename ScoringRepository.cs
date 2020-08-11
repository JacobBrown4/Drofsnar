using DrofsnarTheBirdMan.Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarTheBirdMan
{
    public class ScoringRepository
    {
        private readonly List<IBird> _birds = new List<IBird>();


        public int _score = 5000;
        public int _lives = 5;
        int _livesgained = 1;
        bool _stopper = false;
        public int _birdHunters = 1;
        public int _birdHunterKilled = 0;

        public void Start()
        {
            while (true)
            {
                string fileText = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\DotNetProjects\Challenges\DrofsnarTheBirdMan\gameSequence.txt");
                string[] inputs = fileText.Split(',');
                foreach (var input in inputs)
                {
                    if (_lives == 0) { Console.WriteLine($"No more lives, Game Over! Final Score: {_score}"); break; }
                    Console.Write($"{input}! That's worth {BirdInteraction(input)} points!");
                    if (_score >= 10000 * _livesgained) { ++_lives; ++_livesgained; continue; }
                    Console.Write($" Lives: {_lives}\n");
                    if (_birdHunterKilled == 4) { Console.WriteLine($"Congratulations! You won! Final Score: {_score}"); break; }
                }            
                break;
            }
        }

        public void SeedObjectives()
        {
            _birds.Add(new Bird());
            _birds.Add(new CrestedIbis());
            _birds.Add(new CrestedIbis());
            _birds.Add(new GreatKiskudee());
            _birds.Add(new RedCrossbill());
            _birds.Add(new RedNeckedPhalarope());
            _birds.Add(new EveningGrosbeak());
            _birds.Add(new GreaterPrairieChicken());
            _birds.Add(new IcelandGull());
            _birds.Add(new OrangeBelliedParrot());
            _birds.Add(new VulBirdHunter());
            _birds.Add(new InvBirdHunter());
        }
        public bool StopperInteraction(string onOrOff)
        {
            if (onOrOff == "on")
            {
                return _stopper == true;
            }
            else
            {
                return _stopper == false;
            }
        }
        public IBird GetBirdByString(string name)
        {
            foreach (IBird bird in _birds)
            {
                if (bird.Name == name)
                { return bird; }
            }
            return null;
        }
        public int BirdInteraction(string name)
        {

            IBird bird = GetBirdByString(name);
            //if (_stopper == true) Could utilizing a stopper multiplier but it's more work than needed

            if (bird.Name == "VulnerableBirdHunter")
            {
                int plusScore = 200 * _birdHunters;
                ++_birdHunters;
                ++_birdHunterKilled;
                _score = _score + plusScore;
                _stopper = true;
                return _score;
            }
            else if (bird.Name == "InvincibleBirdHunter")
            {
                _stopper = false;
                _birdHunters = 1;
                --_lives;
                return _score;
            }
            else
            {
                _score = _score + bird.Points;
                return _score;
            }
        }
    }
}

