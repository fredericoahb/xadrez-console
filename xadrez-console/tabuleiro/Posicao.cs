namespace tabuleiro
{
    class Posicao
    {
        //esses atributos podem ser acessados e editados por outras classes
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;

        }
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
