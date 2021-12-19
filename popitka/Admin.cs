using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popitka
{
    public partial class formAdmin : Form
    {
        private Button currentButton;
        private Form activeForm;
        public formAdmin()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DeepSkyBlue;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void DisableButton()
        {
            throw new NotImplementedException();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //this.formAdmin.Controls.Add(childForm);
            //this.formAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Simulac S = new Simulac();
            S.Show();
        }
    }
}