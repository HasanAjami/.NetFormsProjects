
namespace Busfahrkarten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.anzahlHaltstellen = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Alter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlHaltstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alter)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(533, 66);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 68);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // anzahlHaltstellen
            // 
            this.anzahlHaltstellen.Location = new System.Drawing.Point(363, 66);
            this.anzahlHaltstellen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.anzahlHaltstellen.Name = "anzahlHaltstellen";
            this.anzahlHaltstellen.Size = new System.Drawing.Size(120, 38);
            this.anzahlHaltstellen.TabIndex = 1;
            this.anzahlHaltstellen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.anzahlHaltstellen.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 149);
            this.textBox1.TabIndex = 2;
            // 
            // Alter
            // 
            this.Alter.Location = new System.Drawing.Point(363, 123);
            this.Alter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(120, 38);
            this.Alter.TabIndex = 3;
            this.Alter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anzahl Haltstellen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.anzahlHaltstellen);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anzahlHaltstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown anzahlHaltstellen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown Alter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

