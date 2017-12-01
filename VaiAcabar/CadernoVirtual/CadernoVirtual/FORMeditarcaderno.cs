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
    public partial class FORMeditarcaderno : Form
    {
        public string idCadernoI, loginI, matriculaI, senhaI, matNome;

        //INICIALIZAÇÕES
        public FORMeditarcaderno(string idCaderno, string login, string matricula, string senha)
        {
            InitializeComponent();
            idCadernoI = idCaderno;
            loginI = login;
            matriculaI = matricula;
            senhaI = senha;
            tituloEditar.Text = "EDITAR CADERNO: " + idCaderno;
            PreencherCBmatCont();
        }

        //VERIFICAÇÕES
        public bool VerificarMateria(string nome)
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "select count(*) from materia where nome = @nome;";
            cmd.Parameters.AddWithValue("@nome", nome);
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

        //PREENCHER CB Matéria
        public void PreencherCBmaterias(string id)
        {
            MySqlCommand cmd = Conectar();
            MySqlCommand cmd2 = Conectar();
            cmd.CommandText = "SELECT DISTINCT(nome) FROM conteudo WHERE idCaderno = @idCaderno;";
            cmd.Parameters.AddWithValue("@idCaderno", id);

            string erro = "";
            try
            {
                CBmateriaEx.Items.Clear();
                erro = "Falha na conexão ao banco (Editar Caderno)";
                cmd.Connection.Open();
                erro = "Falha ao buscar na tabela Caderno";

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    string mat;
                    while (dr.Read())
                    {
                        cmd2.CommandText = "SELECT DISTINCT Count(idCaderno) FROM conteudo WHERE nome = @nome;";
                        mat = dr.GetString(0);

                        cmd2.Parameters.Clear();
                        cmd2.Parameters.AddWithValue("@nome", mat.ToString());

                        cmd2.Connection.Open();
                        int num = Convert.ToInt32(cmd2.ExecuteScalar().ToString());

                        if (num <= 1)
                        {
                            CBmateriaEx.Items.Add(mat);
                        }
                        cmd2.Connection.Close();
                        erro = "Falha ao fechar conexão";
                    }

                    cmd.Connection.Close();
                }
            }
            catch
            {
                MessageBox.Show(erro);
            }
        }
        //PREENCHER CBCADERNO
        public void PreencherCBmatCont()
        {
            MySqlCommand cmd = Conectar();
            cmd.CommandText = "SELECT nome FROM materia";

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
                    matNome = dr.GetString(0);
                    CBmateria.Items.Add(matNome);

                }

                erro = "Falha ao fechar conexão";
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show(erro);
            }
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

        //PAINEIS E VOLTAR
        private void BTNexcluirConteudo_Click(object sender, EventArgs e)
        {
            PANELaddConteudo.Visible = false;
            PANELexcluirConteudo.Visible = true;
            PANELexcluirMateria.Visible = false;
            PANELaddMateria.Visible = false;

        }
        private void BTNexcluirMateria_Click(object sender, EventArgs e)
        {
            PANELaddConteudo.Visible = false;
            PANELexcluirConteudo.Visible = false;
            PANELexcluirMateria.Visible = true;
            PANELaddMateria.Visible = false;
            PreencherCBmaterias(idCadernoI);
        }
        private void BTNvoltarIndividual_Click(object sender, EventArgs e)
        {
            FORMindividual formIndividual = new FORMindividual(loginI, matriculaI, senhaI);
            formIndividual.Show();
            this.Close();
        }

        //EXCLUIR BTN
        private void BTNmateriaEX_Click(object sender, EventArgs e)
        {
            if (CBmateriaEx.Text == string.Empty)
                MessageBox.Show("Escolha uma opção");

            else
            {
                string erro = "";
                try
                {
                    MySqlCommand cmd = Conectar();
                    MySqlCommand cmd2 = Conectar();
                    cmd.CommandText = "DELETE FROM materia WHERE nome = @nome;";
                    cmd.Parameters.AddWithValue("@nome", CBmateriaEx.Text);

                    erro = "Falha na conexão ao banco (Exclusão de aluno)1";
                    cmd.Connection.Open();
                    erro = "Digite a senha e a matrícula correta1!";
                    cmd.ExecuteNonQuery();
                    erro = "Falha ao fechar conexão1";
                    cmd.Connection.Close();

                    cmd2.CommandText = "DELETE FROM conteudo WHERE nome = @nome;";
                    cmd2.Parameters.AddWithValue("@nome", CBmateriaEx.Text);
                    erro = "Falha na conexão ao banco (Exclusão de aluno)2";
                    cmd2.Connection.Open();
                    erro = "Digite a senha e a matrícula correta!2";
                    cmd2.ExecuteNonQuery();
                    erro = "Falha ao fechar conexão2";
                    cmd2.Connection.Close();

                    MessageBox.Show("Matéria excluída com sucesso!");
                    CBmateriaEx.Text = "";

                    CBmateria.Items.Clear();
                    PreencherCBmatCont();
                    PreencherCBmaterias(idCadernoI);
                }
                catch
                {
                    MessageBox.Show(erro);
                }


            }

        }

        private void BTNcriarMateria_Click(object sender, EventArgs e)
        {
            PANELaddConteudo.Visible = false;
            PANELexcluirConteudo.Visible = false;
            PANELexcluirMateria.Visible = false;
            PANELaddMateria.Visible = true;
        }
        private void BTNadicionarConteudo_Click(object sender, EventArgs e)
        {
            PANELaddConteudo.Visible = true;
            PANELexcluirConteudo.Visible = false;
            PANELexcluirMateria.Visible = false;
            PANELaddMateria.Visible = false;
        }

        //ADD MATÉRIA
        private void BTNaddMat_Click(object sender, EventArgs e)
        {
            if (TXTnomeMateria.Text == string.Empty)
                MessageBox.Show("Preencha o campo Nome da Matéria");
            
            else
            {
                if (VerificarMateria(TXTnomeMateria.Text) == false)
                {
                    MySqlCommand cmd = Conectar();
                    cmd.CommandText = "INSERT INTO materia (idMateria, nome) VALUES (@idMateria, @nome);";
                    Materia m = new Materia();

                    m.idMateria = "ID"+TXTnomeMateria.Text;
                    m.nome = TXTnomeMateria.Text;

                    cmd.Parameters.AddWithValue("@idMateria", m.idMateria);
                    cmd.Parameters.AddWithValue("@nome", m.nome);

                    string erro = "";
                    try
                    {
                        erro = "Falha na conexão ao banco (cadastro matéria)";
                        cmd.Connection.Open();
                        erro = "Falha ao cadastrar matéria";
                        cmd.ExecuteNonQuery();
                        erro = "Falha ao fechar conexão";
                        cmd.Connection.Close();

                        
                        MessageBox.Show("Matéria cadastrada com sucesso");
                        TXTnomeMateria.Clear();
                        PANELaddMateria.Visible = false;                      
                    }
                    catch
                    {
                        MessageBox.Show(erro);
                    }
                }
                        
                else
                {
                    MessageBox.Show("Já existe uma Matéria cadastrada com esse nome");
                    TXTnomeMateria.Clear();
                }
            }
        }
    }
}
