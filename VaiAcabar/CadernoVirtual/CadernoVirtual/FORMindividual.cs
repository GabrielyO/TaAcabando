﻿using MySql.Data.MySqlClient;
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

        public string matriculaAntiga, usuarioAntigo, cadernoId, turma, idCaderno, nomeMateria, senhaAntiga;

        public FORMindividual(string login, string matricula, string senha)
        {
            InitializeComponent();
            matriculaAntiga = matricula;
            usuarioAntigo = login;
            senhaAntiga = senha;
            tituloApresentacao.Text = ("Bem vindo, "+ login);
            LBLuser.Text = ("Usuário: " + login);
            LBLmat.Text = ("Matricula: " + matricula);
        }

        //CONECTAR
        public MySqlCommand Conectar()
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=caderno;Uid=root;Pwd=root")//Lembrar de alterar PWD: root
            };
            return cmd;
        }

        //VERIFICAR NO BANCO
        public bool VerificarUsuario(string usuario)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "select count(*) from Aluno where usuario = @usuario;";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Connection.Open();

            if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) > 0)
            {
                cmd.Connection.Close();
                if (usuario == usuarioAntigo)
                    return false;

                else
                    return true;
            }
            else
            {
                cmd.Connection.Close();
                return false;
            }
        }
        public bool VerificarMatricula(string matricula)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "select count(*) from Aluno where matricula = @matricula;";
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Connection.Open();

            if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) > 0)
            {
                cmd.Connection.Close();
                if (matricula == matriculaAntiga)
                    return false;

                else
                    return true;
            }
            else
            {
                cmd.Connection.Close();
                return false;
            }

        }
        public bool VerificarCaderno(string idCaderno)
        {
            MySqlCommand cmd = Conectar();

            cmd.CommandText = "select count(*) from caderno where idCaderno = @idCaderno;";
            cmd.Parameters.AddWithValue("@idCaderno", idCaderno);
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
        
        //DESCONECTAR
        private void BTNsairusuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ABRE PAINEIS
        private void BTNcriarCaderno_Click(object sender, EventArgs e)
        {
            PANELcriarCaderno.Visible = true;
            PANELeditarCaderno.Visible = false;
            TXTturma.Clear();
            TXTano.Clear();
            TXTsenhaTurma.Clear();
            TXTconfirmarsenhaTurma.Clear();
        }
        private void BTNexcluirUsuario_Click(object sender, EventArgs e)
        {
            PANELexcluirAluno.Visible = true;
            PANELperfil.Visible = false;
            PANELeditarAluno.Visible = false;
            TXTmatExcluir.Text = matriculaAntiga;
        }
        private void BTNperfil_Click(object sender, EventArgs e)
        {
            PANELexcluirAluno.Visible = false;
            PANELperfil.Visible = true;
            PANELeditarAluno.Visible = false;
        }
        private void BTNeditarUsuario_Click(object sender, EventArgs e)
        {
            PANELexcluirAluno.Visible = false;
            PANELperfil.Visible = false;
            PANELeditarAluno.Visible = true;
        }
        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            PANELeditarCaderno.Visible = true;
            PANELcriarCaderno.Visible = false;
            TXTturma.Clear();
            TXTsenhaTurma.Clear();
        }

        private void CBidCaderno_Click(object sender, EventArgs e)
        {
            if(CBmateria.Text == string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT idCaderno FROM caderno";

                string erro = "";
                try
                {
                    CBidCaderno.Items.Clear();
                    erro = "Falha na conexão ao banco (Editar Caderno)";
                    cmd.Connection.Open();
                    erro = "Falha ao buscar na tabela Caderno";
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        idCaderno = dr.GetString(0);
                        CBidCaderno.Items.Add(idCaderno);

                    }

                    erro = "Falha ao fechar conexão";
                    cmd.Connection.Close();
                }
                catch
                {
                    MessageBox.Show(erro);
                }
            }
        }

        //COMBO BOX MATÉRIAS
        private void CBmateria_Click(object sender, EventArgs e)
        {
            if (CBidCaderno.Text == string.Empty)
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT DISTINCT(nome) FROM materia";

                string erro = "";
                try
                {
                    CBmateria.Items.Clear();
                    erro = "Falha na conexão ao banco (Editar Caderno)";
                    cmd.Connection.Open();
                    erro = "Falha ao buscar na tabela Caderno";
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        nomeMateria = dr.GetString(0);
                        CBmateria.Items.Add(nomeMateria);
                    }

                    erro = "Falha ao fechar conexão";
                    cmd.Connection.Close();
                }
                catch
                {
                    MessageBox.Show(erro);
                }
            }

            else
            {

            }
    }


        //EXCLUIR ALUNO
        private void BTNconfirmarExclur_Click(object sender, EventArgs e)
        {
            if (TXTmatExcluir.Text == string.Empty || TXTsenhaExcluir.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos corretamente");

            else 
            {
                string erro = "";
                try
                {
                    if(TXTsenhaExcluir.Text == senhaAntiga)
                    {
                        MySqlCommand cmd = Conectar();
                        cmd.CommandText = "DELETE FROM aluno WHERE matricula = @matricula AND senha = @senha;";
                        cmd.Parameters.AddWithValue("@matricula", TXTmatExcluir.Text);
                        cmd.Parameters.AddWithValue("@senha", TXTsenhaExcluir.Text);

                        erro = "Falha na conexão ao banco (Exclusão de aluno)";
                        cmd.Connection.Open();
                        erro = "Digite a senha e a matrícula correta!";
                        cmd.ExecuteNonQuery();
                        erro = "Falha ao fechar conexão";
                        cmd.Connection.Close();

                        MessageBox.Show("Aluno excluído com sucesso!");
                        TXTmatExcluir.Clear();
                        TXTsenhaExcluir.Clear();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                    }                                        
                }
                catch
                {
                    MessageBox.Show(erro);
                }                
            }

        }

        private void LISTA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 

        //EDITAR CADERNO
        private void BTNeditarCaderno_Click(object sender, EventArgs e)
        {
            if (TXTturmaCaderno.Text == string.Empty || TXTsenhaCaderno.Text == string.Empty || TXTanoCaderno.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos corretamente, verifique se não deixou algum dos campos vazio");

            else
            {
                MySqlCommand cmd = Conectar();
                cmd.CommandText = "SELECT * FROM caderno WHERE turma = @turma AND ano = @ano AND senha = @senha;";
                cmd.Parameters.AddWithValue("@turma", TXTturmaCaderno.Text);
                cmd.Parameters.AddWithValue("@ano", TXTanoCaderno.Text);
                cmd.Parameters.AddWithValue("@senha", TXTsenhaCaderno.Text);
                
                string erro = "";
                try
                {
                    erro = "Falha na conexão ao banco (Editar Caderno)";
                    cmd.Connection.Open();
                    erro = "Falha ao buscar Caderno";
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Caderno c = new Caderno();
                        c.id = dr.GetString(0);
                        c.turma = dr.GetString(1);
                        c.ano = dr.GetString(2);
                        c.senha = dr.GetString(3);

                        FORMcaderno caderno = new FORMcaderno();                        
                        TXTturmaCaderno.Clear();
                        TXTsenhaCaderno.Clear();
                        TXTanoCaderno.Clear();
                        caderno.Show();
                    }
                    else
                    {
                        MessageBox.Show("Turma, ano ou senha incorretos");
                    }

                    erro = "Falha ao fechar conexão";
                    cmd.Connection.Close();
                }
                catch
                {
                    MessageBox.Show(erro);
                }
            }
            
        }

        //EDITAR ALUNO
        private void BTNconfirmarEdicao_Click(object sender, EventArgs e)
        {
            if (TXTmatriculaEditar.Text == string.Empty || TXTusuarioEditar.Text == string.Empty || TXTsenhaEditar.Text == string.Empty || TXTconfirmarsenhaEditar.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos");
            else if (TXTsenhaEditar.Text != TXTconfirmarsenhaEditar.Text)
                MessageBox.Show("As senhas estão diferentes, digite a mesma senha no campo 'SENHA' e no campo 'CONFIRMAR SENHA'");

            else
            {
                if (VerificarMatricula(TXTmatriculaEditar.Text) == false)
                    if (VerificarUsuario(TXTusuarioEditar.Text) == false)
                    {
                        MySqlCommand cmd = Conectar();
                        cmd.CommandText = "UPDATE aluno SET matricula = @matricula, usuario = @usuario, senha = @senha WHERE matricula = @matriculaAntes;";

                        Aluno a = new Aluno();
                        a.matricula = TXTmatriculaEditar.Text;
                        a.usuario = TXTusuarioEditar.Text;
                        a.senha = TXTsenhaEditar.Text;

                        cmd.Parameters.AddWithValue("@matriculaAntes", matriculaAntiga.ToString());
                        cmd.Parameters.AddWithValue("@matricula", a.matricula);
                        cmd.Parameters.AddWithValue("@usuario", a.usuario);
                        cmd.Parameters.AddWithValue("@senha", a.senha);

                        string erro = "";
                        try
                        {
                            erro = "Falha na conexão ao banco (Edição de aluno)";
                            cmd.Connection.Open();
                            erro = "Falha ao editar aluno";
                            cmd.ExecuteNonQuery();
                            erro = "Falha ao fechar conexão";
                            cmd.Connection.Close();

                            tituloApresentacao.Text = ("Bem vindo, " + a.usuario);
                            LBLuser.Text = ("Usuário: " + a.usuario);
                            LBLmat.Text = ("Matricula: " + a.matricula);

                            matriculaAntiga = TXTmatriculaEditar.Text;
                            usuarioAntigo = TXTusuarioEditar.Text;
                            senhaAntiga = TXTsenhaEditar.Text;

                            MessageBox.Show("Aluno editado com sucesso");
                            TXTmatriculaEditar.Clear();
                            TXTusuarioEditar.Clear();
                            TXTsenhaEditar.Clear();
                            TXTconfirmarsenhaEditar.Clear();
                            PANELeditarAluno.Visible = false;
                            PANELperfil.Visible = true;
                        }
                        catch
                        {
                            MessageBox.Show(erro);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este usuário já existe, digite outro");
                        TXTusuarioEditar.Clear();
                    }
                else
                {
                    MessageBox.Show("Já existe um usuário cadastrado nessa matrícula");
                    TXTmatriculaEditar.Clear();
                }
            }
        }

        //CRIAR TURMA
        private void BTNcriarturma_Click(object sender, EventArgs e)
        {
            if (TXTturma.Text == string.Empty || TXTano.Text == string.Empty || TXTsenhaTurma.Text == string.Empty || TXTconfirmarsenhaTurma.Text == string.Empty)
                MessageBox.Show("Preencha todos os campos");

            else if (TXTsenhaTurma.Text != TXTconfirmarsenhaTurma.Text)
                MessageBox.Show("As senhas estão diferentes, digite a mesma senha no campo 'SENHA' e no campo 'CONFIRMAR SENHA'");

            else
            {
                cadernoId = TXTturma.Text + TXTano.Text;
                if (VerificarCaderno(cadernoId) == false)
                {
                    MySqlCommand cmd = Conectar();
                    cmd.CommandText = "INSERT INTO caderno (idCaderno, turma, ano, senha) VALUES (@id, @turma, @ano, @senha);";

                    Caderno c = new Caderno();

                    c.id = cadernoId;
                    c.turma = TXTturma.Text;
                    c.ano = TXTano.Text;
                    c.senha = TXTsenhaTurma.Text;

                    cmd.Parameters.AddWithValue("@id", c.id);
                    cmd.Parameters.AddWithValue("@turma", c.turma);
                    cmd.Parameters.AddWithValue("@ano", c.ano);
                    cmd.Parameters.AddWithValue("@senha", c.senha);

                    string erro = "";
                    try
                    {
                        erro = "Falha na conexão ao banco (cadastro caderno)";
                        cmd.Connection.Open();
                        erro = "Falha ao cadastrar caderno";
                        cmd.ExecuteNonQuery();
                        erro = "Falha ao fechar conexão";
                        cmd.Connection.Close();

                        MessageBox.Show("Caderno cadastrado com sucesso");
                        TXTturma.Clear();
                        TXTano.Clear();
                        TXTsenhaTurma.Clear();
                        TXTconfirmarsenhaTurma.Clear();
                        PANELcriarCaderno.Visible = false;
                        PANELeditarCaderno.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show(erro);
                    }

                }
                else
                {
                    MessageBox.Show("Essa turma desse ano já existe, digite outra turma ou outro ano");
                    TXTturma.Clear();
                    TXTano.Clear();
                }

            }
        }
    }
}
