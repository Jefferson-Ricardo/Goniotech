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
using Kinect;



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
            MessageBox.Show("Efeteu login para avaliar o paciente");
            ValidaFisio validaFisio = new ValidaFisio();
            validaFisio.ShowDialog();
            
        }

        private void Btn_anamnesePaciente_Click(object sender, RoutedEventArgs e)
        {
            Anamnese anamnese = new Anamnese();
            anamnese.ShowDialog();
        }
    }
}
