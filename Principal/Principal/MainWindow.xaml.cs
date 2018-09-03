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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Principal
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string parametro) : this()
        {
            textBoxParametro.Text = parametro;
        }


        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click_Cadastrar(object sender, RoutedEventArgs e)
        {
            CadastrarPaciente cadastrarPaciente = new CadastrarPaciente();
            cadastrarPaciente.ShowDialog();
        }

        private void Button_Click_Localizar (object sender, RoutedEventArgs e)
        {
            LocalizarPaciente localizarPaciente = new LocalizarPaciente();
            localizarPaciente.ShowDialog();
        }
    }
}
