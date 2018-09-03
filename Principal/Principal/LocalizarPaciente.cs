using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class LocalizarPaciente : Form
    {

        public LocalizarPaciente()
        {
            InitializeComponent();
        }

        private void LocalizarPaciente_Load(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem("Barrigudinha Seleida", 0);
            lv1.SubItems.Add("23");
            lv1.SubItems.Add("Neurologia");
            lv1.SubItems.Add("Luciana Soares");

            ListViewItem lv2 = new ListViewItem("Manoel Sovaco de Gambar", 1);
            lv2.SubItems.Add("24");
            lv2.SubItems.Add("Traumatologia");
            lv2.SubItems.Add("Danielle Ferreira");

            ListViewItem lv3 = new ListViewItem("Antônio Morrendo Das Dores", 2);
            lv3.SubItems.Add("38");
            lv3.SubItems.Add("Ortopedia");
            lv3.SubItems.Add("Francisco das Chagas");

            lv_busca.Items.Add(lv1);
            lv_busca.Items.Add(lv2);
            lv_busca.Items.Add(lv3);


        }

        private void txt_avaliar_Click(object sender, EventArgs e)
        {
            string selectName = lv_busca.SelectedItems[0].SubItems[0].Text;
            string area = lv_busca.SelectedItems[0].SubItems[2].Text;
            string fisio = lv_busca.SelectedItems[0].SubItems[3].Text;

            using (var mainWindow = new MainWindow())
            {
                mainWindow.ShowDialog();
            }


        }



    }
}
