using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SistemaAcademico
{
    public partial class btndelete : Form
    {
        int idAluno;
        public btndelete()
        {
            InitializeComponent();

            ListarAlunos();

            Conexao conexao = new Conexao();

            OracleConnection conn = conexao.GetConnection();

            try
            {
                conn.Open();

                MessageBox.Show("Conectado com sucesso!");

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }


        }

        //pega os alunos do oracle, cria uma tabela temporaria e mostra no datagridview
        public void ListarAlunos()
        {
            Conexao conexao = new Conexao();

            OracleConnection conn =
            conexao.GetConnection();

            try
            {
                conn.Open();

                string sql =
                "SELECT * FROM ALUNOS";

                OracleDataAdapter da =
                new OracleDataAdapter(sql, conn);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvalunos.DataSource = dt;

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                "Erro: " + erro.Message);
            }
        }


        //botão que salva todas as informações de email, telefone e nome e manda pro oracle
        private void btnsave_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            OracleConnection conn = conexao.GetConnection();

            try
            {
                conn.Open();

                string sql =
                "INSERT INTO alunos (NOME, EMAIL, TELEFONE) " +
                "VALUES (:nome, :email, :telefone)";

                OracleCommand cmd =
                new OracleCommand(sql, conn);

                cmd.Parameters.Add(":nome", txtname.Text);
                cmd.Parameters.Add(":email", txtmail.Text);
                cmd.Parameters.Add(":telefone", txtphone.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno salvo!");
                ListarAlunos();

                txtname.Clear();
                txtmail.Clear();
                txtphone.Clear();

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void dgvalunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idAluno = Convert.ToInt32(
            dgvalunos.Rows[e.RowIndex]
            .Cells["ID"].Value);


            txtname.Text =
            dgvalunos.Rows[e.RowIndex]
            .Cells["NOME"].Value.ToString();

            txtmail.Text =
            dgvalunos.Rows[e.RowIndex]
            .Cells["EMAIL"].Value.ToString();

            txtphone.Text =
            dgvalunos.Rows[e.RowIndex]
            .Cells["TELEFONE"].Value.ToString();
        }

        //botao que edita o aluno selecionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            OracleConnection conn =
            conexao.GetConnection();

            try
            {
                conn.Open();

                string sql =
                "UPDATE ALUNOS SET " +
                "NOME = :nome, " +
                "EMAIL = :email, " +
                "TELEFONE = :telefone " +
                "WHERE ID = :id";

                OracleCommand cmd =
                new OracleCommand(sql, conn);

                cmd.Parameters.Add(":nome", txtname.Text);
                cmd.Parameters.Add(":email", txtmail.Text);
                cmd.Parameters.Add(":telefone", txtphone.Text);
                cmd.Parameters.Add(":id", idAluno);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                "Aluno atualizado!");

                ListarAlunos();

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                "Erro: " + erro.Message);
            }
        }

        //botão que deleta o aluno selecionado
        private void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            OracleConnection conn =
            conexao.GetConnection();

            try
            {
                conn.Open();

                string sql =
                "DELETE from ALUNOS " +
                "WHERE ID = :id";

                OracleCommand cmd =
                new OracleCommand(sql, conn);

                cmd.Parameters.Add(":id", idAluno);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                "Aluno deletado!");

                ListarAlunos();

                txtname.Clear();
                txtmail.Clear();
                txtphone.Clear();

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                "Erro: " + erro.Message);
            }
        }
    }
}
