using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadernoVirtual
{
    public partial class FORMindividual : Form
    {
        public string login;

        public FORMindividual(string login)
        {
            InitializeComponent();
            this.login = login;
            tituloApresentacao.Text = ("Bem vindo, "+ login);
        }

        public void BTNdesconectar_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNcriarCaderno_Click(object sender, EventArgs e)
        {
            FORMcriarCaderno formcriarCaderno = new FORMcriarCaderno();
            formcriarCaderno.Show();
        }

        private void lblTurma_Click(object sender, EventArgs e)
        {

        }

        
    }
}
