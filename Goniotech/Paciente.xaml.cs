using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
using Kinect;
using Correios;



namespace Goniotech
{
    /// <summary>
    /// Interaction logic for paciente.xaml
    /// </summary>
    public partial class Paciente : Window
    {
        public Paciente()
        {
            InitializeComponent();

            
        }

        //VARIAVEIS GLOBAIS
        public string nome { get; set; }
        string sexo { get; set; }
        string dataDeNascimento { get; set; }
        string idade { get; set; }
        string cep { get; set; }
        string rua { get; set; }
        string numero { get; set; }
        string bairro { get; set; }
        string cidade { get; set; }
        string uf { get; set; }
        string telefoneDDD { get; set; }
        string telefoneNumero { get; set; }
        string profissao { get; set; }
        string ocupacaoAtual { get; set; }
        string outro { get; set; }
        string religiao { get; set; }
        string dataAdmissao { get; set; }

        // Instância da Conexão
        SqlConnection sqlConn = null;
        private string strConn = "Data Source=LAPTOP-5MI2R6SG\\SQLEXPRESS;Initial Catalog=Goniotech;Integrated Security=True";
        private string _Sql = String.Empty;



        private void LocalizarCEP()
        {
            using (var buscaCEP = new BuscaCEPCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultadoBuscaCEP = buscaCEP.consultaCEP(tbx_CEP.Text);

                    tbx_enderecoPaciente.Text = resultadoBuscaCEP.end;
                    tbx_bairroPaciente.Text = resultadoBuscaCEP.bairro;
                    tbx_cidadePaciente.Text = resultadoBuscaCEP.cidade;
                    tbx_estadoPaciente.Text = resultadoBuscaCEP.uf;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Erro", MessageBoxButton.OK);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LocalizarCEP();
        }

        private void Btn_avaliar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Para avaliar, faça login!", "Login");
            ValidaFisio validaFisio = new ValidaFisio();
            validaFisio.ShowDialog();
            
        }

        private void Btn_anamnesePaciente_Click(object sender, RoutedEventArgs e)
        {
            nome = tbx_nomePaciente.Text;
            Anamnese anamnese = new Anamnese(nome);
            anamnese.ShowDialog();
        }

        private void Btn_cancelPaciente_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_salvarPaciente_Click(object sender, RoutedEventArgs e)
        {
            sqlConn = new SqlConnection(strConn);

            try
            {
                //Atribuição das TextBox nas variaveis
                nome = tbx_nomePaciente.Text;
                sexo = cbx_sexoPaciente.Text;
                dataDeNascimento = tbx_dataDeNascimento.Text;
                idade = tbx_idadePaciente.Text;
                cep = tbx_CEP.Text;
                rua = tbx_enderecoPaciente.Text;
                numero = tbx_numeroPaciente.Text;
                bairro = tbx_bairroPaciente.Text;
                cidade = tbx_cidadePaciente.Text;
                uf = tbx_estadoPaciente.Text;
                telefoneDDD = tbx_dddPaciente.Text;
                telefoneNumero = tbx_numeroPaciente.Text;
                profissao = tbx_profissaoPaciente.Text;
                ocupacaoAtual = cbx_ocupacaoAtual.Text;
                outro = tbx_outro.Text;
                religiao = tbx_religiao.Text;
                dataAdmissao = tbx_dataDaAdmissao.Text;

                //COMANDOS PARA CONEXÃO SQLSERVER
                _Sql = "INSERT INTO paciente (nome_paciente, sexo_paciente, dt_nascimento, cep, rua, numero, bairro, cidade, uf, telefone_ddd, telefone_numero, profissao, ocupacao_atual, outro, religiao, dt_admissao) " +
                       "VALUES (@nome, @sexo, @dataDeNascimento, @cep, @rua, @numero, @bairro, @cidade, @uf, @telefoneDDD, @telefoneNumero, @profissao, @ocupacaoAtual, @outro, @religiao, @dataAdmissao)";
                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);
                cmd.Parameters.Add(new SqlParameter("@nome", nome));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@dataDeNascimento", dataDeNascimento));
                cmd.Parameters.Add(new SqlParameter("@cep", cep));
                cmd.Parameters.Add(new SqlParameter("@rua", rua));
                cmd.Parameters.Add(new SqlParameter("@numero", numero));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairro));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidade));
                cmd.Parameters.Add(new SqlParameter("@uf", uf));
                cmd.Parameters.Add(new SqlParameter("@telefoneDDD", telefoneDDD));
                cmd.Parameters.Add(new SqlParameter("@telefoneNumero", telefoneNumero));
                cmd.Parameters.Add(new SqlParameter("@profissao", profissao));
                cmd.Parameters.Add(new SqlParameter("@ocupacaoAtual", ocupacaoAtual));
                cmd.Parameters.Add(new SqlParameter("@outro", outro));
                cmd.Parameters.Add(new SqlParameter("@religiao", religiao));
                cmd.Parameters.Add(new SqlParameter("@dataAdmissao", dataAdmissao));

                sqlConn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Paciente Cadastrado com Sucesso!");
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
            this.tbx_nomePaciente.Text = "";
            this.cbx_sexoPaciente.Text = "";
            this.tbx_dataDeNascimento.Text = "";
            this.tbx_idadePaciente.Text = "";
            this.tbx_CEP.Text = "";
            this.tbx_enderecoPaciente.Text = "";
            this.tbx_numeroPaciente.Text = "";
            this.tbx_bairroPaciente.Text = "";
            this.tbx_cidadePaciente.Text = "";
            this.tbx_estadoPaciente.Text = "";
            this.tbx_dddPaciente.Text = "";
            this.tbx_telefonePaciente.Text = "";
            this.tbx_profissaoPaciente.Text = "";
            this.cbx_ocupacaoAtual.Text = "";
            this.tbx_outro.Text = "";
            this.tbx_religiao.Text = "";
            this.tbx_dataDaAdmissao.Text = "";

        }

        private void Cbx_ocupacaoAtual_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbx_ocupacaoAtual.Text == "Outro")
            {
                tbx_outro.IsEnabled = true;
            }
        }
    }
}
