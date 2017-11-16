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
    public partial class FormCadastrarLivro : Form
    {
        public FormCadastrarLivro()
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

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            //Conexão que cadastra livro

            MySqlCommand cmd = Conectar();
            cmd.CommandText = "INSERT INTO livro (Título, Autor, Editora) VALUES (@titulo, @autor, @editora);";

            if(txttitulo.Text == string.Empty || txtautor.Text == string.Empty || txteditora.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos corretamente"); 
                  
            else
            {
                Livro l = new Livro();
                l.titulo = txttitulo.Text;
                l.autor = txtautor.Text;
                l.editora = txteditora.Text;

                cmd.Parameters.AddWithValue("@titulo", l.titulo);
                cmd.Parameters.AddWithValue("@autor", l.autor);
                cmd.Parameters.AddWithValue("@editora", l.editora);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                MessageBox.Show("Livro cadastrado com sucesso");
                txttitulo.Clear();
                txtautor.Clear();
                txteditora.Clear();
            }           
        }

        public void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
