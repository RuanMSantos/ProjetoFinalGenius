namespace ProjetoFinalGenius
{
    class Program
    {
        static void Main(string[] args)
        {
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
            // ui.ExibeCoresSelecionaveis();

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

                Cores corGerada = new Cores();

                for (int i = 0; i < limiteDeRodadas; i++)
                {
                    ui.ExibePontoDePartida();
                    
                    Console.WriteLine("\nRodada iniciada!");

                    jogo.PlacarJogo(i, limiteDeRodadas);

                    int[] numeroGerado = new int[limiteDeRodadas];
                    Random gerador = new Random();
                    string[] letraDaCor = {"r", "g", "b", "y"};
                    List<string> sequenciaCores = new List<string>();

                    for (int i1 = 0; i1 < limiteDeRodadas; i1++)
                    {
                        numeroGerado[i1] = gerador.Next(1, 5);
                    
                        if (numeroGerado[i1] == 1)
                        {
                            corGerada.Vermelho();
                        }
                        if (numeroGerado[i1] == 2)
                        {
                            corGerada.Verde();
                        }
                        if (numeroGerado[i1] == 3)
                        {
                            corGerada.Azul();
                        }
                        if (numeroGerado[i1] == 4)
                        {
                            corGerada.Amarelo();
                        }

                        // for (int i2 = 0; )
                        // {
                        //     sequenciaCores.Add(corGerada.Nome);
                        // }
                    }





                }
            

            
        }
    }
}