namespace GestioneClientiBanca
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxCognome = new System.Windows.Forms.TextBox();
            this.tbxNumeroConto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnMostra = new System.Windows.Forms.Button();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_error = new System.Windows.Forms.Label();
            this.cmbxValuta = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data di nascita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero di conto:";
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(192, 37);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(335, 26);
            this.tbxNome.TabIndex = 1;
            // 
            // tbxCognome
            // 
            this.tbxCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCognome.Location = new System.Drawing.Point(192, 74);
            this.tbxCognome.Name = "tbxCognome";
            this.tbxCognome.Size = new System.Drawing.Size(335, 26);
            this.tbxCognome.TabIndex = 2;
            // 
            // tbxNumeroConto
            // 
            this.tbxNumeroConto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumeroConto.Location = new System.Drawing.Point(192, 148);
            this.tbxNumeroConto.Name = "tbxNumeroConto";
            this.tbxNumeroConto.Size = new System.Drawing.Size(335, 26);
            this.tbxNumeroConto.TabIndex = 4;
            this.tbxNumeroConto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumeroConto_KeyPress);
            this.tbxNumeroConto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxNumeroConto_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valuta:";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Enabled = false;
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(58, 292);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(117, 77);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(254, 292);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(117, 77);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnMostra
            // 
            this.btnMostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostra.Location = new System.Drawing.Point(450, 292);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(117, 77);
            this.btnMostra.TabIndex = 9;
            this.btnMostra.Text = "MOSTRA CSV";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascita.Location = new System.Drawing.Point(192, 114);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(335, 26);
            this.dtpDataNascita.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.csv)|*.csv";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.csv)|*.csv";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error.Location = new System.Drawing.Point(189, 177);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(358, 17);
            this.lbl_error.TabIndex = 10;
            this.lbl_error.Text = "Il numero conto deve contenere esattamente 8 caratteri";
            this.lbl_error.Visible = false;
            // 
            // cmbxValuta
            // 
            this.cmbxValuta.FormattingEnabled = true;
            this.cmbxValuta.Items.AddRange(new object[] {
            "Euro",
            "Dollaro"});
            this.cmbxValuta.Location = new System.Drawing.Point(192, 210);
            this.cmbxValuta.Name = "cmbxValuta";
            this.cmbxValuta.Size = new System.Drawing.Size(121, 21);
            this.cmbxValuta.TabIndex = 11;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GestioneClientiBanca.Code.Cliente);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.cmbxValuta);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.dtpDataNascita);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.tbxNumeroConto);
            this.Controls.Add(this.tbxCognome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxCognome;
        private System.Windows.Forms.TextBox tbxNumeroConto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ComboBox cmbxValuta;
    }
}

