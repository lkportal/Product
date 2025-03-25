namespace Produtos
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Thread tr = new Thread(() => Application.Run(new CadastroProduto()));
            tr.Start();
           
        }
    }
}
