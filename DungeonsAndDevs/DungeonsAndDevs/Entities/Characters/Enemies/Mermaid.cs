namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Mermaid : Enemy
    {
        public Mermaid()
        {
            Name = "Nerida (Cursed Mermaid)";
            EnemyType = "Boss";
            EnemyLevel = 2;
            Health = 110;
            Strength = 5;
            Defense = 20;
            //Skills.Add(new Utils.Skill("Canto Hipnótico", DamageType.???, 10, 5, true)); Modifica atributo
            Skills.Add(new Utils.Skill("Lança das Marés", DamageType.Puncture, 10, 5, true));
            //Skills.Add(new Utils.Skill("Aurora Celeste", DamageType.???, 10, 5, true)); Modifica atributo
            Skills.Add(new Utils.Skill("Cuspe ácido", DamageType.Poison, 10, 5, true));
            Advantages.Add(DamageType.Bleed);
            Disadvantages.Add(DamageType.Explosion);
            EnemyBaseXP = 45;
        }
    }
}
