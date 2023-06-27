public enum DamageType
{
	Impact, Cut, Puncture, Fire, Bleed, Eletric, Poison, Explosion
}
//DOT = Damage Over Time
public enum DOT
{
	Fire, Bleed, Poison
}

namespace DungeonsAndDevs.Utils
{
	public class Skill
	{
		public string Name { get; private set; }
		public DamageType Type { get; private set; }
		public int BaseDmg { get; private set; }
		public int ArmorPenetration { get; private set; }
		public bool AoE { get; private set; }
		public Skill(string name, DamageType type, int baseDmg, int armorPenetration, bool aoe)
		{
			Name = name;
			Type = type;
			BaseDmg = baseDmg;
			ArmorPenetration = armorPenetration;
			AoE = aoe;
		}
	}
}