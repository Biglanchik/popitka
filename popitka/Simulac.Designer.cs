
namespace popitka
{
    partial class Simulac
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
            this.Start1 = new System.Windows.Forms.Button();
            this.Stop1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stop2 = new System.Windows.Forms.Button();
            this.Start2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(575, 96);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(75, 23);
            this.Start1.TabIndex = 0;
            this.Start1.Text = "Старт";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Stop1
            // 
            this.Stop1.Location = new System.Drawing.Point(695, 96);
            this.Stop1.Name = "Stop1";
            this.Stop1.Size = new System.Drawing.Size(75, 23);
            this.Stop1.TabIndex = 1;
            this.Stop1.Text = "Стоп";
            this.Stop1.UseVisualStyleBackColor = true;
            this.Stop1.Click += new System.EventHandler(this.Stop1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // closeButt
            // 
            this.closeButt.AutoSize = true;
            this.closeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButt.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButt.Location = new System.Drawing.Point(768, 9);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(20, 23);
            this.closeButt.TabIndex = 3;
            this.closeButt.Text = "x";
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Stop2
            // 
            this.Stop2.Location = new System.Drawing.Point(695, 147);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(75, 23);
            this.Stop2.TabIndex = 5;
            this.Stop2.Text = "Стоп";
            this.Stop2.UseVisualStyleBackColor = true;
            
            // 
            // Start2
            // 
            this.Start2.Location = new System.Drawing.Point(575, 147);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(75, 23);
            this.Start2.TabIndex = 4;
            this.Start2.Text = "Старт";
            this.Start2.UseVisualStyleBackColor = true;
            
            // 
            // Simulac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stop2);
            this.Controls.Add(this.Start2);
            this.Controls.Add(this.closeButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop1);
            this.Controls.Add(this.Start1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulac";
            this.Text = "Simulac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button Stop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Button Start2;
    }
}