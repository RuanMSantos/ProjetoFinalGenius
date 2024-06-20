namespace ProjetoFinalGenius
{
    class Jogo
    {
       public int LimiteDeRodadas(int dificuldadeSelecionada, int limiteDeRodadas)
       {
            
            bool validacaoDificuldadeSelecionada =
            dificuldadeSelecionada == 1
            || dificuldadeSelecionada == 2
            || dificuldadeSelecionada == 3
            || dificuldadeSelecionada == 4;
            
            if (validacaoDificuldadeSelecionada)
            {
                if (dificuldadeSelecionada == 1)
                {
                    limiteDeRodadas = 8;
                }
                
                if (dificuldadeSelecionada == 2)
                {
                    limiteDeRodadas = 14;
                }
                
                if (dificuldadeSelecionada == 3)
                {
                    limiteDeRodadas = 20;
                }
                
                if (dificuldadeSelecionada == 4)
                {
                    limiteDeRodadas = 31;
                }
            }

                return limiteDeRodadas;
       }
       
        public void PlacarJogo()
        {

        }
    }
}