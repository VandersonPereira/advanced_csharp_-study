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
    public partial class frmProduto : Form
    {
        private Produto produtoASerAlterado;

        public frmProduto(Produto produto = null)
        {
            produtoASerAlterado = produto;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmProduto_Load(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> viewModels = new List<MarcaViewModel>();

            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                viewModels.Add(viewModel);
            }

            cmbMarcas.DataSource = viewModels;
            cmbMarcas.DisplayMember = "Nome";
            cmbMarcas.ValueMember = "Id";
            cmbMarcas.Refresh();

            if (produtoASerAlterado != null)
            {
                txtNomeProduto.Text = produtoASerAlterado.Nome;
                cmbMarcas.SelectedValue = produtoASerAlterado.MarcaId;
            }
            else
                txtNomeProduto.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();

            if (produtoASerAlterado == null)
            {
                Produto produto = new Produto
                {
                    Nome = txtNomeProduto.Text.Trim(),
                    MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue)
                };

                repositorioProdutos.Inserir(produto);
            }
            else
            {
                produtoASerAlterado.Nome = txtNomeProduto.Text.Trim();
                produtoASerAlterado.MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue);
                repositorioProdutos.Atualizar(produtoASerAlterado);
            }

            Close();
        }
    }
}
