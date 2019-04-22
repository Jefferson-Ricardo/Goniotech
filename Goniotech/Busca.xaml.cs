using System;
using System.Collections.Generic;
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
using System.Data;
using MySql.Data.MySqlClient;



namespace Goniotech
{
    /// <summary>
    /// Interaction logic for Busca.xaml
    /// </summary>
    public partial class Busca : Window
    {

        private string buscaNome;
        private string _strConn = @"DATABASE=goniotec_goniotech; SERVER=bdhost0040.servidorwebfacil.com; UID=goniotec_admin; PWD=goniotech123456";
        MySqlConnection objConect = null;
        MySqlCommand objComand = null;

        public Busca()
        {
            InitializeComponent();
        }

        public void listaPaciente()
        {
            buscaNome = tbx_buscaNome.Text;
            string strMySQL = "SELECT * from paciente WHERE nome LIKE '%" + buscaNome + "%'";
            objConect = new MySqlConnection(_strConn);
            objComand = new MySqlCommand(strMySQL, objConect);
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dg_consulta.ItemsSource = dtLista.DefaultView;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void listaFisioterapeuta()
        {
            buscaNome = tbx_buscaNome.Text;
            string strMySQL = "SELECT * from fisioterapeuta WHERE nomeFisio LIKE '%" + buscaNome + "%'";
            objConect = new MySqlConnection(_strConn);
            objComand = new MySqlCommand(strMySQL, objConect);
            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objComand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                dg_consulta.ItemsSource = dtLista.DefaultView;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }



        private void Btn_busca_Click(object sender, RoutedEventArgs e)
        {
            if(rbtn_buscaPaciente.IsChecked == false && rbtn_buscaFisioterapeuta.IsChecked == false)
            {
                MessageBox.Show("Escolha uma opção entre Fisioterapeuta e Paciente");
            }
            if (rbtn_buscaFisioterapeuta.IsChecked == true)
            {
                listaFisioterapeuta();
            }
            if(rbtn_buscaPaciente.IsChecked == true)
            {
                listaPaciente();
            }
        }
    }
}
