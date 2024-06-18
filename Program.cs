namespace ProjetoFinalGenius
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();

            ui.ExibeTitulo();
            ui.ExibeGenius();
            ui.ExibeDificuldades();

            int dificuldadeSelecionada;
            do
            {
                Console.Write("\nDigite a dificuldade escolhida: ");
                dificuldadeSelecionada = Convert.ToInt32(Console.ReadLine());
                
                if (dificuldadeSelecionada < 1 || dificuldadeSelecionada > 4)
                {
                    Console.WriteLine("\nDificuldade inesistente");
                    Console.WriteLine("\nPressione uma tecla para tentar novamente");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (dificuldadeSelecionada < 1 || dificuldadeSelecionada > 4);

            ui.ExibeDificuldadeEscolhida(dificuldadeSelecionada);
        }
    }
}