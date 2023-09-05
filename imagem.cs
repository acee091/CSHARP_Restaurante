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
    public partial class imagem : Form
    {
        public imagem()
        {
            InitializeComponent();
        }
        string[] bebidas = new string[5] { "Energético", "Café", "Martini", "Vinho Tinto", "Cerveja" };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            string foto = string.Empty;
            string bebida = cmbBebidas.SelectedItem.ToString();
            for (i = 0; i < bebidas.Length; i++)
            {
                if (bebida == bebidas[i])
                {
                    foto = "C:\\bebidas\\" + bebida + ".jpg";
                    break;
                }
            }
            pictBebida.ImageLocation = foto;
        }

        private void imagem_Load(object sender, EventArgs e)
        {
 
            cmbBebidas.Items.AddRange(bebidas);
        }
    }
}
