namespace MDI_PARENT
{
    partial class FormsProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCodigoProduto = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoriaProduto = new System.Windows.Forms.Label();
            this.labelPreçoProduto = new System.Windows.Forms.Label();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodigoProduto
            // 
            this.labelCodigoProduto.AutoSize = true;
            this.labelCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProduto.Location = new System.Drawing.Point(12, 20);
            this.labelCodigoProduto.Name = "labelCodigoProduto";
            this.labelCodigoProduto.Size = new System.Drawing.Size(70, 20);
            this.labelCodigoProduto.TabIndex = 0;
            this.labelCodigoProduto.Text = "Código:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(110, 20);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(110, 50);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(100, 20);
            this.textProduto.TabIndex = 2;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(110, 104);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(100, 20);
            this.textPreco.TabIndex = 3;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProduto.Location = new System.Drawing.Point(12, 48);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(60, 20);
            this.labelNomeProduto.TabIndex = 4;
            this.labelNomeProduto.Text = "Nome:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(110, 77);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // labelCategoriaProduto
            // 
            this.labelCategoriaProduto.AutoSize = true;
            this.labelCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaProduto.Location = new System.Drawing.Point(12, 75);
            this.labelCategoriaProduto.Name = "labelCategoriaProduto";
            this.labelCategoriaProduto.Size = new System.Drawing.Size(92, 20);
            this.labelCategoriaProduto.TabIndex = 6;
            this.labelCategoriaProduto.Text = "Categoria:";
            // 
            // labelPreçoProduto
            // 
            this.labelPreçoProduto.AutoSize = true;
            this.labelPreçoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreçoProduto.Location = new System.Drawing.Point(12, 104);
            this.labelPreçoProduto.Name = "labelPreçoProduto";
            this.labelPreçoProduto.Size = new System.Drawing.Size(60, 20);
            this.labelPreçoProduto.TabIndex = 7;
            this.labelPreçoProduto.Text = "Preço:";
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(281, 29);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(120, 95);
            this.listBoxProdutos.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMsg
            // 
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(118, 17);
            this.statusMsg.Text = "toolStripStatusLabel1";
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 155);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 10;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(93, 155);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 11;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(174, 155);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(255, 155);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(336, 155);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar e Sair";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // FormsProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.labelPreçoProduto);
            this.Controls.Add(this.labelCategoriaProduto);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigoProduto);
            this.Name = "FormsProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormsProdutos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoProduto;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoriaProduto;
        private System.Windows.Forms.Label labelPreçoProduto;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMsg;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}