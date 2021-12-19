
namespace popitka
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistLable = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.RegistLable);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 401);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // RegistLable
            // 
            this.RegistLable.AutoSize = true;
            this.RegistLable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistLable.ForeColor = System.Drawing.Color.DarkGreen;
            this.RegistLable.Location = new System.Drawing.Point(129, 376);
            this.RegistLable.Name = "RegistLable";
            this.RegistLable.Size = new System.Drawing.Size(134, 16);
            this.RegistLable.TabIndex = 6;
            this.RegistLable.Text = "Еще нет аккаунта?";
            this.RegistLable.Click += new System.EventHandler(this.RegistLable_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(132, 318);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(135, 48);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(99, 224);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(281, 64);
            this.pass.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(99, 138);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(281, 64);
            this.log.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.closeButt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 89);
            this.panel2.TabIndex = 0;
            // 
            // closeButt
            // 
            this.closeButt.AutoSize = true;
            this.closeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButt.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButt.Location = new System.Drawing.Point(380, 0);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(20, 23);
            this.closeButt.TabIndex = 1;
            this.closeButt.Text = "x";
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            this.closeButt.MouseEnter += new System.EventHandler(this.closeButt_MouseEnter);
            this.closeButt.MouseLeave += new System.EventHandler(this.closeButt_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(156)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 401);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label RegistLable;
    }
}