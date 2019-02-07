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

namespace Goniotech
{
    /// <summary>
    /// Interaction logic for Fisioterapeuta.xaml
    /// </summary>
    public partial class Fisioterapeuta : Window
    {
        //VARIAVEIS GLOBAIS
        string nomeFisioterapeuta { get; set; }
        string registro { get; set; }
        string especialidade { get; set; }
        string senha { get; set; }

        public Fisioterapeuta()
        {
            InitializeComponent();
        }

        // Instância da Conexão
        SqlConnection sqlConn = null;
        private string strConn = "Data Source=LAPTOP-5MI2R6SG\\SQLEXPRESS;Initial Catalog=Goniotech;Integrated Security=True";
        private string _Sql = String.Empty;

        private void Btn_saveFisioterapeuta_Click(object sender, RoutedEventArgs e)
        {
            sqlConn = new SqlConnection(strConn);

            try
            {
                //Atribuição das TextBox nas variaveis
                nomeFisioterapeuta = tbx_nomeFisioterapeuta.Text;
                senha = pbx_senha.Password;
                registro = tbx_registro.Text;
                especialidade = cbx_especialidade.Text;

                // Validação campos vazios
                if (nomeFisioterapeuta == "" || senha == "" || registro == "" || especialidade == "")
                {
                    MessageBox.Show("Existe campos vazios!!");
                    return;
                }

                //COMANDOS PARA CONEXÃO SQLSERVER
                _Sql = "INSERT INTO cadastro_fisioterapeuta (nome_fisioterapeuta, registro_fisioterapeuta, especialidade_fisioterapeuta, senha_fisioterapeuta) VALUES (@nomeFisioterapeuta, @registroFisioterapeuta, @especialidadeFisioterapeuta, @senhaFisioterapeuta)";
                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
                cmd.Parameters.Add(new SqlParameter ("@nomeFisioterapeuta", nomeFisioterapeuta));
                cmd.Parameters.Add(new SqlParameter("@registroFisioterapeuta", registro));
                cmd.Parameters.Add(new SqlParameter("@especialidadeFisioterapeuta", especialidade));
                cmd.Parameters.Add(new SqlParameter("@senhaFisioterapeuta", senha));
                sqlConn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fisioterapeuta Cadastrado com Sucesso!");
                LimpaCampos();

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No banco");

            }
            sqlConn.Close();
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
