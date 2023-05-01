namespace PI_Zadaća1
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
            this.imeprezime = new System.Windows.Forms.TextBox();
            this.fakultet = new System.Windows.Forms.TextBox();
            this.godina = new System.Windows.Forms.TextBox();
            this.grad = new System.Windows.Forms.TextBox();
            this.uloga = new System.Windows.Forms.TextBox();
            this.ovisi = new System.Windows.Forms.TextBox();
            this.datoteka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imeprezime
            // 
            this.imeprezime.Location = new System.Drawing.Point(116, 97);
            this.imeprezime.Name = "imeprezime";
            this.imeprezime.Size = new System.Drawing.Size(100, 20);
            this.imeprezime.TabIndex = 0;
            // 
            // fakultet
            // 
            this.fakultet.Location = new System.Drawing.Point(116, 204);
            this.fakultet.Name = "fakultet";
            this.fakultet.Size = new System.Drawing.Size(100, 20);
            this.fakultet.TabIndex = 1;
            this.fakultet.TextChanged += new System.EventHandler(this.prezime_TextChanged);
            // 
            // godina
            // 
            this.godina.Location = new System.Drawing.Point(116, 132);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(100, 20);
            this.godina.TabIndex = 2;
            // 
            // grad
            // 
            this.grad.Location = new System.Drawing.Point(116, 168);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(100, 20);
            this.grad.TabIndex = 3;
            // 
            // uloga
            // 
            this.uloga.Location = new System.Drawing.Point(116, 240);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(100, 20);
            this.uloga.TabIndex = 4;
            this.uloga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ovisi
            // 
            this.ovisi.Location = new System.Drawing.Point(116, 271);
            this.ovisi.Name = "ovisi";
            this.ovisi.Size = new System.Drawing.Size(100, 20);
            this.ovisi.TabIndex = 5;
            // 
            // datoteka
            // 
            this.datoteka.Location = new System.Drawing.Point(12, 30);
            this.datoteka.Name = "datoteka";
            this.datoteka.Size = new System.Drawing.Size(104, 23);
            this.datoteka.TabIndex = 6;
            this.datoteka.Text = "Odaberi datoteku";
            this.datoteka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime i prezime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Godina rođenja";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mjesto rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fakultet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uloga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "*ovisi o ulozi*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datoteka);
            this.Controls.Add(this.ovisi);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.grad);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.fakultet);
            this.Controls.Add(this.imeprezime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imeprezime;
        private System.Windows.Forms.TextBox fakultet;
        private System.Windows.Forms.TextBox godina;
        private System.Windows.Forms.TextBox grad;
        private System.Windows.Forms.TextBox uloga;
        private System.Windows.Forms.TextBox ovisi;
        private System.Windows.Forms.Button datoteka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

