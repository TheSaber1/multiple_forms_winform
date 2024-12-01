namespace ÇokluFormYönetimi
{
    partial class KayitOl
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            kullaniciaditextbox = new TextBox();
            sifretextbox = new TextBox();
            sifretekrartextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kayitbutton = new Button();
            girisformadonmebutton = new Button();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(193, 62);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 0;
            label1.Text = "ArdaFlix";
            // 
            // kullaniciaditextbox
            // 
            kullaniciaditextbox.Location = new Point(59, 154);
            kullaniciaditextbox.Name = "kullaniciaditextbox";
            kullaniciaditextbox.Size = new Size(361, 23);
            kullaniciaditextbox.TabIndex = 1;
            // 
            // sifretextbox
            // 
            sifretextbox.Location = new Point(59, 204);
            sifretextbox.Name = "sifretextbox";
            sifretextbox.Size = new Size(361, 23);
            sifretextbox.TabIndex = 2;
            // 
            // sifretekrartextbox
            // 
            sifretekrartextbox.Location = new Point(59, 254);
            sifretekrartextbox.Name = "sifretekrartextbox";
            sifretekrartextbox.Size = new Size(361, 23);
            sifretekrartextbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 127);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 180);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 230);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 6;
            label4.Text = "Şifre Doğrulama";
            // 
            // kayitbutton
            // 
            kayitbutton.BackColor = Color.Red;
            kayitbutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kayitbutton.Location = new Point(59, 300);
            kayitbutton.Name = "kayitbutton";
            kayitbutton.Size = new Size(361, 65);
            kayitbutton.TabIndex = 7;
            kayitbutton.Text = "Kayıt Ol";
            kayitbutton.UseVisualStyleBackColor = false;
            kayitbutton.Click += kayitbutton_Click;
            // 
            // girisformadonmebutton
            // 
            girisformadonmebutton.BackColor = Color.Red;
            girisformadonmebutton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            girisformadonmebutton.Location = new Point(59, 392);
            girisformadonmebutton.Name = "girisformadonmebutton";
            girisformadonmebutton.Size = new Size(361, 45);
            girisformadonmebutton.TabIndex = 8;
            girisformadonmebutton.Text = "Giriş Yapma Sayfasına İlerle";
            girisformadonmebutton.UseVisualStyleBackColor = false;
            girisformadonmebutton.Click += girisformadonmebutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 368);
            label5.Name = "label5";
            label5.Size = new Size(174, 21);
            label5.TabIndex = 9;
            label5.Text = "Hesabınız Mevcut Mu ? ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 461);
            Controls.Add(label5);
            Controls.Add(girisformadonmebutton);
            Controls.Add(kayitbutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sifretekrartextbox);
            Controls.Add(sifretextbox);
            Controls.Add(kullaniciaditextbox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayıtOl";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kullaniciaditextbox;
        private TextBox sifretextbox;
        private TextBox sifretekrartextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button kayitbutton;
        private Button girisformadonmebutton;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}
