using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarTheBirdMan.Birds
{
    public class Bird : IBird
    {
        public Bird()
        {
        }
        public string Name { get; } = "Bird";
        public int Points { get; } = 10;

    }
    public class CrestedIbis : IBird
    {
        public CrestedIbis()
        {
        }
        public string Name { get; } = "CrestedIbis";
        public int Points { get; } = 100;

    }
    public class GreatKiskudee : IBird
    {
        public GreatKiskudee()
        {
        }
        public string Name { get; } = "GreatKiskudee";
        public int Points { get; } = 300;

    }
    public class RedCrossbill : IBird
    {
        public RedCrossbill()
        {
        }
        public string Name { get; } = "RedCrossbill";
        public int Points { get; } = 500;

    }
    public class RedNeckedPhalarope : IBird
    {
        public RedNeckedPhalarope()
        {
        }
        public string Name { get; } = "Red-neckedPhalarope";
        public int Points { get; } = 700;

    }
    public class EveningGrosbeak : IBird
    {
        public EveningGrosbeak()
        {
        }
        public string Name { get; } = "EveningGrosbeak";
        public int Points { get; } = 1000;

    }
    public class GreaterPrairieChicken : IBird
    {
        public GreaterPrairieChicken()
        {
        }
        public string Name { get; } = "GreaterPrairieChicken";
        public int Points { get; } = 2000;

    }
    public class IcelandGull : IBird
    {
        public IcelandGull()
        {
        }
        public string Name { get; } = "IcelandGull";
        public int Points { get; } = 3000;

    }
    public class OrangeBelliedParrot : IBird
    {
        public OrangeBelliedParrot()
        {
        }
        public string Name { get; } = "Orange-belliedParrot";
        public int Points { get; } = 300;

    }
    public class VulBirdHunter : IBird
    {
        public VulBirdHunter()
        {

        }

        public string Name { get; } = "VulnerableBirdHunter";
        public int Points { get; } = 1;

    }
    public class InvBirdHunter : IBird
    {
        public InvBirdHunter()
        {
        }
        public string Name { get; } = "InvincibleBirdHunter";
        public int Points { get; } = 0;

    }
}