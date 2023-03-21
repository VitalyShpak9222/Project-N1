using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(48, 48);
        }
        private void labelSend_Click(object sender, EventArgs e)
        {
            if (this.labelSendMessages.Text != "")
            {
                string newText = "\n" + this.labelSendMessages.Text;
                this.labelSendMessages.Text = newText + this.labelSendMessages.Text;
                this.labelSendMessages.Size = new System.Drawing.Size(labelSendMessages.Size.Height + 16, 200);
            }

        }
        #region *ExitButton*
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.FromArgb(255, 222, 95, 96);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.FromName("ControlText");
        }
        #endregion

        private void Object_MouseEnter(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.BorderStyle = BorderStyle.Fixed3D;
        }
        private void Oblject_MouseLeave(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.BorderStyle = BorderStyle.FixedSingle;
        }

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            if (description.Text != "")
            {          
                MessageBox.Show(description.Text);
                description.Text = "";
            }
            else
                MessageBox.Show("Ошибка! Описание пусто."); 
        }

        private void UserFormTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 4)
            {
                e.Cancel = true;
            }
            if (e.TabPageIndex == 5)
            {
                Application.Exit();
            }
        }
    }
}
