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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
        }
        #region *ExitButton*
        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel1.ForeColor = Color.FromArgb(255, 222, 95, 96);
        }        
        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel1.ForeColor = Color.FromName("ControlText");
        }
        #endregion
        private void RegistrationLabelClick(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Close();
        }
        
        private void IsUserFound(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
                this.Close();
                new UserForm().Show();
            }
            
        }
        private void EntryLabel_Click(object sender, EventArgs e)
        {
            String loginUser = loginTextBox.Text;
            String passUser = passwordTextBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вход выполнен успешно!");
                switch (table.Rows[0].Field<UInt32>("Status"))
                {
                    case 1:
                        this.Close();
                        new UserForm().Show();
                        break;
                    case 2:
                        this.Close();
                        new Engineer1_Form().Show();
                        break;
                    case 3:
                        this.Close();
                        new Engineer2_Form().Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя нет");
            }
        }
    }
}
