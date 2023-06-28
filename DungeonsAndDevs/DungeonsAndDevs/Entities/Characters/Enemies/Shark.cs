using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Shark : Enemy
    {
        public Shark() 
        {
            Name = "White Shark";
            EnemyType = "Monster";
            EnemyLevel = 1;
            Health = 105;
            Strength = 15;
            Defense = 8;
            string descSkill1 = "Desencadeia toda a sua ferocidade em um ataque implacável, como se as profundezas do oceano se revoltassem contra seus inimigos";
            string descSkill2 = "Mergulha com velocidade e precisão, atacando seus oponentes com suas afiadas presas, rasgando e dilacerando tudo em seu caminho";
            string descSkill3 = "Desencadeia uma investida poderosa, dilacerando seu alvo com suas barbatanas afiadas";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Fúria Aquática", DamageType.Impact, 5, 0, false, descSkill1);
            Skill skill2 = new Skill("Presas Implacáveis", DamageType.Cut, 5, 0, false, descSkill2);
            Skill skill3 = new Skill("Espiral do Terror", DamageType.Cut, 5, 0, false, descSkill3);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        //NONE
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)0,
                    };
            
            EnemyBaseXP = 1;
        }  
    }
}
