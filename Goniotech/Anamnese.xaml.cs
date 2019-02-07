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
    /// Interaction logic for Anamnese.xaml
    /// </summary>
    public partial class Anamnese : Window
    {

        // VARIAVEIS GLOBAIS
        
        string diagnosticoCineticoFuncional { get; set; }
        string queixaPrincipal { get; set; }
        string historiaDoencaAtual { get; set; }
        string historiaFamiliar { get; set; }
        string antecedentesCirurgicos { get; set; }
        string medicamentos { get; set; }
        string examesComplementares { get; set; }
        string objetivosFisioterapia { get; set; }
        string diagnostico1 { get; set; }
        string cid1 { get; set; }
        string diagnostico2 { get; set; }
        string cid2 { get; set; }
        string diagnostico3 { get; set; }
        string cid3 { get; set; }
        string diagnostico4 { get; set; }
        string cid4 { get; set; }
        string medicoResponsavel { get; set; }
        string crm { get; set; }

        // Instância da Conexão
        SqlConnection sqlConn = null;
        private string strConn = "Data Source=LAPTOP-5MI2R6SG\\SQLEXPRESS;Initial Catalog=Goniotech;Integrated Security=True";
        private string _Sql = String.Empty;
        

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
            sqlConn = new SqlConnection(strConn);

            try
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
                
                //COMANDOS PARA CONEXÃO SQLSERVER
                _Sql = "INSERT INTO anamnese (diagnostico_cf, queixa_principal, historia_doenca_atual, historia_familiar_pregressa, antecedentes_cirurgicos, medicamentos, exames_complementares, objetivos_fisioterapia, diagnostico1, cid1, diagnostico2, cid2, diagnostico3, cid3, diagnostico4, cid4, medico_responsavel, crm) " +
                       "VALUES (@dcf, @qp, @hda, @hfp, @ac, @medicamentos, @ec, @of, @diagnostico1, @cid1, @diagnostico2, @cid2, @diagnostico3, @cid3, @diagnostico4, @cid4, @medico_responsavel, @crm)";
                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
                cmd.Parameters.Add(new SqlParameter("@dcf", diagnosticoCineticoFuncional));
                cmd.Parameters.Add(new SqlParameter("@qp", queixaPrincipal));
                cmd.Parameters.Add(new SqlParameter("@hda", historiaDoencaAtual));
                cmd.Parameters.Add(new SqlParameter("@hfp", historiaFamiliar));
                cmd.Parameters.Add(new SqlParameter("@ac", antecedentesCirurgicos));
                cmd.Parameters.Add(new SqlParameter("@medicamentos", medicamentos));
                cmd.Parameters.Add(new SqlParameter("@ec", examesComplementares));
                cmd.Parameters.Add(new SqlParameter("@of", objetivosFisioterapia));
                cmd.Parameters.Add(new SqlParameter("@diagnostico1", diagnostico1));
                cmd.Parameters.Add(new SqlParameter("@cid1", cid1));
                cmd.Parameters.Add(new SqlParameter("@diagnostico2", diagnostico2));
                cmd.Parameters.Add(new SqlParameter("@cid2", cid2));
                cmd.Parameters.Add(new SqlParameter("@diagnostico3", diagnostico3));
                cmd.Parameters.Add(new SqlParameter("@cid3", cid3));
                cmd.Parameters.Add(new SqlParameter("@diagnostico4", diagnostico4));
                cmd.Parameters.Add(new SqlParameter("@cid4", cid4));
                cmd.Parameters.Add(new SqlParameter("@medico_responsavel", medicoResponsavel));
                cmd.Parameters.Add(new SqlParameter("@crm", crm));


                sqlConn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Anamnese Salva com Sucesso!");
                
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No banco");

            }
            sqlConn.Close();
        }

    }
}
