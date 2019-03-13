using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ValidaFisio.xaml
    /// </summary>
    public partial class ValidaFisio : Window
    {

        // Variaveis Globais
        public string nome { get; set; }
        public string fisioterapeuta { get; set; }
        string senha;

        // Instância da Conexão
        SqlConnection sqlConn = null;
        private string strConn = "Data Source=LAPTOP-5MI2R6SG\\SQLEXPRESS;Initial Catalog=Goniotech;Integrated Security=True";
        private string _Sql = String.Empty;

        public ValidaFisio(string nome)
        {
            InitializeComponent();
            tbx_nomeFisioterapeuta.Focus();
            nome = nome;
        }

        private void Btn_validarFisio_Click(object sender, RoutedEventArgs e)
        {
            logar();
        }

        private void Btn_cancelarValidarFisio_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logar()
        {
            sqlConn = new SqlConnection(strConn);

            try
            {
                //Atribuição das TextBox nas variaveis
                fisioterapeuta = tbx_nomeFisioterapeuta.Text;
                senha = tbx_senhaFisioterapeuta.Password;
                string user = null;

                //COMANDOS PARA CONEXÃO SQLSERVER
                _Sql = "SELECT COUNT(nome_fisioterapeuta) FROM cadastro_fisioterapeuta WHERE nome_fisioterapeuta = @fisioterapeuta AND senha_fisioterapeuta = @senha";
                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
                cmd.Parameters.Add("@fisioterapeuta", SqlDbType.VarChar).Value = fisioterapeuta;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                sqlConn.Open();
                int v = (int)cmd.ExecuteScalar();
                
                if (v > 0)
                {
                    Kinect.MainWindow avaliar = new Kinect.MainWindow(fisioterapeuta, nome);
                    this.Hide();
                    avaliar.ShowDialog();
                } else
                {
                    MessageBox.Show("Verifique suas credenciais!");
                }

                // Validação campos vazios
                if (fisioterapeuta == "" || senha == "")
                {
                    MessageBox.Show("Existe campos vazios!!");
                    return;
                }

                if (fisioterapeuta.Length > 0)
                {
                    user += fisioterapeuta.Substring(0, 1).ToUpper();
                    user += fisioterapeuta.Substring(1, fisioterapeuta.Length - 1).ToLower();
                }


            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No banco");

            }
            sqlConn.Close();
        }

    }
}
