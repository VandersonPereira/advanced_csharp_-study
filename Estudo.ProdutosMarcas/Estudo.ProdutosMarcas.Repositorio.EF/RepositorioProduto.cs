using Estudo.ProdutosMarcas.Dominio;
using Estudo.ProdutosMarcas.Persistencia.EF.Context;
using Estudo.ProdutosMarcas.Repositorio.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProdutosMarcas.Repositorio.EF
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public void Atualizar(Produto entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marcas.Find(entidade.MarcaId);
                entidade.Marca = marca;
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                contexto.Produtos.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public void Inserir(Produto entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                Marca marca = contexto.Marcas.Find(entidade.MarcaId);
                entidade.Marca = marca;
                contexto.Produtos.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Produto SelecionarPorId(int id)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                return contexto.Produtos.Include("Marca").Single(s => s.Id == id);
            }
        }

        public Task<List<Produto>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
                {
                    return contexto.Produtos.Include("Marca").ToList();
                }
            });
        }
    }
}
