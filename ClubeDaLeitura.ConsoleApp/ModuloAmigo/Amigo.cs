﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Reserva;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class Amigo : EntidadeBase
    {
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public ArrayList Multas {  get; set; } = new ArrayList();

        public Amigo(string nome, string responsavel, string telefone, string endereco)
        {
            Nome = nome;
            Responsavel = responsavel;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Amigo registroNovo = (Amigo)novoRegistro;

            this.Nome = registroNovo.Nome;
            this.Responsavel = registroNovo.Responsavel;
            this.Telefone = registroNovo.Telefone;
            this.Endereco = registroNovo.Endereco;
        }

        internal void ReceberMulta(Multa.Multa novaMulta)
        {
            Multas.Add(novaMulta);
        }
    }
}