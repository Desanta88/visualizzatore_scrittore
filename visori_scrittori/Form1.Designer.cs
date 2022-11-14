namespace visori_scrittori
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxGrassetto = new System.Windows.Forms.CheckBox();
            this.checkBoxSottolineato = new System.Windows.Forms.CheckBox();
            this.checkBoxCorsvivo = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonColori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(198, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 204);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBoxGrassetto
            // 
            this.checkBoxGrassetto.AutoSize = true;
            this.checkBoxGrassetto.Location = new System.Drawing.Point(198, 298);
            this.checkBoxGrassetto.Name = "checkBoxGrassetto";
            this.checkBoxGrassetto.Size = new System.Drawing.Size(75, 19);
            this.checkBoxGrassetto.TabIndex = 1;
            this.checkBoxGrassetto.Text = "Grassetto";
            this.checkBoxGrassetto.UseVisualStyleBackColor = true;
            // 
            // checkBoxSottolineato
            // 
            this.checkBoxSottolineato.AutoSize = true;
            this.checkBoxSottolineato.Location = new System.Drawing.Point(301, 298);
            this.checkBoxSottolineato.Name = "checkBoxSottolineato";
            this.checkBoxSottolineato.Size = new System.Drawing.Size(90, 19);
            this.checkBoxSottolineato.TabIndex = 2;
            this.checkBoxSottolineato.Text = "Sottolineato";
            this.checkBoxSottolineato.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorsvivo
            // 
            this.checkBoxCorsvivo.AutoSize = true;
            this.checkBoxCorsvivo.Location = new System.Drawing.Point(406, 298);
            this.checkBoxCorsvivo.Name = "checkBoxCorsvivo";
            this.checkBoxCorsvivo.Size = new System.Drawing.Size(66, 19);
            this.checkBoxCorsvivo.TabIndex = 3;
            this.checkBoxCorsvivo.Text = "Corsivo";
            this.checkBoxCorsvivo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonColori
            // 
            this.buttonColori.Location = new System.Drawing.Point(503, 298);
            this.buttonColori.Name = "buttonColori";
            this.buttonColori.Size = new System.Drawing.Size(90, 23);
            this.buttonColori.TabIndex = 6;
            this.buttonColori.Text = "scegli il colore";
            this.buttonColori.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonColori);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxCorsvivo);
            this.Controls.Add(this.checkBoxSottolineato);
            this.Controls.Add(this.checkBoxGrassetto);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private CheckBox checkBoxGrassetto;
        private CheckBox checkBoxSottolineato;
        private CheckBox checkBoxCorsvivo;
        private ComboBox comboBox1;
        private Button buttonColori;
    }
}