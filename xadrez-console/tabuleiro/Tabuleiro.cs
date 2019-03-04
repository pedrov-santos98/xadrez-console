using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

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

        // SOBRECARGA DO METODO

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        // METODO PARA COLOCAR PECA

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // METODO PARA TESTAR SE JÁ EXISTE UMA PEÇA EM UMA POSIÇÃO

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        // METODO PARA RETIRAR PEÇA

        public Peca retirarPeca(Posicao pos)
        {
            // Verificar se existe peça para retirar
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        // METODO PARA TESTAR SE UMA POSIÇÃO É VALIDA DENTRO DA MATRIZ (0,0),(7,7)

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida");
            }
        }
    }
}
