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
    public partial class RegistrationForm : Form
    {
        int accessCode = 02110211;
        public RegistrationForm()
        {
            InitializeComponent();
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SetTopLevel(true);
            TopMost = true;

        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            StatusBox.Items.Clear();
            StatusBox.Items.Add("Пользователь");
            StatusBox.Items.Add("Инженер 1-ой линии");
            StatusBox.Items.Add("Инженер 2-ой линии");

            mailLabel.Location = new Point(130, 322);
            mailTextBox.Location = new Point(130, 342);
            registrationFinishButton.Location = new Point(130, 382);
        }
        private void GoBack()
        {
            new EntryForm().Show();
            this.Close();            
        }

        #region *Exit*
        private void ExitLabelClick(object sender, EventArgs e)
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

        /// <summary>
        /// Сдвиг панелек при изменении статуса
        /// </summary>
        private void StatusBox_TextUpdate(object sender, EventArgs e)
        {
            Point accesCodeLabelFirstPlace = new Point(accessCodeLabel.Location.X, accessCodeLabel.Location.Y);
            Point accessCodeTextBoxFirstPlace = new Point(accessCodeTextBox.Location.X, accessCodeTextBox.Location.Y);
            Point mailLabelFirstPlace = new Point(mailLabel.Location.X, mailLabel.Location.Y);
            Point mailTextBoxFirstPlace = new Point(mailTextBox.Location.X, mailTextBox.Location.Y);
            if (StatusBox.Text == "Инженер 1-ой линии" || StatusBox.Text == "Инженер 2-ой линии")
            {
                accessCodeLabel.Visible = true;
                accessCodeLabel.Enabled = true;
                accessCodeTextBox.Visible = true;
                accessCodeTextBox.Enabled = true;
                accessCodeLabel.Location = new Point(130, 322);
                accessCodeTextBox.Location = new Point(130, 342);
                mailLabel.Location = new Point(130, 373);
                mailTextBox.Location = new Point(130, 394);
                registrationFinishButton.Location = new Point(130, 434);
            }
            if (StatusBox.Text == "Пользователь")
            {
                accessCodeLabel.Visible = false;
                accessCodeLabel.Enabled = false;
                accessCodeTextBox.Visible = false;
                accessCodeTextBox.Enabled = false;
                accessCodeLabel.Location = new Point(130, 560);
                accessCodeTextBox.Location = new Point(130, 580);
                mailLabel.Location = new Point(130, 322);
                mailTextBox.Location = new Point(130, 342);
                registrationFinishButton.Location = new Point(130, 382);
            }
        }

        #region *RegistrationFinishButton*
        private void registrationFinishButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passTextBox.Text != "" && repeatPassTextBox.Text != "" 
                && passTextBox.Text == repeatPassTextBox.Text 
                && nameTextBox.Text != "" && surnameTextBox.Text != ""
                && StatusBox.Text != "" && mailTextBox.Text != "")
            {
                if (StatusBox.Text == "Пользователь")
                {   
                    MessageBox.Show("Вы зарегестрированы!");
                    GoBack();
                }
                else if (StatusBox.Text == "Инженер 1-ой линии" || StatusBox.Text == "Инженер 2-ой линии")
                {
                    if (accessCodeTextBox.Text == accessCode.ToString())
                    {
                        MessageBox.Show("Вы зарегестрированы!");
                        GoBack();
                    }
                    else
                    {
                        MessageBox.Show("Неверный код доступа!");
                    }
                }
                else 
                {
                    MessageBox.Show("Форма полностью не заполнена!");
                }
            }
            else
            {
                MessageBox.Show("Форма полностью не заполнена или пароль повторен неправильно!");
            }
        }

        private void registrationFinishButton_MouseEnter(object sender, EventArgs e)
        {
            registrationFinishButton.BorderStyle = BorderStyle.FixedSingle;
        }

        private void registrationFinishButton_MouseLeave(object sender, EventArgs e)
        {
            registrationFinishButton.BorderStyle = BorderStyle.None;
        }
        #endregion
    }
}