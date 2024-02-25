﻿using SupermercadoRepositorio.Entidades;

namespace SupermercadoRepositorio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public Categoria Categoria { get; set; }
    }
}