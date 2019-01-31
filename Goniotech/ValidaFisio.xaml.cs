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

namespace Goniotech
{
    /// <summary>
    /// Interaction logic for ValidaFisio.xaml
    /// </summary>
    public partial class ValidaFisio : Window
    {
        public ValidaFisio()
        {
            InitializeComponent();
        }

        private void Btn_validarFisio_Click(object sender, RoutedEventArgs e)
        {
            Kinect.MainWindow avaliar = new Kinect.MainWindow();
            this.Hide();
            avaliar.ShowDialog();
        }
    }
}
