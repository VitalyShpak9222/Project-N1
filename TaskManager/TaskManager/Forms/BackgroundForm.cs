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
    public partial class BackgroundForm : Form
    {

        public BackgroundForm()
        {
            InitializeComponent();
            this.Size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            new UserForm().Show();
        }

    }
}
