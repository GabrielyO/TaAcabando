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

namespace CadernoVirtual
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
        }

        public bool VerificarUsuario (string usuario)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "select count(*) from Aluno where usuario = @usuario;";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Connection.Open();            

            if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) > 0)
            {
                cmd.Connection.Close();
                return true;
            }

            else
            {
                cmd.Connection.Close();
                return false;
            }
        }

        public bool VerificarMatricula (string matricula)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "select count(*) from Aluno where matricula = @matricula;";
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Connection.Open();
            
            if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) > 0)
            {
                cmd.Connection.Close();
                return true;
            }
            else
            {
                cmd.Connection.Close();
                return false;
            }

        }

        public MySqlCommand Conectar()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=caderno;Uid=root;Pwd=root")
            };
            return cmd;
        }       

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            PANELcadastrar.Visible = true;
            PANELentrar.Visible = false;            
        }

        private void BTNpaginaprincipal_Click(object sender, EventArgs e)
        {
            PANELcadastrar.Visible = false;
            PANELentrar.Visible = false;
        }

        private void BTNentrar_Click(object sender, EventArgs e)
        {
            PANELentrar.Visible = true;
            PANELcadastrar.Visible = false;
        }

        private void BTNefetuarcadastro_Click(object sender, EventArgs e)
        {
            if (TXTmatricula.Text == string.Empty || TXTusuario.Text == string.Empty || TXTsenha.Text == string.Empty || TXTconfirmarsenha.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos");
            else if (TXTsenha.Text != TXTconfirmarsenha.Text)
                MessageBox.Show("As senhas estão diferentes");

            else
            {
                if (VerificarMatricula(TXTmatricula.Text) == false)
                    if (VerificarUsuario(TXTusuario.Text) == false)
                    {
                        MySqlCommand cmd = Conectar();
                        cmd.CommandText = "INSERT INTO Aluno (matricula, usuario, senha) VALUES (@matricula, @usuario, @senha);";
                        Aluno a = new Aluno();

                        a.matricula = TXTmatricula.Text;
                        a.usuario = TXTusuario.Text;
                        a.senha = TXTsenha.Text;

                        cmd.Parameters.AddWithValue("@matricula", a.matricula);
                        cmd.Parameters.AddWithValue("@usuario", a.usuario);
                        cmd.Parameters.AddWithValue("@senha", a.senha);

                        string erro = "";
                        try
                        {
                            erro = "Falha na conexão ao banco (cadastro aluno)";
                            cmd.Connection.Open();
                            erro = "Falha ao cadastrar aluno";
                            cmd.ExecuteNonQuery();
                            erro = "Falha ao fechar conexão";
                            cmd.Connection.Close();

                            MessageBox.Show("Aluno cadastrado com sucesso");
                            TXTmatricula.Clear();
                            TXTusuario.Clear();
                            TXTsenha.Clear();
                            TXTconfirmarsenha.Clear();
                        }
                        catch
                        {
                            MessageBox.Show(erro);
                        }         
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuário já existe");
                        TXTusuario.Clear();
                    }
                else
                {
                    MessageBox.Show("Matrícula já existe");
                    TXTmatricula.Clear();
                }
            }
        }
    }
}
