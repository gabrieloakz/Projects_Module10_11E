using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_PARENT
{
    public partial class FormListaProdutos : Form
    {
        private Produtos[] produtos;
        private int num_produtos;

        public FormListaProdutos(Produtos[] produtos, int num_produtos)
        {
            this.produtos = produtos;
            this.num_produtos = num_produtos;
            InitializeComponent();
        }

        private void FormListaProdutos_Load(object sender, EventArgs e)
        {
            //definir as propriedades do datagridview
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.ColumnCount = 4;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[1].Name = "Designação";
            grelha.Columns[2].Name = "Categoria";
            grelha.Columns[3].Name = "Preço";

            //preencher o datagridview com os dados do array
            grelha.Rows.Clear();
            for (int i = 0; i < num_produtos; i++)
            {
                grelha.Rows.Add(
                    this.produtos[i].getCodigo().ToString(), 
                    this.produtos[i].getNomeProduto(),

                    this.produtos[i].getCategoria(),
                    this.produtos[i].getPreco().ToString());
            }

        }

        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
