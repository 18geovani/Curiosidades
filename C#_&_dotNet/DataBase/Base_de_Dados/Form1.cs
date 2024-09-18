using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Base_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criando uma string de conexão
            string strConexao = "server = localhost; User = root; password =";
            //string strConexao = "server = localhost; User = root; database = teste_db; password =";
            MySqlConnection Conexao = new MySqlConnection(strConexao);
            //Conexao.ConnectionString = strConexao;

            try
            {
                Conexao.Open();
                lblResult.Text = "Conectado com Sucesso";

                MySqlCommand Comando = new MySqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

                Comando.ExecuteNonQuery();
                lblResult.Text = "Base de dados criada com Sucesso";
                Comando.Dispose();
            }
            catch (Exception Ex)
            {
                lblResult.Text = "Erro ao conectar \n" + Ex;
            }
            finally 
            { 
                Conexao.Close(); 
            }


          
        }
    }
}
