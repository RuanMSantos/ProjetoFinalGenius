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

            Jogo jogo = new Jogo();

            int limiteDeRodadas;
            // jogo.LimiteDeRodadas(dificuldadeSelecionada,);
            
            // for (int i = 0; i <= limiteDeRodadas; i++)
            // {}
            ui.ExibePontoDePartida();
        
            Console.WriteLine("\nRodada iniciada!");

        }
    }
}