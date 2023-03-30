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
    public partial class Engineer2_Form : Form
    {
        bool[] DepartmentChecked = {false, false, false, false, false, false}; 
        UInt32 Id { get; }
        public Engineer2_Form(UInt32 id)
        {
            Id = id;
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            Engineer2TabControl.ItemSize = new Size(50, 50);
            Engineer2TabControl.SelectedIndex = 6;
        }
        #region *MakingPagesVisible*
        private void MakeEverythingVisible1()
        {
            //depNumLabel1.Visible = true;
            //responLabel1.Visible = true;
            //deadlineLbl1.Visible = true;
            //prbmIdLabel1.Visible = true;
            prmInfPanel1.Visible = true;
            prmsListBoxPanel1.Visible = true;
            //statusLabel1.Visible = true;
            backgrPanel1.Visible = true;
            lowStatusButton1.Visible = true;
            highStatusButton1.Visible = true;
            makeReport_1.Visible = true;
            //aceptionLbl1.Visible = true;
            //descTextLbl1.Visible = true;
            string wherePart1;
        }
        private void MakeEverythingVisible2()
        {
            //depNumLabel2.Visible = true;
            //responLabel2.Visible = true;
            //deadlineLbl2.Visible = true;
            //prbmIdLabel2.Visible = true;
            prmInfPanel2.Visible = true;
            prmsListBoxPanel2.Visible = true;
            //statusLabel2.Visible = true;
            backgrPanel2.Visible = true;
            lowStatusButton2.Visible = true;
            highStatusButton2.Visible = true;
            makeReport_2.Visible = true;
            //aceptionLbl2.Visible = true;
            //descTextLbl2.Visible = true;
            string wherePart1;
        }
        private void MakeEverythingVisible3()
        {
            //depNumLabel3.Visible = true;
            //responLabel3.Visible = true;
            //deadlineLbl3.Visible = true;
            //prbmIdLabel3.Visible = true;
            prmInfPanel3.Visible = true;
            prmsListBoxPanel3.Visible = true;
            //statusLabel3.Visible = true;
            backgrPanel3.Visible = true;
            lowStatusButton3.Visible = true;
            highStatusButton3.Visible = true;
            makeReport_3.Visible = true;
            //aceptionLbl3.Visible = true;
            //descTextLbl3.Visible = true;
            string wherePart2;
        }
        private void MakeEverythingVisible4()
        {
            //depNumLabel4.Visible = true;
            //responLabel4.Visible = true;
            //deadlineLbl4.Visible = true;
            //prbmIdLabel4.Visible = true;
            prmInfPanel4.Visible = true;
            prmsListBoxPanel4.Visible = true;
            //statusLabel4.Visible = true;
            backgrPanel4.Visible = true;
            lowStatusButton4.Visible = true;
            highStatusButton4.Visible = true;
            makeReport_4.Visible = true;
            //aceptionLbl4.Visible = true;
            //descTextLbl4.Visible = true;
            string wherePart3;
        }
        private void MakeEverythingVisible5()
        {
            //depNumLabel5.Visible = true;
            //responLabel5.Visible = true;
            //deadlineLbl5.Visible = true;
            //prbmIdLabel5.Visible = true;
            prmInfPanel5.Visible = true;
            prmsListBoxPanel5.Visible = true;
            //statusLabel5.Visible = true;
            backgrPanel5.Visible = true;
            lowStatusButton5.Visible = true;
            highStatusButton5.Visible = true;
            makeReport_5.Visible = true;
            //aceptionLbl5.Visible = true;
            //descTextLbl5.Visible = true;
            string wherePart4;
        }
        private void MakeEverythingVisible6()
        {
            //depNumLabel6.Visible = true;
            //responLabel6.Visible = true;
            //deadlineLbl6.Visible = true;
            //prbmIdLabel6.Visible = true;
            prmInfPanel6.Visible = true;
            prmsListBoxPanel6.Visible = true;
            //statusLabel6.Visible = true;
            backgrPanel6.Visible = true;
            lowStatusButton6.Visible = true;
            highStatusButton6.Visible = true;
            makeReport_6.Visible = true;
            //aceptionLbl6.Visible = true;
            //descTextLbl6.Visible = true;
            string wherePart5;
        }
        #endregion
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Fold_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void DepartmentApointment_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox department = (CheckBox)sender;
            int departmentIndex = int.Parse(department.Text.Split(' ')[3]) - 1;
            if (department.Checked)
                DepartmentChecked[departmentIndex] = true;
            else
                DepartmentChecked[departmentIndex] = false;
        }
        private void Engineer2TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();

            
            switch (Engineer2TabControl.SelectedIndex)
            {
                case 0:
                    if (DepartmentChecked[0] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible1();
                    break;
                case 1:
                    if (DepartmentChecked[1] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible2();
                    break;
                case 2:
                    if (DepartmentChecked[2] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible3();
                    break;
                case 3:
                    if (DepartmentChecked[3] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible4();
                    break;
                case 4:
                    if (DepartmentChecked[4] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible5();
                    break;
                case 5:
                    if (DepartmentChecked[5] == false)
                    {
                        return;
                    }
                    else
                        MakeEverythingVisible6();
                    break;

                    MySqlCommand command = new MySqlCommand("SELECT P.Id, U.Name" +
                    " FROM `problems` AS P, `prioritystatus` AS PS, `problemstatus` AS PRS, `users` AS U " +
                    "WHERE P.Priority = PS.Id AND P.Status = PRS.Id AND PRS.Status = 'Ожидают рассмотрения' AND P.Applicant = U.Id;", db.getConnection());

            }
        }
    }
}
