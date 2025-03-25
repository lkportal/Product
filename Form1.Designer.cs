namespace Produtos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Informaçoes = new TabPage();
            btnCadastrar = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Informaçoes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 651);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 618);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Informaçoes
            // 
            Informaçoes.Location = new Point(4, 29);
            Informaçoes.Name = "Informaçoes";
            Informaçoes.Padding = new Padding(3);
            Informaçoes.Size = new Size(792, 417);
            Informaçoes.TabIndex = 1;
            Informaçoes.Text = "tabPage2";
            Informaçoes.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(64, 0, 64);
            btnCadastrar.Font = new Font("Arcane Nine", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(359, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(87, 33);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastra";
            btnCadastrar.TextAlign = ContentAlignment.MiddleCenter;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 651);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Informaçoes;
        private Label btnCadastrar;
    }
}
