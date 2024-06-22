#pragma warning disable CA1416

namespace ProjetoFinalGenius
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coresSelecionaveis = new List<string>(){"r","g", "b", "y"};
            List<string> sequenciaCores = new List<string>();
            List<string> sequenciaDigitada = new List<string>();
            int contadorRodada = 0;

            UI ui = new UI();

            ui.ExibeTitulo();
            ui.ExibeGenius();

            int dificuldadeSelecionada;
            do
            {
                ui.ExibeDificuldades();
                Console.Write("\nDigite a dificuldade escolhida: ");
                dificuldadeSelecionada = Convert.ToInt32(Console.ReadLine());
                
                if (dificuldadeSelecionada < 1 || dificuldadeSelecionada > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDificuldade inexistente");
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (dificuldadeSelecionada < 1 || dificuldadeSelecionada > 4);

            ui.ExibeDificuldadeEscolhida(dificuldadeSelecionada);
            ui.ExibeCoresSelecionaveis();

            Thread.Sleep(500);
            Console.Write("\nEstá pronto(s/n)? ");
            string prontidao1 = Console.ReadLine()!.Trim().ToLower();

            if (prontidao1 != "s")
            {
                return;
            }

            Thread.Sleep(500);
            Console.Write("Tem certeza(s/n)? ");
            string prontidao2 = Console.ReadLine()!.Trim().ToLower();

            
            if (prontidao2 != "s")
            {
                return;
            }
            
            Thread.Sleep(500);
            Console.WriteLine("Ok... Boa sorte");
            Thread.Sleep(500);

            bool validacaoDificuldadeSelecionada =
            dificuldadeSelecionada <= 1
            || dificuldadeSelecionada >= 4;
            
            int limiteDeRodadasParcial = 0;
            if (validacaoDificuldadeSelecionada)
            {
                if (dificuldadeSelecionada == 1)
                {
                    limiteDeRodadasParcial = 8;
                }
                
                if (dificuldadeSelecionada == 2)
                {
                    limiteDeRodadasParcial = 14;
                }
                
                if (dificuldadeSelecionada == 3)
                {
                   limiteDeRodadasParcial = 20;
                }
                
                if (dificuldadeSelecionada == 4)
                {
                    limiteDeRodadasParcial = 31;
                }
            }
            
            int limiteDeRodadas = limiteDeRodadasParcial;

            Jogo jogo = new Jogo();

            ui.ExibePontoDePartida();
                    
            Console.WriteLine("\nRodada iniciada!");

            int contagem = Contador();
            jogo.PlacarJogo(contagem, limiteDeRodadas);

            GerarLetraAleatoria(coresSelecionaveis);

            ExibeCorGerada();

            SequenciaDigitada();

            sequenciaDigitada = SequenciaDigitada();

            if (sequenciaCores == sequenciaDigitada && contadorRodada <= limiteDeRodadas)
            {
                 ui.ExibePontoDePartida();
                jogo.PlacarJogo(contagem, limiteDeRodadas);
                GerarLetraAleatoria(coresSelecionaveis);
                ExibeCorGerada();
                SequenciaDigitada();
            }

            else
            {
                ui.ExibeDerrota();
                return;
            }
            

            void GerarLetraAleatoria(List<string> coresSelecionaveis)
            {
                Random gerador = new Random();
                    
                sequenciaCores.Add(coresSelecionaveis.ElementAt(gerador.Next(0, 4)));
                    
            }

            void ExibeCorGerada()
            {
                foreach (var item in sequenciaCores)
                {
                    Console.Clear();
                    if (item == "r")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("  ");
                        Console.Beep(1000, 500);
                        Console.ResetColor();
                    }
                    
                    if (item == "g")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("  ");
                        Console.Beep(2000, 500);
                        Console.ResetColor();
                    }
                    
                    if (item == "b")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("  ");
                        Console.Beep(3000, 250);
                        Console.ResetColor();
                    }
                    
                    if (item == "r")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("  ");
                        Console.Beep(4000, 250);
                        Console.ResetColor();
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    }
                }

            
            List<string> SequenciaDigitada()
            {
                contadorRodada++;
                sequenciaDigitada.Clear();
                string digito;
                    
                try
                {
                    digito = Console.ReadLine()!.Trim().ToLower();
                }
                catch
                {
                    throw new ArgumentException("Impossível converter em string.");
                    
                
                }
                    
                if (digito != "r" || digito != "g" || digito != "b" || digito != "y")
                {
                    Environment.Exit(0);
                }
                
            
                sequenciaDigitada.Add(digito);
                    
                
            
                return sequenciaDigitada;
            }

            int Contador()
            {
                int contador = 0;
                return contador;
            }
        }
             
    }
}
