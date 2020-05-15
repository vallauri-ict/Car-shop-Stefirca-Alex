namespace Car_shop_Stefirca
{
    partial class FormGestione
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
            this.nPrezzo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nKmFatti = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkKm0 = new System.Windows.Forms.CheckBox();
            this.chkUsato = new System.Windows.Forms.CheckBox();
            this.nAirbag = new System.Windows.Forms.NumericUpDown();
            this.lblNAirbag = new System.Windows.Forms.Label();
            this.txtSella = new System.Windows.Forms.TextBox();
            this.lblSaddleBrand = new System.Windows.Forms.Label();
            this.DataMatricolazione = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nPotenza = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nCilindrata = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Tipo_veicolo = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKmFatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAirbag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPotenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // nPrezzo
            // 
            this.nPrezzo.Location = new System.Drawing.Point(136, 281);
            this.nPrezzo.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.nPrezzo.Name = "nPrezzo";
            this.nPrezzo.Size = new System.Drawing.Size(99, 20);
            this.nPrezzo.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Prezzo:";
            // 
            // nKmFatti
            // 
            this.nKmFatti.Location = new System.Drawing.Point(136, 254);
            this.nKmFatti.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nKmFatti.Name = "nKmFatti";
            this.nKmFatti.Size = new System.Drawing.Size(99, 20);
            this.nKmFatti.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Chilometri percorsi:";
            // 
            // chkKm0
            // 
            this.chkKm0.AutoSize = true;
            this.chkKm0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKm0.Location = new System.Drawing.Point(138, 227);
            this.chkKm0.Margin = new System.Windows.Forms.Padding(2);
            this.chkKm0.Name = "chkKm0";
            this.chkKm0.Size = new System.Drawing.Size(98, 17);
            this.chkKm0.TabIndex = 27;
            this.chkKm0.Text = "Chilometro zero";
            this.chkKm0.UseVisualStyleBackColor = true;
            // 
            // chkUsato
            // 
            this.chkUsato.AutoSize = true;
            this.chkUsato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsato.Location = new System.Drawing.Point(38, 225);
            this.chkUsato.Margin = new System.Windows.Forms.Padding(2);
            this.chkUsato.Name = "chkUsato";
            this.chkUsato.Size = new System.Drawing.Size(54, 17);
            this.chkUsato.TabIndex = 23;
            this.chkUsato.Text = "Usato";
            this.chkUsato.UseVisualStyleBackColor = true;
            // 
            // nAirbag
            // 
            this.nAirbag.Location = new System.Drawing.Point(136, 305);
            this.nAirbag.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nAirbag.Name = "nAirbag";
            this.nAirbag.Size = new System.Drawing.Size(99, 20);
            this.nAirbag.TabIndex = 36;
            // 
            // lblNAirbag
            // 
            this.lblNAirbag.AutoSize = true;
            this.lblNAirbag.Location = new System.Drawing.Point(36, 307);
            this.lblNAirbag.Name = "lblNAirbag";
            this.lblNAirbag.Size = new System.Drawing.Size(80, 13);
            this.lblNAirbag.TabIndex = 21;
            this.lblNAirbag.Text = "Numero Airbag:";
            // 
            // txtSella
            // 
            this.txtSella.Location = new System.Drawing.Point(134, 331);
            this.txtSella.Name = "txtSella";
            this.txtSella.Size = new System.Drawing.Size(100, 20);
            this.txtSella.TabIndex = 37;
            // 
            // lblSaddleBrand
            // 
            this.lblSaddleBrand.AutoSize = true;
            this.lblSaddleBrand.Location = new System.Drawing.Point(37, 328);
            this.lblSaddleBrand.Name = "lblSaddleBrand";
            this.lblSaddleBrand.Size = new System.Drawing.Size(33, 13);
            this.lblSaddleBrand.TabIndex = 20;
            this.lblSaddleBrand.Text = "Sella:";
            // 
            // DataMatricolazione
            // 
            this.DataMatricolazione.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataMatricolazione.Location = new System.Drawing.Point(136, 198);
            this.DataMatricolazione.MaxDate = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            this.DataMatricolazione.Name = "DataMatricolazione";
            this.DataMatricolazione.Size = new System.Drawing.Size(100, 20);
            this.DataMatricolazione.TabIndex = 33;
            this.DataMatricolazione.Value = new System.DateTime(2020, 5, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Immatricolazione:";
            // 
            // nPotenza
            // 
            this.nPotenza.Location = new System.Drawing.Point(135, 152);
            this.nPotenza.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nPotenza.Name = "nPotenza";
            this.nPotenza.Size = new System.Drawing.Size(99, 20);
            this.nPotenza.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Potenza:";
            // 
            // nCilindrata
            // 
            this.nCilindrata.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nCilindrata.Location = new System.Drawing.Point(135, 126);
            this.nCilindrata.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nCilindrata.Name = "nCilindrata";
            this.nCilindrata.Size = new System.Drawing.Size(99, 20);
            this.nCilindrata.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cilindrata:";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(135, 100);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Colore:";
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(134, 74);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Modello:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(134, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marca:";
            // 
            // btnAddModify
            // 
            this.btnAddModify.Location = new System.Drawing.Point(177, 374);
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Size = new System.Drawing.Size(75, 23);
            this.btnAddModify.TabIndex = 39;
            this.btnAddModify.Text = "Aggiungi";
            this.btnAddModify.UseVisualStyleBackColor = true;
            this.btnAddModify.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(26, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Tipo_veicolo
            // 
            this.Tipo_veicolo.FormattingEnabled = true;
            this.Tipo_veicolo.Items.AddRange(new object[] {
            "AUTO",
            "MOTO"});
            this.Tipo_veicolo.Location = new System.Drawing.Point(87, 12);
            this.Tipo_veicolo.Name = "Tipo_veicolo";
            this.Tipo_veicolo.Size = new System.Drawing.Size(121, 21);
            this.Tipo_veicolo.TabIndex = 22;
            this.Tipo_veicolo.SelectedIndexChanged += new System.EventHandler(this.Tipo_veicolo_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FormGestione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 409);
            this.Controls.Add(this.nPrezzo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nKmFatti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkKm0);
            this.Controls.Add(this.chkUsato);
            this.Controls.Add(this.nAirbag);
            this.Controls.Add(this.lblNAirbag);
            this.Controls.Add(this.txtSella);
            this.Controls.Add(this.lblSaddleBrand);
            this.Controls.Add(this.DataMatricolazione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nPotenza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nCilindrata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddModify);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Tipo_veicolo);
            this.Name = "FormGestione";
            this.Text = "FormGestione";
            ((System.ComponentModel.ISupportInitialize)(this.nPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKmFatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAirbag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPotenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nPrezzo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nKmFatti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkKm0;
        private System.Windows.Forms.CheckBox chkUsato;
        private System.Windows.Forms.NumericUpDown nAirbag;
        private System.Windows.Forms.Label lblNAirbag;
        private System.Windows.Forms.TextBox txtSella;
        private System.Windows.Forms.Label lblSaddleBrand;
        private System.Windows.Forms.DateTimePicker DataMatricolazione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nPotenza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nCilindrata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox Tipo_veicolo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ErrorProvider error;
    }
}