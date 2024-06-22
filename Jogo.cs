namespace ProjetoFinalGenius
{
    class Jogo
    {        
        public void PlacarJogo(int contador, int limiteDeRodadas)
        {
            int rodada = contador + 1;
            int rodadasRestantes = rodada - limiteDeRodadas;
            Console.WriteLine($"\nRodada {rodada} | Rodadas restantes {Math.Abs(rodadasRestantes)}");
        }
    

    }
}