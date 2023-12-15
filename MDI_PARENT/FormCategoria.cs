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
    public partial class FormCategoria : Form
    {

        // declarar um vetor para armazenar as categorias
        // //e um contador da posição atual no vetor
        private const int  MaxCategorias = 10;
        private readonly Categorias[] categorias;
        private int num_categorias;
        public FormCategoria()
        {
            //criar o vetor e inicialzar o contador
            categorias = new Categorias[MaxCategorias];
            num_categorias = 0;
            InitializeComponent();
        }

        private void Limpar()
        {
            textBoxCodigo.ResetText();
            textBoxCategoria.ResetText();
            textBoxZona.ResetText();
            textBoxFila.ResetText();
            textBoxPrateleira.ResetText();
            textBoxCodigo.Focus();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            statusMsg.Text = string.Empty;
            Limpar();
            //definir as propriedades do datagridview
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.ColumnCount = 5;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[1].Name = "Categoria";
            grelha.Columns[2].Name = "Zona";
            grelha.Columns[3].Name = "Fila";
            grelha.Columns[4].Name = "Pratelaria";
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //verificar se existem dados válidos a inserir na datagridview

            int x;

            try
            {
                //verificar se o código da categoria é um inteiro e positivo
                if (!int.TryParse(textBoxCodigo.Text, out x))
                {
                    textBoxCodigo.Focus();
                    throw new Exception("Insira um Código válido.");
                }
                else if (Convert.ToInt32(textBoxCodigo.Text) < 0)
                {
                    textBoxCodigo.Focus();
                    throw new Exception("Insira um código com valor positivo.");
                }

                //verificar se a descrição da categoria é válida
                if (textBoxCategoria.Text.Equals("") || textBoxCategoria.Text.Length < 3 || textBoxCategoria.Text.Length > 50)
                {
                    textBoxCategoria.Focus();
                    throw new Exception("Insira a descrição da categoria (3 a 50 caracteres):");
                }

                //verificar se a zona é uma string não vazia
                if (textBoxZona.Text.Equals(""))
                {
                    textBoxZona.Focus();
                    throw new Exception("Insira uma letra para a Zona.");
                }

                //verifcar se fila inteiro e positivo 
                if (!int.TryParse(textBoxFila.Text, out x))
                {
                    
                }


            }
            catch 
            { 
            }
        }
    }
}
