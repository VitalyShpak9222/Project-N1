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
        UInt32 Id { get; }
        public Engineer1_Form(UInt32 id)
        {
            Id = id;
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            Engineer1FormTabControl.ItemSize = new Size(50, 50);

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT P.Id, U.Name" +
                " FROM `problems` AS P, `prioritystatus` AS PS, `problemstatus` AS PRS, `users` AS U " +
                "WHERE P.Priority = PS.Id AND P.Status = PRS.Id AND PRS.Status = 'Ожидают рассмотрения' AND P.Applicant = U.Id;", db.getConnection());
            
            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for(int i = 0; i < table.Rows.Count; i++)
            {
                ProblemsListBox.Items.Add(table.Rows[i].Field<UInt32>("Id").ToString() + " " + table.Rows[i].Field<String>("Name"));
            }
            db.closeConnection();
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
        private void Oblject_MouseLeave(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            button.BorderStyle = BorderStyle.FixedSingle;
        }

        private void TaskStatus_Click(object sender, EventArgs e)
        {
            List<Panel> statuses = new List<Panel>() { lowTaskStatus, mediumTaskStatus, hardTaskStatus };
            Panel button = (Panel)sender;
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
            string problemId = ProblemsListBox.SelectedItem.ToString().Split(' ')[0];
            string applicantName = ProblemsListBox.SelectedItem.ToString().Split(' ')[1];
            problemIdLabel.Text = problemId;
            applicantNameLabel.Text = applicantName;

            DB db = new DB();
            db.openConnection();
            MySqlCommand descr = new MySqlCommand("SELECT P.Id, P.Description FROM `problems` AS P WHERE P.Id = '" + problemId + "';", db.getConnection());

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = descr;
            adapter.Fill(table);

            string Description = table.Rows[0].Field<String>("Description").ToString();
            db.closeConnection();

            problemDescription.Text = Description;
        }
        private void 
    }
}
