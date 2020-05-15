namespace Car_shop_Stefirca
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Nuovo = new System.Windows.Forms.ToolStripButton();
            this.ToolSalva = new System.Windows.Forms.ToolStripButton();
            this.ToolCancella = new System.Windows.Forms.ToolStripButton();
            this.ToolModifica = new System.Windows.Forms.ToolStripButton();
            this.ToolWord = new System.Windows.Forms.ToolStripButton();
            this.ToolExcel = new System.Windows.Forms.ToolStripButton();
            this.ToolStampa = new System.Windows.Forms.ToolStripButton();
            this.ListBoxV = new System.Windows.Forms.ListBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuovo,
            this.ToolSalva,
            this.ToolCancella,
            this.ToolModifica,
            this.ToolWord,
            this.ToolExcel,
            this.ToolStampa});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(488, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // Nuovo
            // 
            this.Nuovo.Image = ((System.Drawing.Image)(resources.GetObject("Nuovo.Image")));
            this.Nuovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuovo.Name = "Nuovo";
            this.Nuovo.Size = new System.Drawing.Size(67, 24);
            this.Nuovo.Text = "&Nuovo";
            this.Nuovo.Click += new System.EventHandler(this.Nuovo_Click);
            // 
            // ToolSalva
            // 
            this.ToolSalva.Image = ((System.Drawing.Image)(resources.GetObject("ToolSalva.Image")));
            this.ToolSalva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSalva.Name = "ToolSalva";
            this.ToolSalva.Size = new System.Drawing.Size(58, 24);
            this.ToolSalva.Text = "&Salva";
            this.ToolSalva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // ToolCancella
            // 
            this.ToolCancella.Image = ((System.Drawing.Image)(resources.GetObject("ToolCancella.Image")));
            this.ToolCancella.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCancella.Name = "ToolCancella";
            this.ToolCancella.Size = new System.Drawing.Size(70, 24);
            this.ToolCancella.Text = "&Elimina";
            this.ToolCancella.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // ToolModifica
            // 
            this.ToolModifica.Image = ((System.Drawing.Image)(resources.GetObject("ToolModifica.Image")));
            this.ToolModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolModifica.Name = "ToolModifica";
            this.ToolModifica.Size = new System.Drawing.Size(78, 24);
            this.ToolModifica.Text = "&Modifica";
            this.ToolModifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // ToolWord
            // 
            this.ToolWord.Image = ((System.Drawing.Image)(resources.GetObject("ToolWord.Image")));
            this.ToolWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolWord.Name = "ToolWord";
            this.ToolWord.Size = new System.Drawing.Size(60, 24);
            this.ToolWord.Text = "&Word";
            this.ToolWord.Click += new System.EventHandler(this.Word_Click);
            // 
            // ToolExcel
            // 
            this.ToolExcel.Image = ((System.Drawing.Image)(resources.GetObject("ToolExcel.Image")));
            this.ToolExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolExcel.Name = "ToolExcel";
            this.ToolExcel.Size = new System.Drawing.Size(58, 24);
            this.ToolExcel.Text = "E&xcel";
            this.ToolExcel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // ToolStampa
            // 
            this.ToolStampa.Image = ((System.Drawing.Image)(resources.GetObject("ToolStampa.Image")));
            this.ToolStampa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStampa.Name = "ToolStampa";
            this.ToolStampa.Size = new System.Drawing.Size(71, 24);
            this.ToolStampa.Text = "Stam&pa";
            this.ToolStampa.Click += new System.EventHandler(this.Stampa_Click);
            // 
            // ListBoxV
            // 
            this.ListBoxV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxV.FormattingEnabled = true;
            this.ListBoxV.Location = new System.Drawing.Point(0, 27);
            this.ListBoxV.Name = "ListBoxV";
            this.ListBoxV.Size = new System.Drawing.Size(488, 245);
            this.ListBoxV.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 272);
            this.Controls.Add(this.ListBoxV);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Autosalone";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Nuovo;
        private System.Windows.Forms.ToolStripButton ToolSalva;
        private System.Windows.Forms.ToolStripButton ToolCancella;
        private System.Windows.Forms.ToolStripButton ToolModifica;
        private System.Windows.Forms.ToolStripButton ToolWord;
        private System.Windows.Forms.ToolStripButton ToolExcel;
        private System.Windows.Forms.ToolStripButton ToolStampa;
        private System.Windows.Forms.ListBox ListBoxV;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}

