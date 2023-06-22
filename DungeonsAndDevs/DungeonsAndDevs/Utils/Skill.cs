public enum DamageTypes
{
	impact,cut,puncture,fire,bleed,eletric,poison,explosion
}

namespace DungeonsAndDevs.Utils
{
	public class Skill
	{
		public string Name { get; private set; }
		public string Type { get; private set; }
		public int BaseDmg { get; private set; }
		public Skill(string name, string type, int baseDmg)
		{
			Name = name;
			Type = type;
			BaseDmg = baseDmg;
		}
	}
}