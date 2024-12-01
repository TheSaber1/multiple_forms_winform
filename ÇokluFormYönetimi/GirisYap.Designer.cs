namespace ÇokluFormYönetimi
{
    partial class GirisYap
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
            label1 = new Label();
            label2 = new Label();
            usernametextbox = new TextBox();
            label3 = new Label();
            passwordtextbox = new TextBox();
            girisyapbutton = new Button();
            kayitolmasayfasibutton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(193, 62);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 0;
            label1.Text = "ArdaFlix";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 136);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 5;
            label2.Text = "Kullanıcı Adı";
            // 
            // usernametextbox
            // 
            usernametextbox.Location = new Point(59, 163);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.Size = new Size(361, 23);
            usernametextbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 211);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 7;
            label3.Text = "Şifre";
            // 
            // passwordtextbox
            // 
            passwordtextbox.Location = new Point(59, 244);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.Size = new Size(361, 23);
            passwordtextbox.TabIndex = 8;
            // 
            // girisyapbutton
            // 
            girisyapbutton.BackColor = Color.Red;
            girisyapbutton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            girisyapbutton.Location = new Point(59, 300);
            girisyapbutton.Name = "girisyapbutton";
            girisyapbutton.Size = new Size(361, 65);
            girisyapbutton.TabIndex = 9;
            girisyapbutton.Text = "Giriş Yap";
            girisyapbutton.UseVisualStyleBackColor = false;
            girisyapbutton.Click += girisyapbutton_Click;
            // 
            // kayitolmasayfasibutton
            // 
            kayitolmasayfasibutton.BackColor = Color.Red;
            kayitolmasayfasibutton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kayitolmasayfasibutton.Location = new Point(59, 392);
            kayitolmasayfasibutton.Name = "kayitolmasayfasibutton";
            kayitolmasayfasibutton.Size = new Size(361, 45);
            kayitolmasayfasibutton.TabIndex = 10;
            kayitolmasayfasibutton.Text = "Kayıt Olma Sayfasına Git";
            kayitolmasayfasibutton.UseVisualStyleBackColor = false;
            kayitolmasayfasibutton.Click += kayitolmasayfasibutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 368);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 11;
            label4.Text = "Hesabın yok mu ?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(484, 461);
            Controls.Add(label4);
            Controls.Add(kayitolmasayfasibutton);
            Controls.Add(girisyapbutton);
            Controls.Add(passwordtextbox);
            Controls.Add(label3);
            Controls.Add(usernametextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirişYap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernametextbox;
        private Label label3;
        private TextBox passwordtextbox;
        private Button girisyapbutton;
        private Button kayitolmasayfasibutton;
        private Label label4;
    }
}