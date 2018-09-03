namespace Principal
{
    partial class CadastrarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dtNasc = new System.Windows.Forms.Label();
            this.txt_dtNasc = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.Label();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.historico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.fisio = new System.Windows.Forms.Label();
            this.nameFisio = new System.Windows.Forms.TextBox();
            this.txt_historico = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Nome";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(55, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(392, 20);
            this.txt_name.TabIndex = 1;
            // 
            // dtNasc
            // 
            this.dtNasc.AutoSize = true;
            this.dtNasc.Location = new System.Drawing.Point(12, 42);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(104, 13);
            this.dtNasc.TabIndex = 2;
            this.dtNasc.Text = "Data de Nascimento";
            // 
            // txt_dtNasc
            // 
            this.txt_dtNasc.Location = new System.Drawing.Point(122, 38);
            this.txt_dtNasc.Name = "txt_dtNasc";
            this.txt_dtNasc.Size = new System.Drawing.Size(161, 20);
            this.txt_dtNasc.TabIndex = 3;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(289, 45);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(31, 13);
            this.sexo.TabIndex = 4;
            this.sexo.Text = "Sexo";
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Location = new System.Drawing.Point(326, 39);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 5;
            // 
            // historico
            // 
            this.historico.AutoSize = true;
            this.historico.Location = new System.Drawing.Point(13, 98);
            this.historico.Name = "historico";
            this.historico.Size = new System.Drawing.Size(48, 13);
            this.historico.TabIndex = 6;
            this.historico.Text = "Histórico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Área";
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(48, 68);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(121, 21);
            this.cb_area.TabIndex = 8;
            // 
            // fisio
            // 
            this.fisio.AutoSize = true;
            this.fisio.Location = new System.Drawing.Point(187, 71);
            this.fisio.Name = "fisio";
            this.fisio.Size = new System.Drawing.Size(73, 13);
            this.fisio.TabIndex = 9;
            this.fisio.Text = "Fisioterapeuta";
            // 
            // nameFisio
            // 
            this.nameFisio.Location = new System.Drawing.Point(266, 68);
            this.nameFisio.Name = "nameFisio";
            this.nameFisio.Size = new System.Drawing.Size(181, 20);
            this.nameFisio.TabIndex = 10;
            // 
            // txt_historico
            // 
            this.txt_historico.Location = new System.Drawing.Point(16, 118);
            this.txt_historico.Multiline = true;
            this.txt_historico.Name = "txt_historico";
            this.txt_historico.Size = new System.Drawing.Size(431, 204);
            this.txt_historico.TabIndex = 11;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(372, 328);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 12;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(291, 328);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 13;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 360);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.txt_historico);
            this.Controls.Add(this.nameFisio);
            this.Controls.Add(this.fisio);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historico);
            this.Controls.Add(this.cb_Sexo);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.txt_dtNasc);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.name);
            this.Name = "CadastrarPaciente";
            this.Text = "Cadastrar Paciente";
            this.Load += new System.EventHandler(this.CadastrarPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label dtNasc;
        private System.Windows.Forms.TextBox txt_dtNasc;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.Label historico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.Label fisio;
        private System.Windows.Forms.TextBox nameFisio;
        private System.Windows.Forms.TextBox txt_historico;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}