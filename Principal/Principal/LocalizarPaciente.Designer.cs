namespace Principal
{
    partial class LocalizarPaciente
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
            this.txt_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_localizar = new System.Windows.Forms.Button();
            this.lv_busca = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_idade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fisio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_avaliar = new System.Windows.Forms.Button();
            this.txt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(12, 9);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(35, 13);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bt_localizar
            // 
            this.bt_localizar.Location = new System.Drawing.Point(706, 9);
            this.bt_localizar.Name = "bt_localizar";
            this.bt_localizar.Size = new System.Drawing.Size(82, 23);
            this.bt_localizar.TabIndex = 2;
            this.bt_localizar.Text = "Localizar";
            this.bt_localizar.UseVisualStyleBackColor = true;
            // 
            // lv_busca
            // 
            this.lv_busca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_idade,
            this.ch_area,
            this.fisio});
            this.lv_busca.Location = new System.Drawing.Point(15, 39);
            this.lv_busca.MultiSelect = false;
            this.lv_busca.Name = "lv_busca";
            this.lv_busca.Size = new System.Drawing.Size(773, 373);
            this.lv_busca.TabIndex = 3;
            this.lv_busca.UseCompatibleStateImageBehavior = false;
            this.lv_busca.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Nome";
            // 
            // ch_area
            // 
            this.ch_area.Text = "Area";
            // 
            // ch_idade
            // 
            this.ch_idade.Text = "Idade";
            // 
            // fisio
            // 
            this.fisio.Text = "Fisioterapeuta";
            // 
            // txt_avaliar
            // 
            this.txt_avaliar.Location = new System.Drawing.Point(713, 418);
            this.txt_avaliar.Name = "txt_avaliar";
            this.txt_avaliar.Size = new System.Drawing.Size(75, 23);
            this.txt_avaliar.TabIndex = 4;
            this.txt_avaliar.Text = "Avaliar";
            this.txt_avaliar.UseVisualStyleBackColor = true;
            this.txt_avaliar.Click += new System.EventHandler(this.txt_avaliar_Click);
            // 
            // txt_cancelar
            // 
            this.txt_cancelar.Location = new System.Drawing.Point(632, 418);
            this.txt_cancelar.Name = "txt_cancelar";
            this.txt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.txt_cancelar.TabIndex = 5;
            this.txt_cancelar.Text = "Cancelar";
            this.txt_cancelar.UseVisualStyleBackColor = true;
            // 
            // LocalizarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_cancelar);
            this.Controls.Add(this.txt_avaliar);
            this.Controls.Add(this.lv_busca);
            this.Controls.Add(this.bt_localizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_nome);
            this.Name = "LocalizarPaciente";
            this.Text = "Localizar Paciente";
            this.Load += new System.EventHandler(this.LocalizarPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_localizar;
        private System.Windows.Forms.ListView lv_busca;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_area;
        private System.Windows.Forms.ColumnHeader ch_idade;
        private System.Windows.Forms.ColumnHeader fisio;
        private System.Windows.Forms.Button txt_avaliar;
        private System.Windows.Forms.Button txt_cancelar;
    }
}