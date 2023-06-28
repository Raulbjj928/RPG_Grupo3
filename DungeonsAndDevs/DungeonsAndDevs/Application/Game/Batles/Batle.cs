using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters.Enemies;
using DungeonsAndDevs.Utils;
using System;
using System.Linq;
using System.Threading;

namespace DungeonsAndDevs.Application.Game.Batles
{
    public class Batle
    {
        public Batle() {}

        public Player Combat(Player player, Enemy enemy)
        {
            Skill enemySkill = new Skill();

            if (enemy.EnemyType == "Monster")
            {
                if (enemy.Name == "White Shark")
                {
                    enemySkill = ReturnRandomSkill(enemy);
                    string shark = $"VORAX (Megalodon) envia seus capangas para te atacar: um cardume de {enemy.Name}...." +
                        $"{enemySkill.Name}:{enemySkill.Description}" ;
                    DisplayTextLetterByLetter(shark, 0);
                }

                if (enemy.Name == "Mullet")
                {
                    string mullets = $"NERIDA (Cursed Mermaid) esta irritadisssima com sua presença ela envia seu exercito de Tainhas para confronta-lo...";

                    DisplayTextLetterByLetter(mullets, 0);
                }

                if (enemy.Name == "Jellyfish")
                {
                    string jellyFish = $"KRAKEN (Giant Oktopus) esta incredulo que você chegou tão longe, mas ele tem uma arma poderosa não mãos: seu exercito de aguas-vivas..."; ;
                    
                    DisplayTextLetterByLetter(jellyFish, 0);
                }
                string text = $"Maldito bando de {enemy.Name}s é sua hora de revidar:\n";

                DisplayTextLetterByLetter(text, 0);

                ShowPlayer(player);

                while (enemy.Health > 0)
                {
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    enemySkill = ReturnRandomSkill(enemy);
                    Console.WriteLine($"\n*** *** *** ATAQUE INIMIGO *** *** ***\n" +
                                      $"\n           {enemySkill.Name} " +
                                      $"\n{enemySkill.Description}");
                    Console.WriteLine("*** *** *** *** *** *** *** *** *** *** *** ***\n");

                    player.Health = enemy.TakeSkillDamage(enemySkill, player.Defense, player.Health);
                    ShowPlayer(player);

                    Console.WriteLine($"\n### ### ###  SEU ATAQUE ### ### ###\n");
                    enemy.Health = player.TakeSkillDamage(ChangeSkill(player), enemy.Defense, enemy.Health);
                    Console.WriteLine();

                    ShowEnemy(enemy);
                }

                player.XP += enemy.EnemyBaseXP;

                return player;
            }
            else
            {                
                if (enemy.Name == "Vorax (Megalodon)")
                {
                    string text = $"{enemy.Name} é um gigantesco tubarão pré-histórico que ameaça afundar o barco com " ;

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

                while (enemy.Health > 0)
                {
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    enemySkill = ReturnRandomSkill(enemy);
                    Console.WriteLine($"\n*** *** *** ATAQUE INIMIGO *** *** ***\n" +
                                      $"\n           {enemySkill.Name} " +
                                      $"\n{enemySkill.Description}");
                    Console.WriteLine("*** *** *** *** *** *** *** *** *** *** *** ***\n");

                    player.Health = enemy.TakeSkillDamage(enemySkill, player.Defense, player.Health);
                    ShowPlayer(player);

                    Console.WriteLine($"\n### ### ###  SEU ATAQUE ### ### ###\n");
                    enemy.Health = player.TakeSkillDamage(ChangeSkill(player), enemy.Defense, enemy.Health);
                    Console.WriteLine();

                    ShowEnemy(enemy);
                }

                player.XP += enemy.EnemyBaseXP;

                return player;
            }
        }

        private Skill ReturnRandomSkill(Enemy enemy)
        {
            Random random = new Random();

            return enemy.Skills[(int)random.Next(0, enemy.Skills.Count())];

        }

        public Skill ChangeSkill(Player player)
        {
            bool flag = true;
            Skill skill = new Skill() { } ;

            while (flag)
            {
                string txt = $"Escolha a habilidade que deseja usar:\n" +
                             $"   0 - {player.Skills[0].Name}" +
                             $"   1 - {player.Skills[1].Name}\n";

                DisplayTextLetterByLetter(txt, 1);

                int option = int.Parse(Console.ReadLine());

                if (option == 0 || option == 1)
                {
                    flag = false;

                    if (option == 0) 
                    { 
                        skill = player.Skills[0];
                        Console.WriteLine($"\n Você atacou com : \n {skill.Name} - {skill.Description}");
                    }
                    else 
                    { 
                        skill = player.Skills[1];
                        Console.WriteLine($"\n Você atacou com : \n {skill.Name} - {skill.Description}");
                    }
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida!");
                }
            }
            return skill;
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
                string txt = $"Escolha o herói que v=ocê deseja ser para embarcar nessa aventura:\n" +
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
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console .ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"+=+=+=+=+=+=+=+=+ Estatisticas do Sr(a) {player.Name} +=+=+=+=+=+=+=+=+\n\n" +
                              $"                  Classe      : {player.PlayerClass}\n" +
                              $"                  Vida        : {player.Health}     \n" +
                              $"                  Defesa      : {player.Defense}    \n" +
                              $"                  Força       : {player.Strength}   \n");

            Console.WriteLine($"                  Vantagens                          ");
            foreach (var item in player.Advantages)
            {
            Console.WriteLine("                            +++ " + item.ToString());
            }

            Console.WriteLine($"                  Desvantagens             ");
            foreach (var item in player.Disadvantages)
            {
            Console.WriteLine("                            --- " + item.ToString());
            }
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+\n");
            Console.ResetColor();
        }

        public void ShowEnemy(Enemy enemy)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"*#*#*#*#*#*#*#*#* Estatisticas do {enemy.Name}  *#*#*#*#*#*#*#*#*\n\n" +
                              $"                  Tipo        : {enemy.EnemyType}\n" +
                              $"                  Vida        : {enemy.Health}   \n" +
                              $"                  Defesa      : {enemy.Defense}  \n" +
                              $"                  Força       : {enemy.Strength} \n");
            Console.WriteLine("*#*#*#*#*#*#*#*#*#**#*#*#*#*#*#*#*#*#**#*#*#*#*#*#*#*#*#*#*#*#*\n");
            Console.ResetColor();
        }
    }
}
