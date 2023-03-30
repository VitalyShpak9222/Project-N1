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
    public partial class Engineer1_Form : Form
    {        
        string problemId;
        bool IsProblemSelected = false;
        int choosenDepartment;
        int choosenPriority;

        UInt32 Id { get; }
        public Engineer1_Form(UInt32 id)
        {
            Id = id;  
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            Engineer1FormTabControl.ItemSize = new Size(50, 50);

            UpdateListBox();
        }
        private void UpdateListBox()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT P.Id, U.Name" +
                " FROM `problems` AS P, `prioritystatus` AS PS, `problemstatus` AS PRS, `users` AS U " +
                "WHERE P.Priority = PS.Id AND P.Status = PRS.Id AND PRS.Status = 'Ожидают рассмотрения' AND P.Applicant = U.Id;", db.getConnection());

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                ProblemsListBox.Items.Add(table.Rows[i].Field<UInt32>("Id").ToString() + " " + table.Rows[i].Field<String>("Name"));
            }
            db.closeConnection();
        }
        private bool IsDeadlineBurned(DateTime deadlineDate)
        {
            if (deadlineDate < DateTime.Now)
            {
                return true;
            }
            return false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Object_MouseEnter(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.BorderStyle = BorderStyle.Fixed3D;
        }
        private void Object_MouseLeave(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Department_Choose(object sender, EventArgs e)
        {
            if (!IsProblemSelected)
                return;
            List<Label> departments = new List<Label> { department1, department2, department3, department4, department5, department6 };
            Label department = (Label)sender;
            department.BackColor = Color.Gray;
            switch (department.Name)
            {
                case "department1":
                    choosenDepartment = 1;
                    break;
                case "department2":
                    choosenDepartment = 2;
                    break;              
                case "department3":     
                    choosenDepartment = 3;
                    break;              
                case "department4":     
                    choosenDepartment = 4;
                    break;              
                case "department5":     
                    choosenDepartment = 5;
                    break;              
                case "department6":     
                    choosenDepartment = 6;
                    break;
            }

            foreach (Label button in departments)
            {
                if (button != department)
                    button.BackColor = Color.DarkGray;     
            }

        }
        private void ProblemPriority_Click(object sender, EventArgs e)
        {
            if (!IsProblemSelected)
                return;
            List<Panel> statuses = new List<Panel>() { lowProblemPriority, mediumProblemPriority, hardProblemPriority };
            Panel button = (Panel)sender;
            switch (button.Name)
            {
                case "lowProblemPriority":
                    choosenPriority = 1;
                    break;
                case "mediumProblemPriority":
                    choosenPriority = 2;
                    break;
                case "hardProblemPriority":
                    choosenPriority = 3;
                    break;
            }
            foreach (Panel item in statuses)
            {
                if (item != button)
                    item.BorderStyle = BorderStyle.None;
            }
            
            button.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Fold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ProbemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsProblemSelected = true;
            problemId = ProblemsListBox.SelectedItem.ToString().Split(' ')[0];
            string applicantName = ProblemsListBox.SelectedItem.ToString().Split(' ')[1];
            problemIdLabel.Text = problemId;
            applicantNameLabel.Text = applicantName;

            DB db = new DB();

            db.openConnection();
            MySqlCommand problemInfo = new MySqlCommand("SELECT P.Id, P.Description, P.EndDate FROM `problems` AS P WHERE P.Id = '" + problemId + "';", db.getConnection());

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = problemInfo;
            adapter.Fill(table);

            DateTime deadlineDate = table.Rows[0].Field<DateTime>("EndDate");
            string Description = table.Rows[0].Field<String>("Description").ToString();
            db.closeConnection();

            if(IsDeadlineBurned(deadlineDate))
            {
                DeadlineDate.ForeColor = Color.Red;
            }

           
            DeadlineDate.Text = deadlineDate.ToString().Split(' ')[0]; 
            problemDescription.Text = Description;
        }
        private void SendToDepartment_Click(object sender, EventArgs e)
        {
            string startDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            if (choosenDepartment != 0 && choosenPriority != 0 && IsProblemSelected)
            {
                DB db = new DB();

                db.openConnection();
                MySqlCommand command = new MySqlCommand("UPDATE `problems` SET `Priority` = '" + choosenPriority.ToString() + "', " +
                    "`Status` = '2', `StartDate` = '" + startDate + "', `Departments` = '" + choosenDepartment.ToString() + "' " +
                    "WHERE `problems`.`Id` = '" + problemId.ToString() + "';", db.getConnection());

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                MessageBox.Show("Проблема отправлена в отдел " + choosenDepartment.ToString());
                db.closeConnection();
                ProblemsListBox.Items.Clear();
                UpdateListBox();
            }
        }

    }
}
