namespace WindowsFormsApp2
{
    partial class Form3
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
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrescWiadomosci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.Ustawienia = new System.Windows.Forms.GroupBox();
            this.chbssl = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Ustawienia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do:";
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(229, 48);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(536, 22);
            this.txtDo.TabIndex = 0;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(229, 86);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(536, 22);
            this.txtCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC:";
            // 
            // txtTemat
            // 
            this.txtTemat.Location = new System.Drawing.Point(229, 123);
            this.txtTemat.Name = "txtTemat";
            this.txtTemat.Size = new System.Drawing.Size(536, 22);
            this.txtTemat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temat:";
            // 
            // txtTrescWiadomosci
            // 
            this.txtTrescWiadomosci.Location = new System.Drawing.Point(229, 160);
            this.txtTrescWiadomosci.Multiline = true;
            this.txtTrescWiadomosci.Name = "txtTrescWiadomosci";
            this.txtTrescWiadomosci.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrescWiadomosci.Size = new System.Drawing.Size(536, 261);
            this.txtTrescWiadomosci.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tresc wiadomosci:";
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(353, 49);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 33);
            this.btnWyslij.TabIndex = 5;
            this.btnWyslij.Text = "Wyslij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // Ustawienia
            // 
            this.Ustawienia.Controls.Add(this.txtsmtp);
            this.Ustawienia.Controls.Add(this.chbssl);
            this.Ustawienia.Controls.Add(this.btnWyslij);
            this.Ustawienia.Controls.Add(this.label8);
            this.Ustawienia.Controls.Add(this.txtPort);
            this.Ustawienia.Controls.Add(this.label7);
            this.Ustawienia.Controls.Add(this.txtHaslo);
            this.Ustawienia.Controls.Add(this.label5);
            this.Ustawienia.Controls.Add(this.txtImie);
            this.Ustawienia.Controls.Add(this.label6);
            this.Ustawienia.Location = new System.Drawing.Point(229, 431);
            this.Ustawienia.Name = "Ustawienia";
            this.Ustawienia.Size = new System.Drawing.Size(536, 116);
            this.Ustawienia.TabIndex = 3;
            this.Ustawienia.TabStop = false;
            this.Ustawienia.Text = "Ustawienia";
            // 
            // chbssl
            // 
            this.chbssl.Location = new System.Drawing.Point(353, 22);
            this.chbssl.Name = "chbssl";
            this.chbssl.Size = new System.Drawing.Size(75, 21);
            this.chbssl.TabIndex = 1;
            this.chbssl.Text = "SSL";
            this.chbssl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Smtp:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(114, 87);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(74, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Port:";
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(114, 60);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(191, 22);
            this.txtHaslo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Haslo:";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(114, 22);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(191, 22);
            this.txtImie.TabIndex = 0;
            this.txtImie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtImie_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nick:";
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(254, 87);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(207, 22);
            this.txtsmtp.TabIndex = 15;
            this.txtsmtp.Text = "smtp.gmail.com";
            this.txtsmtp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtsmtp_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pomoc techniczna:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "pomoc_techniczna@1win1.com.pl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "administracja@1win1.com.pl";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Administracja:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "bezpieczenstwo@1win1.com.pl";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Dzial bezpieczenstwa:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 572);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ustawienia);
            this.Controls.Add(this.txtTrescWiadomosci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTemat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wyslij mail";
            this.Ustawienia.ResumeLayout(false);
            this.Ustawienia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrescWiadomosci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.GroupBox Ustawienia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbssl;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}