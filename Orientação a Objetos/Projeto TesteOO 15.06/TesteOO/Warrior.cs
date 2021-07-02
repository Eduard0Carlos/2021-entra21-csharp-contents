using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO
{
    class Warrior : Hero, IWarriorSkills
    {
        public double Fury { get; private set; }

        private bool _isInBerserkForm;
        private int _turnsInBerserkForm;
        private double _strengthGainedWithBerserk;
        private bool _bashInUse;
        private bool _isIronSkinActive;


        public override void LevelUp()
        {
            this.Strength += 10;
            this.Agility += 6;
            this.Intelligence += 2;
            this.Vitality += 10;
            this.HP += 100;
            base.LevelUp();
        }

        public override double Attack(Hero hero)
        {
            double damage = this.Strength * 1.7 + this.Agility * 1.2;

            if (this._isInBerserkForm)
            {
                this._turnsInBerserkForm--;
                if (this._turnsInBerserkForm == 0)
                {
                    this.Strength -= this._strengthGainedWithBerserk;
                    this._isInBerserkForm = false;
                }
            }
            else
            {
                this.Fury += 10;
            }

            if (this._bashInUse)
            {
                damage = damage * 3;
                this._bashInUse = false;
            }

            return hero.BeAttacked(damage, SourceDamage.Physical);
        }

        public override double BeAttacked(double damage, SourceDamage source)
        {
            //Calcular mitigação de dano base de acordo com defesa, resistencia e vitalidade
            double dmgAfterMitigation = base.BeAttacked(damage, source);

            int seedEvasion = new Random().Next(0, 100);
            if (this.Evasion > seedEvasion)
            {
                return 0;
            }

            this.Fury += dmgAfterMitigation * 0.1;

            if (this._isIronSkinActive)
            {
                dmgAfterMitigation = dmgAfterMitigation * 0.1;
                this._isIronSkinActive = false;
            }

            this.HP -= dmgAfterMitigation;
            return dmgAfterMitigation;
        }

        public void Berserk()
        {
            this.Strength += this.Fury;
            this._strengthGainedWithBerserk = this.Fury;
            this.Fury = 0;
            this._isInBerserkForm = true;
            this._turnsInBerserkForm = 5;
        }

        public void Bash()
        {
            if (this.Fury >= 100)
            {
                this.Fury -= 100;
                this._bashInUse = true;
            }

        }

        public void IronSkin()
        {
            if (this.Fury >= 50)
            {
                this.Fury -= 50;
                this._isIronSkinActive = true;
            }
        }
    }
}
