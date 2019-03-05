﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }


        // METODO ABSTRATO PARA VERIFICAR LUGARES POSSÍVEIS QUE A PEÇA PODE IR

     

        public void incrementarQteMovimentos()
        {
            qtdMovimentos++;
        }


        public abstract bool[,] movimentosPossiveis();



    }
}
