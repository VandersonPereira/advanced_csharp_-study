﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.ProdutosMarcas.Dominio;

namespace Estudo.ProdutosMarcas.Persistencia.EF.Context
{
    public class EstudoProdutosMarcasDbContext : DbContext
    {
        public EstudoProdutosMarcasDbContext()
            : base("name=MyConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasRequired(p => p.Marca)
                .WithMany(p => p.Produtos)
                .HasForeignKey(fk => fk.MarcaId)
                .WillCascadeOnDelete(false);
        }
    }
}
