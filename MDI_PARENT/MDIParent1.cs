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
    public partial class LojaXPTO : Form
    {
        private int childFormNumber = 0;

        public LojaXPTO()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new FormsProdutos();
            childForm.MdiParent = this;
            childForm.Text = "Produtos" ;
            childForm.Show();
        }

        private void ShowListarForm(object sender, EventArgs e)
        {
            Form childForm = new FormListaProdutos();
            childForm.MdiParent = this;
            childForm.Text = "Lista de Produtos";
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void LojaXPTO_Load(object sender, EventArgs e)
        {

        }
    }

    public class Produtos
    {
        private int codigo; //de 0 a 3 digitos
        private string nomeProduto; //limitar a 30 carcateres
        private int categoria; //1 - Hardware | 2 - Software
        private double preco; //formato 0000;

        //construtor
        public Produtos(int codigo, string nomeProduto, int categoria, double preco)
        {
            this.codigo = codigo;
            this.nomeProduto = nomeProduto;
            this.categoria = categoria;
            this.preco = preco;
        }

        //seletores
        public int getCodigo()
        {
            return codigo;
        }

        public string getNomeProduto()
        {
            return nomeProduto;
        }

        public int getCategoria()
        {
            return categoria;
        }

        public double getPreco()
        {
            return preco;
        }

        //modificadores

       public void setCodigo(int codigo) 
       {  
            this.codigo = codigo;
       }

        public void setNomeProduto(string nomeProduto)
        {
            this.nomeProduto = nomeProduto;
        }

        public void setCategoria(int categoria)
        {
            this.categoria = categoria;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }
    }
}
