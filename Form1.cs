namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista Tela = new lista();
            Tela.Show();
        }

        private void imagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagem Tela = new imagem();
            Tela.Show();
        }
    }
}