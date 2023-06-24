using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDevs.Utils;



namespace DungeonsAndDevs.Entidades.Personagens
{
	public abstract class Character
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Strength { get; set; }
		public int Defense { get; set; }
		public List<Skill> Skills { get; set; }
		public List<DamageTypes> Advantages { get; set; }
		public List<DamageTypes> Disadvantages { get; set; }


		public int CalculateDamage(int damage, DamageTypes damageType, int targetDefense, int targetHealth)
		{
            return targetHealth;
		}
	}
}
