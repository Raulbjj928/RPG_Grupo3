using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
   

    public class Enemy : Character
    {
        public string EnemyType { get; set; }
        public int EnemyLevel { get; set; }
        public int EnemyBaseXP { get; set; } //Ao final de cada combate (implementar contagem de turno^ = Xp^
        //Adicionar Gold Coins como drop para comprar itens no futuro
       
        private void setInitialStats()
        {
            Jellyfish jellyfish1 = new Jellyfish();
            Megalodon megalodon1 = new Megalodon();
            Mermaid mermaid1 = new Mermaid();
            Mullet mullet1 = new Mullet();
            Oktopus oktopus1 = new Oktopus();
            Shark shark1 = new Shark();

        }
    }
}


	

