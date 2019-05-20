
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
using MySql.Data.MySqlClient;


namespace Goniotech
{
    /// <summary>
    /// Interaction logic for ValidaFisio.xaml
    /// </summary>
    public partial class ValidaFisio : Window
    {

        // Variaveis Globais
        public string user { get; set; }
        public string fisioterapeuta { get; set; }
        string senha;
        
        public ValidaFisio()
        {
            InitializeComponent();
        }

        public ValidaFisio(string nome)
        {
            InitializeComponent();
            tbx_nomeFisioterapeuta.Focus();
            user = nome;
        }

        private void validaFisio ()
        {
            logar();
        }

        private void Btn_validarFisio_Click(object sender, RoutedEventArgs e)
        {
            validaFisio();
        }

        private void Btn_cancelarValidarFisio_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void logar()
        {

            //Atribuição das TextBox nas variaveis
            fisioterapeuta = tbx_nomeFisioterapeuta.Text;
            senha = pbx_senhaFisioterapeuta.Password.ToString();
            

            //COMANDOS PARA CONEXÃO MySql
            string configuracao = "DATABASE=goniotec_goniotech; SERVER=bdhost0040.servidorwebfacil.com; UID=goniotec_admin; PWD=goniotech123456";
            MySqlConnection conexao = new MySqlConnection(configuracao);
            try
            {
                if (conexao.State == ConnectionState.Closed)
                conexao.Open();
                String mySqlCmd = "SELECT COUNT(idFisio) FROM fisioterapeuta WHERE nomeFisio = @fisioterapeuta AND senha = @senha";
                MySqlCommand comando = new MySqlCommand(mySqlCmd, conexao);
                comando.Parameters.AddWithValue("@fisioterapeuta", fisioterapeuta);
                comando.Parameters.AddWithValue("@senha", senha);
                int v = Convert.ToInt32 (comando.ExecuteScalar());

                if (v > 0)
                {
                    Kinect.MainWindow avaliar = new Kinect.MainWindow(fisioterapeuta, user);
                    this.Hide();
                    avaliar.ShowDialog();
                }
                else
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

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "No banco");

            }
            
        }

    }
}
