using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];

        }

        // METODO PARA ACESSAR 

        public  Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
