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

        private void BTNsairusuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
