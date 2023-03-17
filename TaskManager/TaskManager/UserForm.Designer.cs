
namespace TaskManager
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.UserFormTabControl = new System.Windows.Forms.TabControl();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.Messages = new System.Windows.Forms.TabPage();
            this.Requests = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.category9 = new System.Windows.Forms.Label();
            this.category8 = new System.Windows.Forms.Label();
            this.category7 = new System.Windows.Forms.Label();
            this.category6 = new System.Windows.Forms.Label();
            this.category3 = new System.Windows.Forms.Label();
            this.category5 = new System.Windows.Forms.Label();
            this.category4 = new System.Windows.Forms.Label();
            this.category2 = new System.Windows.Forms.Label();
            this.category1 = new System.Windows.Forms.Label();
            this.makeRequestButton = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.GoBack = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserFormTabControl.SuspendLayout();
            this.Requests.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserFormTabControl
            // 
            this.UserFormTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.UserFormTabControl.Controls.Add(this.Tasks);
            this.UserFormTabControl.Controls.Add(this.Messages);
            this.UserFormTabControl.Controls.Add(this.Requests);
            this.UserFormTabControl.Controls.Add(this.Settings);
            this.UserFormTabControl.Controls.Add(this.GoBack);
            this.UserFormTabControl.ImageList = this.imageList;
            this.UserFormTabControl.Location = new System.Drawing.Point(0, 37);
            this.UserFormTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.UserFormTabControl.Multiline = true;
            this.UserFormTabControl.Name = "UserFormTabControl";
            this.UserFormTabControl.SelectedIndex = 0;
            this.UserFormTabControl.Size = new System.Drawing.Size(1300, 665);
            this.UserFormTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.UserFormTabControl.TabIndex = 0;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.LightGray;
            this.Tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tasks.ImageIndex = 2;
            this.Tasks.Location = new System.Drawing.Point(25, 4);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tasks.Size = new System.Drawing.Size(1271, 657);
            this.Tasks.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.Color.LightGray;
            this.Messages.ImageIndex = 4;
            this.Messages.Location = new System.Drawing.Point(25, 4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1271, 657);
            this.Messages.TabIndex = 2;
            // 
            // Requests
            // 
            this.Requests.BackColor = System.Drawing.Color.LightGray;
            this.Requests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Requests.Controls.Add(this.label2);
            this.Requests.Controls.Add(this.category9);
            this.Requests.Controls.Add(this.category8);
            this.Requests.Controls.Add(this.category7);
            this.Requests.Controls.Add(this.category6);
            this.Requests.Controls.Add(this.category3);
            this.Requests.Controls.Add(this.category5);
            this.Requests.Controls.Add(this.category4);
            this.Requests.Controls.Add(this.category2);
            this.Requests.Controls.Add(this.category1);
            this.Requests.Controls.Add(this.makeRequestButton);
            this.Requests.Controls.Add(this.description);
            this.Requests.Controls.Add(this.label3);
            this.Requests.Controls.Add(this.label1);
            this.Requests.ImageIndex = 3;
            this.Requests.Location = new System.Drawing.Point(25, 4);
            this.Requests.Name = "Requests";
            this.Requests.Padding = new System.Windows.Forms.Padding(3);
            this.Requests.Size = new System.Drawing.Size(1271, 657);
            this.Requests.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Категории";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category9
            // 
            this.category9.BackColor = System.Drawing.Color.DarkGray;
            this.category9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category9.Location = new System.Drawing.Point(691, 252);
            this.category9.Name = "category9";
            this.category9.Size = new System.Drawing.Size(264, 59);
            this.category9.TabIndex = 20;
            this.category9.Text = "Категория 9";
            this.category9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category9.Click += new System.EventHandler(this.Category_Click);
            this.category9.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category9.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category8
            // 
            this.category8.BackColor = System.Drawing.Color.DarkGray;
            this.category8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category8.Location = new System.Drawing.Point(418, 252);
            this.category8.Name = "category8";
            this.category8.Size = new System.Drawing.Size(264, 59);
            this.category8.TabIndex = 19;
            this.category8.Text = "Категория 8";
            this.category8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category8.Click += new System.EventHandler(this.Category_Click);
            this.category8.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category8.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category7
            // 
            this.category7.BackColor = System.Drawing.Color.DarkGray;
            this.category7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category7.Location = new System.Drawing.Point(148, 252);
            this.category7.Name = "category7";
            this.category7.Size = new System.Drawing.Size(264, 59);
            this.category7.TabIndex = 18;
            this.category7.Text = "Категория 7";
            this.category7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category7.Click += new System.EventHandler(this.Category_Click);
            this.category7.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category7.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category6
            // 
            this.category6.BackColor = System.Drawing.Color.DarkGray;
            this.category6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category6.Location = new System.Drawing.Point(691, 183);
            this.category6.Name = "category6";
            this.category6.Size = new System.Drawing.Size(264, 59);
            this.category6.TabIndex = 17;
            this.category6.Text = "Категория 6";
            this.category6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category6.Click += new System.EventHandler(this.Category_Click);
            this.category6.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category6.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category3
            // 
            this.category3.BackColor = System.Drawing.Color.DarkGray;
            this.category3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category3.Location = new System.Drawing.Point(691, 115);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(264, 59);
            this.category3.TabIndex = 16;
            this.category3.Text = "Категория 3";
            this.category3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category3.Click += new System.EventHandler(this.Category_Click);
            this.category3.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category3.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category5
            // 
            this.category5.BackColor = System.Drawing.Color.DarkGray;
            this.category5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category5.Location = new System.Drawing.Point(418, 183);
            this.category5.Name = "category5";
            this.category5.Size = new System.Drawing.Size(264, 59);
            this.category5.TabIndex = 15;
            this.category5.Text = "Категория 5";
            this.category5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category5.Click += new System.EventHandler(this.Category_Click);
            this.category5.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category5.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category4
            // 
            this.category4.BackColor = System.Drawing.Color.DarkGray;
            this.category4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category4.Location = new System.Drawing.Point(148, 183);
            this.category4.Name = "category4";
            this.category4.Size = new System.Drawing.Size(264, 59);
            this.category4.TabIndex = 14;
            this.category4.Text = "Категория 4";
            this.category4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category4.Click += new System.EventHandler(this.Category_Click);
            this.category4.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category4.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category2
            // 
            this.category2.BackColor = System.Drawing.Color.DarkGray;
            this.category2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category2.Location = new System.Drawing.Point(418, 115);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(264, 59);
            this.category2.TabIndex = 13;
            this.category2.Text = "Категория 2";
            this.category2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category2.Click += new System.EventHandler(this.Category_Click);
            this.category2.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category2.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // category1
            // 
            this.category1.BackColor = System.Drawing.Color.DarkGray;
            this.category1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category1.Location = new System.Drawing.Point(148, 115);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(264, 59);
            this.category1.TabIndex = 0;
            this.category1.Text = "Категория 1";
            this.category1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category1.Click += new System.EventHandler(this.Category_Click);
            this.category1.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.category1.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // makeRequestButton
            // 
            this.makeRequestButton.BackColor = System.Drawing.Color.DimGray;
            this.makeRequestButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeRequestButton.ForeColor = System.Drawing.SystemColors.Window;
            this.makeRequestButton.Location = new System.Drawing.Point(151, 556);
            this.makeRequestButton.Name = "makeRequestButton";
            this.makeRequestButton.Size = new System.Drawing.Size(274, 44);
            this.makeRequestButton.TabIndex = 12;
            this.makeRequestButton.Text = "Оформить";
            this.makeRequestButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makeRequestButton.Click += new System.EventHandler(this.MakeRequestButton_Click);
            this.makeRequestButton.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.makeRequestButton.MouseLeave += new System.EventHandler(this.Oblject_MouseLeave);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(148, 330);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(807, 210);
            this.description.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оформление заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.LightGray;
            this.Settings.Controls.Add(this.label4);
            this.Settings.ImageIndex = 1;
            this.Settings.Location = new System.Drawing.Point(25, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1271, 657);
            this.Settings.TabIndex = 3;
            // 
            // GoBack
            // 
            this.GoBack.ImageIndex = 0;
            this.GoBack.Location = new System.Drawing.Point(25, 4);
            this.GoBack.Name = "GoBack";
            this.GoBack.Padding = new System.Windows.Forms.Padding(3);
            this.GoBack.Size = new System.Drawing.Size(1271, 657);
            this.GoBack.TabIndex = 4;
            this.GoBack.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Выход.png");
            this.imageList.Images.SetKeyName(1, "Настройки.png");
            this.imageList.Images.SetKeyName(2, "Задания.png");
            this.imageList.Images.SetKeyName(3, "Оформить заявку.png");
            this.imageList.Images.SetKeyName(4, "Сообщения.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 38);
            this.panel1.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1262, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(143, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Настройки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserFormTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFormTest";
            this.UserFormTabControl.ResumeLayout(false);
            this.Requests.ResumeLayout(false);
            this.Requests.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserFormTabControl;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.TabPage Requests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label makeRequestButton;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage GoBack;
        private System.Windows.Forms.Label category9;
        private System.Windows.Forms.Label category8;
        private System.Windows.Forms.Label category7;
        private System.Windows.Forms.Label category6;
        private System.Windows.Forms.Label category3;
        private System.Windows.Forms.Label category5;
        private System.Windows.Forms.Label category4;
        private System.Windows.Forms.Label category2;
        private System.Windows.Forms.Label category1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}