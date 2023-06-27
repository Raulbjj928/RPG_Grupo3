namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Megalodon : Enemy
    {
        public Megalodon()
        {
            Name = "Vorax (Megalodon)";
            EnemyType = "Boss";
            EnemyLevel = 2;
            Health = 110;
            Strength = 20;
            Defense = 5;
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Fúria das Profundezas", DamageType.Impact, 10, 5, false);
            Skill skill2 = new Skill("Mordida Devastadora", DamageType.Bleed, 10, 5, false);
            Skill skill3 = new Skill("Torrente Sanguinária", DamageType.Impact, 10, 5, false);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)1,
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)0,
                    };

            EnemyBaseXP = 30;
        }
    }
}
