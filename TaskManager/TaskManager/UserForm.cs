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
        private Label category;
        List<Label> DarkGrayColoredLabels = new List<Label>();
        public UserForm()
        {
            InitializeComponent();
            this.SetTopLevel(true);
            TopMost = true;
            UserFormTabControl.ItemSize = new Size(107, 100);

            //Сохраняю все label у которых BackColor = Color.DarkGray, тоесть все категории
            foreach (var item in Requests.Controls)
            {
                if (item is Label && ((Label)item).BackColor == Color.DarkGray)
                {
                    DarkGrayColoredLabels.Add((Label)item);
                }
            }
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
        private void Category_Click(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            foreach (var item in DarkGrayColoredLabels)
            {
                ((Label)item).BackColor = Color.DarkGray;                
            }
            Color firstColor = button.BackColor;
            button.BackColor = Color.DimGray;
            if (firstColor == Color.DimGray)
            {
                button.BackColor = Color.DarkGray;
            }           
            category = button;          
        }

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            if (category != null && description.Text != "")
            {          
                MessageBox.Show(category.Text + "\n" + description.Text);
                category.BackColor = Color.DarkGray;
                category = null;
                description.Text = "";
            }

            else if (category == null && description.Text != "")
                MessageBox.Show("Ошибка! Вы не выбрали категорию");
            else if (category != null && description.Text == "")
                MessageBox.Show("Ошибка! Вы не написали описание");
            else
                MessageBox.Show("Ошибка! Выберите категорию заявки и напишите описание"); 
        }
    }
}
