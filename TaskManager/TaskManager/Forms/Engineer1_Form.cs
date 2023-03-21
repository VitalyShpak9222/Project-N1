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
        public Engineer1_Form()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
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
            foreach(Panel item in statuses)
            {
                if (item != button)
                    item.BorderStyle = BorderStyle.None;
            }
            button.BorderStyle = BorderStyle.FixedSingle;

            
        }
    }
}
