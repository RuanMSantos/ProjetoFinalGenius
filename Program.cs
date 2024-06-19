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
            ui.ExibeCoresSelecionaveis();

            ui.ExibePontoDePartida(0, 0, 0);
        }
    }
}