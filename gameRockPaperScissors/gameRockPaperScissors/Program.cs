using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Steps:
//Accept user input in various ways
//Generate a random choice
//Compare the choices
//Declare a winner
//Optimize afterwards

namespace gameRockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputPC;
            int randomInt;
            bool playAgain = true;

            Console.WriteLine("===== BEM-VINDO(A) AO JOGO PEDRA | PAPEL | TESOURA =====");
            Console.WriteLine("\n");

            while (playAgain == true)
            {

                int scorePC = 0;
                int scorePlayer = 0;

                while (scorePC < 3 && scorePlayer < 3)
                {
                    Console.Write("Escolha entre PEDRA, PAPEL e TESOURA: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:
                            inputPC = "PEDRA";
                            Console.WriteLine("O Computador escolheu PEDRA!\n");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("DEU EMPATE! Vamos tentar de novo?\n\n");
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Papel envolve a Pedra!\nVocê VENCEU! A batalha, mas não a guerra...\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Pedra quebra Tesoura!\nVocê PERDEU! Só lamento...\n\n");
                                scorePC++;
                            }
                            else
                            {
                                Console.WriteLine("OPÇÃO INVÁLIDA!");
                            }
                            break;
                        case 2:
                            inputPC = "PAPEL";
                            Console.WriteLine("O Computador escolheu PAPEL!\n");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Papel envolve a Pedra!\nVocê PERDEU! Só lamento...\n\n");
                                scorePC++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("DEU EMPATE! Vamos tentar de novo?\n\n");
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Tesoura corta o Papel!\nVocê VENCEU! A batalha, mas não a guerra...\n\n");
                                scorePlayer++;
                            }
                            else
                            {
                                Console.WriteLine("OPÇÃO INVÁLIDA!");
                            }
                            break;
                        case 3:
                            inputPC = "TESOURA";
                            Console.WriteLine("O Computador escolheu TESOURA!\n");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Pedra quebra a Tesoura!\nVocê VENCEU! A batalha, mas não a guerra...\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Tesoura corta o Papel!\nVocê PERDEU! Só lamento...\n\n");
                                scorePC++;
                            }
                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("DEU EMPATE! Vamos tentar de novo?\n\n");
                            }
                            else
                            {
                                Console.WriteLine("OPÇÃO INVÁLIDA!");
                            }
                            break;
                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA!");
                            break;
                    }

                    Console.WriteLine("PONTUAÇÃO PARCIAL:\n\tPC:\t{0}\tJOGADOR(A):\t{1}\n",scorePC, scorePlayer);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("========== PONTUAÇÃO FINAL ==========");
                    Console.WriteLine($"PC: {scorePC} pontos.");
                    Console.WriteLine($"JOGADOR: {scorePlayer} pontos.");
                    Console.WriteLine("==== UAU! Parabéns! VOCÊ venceu! ====");
                }
                else if (scorePC == 3)
                {
                    Console.WriteLine("============ PONTUAÇÃO FINAL =============");
                    Console.WriteLine($"PC:\t{scorePC} pontos.");
                    Console.WriteLine($"JOGADOR:\t{scorePlayer} pontos.");
                    Console.WriteLine("== UUUUH, não foi dessa vez! PC venceu! ==");
                }

                Console.Write("\nGostaria de jogar novamente [s/n]? ");
                string loop = Console.ReadLine();
                loop = loop.ToUpper();
                if (loop == "S")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    playAgain = false;
                    Console.WriteLine("\n\tObrigada pela jogatina!");
                }
                else
                {

                }
            }
            

            Console.ReadLine();

        }
    }
}
