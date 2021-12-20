
namespace popitka
{
    partial class registrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistLable = new System.Windows.Forms.Label();
            this.UserSernameFild = new System.Windows.Forms.TextBox();
            this.UserNameFild = new System.Windows.Forms.TextBox();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Candara", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(156)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.RegistLable);
            this.panel1.Controls.Add(this.UserSernameFild);
            this.panel1.Controls.Add(this.UserNameFild);
            this.panel1.Controls.Add(this.buttonRegistr);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 449);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // RegistLable
            // 
            this.RegistLable.AutoSize = true;
            this.RegistLable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistLable.ForeColor = System.Drawing.Color.DarkGreen;
            this.RegistLable.Location = new System.Drawing.Point(329, 406);
            this.RegistLable.Name = "RegistLable";
            this.RegistLable.Size = new System.Drawing.Size(116, 16);
            this.RegistLable.TabIndex = 8;
            this.RegistLable.Text = "Авторизоваться";
            this.RegistLable.Click += new System.EventHandler(this.RegistLable_Click);
            // 
            // UserSernameFild
            // 
            this.UserSernameFild.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSernameFild.Location = new System.Drawing.Point(480, 138);
            this.UserSernameFild.Multiline = true;
            this.UserSernameFild.Name = "UserSernameFild";
            this.UserSernameFild.Size = new System.Drawing.Size(281, 64);
            this.UserSernameFild.TabIndex = 7;
            this.UserSernameFild.Enter += new System.EventHandler(this.UserSernameFild_Enter);
            this.UserSernameFild.Leave += new System.EventHandler(this.UserSernameFild_Leave);
            // 
            // UserNameFild
            // 
            this.UserNameFild.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameFild.Location = new System.Drawing.Point(95, 138);
            this.UserNameFild.Multiline = true;
            this.UserNameFild.Name = "UserNameFild";
            this.UserNameFild.Size = new System.Drawing.Size(281, 64);
            this.UserNameFild.TabIndex = 6;
            this.UserNameFild.Enter += new System.EventHandler(this.UserNameFild_Enter);
            this.UserNameFild.Leave += new System.EventHandler(this.UserNameFild_Leave);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRegistr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRegistr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistr.Location = new System.Drawing.Point(262, 332);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(278, 48);
            this.buttonRegistr.TabIndex = 5;
            this.buttonRegistr.Text = "Зарегестрироваться";
            this.buttonRegistr.UseVisualStyleBackColor = true;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(480, 208);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(281, 64);
            this.pass.TabIndex = 4;
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(95, 208);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(281, 64);
            this.log.TabIndex = 2;
            this.log.Enter += new System.EventHandler(this.log_Enter);
            this.log.Leave += new System.EventHandler(this.log_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 208);
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
            this.panel2.Size = new System.Drawing.Size(790, 89);
            this.panel2.TabIndex = 0;
            // 
            // closeButt
            // 
            this.closeButt.AutoSize = true;
            this.closeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButt.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButt.Location = new System.Drawing.Point(759, 0);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(20, 23);
            this.closeButt.TabIndex = 1;
            this.closeButt.Text = "x";
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // registrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrForm";
            this.Text = "registrForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButt;
        private System.Windows.Forms.TextBox UserSernameFild;
        private System.Windows.Forms.TextBox UserNameFild;
        private System.Windows.Forms.Label RegistLable;
    }
}