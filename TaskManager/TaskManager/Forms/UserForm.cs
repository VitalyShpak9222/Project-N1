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
        UInt32 Id { get; }
        public UserForm(UInt32 id)
        {
            Id = id;
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(50, 50);
            EndDateTextBox.Text = "дд/мм/гггг";
            EndDateTextBox.ForeColor = Color.Gray;
            ShowTabToolTipBar();
        }
        public UserForm()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(50, 50);
            ShowTabToolTipBar();
        }
        private void ShowTabToolTipBar()
        {
            this.UserFormTabControl.ShowToolTips = true;
            this.Tasks.ToolTipText = "Проблемы";
            this.Messages.ToolTipText = "Сообщения";
            this.Requests.ToolTipText = "Оформление заявок";
            this.Settings.ToolTipText = "Настройки";
        }
        private bool IsEndDateInFormat()
        {
            string[] temp = EndDateTextBox.Text.Split('/');
            
            if (temp.Length == 3)
            {
                int day;
                int.TryParse(temp[0], out day);
                int month;
                int.TryParse(temp[1], out month);
                int year;
                int.TryParse(temp[2], out year);
                if (year >= DateTime.Now.Year && month <= 12 && month >= 1 && day <= DateTime.DaysInMonth(year, month) && day >= 1)
                    return true;
            }
            return false;
        }
        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (SendMessageText.Text != "")
            {
                string newText = "\n" + SendMessageText.Text + "\n" + DateTime.Now.ToString();
                YourMessageHistory.Text += newText;
                YourMessageHistory.Size = new System.Drawing.Size(SendMessageText.Size.Height + 1, 1);
                SendMessageText.Text = "";
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
            if (descriptionTextBox.Text != "" && EndDateTextBox.Text != "" && IsEndDateInFormat())
            {
                string[] stringDeadlineDate = EndDateTextBox.Text.Split('/');
                int[] deadlineDate = new int[3];
                for(int i = 0; i < stringDeadlineDate.Length; i++)
                {
                    deadlineDate[i] = int.Parse(stringDeadlineDate[i]);
                }

                int day = deadlineDate[0];
                int month = deadlineDate[1];
                int year = deadlineDate[2];

                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `problems` (`Priority`, `Status`, `Applicant`, `Description`, `StartDate`, `EndDate`, `Departments`, `Report`, `Responsible`) " +
                    "VALUES (@priority, @status, @applicant, @description, @startDate, @endDate, @department, @report, @responsible)", db.getConnection());

                command.Parameters.Add("@priority", MySqlDbType.UInt32).Value = 0;
                command.Parameters.Add("@status", MySqlDbType.UInt32).Value = 1;
                command.Parameters.Add("@applicant", MySqlDbType.UInt32).Value = Id;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;
                command.Parameters.Add("@startDate", MySqlDbType.Date).Value = new DateTime();
                command.Parameters.Add("@endDate", MySqlDbType.Date).Value = new DateTime(year, month, day);
                command.Parameters.Add("@department", MySqlDbType.UInt32).Value = 0;
                command.Parameters.Add("@report", MySqlDbType.VarChar).Value = "";
                command.Parameters.Add("@responsible", MySqlDbType.UInt32).Value = 0;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();

                MessageBox.Show("Заявка отправлена");
                descriptionTextBox.Text = "";
                EndDateTextBox.Text = "";

                UserFormTabControl.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Ошибка! Описание пусто или дата введена не по формату.");
        }

        private void UserFormTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }
        public void Fold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ProblemStatus_Click(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            string problemStatus = button.Text;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT P.id, PS.Priority, U.Name AS Applicant, P.Description, " +
                "P.StartDate, P.EndDate, P.Departments, P.Report, P.Responsible FROM `users` AS U, `problems` AS P, " +
                "`prioritystatus` AS PS, `problemstatus` AS PRS " +
                "WHERE U.Id = P.Applicant AND P.Priority = PS.id AND P.Status = PRS.id AND PRS.Status = '" + problemStatus + "';", db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            this.UserDataGridView.DataSource = dt;

            db.closeConnection();
        }

        private void EndDateTextBox_Enter(object sender, EventArgs e)
        {
            if (EndDateTextBox.Text == "дд/мм/гггг")
            {
                EndDateTextBox.Text = "";
                EndDateTextBox.ForeColor = Color.Black;
            }
                
        }

        private void EndDateTextBox_Leave(object sender, EventArgs e)
        {
            if (EndDateTextBox.Text == "")
            {
                EndDateTextBox.Text = "дд/мм/гггг";
                EndDateTextBox.ForeColor = Color.Gray;
            }
                
            
        }
    }
}
