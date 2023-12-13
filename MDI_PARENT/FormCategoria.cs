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
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
