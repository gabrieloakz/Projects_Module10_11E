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
            InitializeComponent();
        }

        private void FormsProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
