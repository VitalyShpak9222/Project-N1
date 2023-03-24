﻿
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSendMessages = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.UserFormTabControl.SuspendLayout();
            this.Messages.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.UserFormTabControl.Size = new System.Drawing.Size(1372, 656);
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
            this.Tasks.Size = new System.Drawing.Size(1343, 648);
            this.Tasks.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.Color.LightGray;
            this.Messages.Controls.Add(this.tableLayoutPanel1);
            this.Messages.Controls.Add(this.label6);
            this.Messages.Controls.Add(this.textBox1);
            this.Messages.Controls.Add(this.panel3);
            this.Messages.Controls.Add(this.label2);
            this.Messages.Controls.Add(this.labelSendMessages);
            this.Messages.ImageIndex = 4;
            this.Messages.Location = new System.Drawing.Point(25, 4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1343, 648);
            this.Messages.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 596);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Window;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(3, 549);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(352, 44);
            this.label23.TabIndex = 16;
            this.label23.Text = "Имя";
            this.label23.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Window;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(3, 510);
            this.label22.Margin = new System.Windows.Forms.Padding(3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(352, 33);
            this.label22.TabIndex = 15;
            this.label22.Text = "Имя";
            this.label22.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Window;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(3, 471);
            this.label21.Margin = new System.Windows.Forms.Padding(3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(352, 33);
            this.label21.TabIndex = 14;
            this.label21.Text = "Имя";
            this.label21.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Window;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 432);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(352, 33);
            this.label20.TabIndex = 13;
            this.label20.Text = "Имя";
            this.label20.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Window;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 393);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(352, 33);
            this.label19.TabIndex = 12;
            this.label19.Text = "Имя";
            this.label19.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Window;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(352, 33);
            this.label18.TabIndex = 11;
            this.label18.Text = "Имя";
            this.label18.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Window;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 315);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(352, 33);
            this.label17.TabIndex = 10;
            this.label17.Text = "Имя";
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 276);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(352, 33);
            this.label16.TabIndex = 9;
            this.label16.Text = "Имя";
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 237);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(352, 33);
            this.label15.TabIndex = 8;
            this.label15.Text = "Имя";
            this.label15.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 198);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(352, 33);
            this.label14.TabIndex = 7;
            this.label14.Text = "Имя";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(352, 33);
            this.label13.TabIndex = 6;
            this.label13.Text = "Имя";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(352, 33);
            this.label12.TabIndex = 5;
            this.label12.Text = "Имя";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 33);
            this.label11.TabIndex = 4;
            this.label11.Text = "Имя";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "Имя";
            this.label10.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Имя";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(331, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "+";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 34);
            this.textBox1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(1233, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 55);
            this.panel3.TabIndex = 5;
            this.panel3.Click += new System.EventHandler(this.labelSend_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(367, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(923, 544);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelSendMessages
            // 
            this.labelSendMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSendMessages.Location = new System.Drawing.Point(367, 556);
            this.labelSendMessages.Multiline = true;
            this.labelSendMessages.Name = "labelSendMessages";
            this.labelSendMessages.Size = new System.Drawing.Size(860, 83);
            this.labelSendMessages.TabIndex = 0;
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
            this.Requests.Size = new System.Drawing.Size(1343, 648);
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
            this.Settings.Size = new System.Drawing.Size(1343, 648);
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
            this.imageList.Images.SetKeyName(5, "Отправить сообщение.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 38);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1321, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.Fold_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1334, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserFormTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserFormTest";
            this.UserFormTabControl.ResumeLayout(false);
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Requests.ResumeLayout(false);
            this.Requests.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox labelSendMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}