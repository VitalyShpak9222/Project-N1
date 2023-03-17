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
    public partial class UserFormFristIdea : Form
    {
        public UserFormFristIdea()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;            
        }
        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void add_Form(Form form)
        {
            form.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(form);
            form.BringToFront();
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    Panel btn = (Panel)sender;
        //    switch (btn.Name)
        //    {
        //        case "taskShowButton":
        //            add_UControls(new UC_Tasks());
        //            break;
        //        case "messageShowButton":
        //            add_UControls(new UC_Messages());
        //            break;
        //        case "makeRequestButton":
        //            add_Form(new MakeRequest());
        //            break;
        //        case "settingsButton":
        //            add_UControls(new UC_Settings());
        //            break;
        //    }
        //}
        private void Category_MouseEnter(object sender, EventArgs e)
        {
            Panel category = (Panel)sender;
            switch (category.Name)
            {
                case "category1":
                    break;
                case "messageShowButton":
                    
                    break;
                case "makeRequestButton":
                    
                    break;
                case "settingsButton":
                    
                    break;
            }
        }

        #region *Exit*
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.FromArgb(255, 222, 95, 96);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.FromName("ControlText");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new EntryForm().Show();
        }
        #endregion

    }
}
