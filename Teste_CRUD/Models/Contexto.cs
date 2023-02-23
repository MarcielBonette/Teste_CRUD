﻿using Microsoft.EntityFrameworkCore;

namespace Teste_CRUD.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

    }
}
