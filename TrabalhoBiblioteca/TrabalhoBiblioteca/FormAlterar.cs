using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoBiblioteca
{
    public partial class FormAlterar : Form
    {
        public FormAlterar()
        {
            InitializeComponent();
        }

        public MySqlCommand Conectar()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=biblioteca;Uid=root;Pwd=")
            };
            return cmd;
        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            if (txtidalterar.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT * FROM livro WHERE Id = @Id;";
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtidalterar.Text));

                cmd.Connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    txttituloalterar.Text = r.GetString(1);
                    txtautoralterar.Text = r.GetString(2);
                    txteditoraalterar.Text = r.GetString(3);
                }
                else
                {
                    MessageBox.Show("Digite um ID válido!");
                    txtidalterar.Clear();
                }

                cmd.Connection.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtidalterar.Text != string.Empty && txttituloalterar.Text != string.Empty && txtautoralterar.Text != string.Empty && txteditoraalterar.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "UPDATE livro SET Título = @Título, Autor = @Autor, Editora = @Editora WHERE Id = @Id;";
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtidalterar.Text));
                cmd.Parameters.AddWithValue("@Título", txttituloalterar.Text.ToString());
                cmd.Parameters.AddWithValue("@Autor", txtautoralterar.Text.ToString());
                cmd.Parameters.AddWithValue("@Editora", txteditoraalterar.Text.ToString());

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Livro alterado com sucesso!");
                txtidalterar.Clear();
                txttituloalterar.Clear();
                txtautoralterar.Clear();
                txteditoraalterar.Clear();
            }
            else
                MessageBox.Show("Livro não identificado");

        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
