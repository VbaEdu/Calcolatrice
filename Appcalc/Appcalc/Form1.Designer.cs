
namespace Appcalc
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSomma = new System.Windows.Forms.Button();
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.tbInsert2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSottrae = new System.Windows.Forms.Button();
            this.btnMoltiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 23);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "La mia prima calcolatrice";
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(275, 201);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(53, 30);
            this.btnSomma.TabIndex = 1;
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tbInsert
            // 
            this.tbInsert.Location = new System.Drawing.Point(253, 172);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Size = new System.Drawing.Size(48, 23);
            this.tbInsert.TabIndex = 3;
            // 
            // tbInsert2
            // 
            this.tbInsert2.Location = new System.Drawing.Point(307, 172);
            this.tbInsert2.Name = "tbInsert2";
            this.tbInsert2.Size = new System.Drawing.Size(48, 23);
            this.tbInsert2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // btnSottrae
            // 
            this.btnSottrae.Location = new System.Drawing.Point(275, 237);
            this.btnSottrae.Name = "btnSottrae";
            this.btnSottrae.Size = new System.Drawing.Size(53, 30);
            this.btnSottrae.TabIndex = 6;
            this.btnSottrae.Text = "-";
            this.btnSottrae.UseVisualStyleBackColor = true;
            this.btnSottrae.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnMoltiplica
            // 
            this.btnMoltiplica.Location = new System.Drawing.Point(275, 273);
            this.btnMoltiplica.Name = "btnMoltiplica";
            this.btnMoltiplica.Size = new System.Drawing.Size(53, 30);
            this.btnMoltiplica.TabIndex = 7;
            this.btnMoltiplica.Text = "x";
            this.btnMoltiplica.UseVisualStyleBackColor = true;
            this.btnMoltiplica.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(275, 309);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(53, 30);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(382, 172);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 23);
            this.tbResult.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Appcalc.Properties.Resources.calciPhone;
            this.pictureBox1.Location = new System.Drawing.Point(556, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(597, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 44);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMoltiplica);
            this.Controls.Add(this.btnSottrae);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInsert2);
            this.Controls.Add(this.tbInsert);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.TextBox tbInsert;
        private System.Windows.Forms.TextBox tbInsert2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSottrae;
        private System.Windows.Forms.Button btnMoltiplica;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

