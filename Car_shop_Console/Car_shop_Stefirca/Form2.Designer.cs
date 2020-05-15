namespace Car_shop_Stefirca
{
    partial class FormDialogVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogVehicle));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tlbUpload = new System.Windows.Forms.ToolStripButton();
            this.nmuPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmuKmDone = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkIsKmZero = new System.Windows.Forms.CheckBox();
            this.chkIsUsed = new System.Windows.Forms.CheckBox();
            this.nmuAirbag = new System.Windows.Forms.NumericUpDown();
            this.lblNAirbag = new System.Windows.Forms.Label();
            this.txtSaddleBrand = new System.Windows.Forms.TextBox();
            this.lblSaddleBrand = new System.Windows.Forms.Label();
            this.dtpMatriculation = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nmuPower = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmuDisplacement = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKmDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAirbag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDisplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbUpload});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(296, 27);
            this.toolStrip.TabIndex = 40;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tlbUpload
            // 
            this.tlbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbUpload.Image = ((System.Drawing.Image)(resources.GetObject("tlbUpload.Image")));
            this.tlbUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbUpload.Name = "tlbUpload";
            this.tlbUpload.Size = new System.Drawing.Size(24, 24);
            this.tlbUpload.Text = "&Carica immagine";
            // 
            // nmuPrice
            // 
            this.nmuPrice.Location = new System.Drawing.Point(127, 317);
            this.nmuPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmuPrice.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nmuPrice.Name = "nmuPrice";
            this.nmuPrice.Size = new System.Drawing.Size(99, 20);
            this.nmuPrice.TabIndex = 35;
            this.nmuPrice.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Prezzo:";
            // 
            // nmuKmDone
            // 
            this.nmuKmDone.Location = new System.Drawing.Point(127, 290);
            this.nmuKmDone.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmuKmDone.Name = "nmuKmDone";
            this.nmuKmDone.Size = new System.Drawing.Size(99, 20);
            this.nmuKmDone.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Chilometri percorsi:";
            // 
            // chkIsKmZero
            // 
            this.chkIsKmZero.AutoSize = true;
            this.chkIsKmZero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsKmZero.Location = new System.Drawing.Point(129, 263);
            this.chkIsKmZero.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsKmZero.Name = "chkIsKmZero";
            this.chkIsKmZero.Size = new System.Drawing.Size(98, 17);
            this.chkIsKmZero.TabIndex = 27;
            this.chkIsKmZero.Text = "Chilometro zero";
            this.chkIsKmZero.UseVisualStyleBackColor = true;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.AutoSize = true;
            this.chkIsUsed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsUsed.Location = new System.Drawing.Point(29, 261);
            this.chkIsUsed.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(54, 17);
            this.chkIsUsed.TabIndex = 23;
            this.chkIsUsed.Text = "Usato";
            this.chkIsUsed.UseVisualStyleBackColor = true;
            // 
            // nmuAirbag
            // 
            this.nmuAirbag.Location = new System.Drawing.Point(127, 341);
            this.nmuAirbag.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmuAirbag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmuAirbag.Name = "nmuAirbag";
            this.nmuAirbag.Size = new System.Drawing.Size(99, 20);
            this.nmuAirbag.TabIndex = 36;
            this.nmuAirbag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNAirbag
            // 
            this.lblNAirbag.AutoSize = true;
            this.lblNAirbag.Location = new System.Drawing.Point(27, 343);
            this.lblNAirbag.Name = "lblNAirbag";
            this.lblNAirbag.Size = new System.Drawing.Size(80, 13);
            this.lblNAirbag.TabIndex = 21;
            this.lblNAirbag.Text = "Numero Airbag:";
            // 
            // txtSaddleBrand
            // 
            this.txtSaddleBrand.Location = new System.Drawing.Point(125, 367);
            this.txtSaddleBrand.Name = "txtSaddleBrand";
            this.txtSaddleBrand.Size = new System.Drawing.Size(100, 20);
            this.txtSaddleBrand.TabIndex = 37;
            // 
            // lblSaddleBrand
            // 
            this.lblSaddleBrand.AutoSize = true;
            this.lblSaddleBrand.Location = new System.Drawing.Point(28, 364);
            this.lblSaddleBrand.Name = "lblSaddleBrand";
            this.lblSaddleBrand.Size = new System.Drawing.Size(64, 13);
            this.lblSaddleBrand.TabIndex = 20;
            this.lblSaddleBrand.Text = "Marca sella:";
            // 
            // dtpMatriculation
            // 
            this.dtpMatriculation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatriculation.Location = new System.Drawing.Point(127, 234);
            this.dtpMatriculation.MaxDate = new System.DateTime(2019, 12, 13, 0, 0, 0, 0);
            this.dtpMatriculation.Name = "dtpMatriculation";
            this.dtpMatriculation.Size = new System.Drawing.Size(100, 20);
            this.dtpMatriculation.TabIndex = 33;
            this.dtpMatriculation.Value = new System.DateTime(2019, 12, 4, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Immatricolazione:";
            // 
            // nmuPower
            // 
            this.nmuPower.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmuPower.Location = new System.Drawing.Point(126, 188);
            this.nmuPower.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmuPower.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmuPower.Name = "nmuPower";
            this.nmuPower.Size = new System.Drawing.Size(99, 20);
            this.nmuPower.TabIndex = 32;
            this.nmuPower.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Potenza:";
            // 
            // nmuDisplacement
            // 
            this.nmuDisplacement.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmuDisplacement.Location = new System.Drawing.Point(126, 162);
            this.nmuDisplacement.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmuDisplacement.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmuDisplacement.Name = "nmuDisplacement";
            this.nmuDisplacement.Size = new System.Drawing.Size(99, 20);
            this.nmuDisplacement.TabIndex = 31;
            this.nmuDisplacement.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cilindrata:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(126, 136);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Colore:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(125, 110);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Modello:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(125, 84);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marca:";
            // 
            // btnAddModify
            // 
            this.btnAddModify.Location = new System.Drawing.Point(200, 410);
            this.btnAddModify.Name = "btnAddModify";
            this.btnAddModify.Size = new System.Drawing.Size(75, 23);
            this.btnAddModify.TabIndex = 39;
            this.btnAddModify.Text = "AGGIUNGI";
            this.btnAddModify.UseVisualStyleBackColor = true;
            this.btnAddModify.Click += new System.EventHandler(this.btnAddModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "ANNULLA";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "AUTO",
            "MOTO"});
            this.cmbVehicleType.Location = new System.Drawing.Point(78, 30);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(121, 21);
            this.cmbVehicleType.TabIndex = 22;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FormDialogVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.nmuPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmuKmDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkIsKmZero);
            this.Controls.Add(this.chkIsUsed);
            this.Controls.Add(this.nmuAirbag);
            this.Controls.Add(this.lblNAirbag);
            this.Controls.Add(this.txtSaddleBrand);
            this.Controls.Add(this.lblSaddleBrand);
            this.Controls.Add(this.dtpMatriculation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmuPower);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmuDisplacement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddModify);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbVehicleType);
            this.Name = "FormDialogVehicle";
            this.Text = "Form2";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuKmDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAirbag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuDisplacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tlbUpload;
        private System.Windows.Forms.NumericUpDown nmuPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmuKmDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkIsKmZero;
        private System.Windows.Forms.CheckBox chkIsUsed;
        private System.Windows.Forms.NumericUpDown nmuAirbag;
        private System.Windows.Forms.Label lblNAirbag;
        private System.Windows.Forms.TextBox txtSaddleBrand;
        private System.Windows.Forms.Label lblSaddleBrand;
        private System.Windows.Forms.DateTimePicker dtpMatriculation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmuPower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmuDisplacement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ErrorProvider error;
    }
}