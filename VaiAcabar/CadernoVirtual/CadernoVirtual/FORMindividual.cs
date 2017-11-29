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
        public string login, matricula;

        public FORMindividual(string login, string matricula)
        {
            InitializeComponent();
            this.login = login;
            this.matricula = matricula;
            tituloApresentacao.Text = ("Bem vindo, "+ login);
            LBLuser.Text = ("Usuário: " + login);
            LBLuser.Text = ("Matricula: " + matricula);

        }

        private void BTNsairusuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNcriarCaderno_Click(object sender, EventArgs e)
        {
            PANELcriarCaderno.Visible = true;
        }

        private void BTNexcluirUsuario_Click(object sender, EventArgs e)
        {
            PANELexcluirAluno.Visible = true;
        }

        private void BTNinicio_Click(object sender, EventArgs e)
        {
            PANELeditarAluno.Visible = false;
            PANELexcluirAluno.Visible = false;
        }

        private void BTNeditarUsuario_Click(object sender, EventArgs e)
        {
            PANELeditarAluno.Visible = true;
        }
    }
}
