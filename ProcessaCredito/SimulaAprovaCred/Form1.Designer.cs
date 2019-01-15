namespace SimulaAprovaCred
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValCred = new System.Windows.Forms.TextBox();
            this.cboTipoCred = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumParc = new System.Windows.Forms.TextBox();
            this.dtPrimVenc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValTotJur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValJur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatusCred = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Crédito";
            // 
            // txtValCred
            // 
            this.txtValCred.Location = new System.Drawing.Point(12, 28);
            this.txtValCred.Name = "txtValCred";
            this.txtValCred.Size = new System.Drawing.Size(132, 20);
            this.txtValCred.TabIndex = 1;
            // 
            // cboTipoCred
            // 
            this.cboTipoCred.FormattingEnabled = true;
            this.cboTipoCred.Items.AddRange(new object[] {
            "Crédito Direto",
            "Crédito Consignado",
            "Crédito Pessoa Jurídica",
            "Crédito Pessoa Física",
            "Crédito Imobiliário"});
            this.cboTipoCred.Location = new System.Drawing.Point(150, 28);
            this.cboTipoCred.Name = "cboTipoCred";
            this.cboTipoCred.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCred.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de Parcelas";
            // 
            // txtNumParc
            // 
            this.txtNumParc.Location = new System.Drawing.Point(277, 28);
            this.txtNumParc.Name = "txtNumParc";
            this.txtNumParc.Size = new System.Drawing.Size(100, 20);
            this.txtNumParc.TabIndex = 1;
            // 
            // dtPrimVenc
            // 
            this.dtPrimVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrimVenc.Location = new System.Drawing.Point(386, 28);
            this.dtPrimVenc.Name = "dtPrimVenc";
            this.dtPrimVenc.Size = new System.Drawing.Size(121, 20);
            this.dtPrimVenc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Primeiro Vencimento";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(432, 110);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor Total com Juros";
            // 
            // txtValTotJur
            // 
            this.txtValTotJur.Location = new System.Drawing.Point(12, 80);
            this.txtValTotJur.Name = "txtValTotJur";
            this.txtValTotJur.Size = new System.Drawing.Size(132, 20);
            this.txtValTotJur.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor dos Juros Mensais";
            // 
            // txtValJur
            // 
            this.txtValJur.Location = new System.Drawing.Point(150, 80);
            this.txtValJur.Name = "txtValJur";
            this.txtValJur.Size = new System.Drawing.Size(132, 20);
            this.txtValJur.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status do Crédito";
            // 
            // txtStatusCred
            // 
            this.txtStatusCred.Location = new System.Drawing.Point(288, 80);
            this.txtStatusCred.Name = "txtStatusCred";
            this.txtStatusCred.Size = new System.Drawing.Size(132, 20);
            this.txtStatusCred.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 147);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dtPrimVenc);
            this.Controls.Add(this.cboTipoCred);
            this.Controls.Add(this.txtNumParc);
            this.Controls.Add(this.txtStatusCred);
            this.Controls.Add(this.txtValJur);
            this.Controls.Add(this.txtValTotJur);
            this.Controls.Add(this.txtValCred);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValCred;
        private System.Windows.Forms.ComboBox cboTipoCred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumParc;
        private System.Windows.Forms.DateTimePicker dtPrimVenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValTotJur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValJur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatusCred;
    }
}

