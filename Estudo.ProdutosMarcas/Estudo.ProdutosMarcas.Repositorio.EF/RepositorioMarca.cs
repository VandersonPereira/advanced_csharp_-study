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
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {
        public void Atualizar(Marca entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Marca entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                contexto.Marcas.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public void Inserir(Marca entidade)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                contexto.Marcas.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Marca SelecionarPorId(int id)
        {
            using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
            {
                return contexto.Marcas.Find(id);
            }
        }

        public Task<List<Marca>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (EstudoProdutosMarcasDbContext contexto = new EstudoProdutosMarcasDbContext())
                {
                    return contexto.Marcas.ToList();
                }
            });
        }
    }
}
