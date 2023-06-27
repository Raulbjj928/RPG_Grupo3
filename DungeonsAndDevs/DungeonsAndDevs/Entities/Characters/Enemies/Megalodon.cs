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
            Skills.Add(new Utils.Skill("Fúria das Profundezas", DamageType.Impact, 10, 5, false));
            Skills.Add(new Utils.Skill("Mordida Devastadora", DamageType.Bleed, 10, 5, false));
            Skills.Add(new Utils.Skill("Torrente Sanguinária", DamageType.Impact, 10, 5, false));
            Advantages.Add(DamageType.Cut);
            Disadvantages.Add(DamageType.Impact);
            EnemyBaseXP = 30;
        }
    }
}
