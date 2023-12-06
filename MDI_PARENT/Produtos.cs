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
    public partial class FormsProdutos : Form
    {
        //delarar um vetor para armazenar os produtos
        //e um contador da posição atual no vetor
        private const int MaxProdutos = 100;
        private readonly Produtos[] produtos;
        private int num_produtos;

        public FormsProdutos()
        {
            //criar o vetor e inicialar o contador
            produtos = new Produtos[MaxProdutos];
            num_produtos = 0;

            InitializeComponent();
            //adicionar os itens da combobox
            comboBoxCategoria.Items.Clear();
            comboBoxCategoria.Items.Add("Hardware");
            comboBoxCategoria.Items.Add("Software");
            comboBoxCategoria.SelectedIndex = -1;
        }

        private void FormsProdutos_Load(object sender, EventArgs e)
        {
            //prepara o formulário
            statusMsg.Text = "";
            Limpar();
        }

        //procedimento para limpar o formulário
        private void Limpar()
        {
            textCodigo.ResetText();
            textProduto.ResetText();
            comboBoxCategoria.SelectedIndex = -1;
            textPreco.ResetText();
            textCodigo.Focus();
        }

        //método para adicionar um novo produto

        private void AdicionaProduto(Produtos p)
        {
            if (num_produtos < MaxProdutos)
                produtos[num_produtos] = p;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //limpa os dados do formulário
            Limpar();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //verificar se existem dados validos a inserir na listbox
            int x;
            double y;
            try
            {
                //verificar se o codigo do produto é um inteiro
                if (!int.TryParse(textCodigo.Text, out x))
                {
                    textCodigo.Focus();
                    throw new Exception("Insira um código válido");
                }
                else if (Convert.ToInt32(textCodigo.Text) < 99)
                {
                    textCodigo.Focus();
                    throw new Exception("Insira um código com 3 ou mais dígitos");
                }

                //verificar se a descrição é válida
                if (textProduto.Text.Equals("") || textProduto.Text.Length < 3 || textProduto.Text.Length > 50)
                {
                    textProduto.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 caracteres).");
                }

                //verificar se está selecionada uma categoria
                if (comboBoxCategoria.SelectedIndex == -1)
                {
                    throw new Exception("Escolha a categoria do produto.");
                }

                //verificar se tem um produto válido
                if (!double.TryParse(textPreco.Text, out y))
                {
                    textPreco.Focus();
                    throw new Exception("Insira em preço um valor monetário");
                }
                else if (Convert.ToDouble(textPreco.Text) <= 0)
                {
                    textPreco.Focus();
                    throw new Exception("Insira em preço um valor superior a 0.");
                }
                //fim das verificações
            }
            catch (Exception ex)
            {
                //enviar mensagem de erro de exceção
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //regressar ao ponto de chamada de execução do botão
                return;
            }

            //depois de tudo verificado vamos enviar para a lisbox uma string longa 
            //composta por todos os campos e separados cm "|" que será o separador 
            //usado posteriormente para caso seja necessário a sua separação (parse)

            string linha = textCodigo.Text.ToString() + " | " + textProduto.Text + " | " + comboBoxCategoria.SelectedItem + " | " + textPreco.Text.ToString();
            
            //adicionar a listbox
            listBoxProdutos.Items.Add(linha);

            //enviar mensagem apra o status
        }
    }
}
