namespace Produtos {
    partial class CadastroProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            txtQuantidadeProduto = new TextBox();
            AbrirImagem = new OpenFileDialog();
            txtUrlImagemProduto = new TextBox();
            button1 = new Button();
            cbLocalVendaProduto = new ComboBox();
            txtAdicionaCategoriaProduto = new TextBox();
            btnAdicionaProduto = new Button();
            cbSelecionaCategoriaProduto = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            resources.ApplyResources(txtNomeProduto, "txtNomeProduto");
            txtNomeProduto.Name = "txtNomeProduto";
            // 
            // txtValorProduto
            // 
            resources.ApplyResources(txtValorProduto, "txtValorProduto");
            txtValorProduto.Name = "txtValorProduto";
            // 
            // txtQuantidadeProduto
            // 
            resources.ApplyResources(txtQuantidadeProduto, "txtQuantidadeProduto");
            txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            // 
            // AbrirImagem
            // 
            AbrirImagem.FileName = "openFileDialog1";
            resources.ApplyResources(AbrirImagem, "AbrirImagem");
            // 
            // txtUrlImagemProduto
            // 
            resources.ApplyResources(txtUrlImagemProduto, "txtUrlImagemProduto");
            txtUrlImagemProduto.Name = "txtUrlImagemProduto";
            txtUrlImagemProduto.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbLocalVendaProduto
            // 
            resources.ApplyResources(cbLocalVendaProduto, "cbLocalVendaProduto");
            cbLocalVendaProduto.FormattingEnabled = true;
            cbLocalVendaProduto.Items.AddRange(new object[] { resources.GetString("cbLocalVendaProduto.Items"), resources.GetString("cbLocalVendaProduto.Items1"), resources.GetString("cbLocalVendaProduto.Items2") });
            cbLocalVendaProduto.Name = "cbLocalVendaProduto";
            // 
            // txtAdicionaCategoriaProduto
            // 
            resources.ApplyResources(txtAdicionaCategoriaProduto, "txtAdicionaCategoriaProduto");
            txtAdicionaCategoriaProduto.Name = "txtAdicionaCategoriaProduto";
            // 
            // btnAdicionaProduto
            // 
            resources.ApplyResources(btnAdicionaProduto, "btnAdicionaProduto");
            btnAdicionaProduto.Name = "btnAdicionaProduto";
            btnAdicionaProduto.UseVisualStyleBackColor = true;
            // 
            // cbSelecionaCategoriaProduto
            // 
            resources.ApplyResources(cbSelecionaCategoriaProduto, "cbSelecionaCategoriaProduto");
            cbSelecionaCategoriaProduto.FormattingEnabled = true;
            cbSelecionaCategoriaProduto.Name = "cbSelecionaCategoriaProduto";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // CadastroProduto
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(cbSelecionaCategoriaProduto);
            Controls.Add(btnAdicionaProduto);
            Controls.Add(txtAdicionaCategoriaProduto);
            Controls.Add(cbLocalVendaProduto);
            Controls.Add(button1);
            Controls.Add(txtUrlImagemProduto);
            Controls.Add(txtQuantidadeProduto);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroProduto";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private TextBox txtQuantidadeProduto;
        private OpenFileDialog AbrirImagem;
        private TextBox txtUrlImagemProduto;
        private Button button1;
        private ComboBox cbLocalVendaProduto;
        private TextBox txtAdicionaCategoriaProduto;
        private Button btnAdicionaProduto;
        private ComboBox cbSelecionaCategoriaProduto;
        private Button button2;
    }
}