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
    public partial class frmMarca : Form
    {
        private Marca marcaASerAlterada;

        public frmMarca(Marca marca = null)
        {
            marcaASerAlterada = marca;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();

            if (marcaASerAlterada == null)
            {
                Marca novaMarca = new Marca
                {
                    Nome = txtNomeMarca.Text.Trim()
                };
                
                repositorioMarcas.Inserir(novaMarca);
            }
            else
            {
                marcaASerAlterada.Nome = txtNomeMarca.Text.Trim();
                repositorioMarcas.Atualizar(marcaASerAlterada);
            }
           
            Close();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            if (marcaASerAlterada != null)
                txtNomeMarca.Text = marcaASerAlterada.Nome;
            else
                txtNomeMarca.Text = string.Empty;
        }
    }
}
