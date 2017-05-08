namespace WindowsFormsApplication33
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Web_Topic = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_ru1 = new System.Windows.Forms.RadioButton();
            this.radio_us1 = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userid_field = new System.Windows.Forms.TextBox();
            this.postid_field = new System.Windows.Forms.TextBox();
            this.MPL_Button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CLP_Controller = new System.Windows.Forms.Button();
            this.lbl_DM_Status = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.clear_userid = new System.Windows.Forms.Label();
            this.WebGitHub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Post_Panel1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_panel2_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtlogviewer_panel2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Send_Panel2 = new System.Windows.Forms.Button();
            this.lbluserid_panel2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Easegram [Beta 1.4.3]");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Note:";
            // 
            // Web_Topic
            // 
            this.Web_Topic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Web_Topic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Web_Topic.Location = new System.Drawing.Point(215, 495);
            this.Web_Topic.Name = "Web_Topic";
            this.Web_Topic.Size = new System.Drawing.Size(20, 24);
            this.Web_Topic.TabIndex = 8;
            this.Web_Topic.Text = "?";
            this.toolTip1.SetToolTip(this.Web_Topic, "View topic on the web");
            this.Web_Topic.UseVisualStyleBackColor = true;
            this.Web_Topic.Click += new System.EventHandler(this.Web_Topic_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catch Size";
            this.toolTip1.SetToolTip(this.groupBox2, "Average hits on target post");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "50";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(6, 24);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(261, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.trackBar1, "Average hits on target post");
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_ru1);
            this.groupBox1.Controls.Add(this.radio_us1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(15, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Server";
            this.toolTip1.SetToolTip(this.groupBox1, "Available servers to get the requests\r\n");
            // 
            // radio_ru1
            // 
            this.radio_ru1.AutoSize = true;
            this.radio_ru1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radio_ru1.Location = new System.Drawing.Point(16, 28);
            this.radio_ru1.Name = "radio_ru1";
            this.radio_ru1.Size = new System.Drawing.Size(50, 21);
            this.radio_ru1.TabIndex = 11;
            this.radio_ru1.Text = "RU1";
            this.radio_ru1.UseVisualStyleBackColor = true;
            this.radio_ru1.CheckedChanged += new System.EventHandler(this.radio_ru1_CheckedChanged);
            // 
            // radio_us1
            // 
            this.radio_us1.AutoSize = true;
            this.radio_us1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radio_us1.Location = new System.Drawing.Point(16, 55);
            this.radio_us1.Name = "radio_us1";
            this.radio_us1.Size = new System.Drawing.Size(49, 21);
            this.radio_us1.TabIndex = 12;
            this.radio_us1.Text = "US1";
            this.radio_us1.UseVisualStyleBackColor = true;
            this.radio_us1.CheckedChanged += new System.EventHandler(this.radio_us1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 473);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[CYBER EH]";
            this.toolTip1.SetToolTip(this.linkLabel1, "Contact on Telegram Messenger");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabel2.Location = new System.Drawing.Point(18, 495);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "[Saleh.k]";
            this.toolTip1.SetToolTip(this.linkLabel2, "Contact on Telegram Messenger");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Post URL";
            this.toolTip1.SetToolTip(this.label4, "Add \"owner_user_id\" value");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "User ID";
            this.toolTip1.SetToolTip(this.label6, "Add \"owner_user_id\" value");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Post ID";
            this.toolTip1.SetToolTip(this.label7, "Add Single \"media?id\" value");
            // 
            // userid_field
            // 
            this.userid_field.Enabled = false;
            this.userid_field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userid_field.Location = new System.Drawing.Point(69, 115);
            this.userid_field.MaxLength = 10;
            this.userid_field.Name = "userid_field";
            this.userid_field.Size = new System.Drawing.Size(144, 23);
            this.userid_field.TabIndex = 4;
            this.toolTip1.SetToolTip(this.userid_field, "Add \"owner_user_id\" value");
            this.userid_field.TextChanged += new System.EventHandler(this.userid_field_TextChanged);
            this.userid_field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userid_field_KeyPress);
            this.userid_field.Leave += new System.EventHandler(this.userid_field_Leave);
            // 
            // postid_field
            // 
            this.postid_field.Enabled = false;
            this.postid_field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.postid_field.Location = new System.Drawing.Point(69, 141);
            this.postid_field.MaxLength = 19;
            this.postid_field.Name = "postid_field";
            this.postid_field.Size = new System.Drawing.Size(144, 23);
            this.postid_field.TabIndex = 5;
            this.toolTip1.SetToolTip(this.postid_field, "Add Single \"media?id\" value");
            this.postid_field.TextChanged += new System.EventHandler(this.postid_field_TextChanged);
            this.postid_field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postid_field_KeyPress);
            // 
            // MPL_Button
            // 
            this.MPL_Button.Enabled = false;
            this.MPL_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPL_Button.Location = new System.Drawing.Point(244, 427);
            this.MPL_Button.Name = "MPL_Button";
            this.MPL_Button.Size = new System.Drawing.Size(42, 23);
            this.MPL_Button.TabIndex = 6;
            this.MPL_Button.Text = "MPL";
            this.toolTip1.SetToolTip(this.MPL_Button, "Add Multiple \"media?id\" value\r\nAvailable Soon\r\n");
            this.MPL_Button.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CLP_Controller);
            this.panel4.Controls.Add(this.lbl_DM_Status);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(69, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 43);
            this.panel4.TabIndex = 21;
            this.toolTip1.SetToolTip(this.panel4, "Just copy post URL, and then click here!");
            // 
            // CLP_Controller
            // 
            this.CLP_Controller.BackColor = System.Drawing.Color.SteelBlue;
            this.CLP_Controller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLP_Controller.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLP_Controller.ForeColor = System.Drawing.Color.White;
            this.CLP_Controller.Location = new System.Drawing.Point(25, 9);
            this.CLP_Controller.Name = "CLP_Controller";
            this.CLP_Controller.Size = new System.Drawing.Size(103, 23);
            this.CLP_Controller.TabIndex = 2;
            this.CLP_Controller.Text = "Click To Paste!";
            this.toolTip1.SetToolTip(this.CLP_Controller, "Just copy post URL, and then click here!");
            this.CLP_Controller.UseVisualStyleBackColor = false;
            this.CLP_Controller.Click += new System.EventHandler(this.CLP_Controller_Click);
            // 
            // lbl_DM_Status
            // 
            this.lbl_DM_Status.AutoSize = true;
            this.lbl_DM_Status.BackColor = System.Drawing.Color.Gray;
            this.lbl_DM_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DM_Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DM_Status.Location = new System.Drawing.Point(137, 14);
            this.lbl_DM_Status.MinimumSize = new System.Drawing.Size(14, 14);
            this.lbl_DM_Status.Name = "lbl_DM_Status";
            this.lbl_DM_Status.Size = new System.Drawing.Size(14, 14);
            this.lbl_DM_Status.TabIndex = 20;
            this.toolTip1.SetToolTip(this.lbl_DM_Status, "URL Decoder : Status");
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inspect Mode";
            this.toolTip1.SetToolTip(this.radioButton2, "Enter elements manually");
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Direct Mode";
            this.toolTip1.SetToolTip(this.radioButton1, "Fetch elements directly from target post");
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // clear_userid
            // 
            this.clear_userid.AutoSize = true;
            this.clear_userid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_userid.Enabled = false;
            this.clear_userid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clear_userid.ForeColor = System.Drawing.Color.DarkGray;
            this.clear_userid.Location = new System.Drawing.Point(205, 214);
            this.clear_userid.Name = "clear_userid";
            this.clear_userid.Size = new System.Drawing.Size(13, 13);
            this.clear_userid.TabIndex = 8;
            this.clear_userid.Text = "X";
            this.toolTip1.SetToolTip(this.clear_userid, "Clear");
            this.clear_userid.Visible = false;
            this.clear_userid.Click += new System.EventHandler(this.clear_userid_Click);
            // 
            // WebGitHub
            // 
            this.WebGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebGitHub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebGitHub.Location = new System.Drawing.Point(238, 495);
            this.WebGitHub.Name = "WebGitHub";
            this.WebGitHub.Size = new System.Drawing.Size(68, 24);
            this.WebGitHub.TabIndex = 7;
            this.WebGitHub.Text = "GitHub";
            this.toolTip1.SetToolTip(this.WebGitHub, "View topic on the web");
            this.WebGitHub.UseVisualStyleBackColor = true;
            this.WebGitHub.Click += new System.EventHandler(this.WebGitHub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(138, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Post_Panel1
            // 
            this.Post_Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Post_Panel1.Enabled = false;
            this.Post_Panel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post_Panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Post_Panel1.Location = new System.Drawing.Point(120, 439);
            this.Post_Panel1.Name = "Post_Panel1";
            this.Post_Panel1.Size = new System.Drawing.Size(79, 36);
            this.Post_Panel1.TabIndex = 6;
            this.Post_Panel1.Text = "Configure";
            this.Post_Panel1.UseVisualStyleBackColor = true;
            this.Post_Panel1.Click += new System.EventHandler(this.Post_Panel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WebGitHub);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.clear_userid);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.MPL_Button);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Post_Panel1);
            this.panel1.Controls.Add(this.Web_Topic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 525);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.userid_field);
            this.groupBox3.Controls.Add(this.postid_field);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(21, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 194);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_panel2_status);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.Send_Panel2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lbluserid_panel2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(357, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 525);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // lbl_panel2_status
            // 
            this.lbl_panel2_status.AutoSize = true;
            this.lbl_panel2_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_panel2_status.Location = new System.Drawing.Point(12, 36);
            this.lbl_panel2_status.Name = "lbl_panel2_status";
            this.lbl_panel2_status.Size = new System.Drawing.Size(43, 17);
            this.lbl_panel2_status.TabIndex = 8;
            this.lbl_panel2_status.Text = "label6";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtlogviewer_panel2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Location = new System.Drawing.Point(15, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 159);
            this.panel3.TabIndex = 7;
            // 
            // txtlogviewer_panel2
            // 
            this.txtlogviewer_panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtlogviewer_panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlogviewer_panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogviewer_panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogviewer_panel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtlogviewer_panel2.Location = new System.Drawing.Point(33, 3);
            this.txtlogviewer_panel2.Multiline = true;
            this.txtlogviewer_panel2.Name = "txtlogviewer_panel2";
            this.txtlogviewer_panel2.ReadOnly = true;
            this.txtlogviewer_panel2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtlogviewer_panel2.Size = new System.Drawing.Size(202, 72);
            this.txtlogviewer_panel2.TabIndex = 5;
            this.txtlogviewer_panel2.Text = "<Logs Appear Here>";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 99);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 22);
            this.progressBar1.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(48, 304);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(188, 98);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Visible = false;
            // 
            // Send_Panel2
            // 
            this.Send_Panel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_Panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Send_Panel2.Location = new System.Drawing.Point(109, 445);
            this.Send_Panel2.Name = "Send_Panel2";
            this.Send_Panel2.Size = new System.Drawing.Size(90, 30);
            this.Send_Panel2.TabIndex = 14;
            this.Send_Panel2.Text = "Commit!";
            this.Send_Panel2.UseVisualStyleBackColor = true;
            this.Send_Panel2.Click += new System.EventHandler(this.Send_Panel2_Click);
            // 
            // lbluserid_panel2
            // 
            this.lbluserid_panel2.AutoSize = true;
            this.lbluserid_panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbluserid_panel2.Location = new System.Drawing.Point(12, 9);
            this.lbluserid_panel2.Name = "lbluserid_panel2";
            this.lbluserid_panel2.Size = new System.Drawing.Size(43, 17);
            this.lbluserid_panel2.TabIndex = 0;
            this.lbluserid_panel2.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 3800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(309, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easegram [Beta 1.4.3]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Web_Topic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Post_Panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbluserid_panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Send_Panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RadioButton radio_ru1;
        private System.Windows.Forms.RadioButton radio_us1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtlogviewer_panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lbl_panel2_status;
        private System.Windows.Forms.Label clear_userid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userid_field;
        private System.Windows.Forms.TextBox postid_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MPL_Button;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button CLP_Controller;
        private System.Windows.Forms.Label lbl_DM_Status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button WebGitHub;
    }
}

