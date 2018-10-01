namespace TerbilangApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.nilainominal = new System.Windows.Forms.TextBox();
            this.btnTerbilang = new System.Windows.Forms.Button();
            this.hasilTerbilang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // nilainominal
            // 
            this.nilainominal.Location = new System.Drawing.Point(103, 39);
            this.nilainominal.Name = "nilainominal";
            this.nilainominal.Size = new System.Drawing.Size(241, 20);
            this.nilainominal.TabIndex = 2;
            // 
            // btnTerbilang
            // 
            this.btnTerbilang.Location = new System.Drawing.Point(368, 37);
            this.btnTerbilang.Name = "btnTerbilang";
            this.btnTerbilang.Size = new System.Drawing.Size(75, 23);
            this.btnTerbilang.TabIndex = 3;
            this.btnTerbilang.Text = "Terbilang";
            this.btnTerbilang.UseVisualStyleBackColor = true;
            this.btnTerbilang.Click += new System.EventHandler(this.btnTerbilang_Click);
            // 
            // hasilTerbilang
            // 
            this.hasilTerbilang.FormattingEnabled = true;
            this.hasilTerbilang.Location = new System.Drawing.Point(103, 94);
            this.hasilTerbilang.Name = "hasilTerbilang";
            this.hasilTerbilang.Size = new System.Drawing.Size(760, 199);
            this.hasilTerbilang.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 326);
            this.Controls.Add(this.hasilTerbilang);
            this.Controls.Add(this.btnTerbilang);
            this.Controls.Add(this.nilainominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nilainominal;
        private System.Windows.Forms.Button btnTerbilang;
        private System.Windows.Forms.ListBox hasilTerbilang;
    }
}

