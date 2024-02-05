namespace parametrealmayan_geridegerdondürmeyen
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbSari = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(70, 69);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(48, 17);
            this.rbMavi.TabIndex = 1;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(70, 92);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(54, 17);
            this.rbKirmizi.TabIndex = 2;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            // 
            // rbSari
            // 
            this.rbSari.AutoSize = true;
            this.rbSari.Location = new System.Drawing.Point(73, 115);
            this.rbSari.Name = "rbSari";
            this.rbSari.Size = new System.Drawing.Size(43, 17);
            this.rbSari.TabIndex = 3;
            this.rbSari.TabStop = true;
            this.rbSari.Text = "Sarı";
            this.rbSari.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbSari);
            this.Controls.Add(this.rbKirmizi);
            this.Controls.Add(this.rbMavi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.RadioButton rbSari;
    }
}

