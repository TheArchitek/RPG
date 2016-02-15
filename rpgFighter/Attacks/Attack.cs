using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Attacks
{
    class Attack
    {
        private string Name { get; set; }
        private int Damage { get; set; }
        private double SuccessRate { get; set; }
        private int MinDamage { get; set; }
        private int MaxDamage { get; set; }

        public Attack(string name, int damage, double successRate, int minDamage, int maxDamage)
        {
            Name = name;
            Damage = damage;
            SuccessRate = successRate;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public override string ToString()
        {
            return "You just got hit boi!";
        }

    }
}
