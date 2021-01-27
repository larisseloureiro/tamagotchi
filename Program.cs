using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {

                 Tamagotchi TamagotchiLarisse;
                 TamagotchiLarisse = new Tamagotchi();
                 string nome;
                 string cor;

                 TamagotchiLarisse.AumentarLevel();
                 TamagotchiLarisse.AumentarIdade();
                 TamagotchiLarisse.AumentarFome();
                 TamagotchiLarisse.AumentarVida();
                 TamagotchiLarisse.DiminuirVida();
                 TamagotchiLarisse.AumentarSede();
                 TamagotchiLarisse.AumentarTedio();

                 Console.WriteLine("Você prefere a cor rosa ou azul?");
                 cor = Console.ReadLine();
                 if (cor == "rosa")
                 {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    Console.ReadLine();
                    }
                 else if (cor == "azul")
                 {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.ReadLine();
                 }
                 else 
                 {
                    Console.ResetColor();
                 }

                

                 Console.WriteLine("NOME PARA SEU NOVO TAMAGOTCHI: ");
                 nome = Console.ReadLine();

                 Console.WriteLine("Nome: " + nome);
                 Console.WriteLine("Level: " + TamagotchiLarisse.Level);
                 Console.WriteLine("Idade: " + TamagotchiLarisse.Idade + "%");
                 Console.WriteLine("Fome: " + TamagotchiLarisse.Fome + "%");
                 Console.WriteLine("Sede: " + TamagotchiLarisse.Sede + "%");
                 Console.WriteLine("Tédio: " + TamagotchiLarisse.Tedio + "%");


                 Console.WriteLine(" _______    _______");
                 Console.WriteLine(" |      |   |      |");
                 Console.WriteLine(" |      |   |      |");
                 Console.WriteLine(" |______|___|______| ");
                 Console.WriteLine("        |   |        ");
                 Console.WriteLine("     ___|   |___      ");
                 Console.WriteLine("     |          |     ");
                 Console.WriteLine("     |          |     ");
                 Console.WriteLine("     |   ____   |     ");
                 Console.WriteLine("     |  |    |  |  ");
                 Console.WriteLine("     |__|    |__|  ");


        }


        class Tamagotchi
        {
            public int _level;
            public int _idade;
            public int _fome;
            public int _statusVida;
            public int _sede;
            public int _tedio;


            public int Level
            {
                get { return _level; }
            }
            public int Idade
            {
                get { return _idade; }
            }
            public int Fome
            {
                get { return _fome; }
            }
            public int Vida
            {
                get { return _statusVida; }
            }
            public int Sede
            {
                get { return _sede; }
            }
            public int Tedio
            {
                get { return _tedio; }
            }


            public Tamagotchi()
            {
                _level = 1;
                _idade = 1;
                _fome = 0;
                _statusVida = 100;
                _sede = 0;
                _tedio = 20;
            }
            public void AumentarLevel()
            {
                _level += 1;
            }
            public void AumentarIdade()
            {
                _idade += 1;
            }
            public void AumentarFome()
            {
                _fome += 20;
            }
            public void AumentarVida()
            {
                _statusVida += 10;
            }
            public void DiminuirVida()
            {
                _statusVida -= 20;
            }
            public void AumentarSede()
            {
                _sede += 20;
            }
            public void DiminuirrSede()
            {
                _sede -= 20;
            }
            public void AumentarTedio()
            {
                _tedio += 20;
            }
            public void DiminuirTedio()
            {
                _tedio -= 20;
            }

        }
    }
}
    
