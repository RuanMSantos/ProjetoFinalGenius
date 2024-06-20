namespace ProjetoFinalGenius
{
    class Cores
    {
        public string Nome { get; set; } = default!;

        public void Vermelho()
        {
            this.Nome = "r";
        }
    
        public void Verde()
        {
            this.Nome = "g";
        }

        public void Azul()
        {
            this.Nome = "b";
        }

        public void Amarelo()
        {
            this.Nome = "y";
        }
    }
}