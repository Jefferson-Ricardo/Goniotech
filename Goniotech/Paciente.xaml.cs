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
using MySql.Data.MySqlClient;




namespace Goniotech
{
    
    public partial class Paciente : Window
    {

        

        //VARIAVEIS GLOBAIS
        public string nome { get; set; }
        public string sexo { get; set; }
        public string dtNasc { get; set; }
        public string idade { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string dtAdmissao { get; set; }
        public string dtAvaliacao { get; set; }
        public string uf { get; set; }
        public string telDDD { get; set; }
        public string telNumero { get; set; }
        public string profissao { get; set; }
        public string ocupacaoAtual { get; set; }
        public string outro { get; set; }
        public string religiao { get; set; }

        public Paciente()
        {
            InitializeComponent();
        }

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
            ValidaFisio validaFisio = new ValidaFisio(nome);
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

        public void salvar ()
        {
            nome = tbx_nomePaciente.Text;
            sexo = cbx_sexoPaciente.Text;
            dtNasc = dataNasc.Text;
            idade = tbx_idadePaciente.Text;
            cep = tbx_CEP.Text;
            rua = tbx_enderecoPaciente.Text;
            numero = tbx_numeroPaciente.Text;
            bairro = tbx_bairroPaciente.Text;
            cidade = tbx_cidadePaciente.Text;
            uf = tbx_estadoPaciente.Text;
            telDDD = tbx_dddPaciente.Text;
            telNumero = tbx_telefonePaciente.Text;
            profissao = tbx_profissaoPaciente.Text;
            ocupacaoAtual = cbx_ocupacaoAtual.Text;
            outro = tbx_outro.Text;
            religiao = tbx_religiao.Text;
            dtAdmissao = dataAdm.Text;
            dtAvaliacao = cbx_avaliacoesPaciente.Text;

            
            try
            {
                string configuracao = "DATABASE=goniotec_goniotech; SERVER=bdhost0040.servidorwebfacil.com; UID=goniotec_admin; PWD=goniotech123456";
                MySqlConnection conexao = new MySqlConnection(configuracao);
                conexao.Open();               
                MySqlCommand comando = new MySqlCommand("INSERT INTO paciente (nome, sexo, dtNasc, telDdd, telNumero, profissao, ocupacaoAtual, outro, religiao, dtAdmissao, dtAvaliacao, cep, rua, numero, bairro, cidade, uf) VALUES (@nome, @sexo, @dtNasc, @telDdd, @telNumero, @profissao, @ocupacaoAtual, @outro, @religiao, @dtAdmissao, @dtAvaliacao, @cep, @rua, @numero, @bairro, @cidade, @uf)", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.VarChar, 300).Value = nome;
                comando.Parameters.Add("@sexo", MySqlDbType.VarChar, 15).Value = sexo;
                comando.Parameters.Add("@dtNasc", MySqlDbType.VarChar, 10).Value = dtNasc;
                comando.Parameters.Add("@telDdd", MySqlDbType.VarChar, 3).Value = telDDD;
                comando.Parameters.Add("@telNumero", MySqlDbType.VarChar, 11).Value = telNumero;
                comando.Parameters.Add("@profissao", MySqlDbType.VarChar, 200).Value = profissao;
                comando.Parameters.Add("@ocupacaoAtual", MySqlDbType.VarChar, 200).Value = ocupacaoAtual;
                comando.Parameters.Add("@outro", MySqlDbType.VarChar, 200).Value = outro;
                comando.Parameters.Add("@religiao", MySqlDbType.VarChar, 200).Value = religiao;
                comando.Parameters.Add("@dtAdmissao", MySqlDbType.VarChar, 10).Value = dtAdmissao;
                comando.Parameters.Add("@dtAvaliacao", MySqlDbType.VarChar, 10).Value = dtAvaliacao;
                comando.Parameters.Add("@cep", MySqlDbType.VarChar, 20).Value = cep;
                comando.Parameters.Add("@rua", MySqlDbType.VarChar, 200).Value = rua;
                comando.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = numero;
                comando.Parameters.Add("@bairro", MySqlDbType.VarChar, 200).Value = bairro;
                comando.Parameters.Add("@cidade", MySqlDbType.VarChar, 200).Value = cidade;
                comando.Parameters.Add("@uf", MySqlDbType.VarChar, 3).Value = uf;
                comando.ExecuteNonQuery();
                conexao.Close();

            } catch(Exception erro)
            {
                throw erro;    
            }
            


            MessageBox.Show("Paciente Cadastrado com Sucesso!");
            LimpaCampos();
        }


        private void Btn_salvarPaciente_Click(object sender, RoutedEventArgs e)
        {
            salvar();
        }

        private void LimpaCampos()
        {
            this.tbx_nomePaciente.Text = "";
            this.cbx_sexoPaciente.Text = "";
            this.dataNasc.Text = "";
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
            this.dataAdm.Text = "";

        }

        private void calcularIdade(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                DateTime dtNasc, dtAtual;
                TimeSpan idade;
                dtNasc = DateTime.Parse(dataNasc.ToString());
                dtAtual = DateTime.Now;
                idade = dtAtual - dtNasc;
                tbx_idadePaciente.Text = $"O Paciente tem {idade.Days / 30 / 12} anos";
            }
            
        }

    }
}
