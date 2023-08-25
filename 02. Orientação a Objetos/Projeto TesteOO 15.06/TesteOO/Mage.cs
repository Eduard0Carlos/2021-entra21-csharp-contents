using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Mage : Hero, IMageSkills
    {

        private bool isFireballActive;
        private double manaShieldValue;
        private bool isManaTapActive;

        public double Mana { get; set; }

        public Mage()
        {
            this.Mana = 100;
        }

        public override double Attack(Hero hero)
        {
            double damage = this.Intelligence * 2;

            if (isFireballActive)
            {
                damage = damage * 3;
                isFireballActive = false;
            }

            if (isManaTapActive)
            {
                this.Mana += 60;
            }

            return hero.BeAttacked(damage, SourceDamage.Magical);
        }

        public override double BeAttacked(double damage, SourceDamage source)
        {
            double dano = base.BeAttacked(damage, source);

            if (this.manaShieldValue != 0)
            {
                this.manaShieldValue -= dano;
                if (this.manaShieldValue < 0)
                {
                    this.HP += this.manaShieldValue;
                    this.manaShieldValue = 0;
                }
            }
            else
            {
                this.HP -= dano;
            }
            return dano;
        }

        public override void LevelUp()
        {
            this.Strength += 2;
            this.Agility += 3;
            this.Intelligence += 15;
            this.Vitality += 5;
            this.HP += 60;
            base.LevelUp();
        }

        public void Fireball()
        {
            if (this.Mana >= 40)
            {
                this.isFireballActive = true;
                this.Mana -= 40;
            }
        }

        public void ManaShield()
        {
            this.manaShieldValue = this.Mana * 4;
            this.Mana = 0;
        }

        public void ManaTap()
        {
            this.isManaTapActive = true;
            this.HP = this.HP * 0.7;
        }
    }
}
