using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        //CONSTRUTOR

        public PosicaoXadrez (char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;

        }

        // METODO PARA CONVERTER A POSIÇÃO DO XADRES PARA A MATRIZ

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }


        public override string ToString()
        {
            return "" + coluna + linha;
        }


    }
}
