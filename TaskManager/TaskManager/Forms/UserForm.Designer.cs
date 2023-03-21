
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
            this.makeRequestButton = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.settingsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Label();
            this.labelSendMessages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserFormTabControl.SuspendLayout();
            this.Messages.SuspendLayout();
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
            this.UserFormTabControl.ImageList = this.imageList;
            this.UserFormTabControl.Location = new System.Drawing.Point(0, 38);
            this.UserFormTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.UserFormTabControl.Multiline = true;
            this.UserFormTabControl.Name = "UserFormTabControl";
            this.UserFormTabControl.SelectedIndex = 0;
            this.UserFormTabControl.Size = new System.Drawing.Size(1300, 656);
            this.UserFormTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.UserFormTabControl.TabIndex = 0;
            this.UserFormTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.UserFormTabControl_Selecting);
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
            this.Tasks.Size = new System.Drawing.Size(1271, 648);
            this.Tasks.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.Color.LightGray;
            this.Messages.Controls.Add(this.label5);
            this.Messages.Controls.Add(this.label2);
            this.Messages.Controls.Add(this.labelSendMessages);
            this.Messages.ImageIndex = 4;
            this.Messages.Location = new System.Drawing.Point(25, 4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1271, 648);
            this.Messages.TabIndex = 2;
            // 
            // Requests
            // 
            this.Requests.BackColor = System.Drawing.Color.LightGray;
            this.Requests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Requests.Controls.Add(this.makeRequestButton);
            this.Requests.Controls.Add(this.description);
            this.Requests.Controls.Add(this.label3);
            this.Requests.Controls.Add(this.label1);
            this.Requests.ImageIndex = 3;
            this.Requests.Location = new System.Drawing.Point(25, 4);
            this.Requests.Name = "Requests";
            this.Requests.Padding = new System.Windows.Forms.Padding(3);
            this.Requests.Size = new System.Drawing.Size(1271, 648);
            this.Requests.TabIndex = 1;
            // 
            // makeRequestButton
            // 
            this.makeRequestButton.BackColor = System.Drawing.Color.DimGray;
            this.makeRequestButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeRequestButton.ForeColor = System.Drawing.SystemColors.Window;
            this.makeRequestButton.Location = new System.Drawing.Point(148, 547);
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
            this.description.Location = new System.Drawing.Point(148, 99);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(838, 429);
            this.description.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 99);
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
            this.Settings.Controls.Add(this.settingsCheckBox);
            this.Settings.Controls.Add(this.label4);
            this.Settings.ImageIndex = 1;
            this.Settings.Location = new System.Drawing.Point(25, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1271, 648);
            this.Settings.TabIndex = 3;
            // 
            // settingsCheckBox
            // 
            this.settingsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsCheckBox.Location = new System.Drawing.Point(151, 103);
            this.settingsCheckBox.Name = "settingsCheckBox";
            this.settingsCheckBox.Size = new System.Drawing.Size(603, 214);
            this.settingsCheckBox.TabIndex = 9;
            this.settingsCheckBox.Text = "Уведомлять об обновлении статуса проблемы";
            this.settingsCheckBox.UseVisualStyleBackColor = true;
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
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1262, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // labelSendMessages
            // 
            this.labelSendMessages.Location = new System.Drawing.Point(363, 488);
            this.labelSendMessages.Multiline = true;
            this.labelSendMessages.Name = "labelSendMessages";
            this.labelSendMessages.Size = new System.Drawing.Size(602, 90);
            this.labelSendMessages.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(363, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 401);
            this.label2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Send";
            this.label5.Click += new System.EventHandler(this.labelSend_Click);
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
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox settingsCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelSendMessages;
    }
}