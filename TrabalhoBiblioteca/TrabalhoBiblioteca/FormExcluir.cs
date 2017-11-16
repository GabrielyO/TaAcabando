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
    public partial class FormExcluir : Form
    {
        public FormExcluir()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtid.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT * FROM livro WHERE Id = @Id;";
                cmd.Parameters.AddWithValue("@Id", int.Parse(txtid.Text));

                cmd.Connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                

                if (r.Read())
                {
                    txttitulo.Text = r.GetString(1);
                    txtautor.Text = r.GetString(2);
                    txteditora.Text = r.GetString(3);
                }                
                else
                {
                    MessageBox.Show("Digite um ID válido!");
                    txtid.Clear();
                }
                   
                cmd.Connection.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text != string.Empty && txtautor.Text != string.Empty && txteditora.Text != string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "DELETE FROM livro WHERE Título = @Título AND Autor = @Autor AND Editora = @Editora;";
                cmd.Parameters.AddWithValue("@Título", txttitulo.Text);
                cmd.Parameters.AddWithValue("@Autor", txtautor.Text);
                cmd.Parameters.AddWithValue("@Editora", txteditora.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Livro excluído com sucesso!");
                txttitulo.Clear();
                txtautor.Clear();
                txteditora.Clear();
            }
            else
                MessageBox.Show("Livro não identificado");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
