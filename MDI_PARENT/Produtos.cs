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
                produtos[num_produtos++] = p;
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

            //enviar mensagem apra o status e limpar oc campos do formulário
            statusMsg.Text = "Adicionado um novo produto.";
            Limpar();
        }

        public int posicaoLista = -1;

        private void listboxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedIndex != -1)
            {
                //obter a posição na listbox do item a alterar
                posicaoLista = listBoxProdutos.SelectedIndex;

                //pegar no item selecionado na listbox e colocar nos campos
                //fazendo um parse a toda a linha usando o separador "|"
                string[] campos = listBoxProdutos.SelectedItem.ToString().Split('|');

                //colocar em cada um dos campos do formulário
                textCodigo.Text = campos[0];
                textProduto.Text = campos[1];

                switch (campos[2])
                {
                    case "Hardware": comboBoxCategoria.SelectedIndex = 0; break;
                    case "Software": comboBoxCategoria.SelectedIndex = 1; break;
                    default: comboBoxCategoria.SelectedIndex = -1; break;
                }
                textPreco.Text = campos[3];
                textCodigo.Focus();
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            //se existir um elemnto selecionado podemos iniciar a ataualização
            if (posicaoLista != -1)
            {
                //código seguinte é igual ao do botão Novo na verificação dos campos
                int x; double y;
                try
                {
                    if (!int.TryParse(textCodigo.Text, out x))
                    {
                        textCodigo.Focus();
                        throw new Exception("Insira um Código válido.");
                    }
                    else if (Convert.ToInt32(textCodigo.Text) < 99)
                    {
                        textCodigo.Focus();
                        throw new Exception("Insira um código com 3 ou mais dígitos");
                    }

                    if (textProduto.Text.Equals("") || textProduto.Text.Length < 3 || textProduto.Text.Length > 50)
                    {
                        textProduto.Focus();
                        throw new Exception("Insira a descrição do produto (3 a 50 caracteres).");
                    }

                    if (comboBoxCategoria.SelectedIndex == -1)
                    {
                        throw new Exception("Escolha a categoria do produto.");
                    }

                    if (!double.TryParse(textPreco.Text, out y))
                    {
                        textPreco.Focus();
                        throw new Exception("Insira em preço um valor monetário.");
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
                    //enviar mensagem de erro da exceção
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //regressar ao ponto de chamada de execução do botão
                    return;
                }

                //depois de verifcado vamos colocar uma string longa com os campos
                //na posição correta da listbox, de acordo com o obtido em posicaoLista
                string linha = textCodigo.Text.ToString() + " | " + textProduto.Text + " | " + comboBoxCategoria.SelectedItem + " | " + textPreco.Text.ToString();

                //colocar na posição correta da listbox
                listBoxProdutos.Items.RemoveAt(posicaoLista);
                listBoxProdutos.Items.Insert(posicaoLista, linha);
                posicaoLista = -1;

                statusMsg.Text = "Atualizado um produto.";
                Limpar();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //se existir um elemento selecionado podemos eliminar
            if (posicaoLista != -1)
            {
                //remover da listbox
                listBoxProdutos.Items.RemoveAt(posicaoLista);
                statusMsg.Text = "Eliminado um produto";
                Limpar();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //guarda cada item da listbox para o vetor
            foreach (var listBoxItem in listBoxProdutos.Items)
            {
                string[] campos = listBoxItem.ToString().Split('|');

                //converter para o tipo dos atributos da classe produtos
                int cod = Convert.ToInt32(campos[0]);
                string nomeProduto = campos[1];
                
                string categoria = campos[2];
                
                double preco = Convert.ToDouble(campos[3]);

                //adiciona os objetos da classe Produtos no array usando o método
                AdicionaProduto(new Produtos(cod, nomeProduto, categoria, preco));
            }
            //abrir o formulário de listagem
            Form flista = new FormListaProdutos(produtos, num_produtos);
            flista.MdiParent = MdiParent;
            flista.Show();
            flista.Location = new Point(5, 5);
            flista.Dock = DockStyle.Fill;

            //encerra o formulário (fica a faltar guardar num ficheiro de dados)
            this.Close();
        }
    }
}
