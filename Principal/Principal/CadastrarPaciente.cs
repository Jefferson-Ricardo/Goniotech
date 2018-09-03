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
    public partial class CadastrarPaciente : Form
    {
        public CadastrarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarPaciente_Load(object sender, EventArgs e)
        {
            cb_Sexo.Items.Add(new KeyValuePair<string, string>("Masculino", "0"));
            cb_Sexo.Items.Add(new KeyValuePair<string, string>("Feminino", "1"));
            cb_Sexo.DisplayMember = "key";
            cb_Sexo.ValueMember = "value";

            cb_area.Items.Add(new KeyValuePair<string, string>("Neurologia", "0"));
            cb_area.Items.Add(new KeyValuePair<string, string>("Traumatologia", "1"));
            cb_area.Items.Add(new KeyValuePair<string, string>("Reumatologia", "2"));
            cb_area.DisplayMember = "key";
            cb_area.ValueMember = "value";



        }
    }
}
