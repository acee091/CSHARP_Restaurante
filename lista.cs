using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class lista : Form
    {
        public lista()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lista_Load(object sender, EventArgs e)
        {
            string[] pratos = new string[10] { "Prato Feito", "Feijoada", "Strogonoff", "EScondidinho",
                "Ostras","Fettuccine", "Churrasco", "X-Salada", "X-Bacon", "X-Tudo"};

            lstPratos.Items.AddRange(pratos);
        }
    }
}
