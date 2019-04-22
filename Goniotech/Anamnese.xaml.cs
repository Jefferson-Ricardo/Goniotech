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
    /// <summary>
    /// Interaction logic for Anamnese.xaml
    /// </summary>
    public partial class Anamnese : Window
    {

        // VARIAVEIS GLOBAIS
        
        public string diagnosticoCineticoFuncional { get; set; }
        public string queixaPrincipal { get; set; }
        public string historiaDoencaAtual { get; set; }
        public string historiaFamiliar { get; set; }
        public string antecedentesCirurgicos { get; set; }
        public string medicamentos { get; set; }
        public string examesComplementares { get; set; }
        public string objetivosFisioterapia { get; set; }
        public string diagnostico1 { get; set; }
        public string cid1 { get; set; }
        public string diagnostico2 { get; set; }
        public string cid2 { get; set; }
        public string diagnostico3 { get; set; }
        public string cid3 { get; set; }
        public string diagnostico4 { get; set; }
        public string cid4 { get; set; }
        public string medicoResponsavel { get; set; }
        public string crm { get; set; }


        public Anamnese()
        {
            InitializeComponent();
            
        }

        public Anamnese(string nome)
        {
            InitializeComponent();
            tbx_AnamneseNomePaciente.Text = nome;
            tbx_AnamneseNomePaciente.IsEnabled = false;
        }
        
        
        private void Btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_salvarAnamnese_Click(object sender, RoutedEventArgs e)
        {
            salvarAnamnese();
        }

        public void salvarAnamnese()
        {
            //Atribuição das TextBox nas variaveis
            diagnosticoCineticoFuncional = tbx_diagnosticoCineticoFuncional.Text;
            queixaPrincipal = tbx_queixaprincipal.Text;
            historiaDoencaAtual = tbx_historiaDoencaAtual.Text;
            historiaFamiliar = tbx_historiaFamiliar.Text;
            antecedentesCirurgicos = tbx_antecedentesCirurgicos.Text;
            medicamentos = tbx_medicamentos.Text;
            examesComplementares = tbx_examesComplementares.Text;
            objetivosFisioterapia = tbx_objetivosFisioterapia.Text;
            diagnostico1 = tbx_diagnostico1.Text;
            cid1 = tbx_cid1.Text;
            diagnostico2 = tbx_diagnostico2.Text;
            cid2 = tbx_cid2.Text;
            diagnostico3 = tbx_diagnostico3.Text;
            cid3 = tbx_cid3.Text;
            diagnostico4 = tbx_diagnostico4.Text;
            cid4 = tbx_cid4.Text;
            medicoResponsavel = tbx_medicoResponsavel.Text;
            crm = tbx_crm.Text;


            try
            {
                string configuracao = "DATABASE=goniotec_goniotech; SERVER=bdhost0040.servidorwebfacil.com; UID=goniotec_admin; PWD=goniotech123456";
                MySqlConnection conexao = new MySqlConnection(configuracao);
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("UPDATE paciente SET "+
                    "dcf = @diagnosticoCineticoFuncional, "+
                    "hda = @historiaDoencaAtual, "+
                    "ac = @antecedentesCirurgicos, "+
                    "ec = @examesComplementares, "+
                    "qp = @queixaprincipal, "+
                    "hfp = @historiaFamiliar, "+
                    "medicamentos = @medicamentos, "+
                    "objFisio = @objetivosFisioterapia, "+
                    "medicoResp = @medicoResponsavel, "+
                    "crm = @crm, "+
                    "diag1 = @diagnostico1, "+
                    "cid1 = @cid1, "+
                    "diag2 = @diagnostico2, "+
                    "cid2 = @cid2, "+
                    "diag3 = @diagnostico3, "+
                    "cid3 = @cid3, "+
                    "diag4 = @diagnostico4, "+
                    "cid4 = @cid4 WHERE nome = @nomePaciente", conexao);
                comando.Parameters.Add("@diagnosticoCineticoFuncional", MySqlDbType.VarChar, 3000).Value = diagnosticoCineticoFuncional;
                comando.Parameters.Add("@historiaDoencaAtual", MySqlDbType.VarChar, 3000).Value = historiaDoencaAtual;
                comando.Parameters.Add("@antecedentesCirurgicos", MySqlDbType.VarChar, 3000).Value = antecedentesCirurgicos;
                comando.Parameters.Add("@examesComplementares", MySqlDbType.VarChar, 3000).Value = examesComplementares;
                comando.Parameters.Add("@queixaPrincipal", MySqlDbType.VarChar, 3000).Value = queixaPrincipal;
                comando.Parameters.Add("@historiaFamiliar", MySqlDbType.VarChar, 3000).Value = historiaFamiliar;
                comando.Parameters.Add("@medicamentos", MySqlDbType.VarChar, 3000).Value = medicamentos;
                comando.Parameters.Add("@objetivosFisioterapia", MySqlDbType.VarChar, 3000).Value = objetivosFisioterapia;
                comando.Parameters.Add("@medicoResponsavel", MySqlDbType.VarChar, 100).Value = medicoResponsavel;
                comando.Parameters.Add("@crm", MySqlDbType.Int32, 10).Value = crm;
                comando.Parameters.Add("@diagnostico1", MySqlDbType.VarChar, 100).Value = diagnostico1;
                comando.Parameters.Add("@cid1", MySqlDbType.VarChar, 5).Value = cid1;
                comando.Parameters.Add("@diagnostico2", MySqlDbType.VarChar, 100).Value = diagnostico2;
                comando.Parameters.Add("@cid2", MySqlDbType.VarChar, 5).Value = cid2;
                comando.Parameters.Add("@diagnostico3", MySqlDbType.VarChar, 100).Value = diagnostico3;
                comando.Parameters.Add("@cid3", MySqlDbType.VarChar, 5).Value = cid3;
                comando.Parameters.Add("@diagnostico4", MySqlDbType.VarChar, 100).Value = diagnostico4;
                comando.Parameters.Add("@cid4", MySqlDbType.VarChar, 5).Value = cid4;
                comando.Parameters.Add("@nomePaciente", MySqlDbType.VarChar, 300).Value = tbx_AnamneseNomePaciente.Text;
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Anamnese Salva com Sucesso!");
            }
            catch (Exception erro)
            {
                throw erro;
            }
  
        }

    }
}
