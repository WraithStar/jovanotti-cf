namespace Jovanotti
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCopyTextToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(31, 153);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(285, 92);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Inserisci il testo da tradurre qui";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(31, 277);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(285, 92);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.Text = "Il tefto tradotto verrá moftrato qui";
            // 
            // buttonCopyTextToClipboard
            // 
            this.buttonCopyTextToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyTextToClipboard.Location = new System.Drawing.Point(50, 388);
            this.buttonCopyTextToClipboard.Name = "buttonCopyTextToClipboard";
            this.buttonCopyTextToClipboard.Size = new System.Drawing.Size(240, 23);
            this.buttonCopyTextToClipboard.TabIndex = 2;
            this.buttonCopyTextToClipboard.Text = "Clicca per copiare tutto il tefto tradotto";
            this.buttonCopyTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyTextToClipboard.Click += new System.EventHandler(this.buttonCopyTextToClipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jovanotti.Properties.Resources.jovawp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCopyTextToClipboard);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jovanotti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCopyTextToClipboard;
    }
}

