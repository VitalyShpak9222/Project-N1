using MySql.Data.MySqlClient;
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
        bool FoldClicked = false;
        Form Background;
        public UserForm(Form background)
        {
            Background = background;
        }
        UInt32 Id { get; }
        public UserForm(UInt32 id)
        {
            Id = id;
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(48, 48);
        }
        public UserForm()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(50, 50);
        }
        private void labelSend_Click(object sender, EventArgs e)
        {
            if (labelSendMessages.Text != "")
            {
                string newText = "\n" + labelSendMessages.Text;
                label2.Text = newText + label2.Text;
                //label2.Size = new System.Drawing.Size(labelSendMessages.Size.Height + 16, 200);
                labelSendMessages.Text = "";
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
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `problems` (`Priority`, `Applicant`, `Description`, `StartDate`, `EndDate`, `Department`, `Report`) " +
                    "VALUES (@priority, @applicant, @description, @startDate, @endDate, @department, @report)", db.getConnection());
                
                command.Parameters.Add("@priority", MySqlDbType.UInt32).Value = 0;
                command.Parameters.Add("@applicant", MySqlDbType.UInt32).Value = Id;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description.Text;
                command.Parameters.Add("@startDate", MySqlDbType.Date).Value = new DateTime(2000, 01, 1);
                command.Parameters.Add("@endDate", MySqlDbType.Date).Value = new DateTime(2000, 02, 1);
                command.Parameters.Add("@department", MySqlDbType.UInt32).Value = 0;
                command.Parameters.Add("@report", MySqlDbType.VarChar).Value = "";

                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();

                description.Text = "";
            }
            else
                MessageBox.Show("Ошибка! Описание пусто."); 
        }

        private void UserFormTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }
        public void Fold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
