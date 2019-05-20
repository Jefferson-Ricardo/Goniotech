using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;


namespace Goniotech
{
    /// </summary>
    public partial class Fisioterapeuta : Window
    {
        public string NomeFisio { get; set; }
        public string Registro { get; set; }
        public string Especialidade { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
        public int Length { get; set; }

        public Fisioterapeuta()
        {
            InitializeComponent();
        }


        private void salvarFisioterapeuta ()
        {
            
            NomeFisio = tbx_nomeFisioterapeuta.Text;
            Registro = tbx_registro.Text;
            Especialidade = cbx_especialidade.Text;
            Senha = pbx_senha.Password.ToString();
            ConfirmSenha = pbx_confirmSenha.Password.ToString();

            if (Senha != ConfirmSenha)
            {
                MessageBox.Show("Os campos Senha e Confirmar senha devem ser iguais!");
            }
            else
            {
                string configuracao = "DATABASE=goniotec_goniotech; SERVER=bdhost0040.servidorwebfacil.com; UID=goniotec_admin; PWD=goniotech123456";
                MySqlConnection conexao = new MySqlConnection(configuracao);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO fisioterapeuta (nomeFisio, registro, especialidade, senha) VALUES (@nome, @registro, @especialidade, @senha)", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.VarChar, 200).Value = NomeFisio;
                comando.Parameters.Add("@registro", MySqlDbType.VarChar, 10).Value = Registro;
                comando.Parameters.Add("@especialidade", MySqlDbType.VarChar, 50).Value = Especialidade;
                comando.Parameters.Add("@senha", MySqlDbType.VarChar, 15).Value = Senha;
                comando.ExecuteNonQuery();
                conexao.Close();


                MessageBox.Show("Fisioterapeuta Cadastrado com Sucesso!");
                LimpaCampos();
                Close();
            }
        }

        private void Btn_saveFisioterapeuta_Click(object sender, RoutedEventArgs e)
        {
            salvarFisioterapeuta();
        }

        private void LimpaCampos()
        {

            this.tbx_nomeFisioterapeuta.Text = "";
            this.tbx_registro.Text = "";
            this.cbx_especialidade.Text = "";
            this.pbx_senha.Password = "";
            this.pbx_confirmSenha.Password = "";
        }

        private void Btn_cancelFisioterapeuta_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
