using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters.Enemies;
using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Application.Game.Batles
{
    public class Batle
    {
        public Batle() {}

        public Player Combat(Player player, Enemy enemy)
        {
            Random random = new Random();

            int amountOfSkills = enemy.Skills.Count();
            Skill enemySkill = enemy.Skills[random.Next(0, amountOfSkills - 1)];

            if (enemy.EnemyType == "Monster")
            {
                player.Health = enemy.TakeSkillDamage(enemySkill, player.Defense, player.Health);

                if (enemy.Name == "White Shark")
                {
                    string shark = $"VORAX (Megalodon) envia seus capangas para te atacar...." +
                        $"{enemySkill.Name}: um cardume de Tubarões Brancos desencadeia toda a sua ferocidade em um ataque implacável, " +
                        $"como se as profundezas do oceano se revoltassem contra seus inimigos.";
                    DisplayTextLetterByLetter(shark, 0);
                }

                if (enemy.Name == "Mullet")
                {
                    string mullets = $"NERIDA (Cursed Mermaid) esta irritadisssima com sua presença ela envia seu exercito de Tainhas para confronta-lo..." +
                        $"{enemySkill.Name}: O cardume de Tainhas ataca em um frenesi coordenado," +
                        $" nadando em rápida sucessão e desferindo uma série de golpes rápidos e precisos contra seus adversários.";

                    DisplayTextLetterByLetter(mullets, 0);
                }

                if (enemy.Name == "Jellyfish")
                {
                    string jellyFish = $"KRAKEN (Giant Oktopus) esta incredulo que você chegou tão longe, mas ele tem uma arma poderosa não mãos: seu exercito de aguas-vivas..." +
                        $"{enemySkill.Name}: As Água-vivas disparam uma rede de tentáculos viscosos em direção aos oponentes, causando queimaduras severas.";

                    DisplayTextLetterByLetter(jellyFish, 0);
                }
                string text = $"Maldito bando de {enemy.Name}s é sua hora de revidar:";

                DisplayTextLetterByLetter(text, 0);

                ShowPlayer(player);

                while (enemy.Health <= 0)
                {
                    enemy.Health = player.TakeSkillDamage(ChangeSkill(player), enemy.Defense, enemy.Health);

                    ShowEnemy(enemy);
                }
                return player;
            }
            else
            {                
                player.Health = enemy.TakeSkillDamage(enemySkill, player.Defense, player.Health);

                if (enemy.Name == "Vorax (Megalodon)")
                {
                    string text = $"{enemy.Name} é um gigantesco tubarão pré-histórico que ameaça afundar o barco com " +
                        $"seus poderosos ataques. O combate ira ser tenso e mortal.";

                    DisplayTextLetterByLetter(text, 0);
                }         
                
                if (enemy.Name == "Nerida (Cursed Mermaid)")
                {
                    string text = $"A {enemy.Name}, uma criatura bela e traiçoeira que tenta seduzir e enfeitiçar a tripulação...";

                    DisplayTextLetterByLetter(text, 0);
                }         
                
                if (enemy.Name == "Kraken (Giant Oktopus)")
                {
                    string text = $"O {enemy.Name} furioso emerge das profundezas, com seus tentáculos poderosos ameaçando destruir o barco";

                    DisplayTextLetterByLetter(text, 0);
                }         

                ShowPlayer(player);

                while (enemy.Health <= 0)
                {
                    enemy.Health = player.TakeSkillDamage(ChangeSkill(player), enemy.Defense, enemy.Health);

                    ShowEnemy(enemy);
                }
                return player;
            }
        }


        public Skill ChangeSkill(Player player)
        {
            while (true)
            {
                string txt = $"Escolha a habilidade que deseja usar:\n" +
                            $"   0 - {player.Skills[0].Name}" +
                            $"   1 - {player.Skills[1].Name}\n";

                DisplayTextLetterByLetter(txt, 1);

                int option = int.Parse(Console.ReadLine());

                if (option == 0 || option == 1)
                {
                    if (option == 0) return player.Skills[0];
                    else return player.Skills[1];
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida!");
                }
            }
        }
        public void DisplayTextLetterByLetter(string txt, int vel)
        {
            foreach (char letter in txt)
            {
                Console.Write(letter);
                Thread.Sleep(vel);
            }

            Console.WriteLine();
        }
        public int ChangeCharacter()
        {
            while (true)
            {
                string txt = $"Escolha o herói que deseja para embarcar nessa aventura:\n" +
                            $"   0 - Mergulhador\n" +
                            $"   1 - Artilheiro\n" +
                            $"   2 - Mosqueteiro\n";

                DisplayTextLetterByLetter(txt, 5);

                int option = int.Parse(Console.ReadLine());

                if (option == 0 || option == 1 || option == 2)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida!");
                }
            }
        }
        public string ChangeName()
        {
            string txt = " Digite o nome do seu Herói lendario: ";
            DisplayTextLetterByLetter(txt, 10);
            string name = Console.ReadLine();

            return name;
        }
        public void ShowPlayer(Player player)
        {
            Console.WriteLine($" =+=+=+=+=+=+=+=+ Estatisticas do Sr(a) {player.Name} =+=+=+=+=+=+=+=+\n\n" +
                                $"                  Classe : {player.PlayerClass}\n" +
                                $"                  Vida : {player.Health} \n" +
                                $"                  Defesa : {player.Defense} \n" +
                                $"                  Força : {player.Strength} \n");

            Console.WriteLine("=+=+=+=+=+=+=+=+ Habilidades =+=+=+=+=+=+=+=+\n");

            foreach (var item in player.Skills)
            {
                Console.WriteLine($"*********** {item.Name} *********** \n" +
                                  $"                Tipo : {item.Type}\n" +
                                  $"                Dano em armadura: {item.ArmorPenetration}\n");
            }

            Console.WriteLine("=+=+=+=+=+=+=+=+ Vantagens =+=+=+=+=+=+=+=+");
            foreach (var item in player.Advantages)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("=+=+=+=+=+=+=+=+ Desvantagens =+=+=+=+=+=+=+=+");
            foreach (var item in player.Disadvantages)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+\n");
        }

        public void ShowEnemy(Enemy enemy)
        {

            Console.WriteLine($" =+=+=+=+=+=+=+=+ Estatisticas do {enemy.Name} =+=+=+=+=+=+=+=+\n\n" +
                                $"                  Tipo : {enemy.EnemyType}\n" +
                                $"                  Vida : {enemy.Health} \n" +
                                $"                  Defesa : {enemy.Defense} \n" +
                                $"                  Força : {enemy.Strength} \n" +
                                $"=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+\n");
        }
    }
}
