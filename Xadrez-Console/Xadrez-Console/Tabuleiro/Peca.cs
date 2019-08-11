namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tab = tabuleiro;
            this.cor = cor;
            this.quantidadeMovimentos = 0;

        }
        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQteMovimentos()//lembrar
        {
            quantidadeMovimentos++;
        }
    }
}
