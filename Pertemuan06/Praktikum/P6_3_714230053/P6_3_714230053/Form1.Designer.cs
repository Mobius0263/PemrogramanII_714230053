namespace P6_3_714230053
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.huruf = new System.Windows.Forms.Label();
            this.angka = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.angka12 = new System.Windows.Forms.Label();
            this.angka1 = new System.Windows.Forms.Label();
            this.angka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // huruf
            // 
            this.huruf.AutoSize = true;
            this.huruf.Location = new System.Drawing.Point(75, 68);
            this.huruf.Name = "huruf";
            this.huruf.Size = new System.Drawing.Size(49, 20);
            this.huruf.TabIndex = 0;
            this.huruf.Text = "Huruf";
            // 
            // angka
            // 
            this.angka.AutoSize = true;
            this.angka.Location = new System.Drawing.Point(75, 134);
            this.angka.Name = "angka";
            this.angka.Size = new System.Drawing.Size(55, 20);
            this.angka.TabIndex = 1;
            this.angka.Text = "Angka";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(75, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // angka12
            // 
            this.angka12.AutoSize = true;
            this.angka12.ForeColor = System.Drawing.Color.Red;
            this.angka12.Location = new System.Drawing.Point(75, 240);
            this.angka12.Name = "angka12";
            this.angka12.Size = new System.Drawing.Size(150, 20);
            this.angka12.TabIndex = 3;
            this.angka12.Text = "*Angka 1 > Angka 2";
            // 
            // angka1
            // 
            this.angka1.AutoSize = true;
            this.angka1.Location = new System.Drawing.Point(75, 291);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(68, 20);
            this.angka1.TabIndex = 4;
            this.angka1.Text = "Angka 1";
            // 
            // angka2
            // 
            this.angka2.AutoSize = true;
            this.angka2.Location = new System.Drawing.Point(75, 350);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(68, 20);
            this.angka2.TabIndex = 5;
            this.angka2.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(315, 62);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(186, 26);
            this.txtHuruf.TabIndex = 6;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(315, 128);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(186, 26);
            this.txtAngka.TabIndex = 7;
            this.txtAngka.TextChanged += new System.EventHandler(this.txtAngka_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(315, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 26);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(315, 285);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(186, 26);
            this.txtAngka1.TabIndex = 9;
            this.txtAngka1.TextChanged += new System.EventHandler(this.txtAngka1_TextChanged);
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(315, 344);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(186, 26);
            this.txtAngka2.TabIndex = 10;
            this.txtAngka2.TextChanged += new System.EventHandler(this.txtAngka2_TextChanged);
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.angka12);
            this.Controls.Add(this.email);
            this.Controls.Add(this.angka);
            this.Controls.Add(this.huruf);
            this.Name = "Form1";
            this.Text = "Validasi";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label huruf;
        private System.Windows.Forms.Label angka;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label angka12;
        private System.Windows.Forms.Label angka1;
        private System.Windows.Forms.Label angka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

