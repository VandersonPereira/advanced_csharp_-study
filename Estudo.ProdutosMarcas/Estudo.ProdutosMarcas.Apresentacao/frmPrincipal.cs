using Estudo.ProdutosMarcas.Apresentacao.ViewModels;
using Estudo.ProdutosMarcas.Dominio;
using Estudo.ProdutosMarcas.Repositorio.Comum;
using Estudo.ProdutosMarcas.Repositorio.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo.ProdutosMarcas.Apresentacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcasAsync();
            PreencherDataGridViewProdutossAsync();
        }

        private async void PreencherDataGridViewMarcasAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarca.SelecionarTodos();
            List<MarcaViewModel> marcasViewModel = new List<MarcaViewModel>();

            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                marcasViewModel.Add(viewModel);
            }

            grdMarcas.Invoke((MethodInvoker)delegate 
            {
                grdMarcas.DataSource = marcasViewModel;
                grdMarcas.Refresh();
            });
        }

        private async void PreencherDataGridViewProdutossAsync()
        {
            IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();
            List<Produto> produtos = await repositorioProduto.SelecionarTodos();
            List<ProdutoViewModel> produtosViewModel = new List<ProdutoViewModel>();

            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Marca = produto.Marca.Nome,
                    IdMarca = produto.MarcaId,
                    Nome = produto.Nome
                };
                produtosViewModel.Add(viewModel);
            }

            grdProdutos.Invoke((MethodInvoker)delegate
            {
                grdProdutos.DataSource = produtosViewModel;
                grdProdutos.Refresh();
            });
        }

        private void BtnCadastrarMarca_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.ShowDialog();
            PreencherDataGridViewMarcasAsync();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutossAsync();
        }

        private void btnAtualizarMarca_Click(object sender, EventArgs e)
        {
            if (grdMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(grdMarcas.SelectedRows[0].Cells[0].Value);

                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaASerAlterada = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                frmMarca frmMarca = new frmMarca(marcaASerAlterada);
                frmMarca.ShowDialog();
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutossAsync();
            }
            else
                MessageBox.Show("Selecione uma marca antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);

                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoASerAlterada = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                frmProduto frmProduto = new frmProduto(produtoASerAlterada);
                frmProduto.ShowDialog();
                PreencherDataGridViewProdutossAsync();
            }
            else
                MessageBox.Show("Selecione um produto antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count > 0)
            {
                int idMarcaSelecionado = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);

                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaASerAlterada = repositorioMarcas.SelecionarPorId(idMarcaSelecionado);
                repositorioMarcas.Excluir(marcaASerAlterada);
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutossAsync();
            }
            else
                MessageBox.Show("Selecione um produto antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(grdProdutos.SelectedRows[0].Cells[0].Value);

                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoASerAlterada = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                repositorioProdutos.Excluir(produtoASerAlterada);
                PreencherDataGridViewProdutossAsync();
            }
            else
                MessageBox.Show("Selecione um produto antes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
