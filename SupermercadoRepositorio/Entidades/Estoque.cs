﻿namespace SupermercadoRepositorio.Entidades
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }

    }
}
