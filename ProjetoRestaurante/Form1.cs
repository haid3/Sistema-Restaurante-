using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (boxlogin.Text == "" || boxsenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");

            }


            else if (boxsenha.Text == "1" && boxlogin.Text == "1")
            {

                

                TelaInicial login = new TelaInicial();
                login.ShowDialog();

              



            }












            else
            {
                MessageBox.Show("Senha inválida");
            }
        }

        private void boxlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
