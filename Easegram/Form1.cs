using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// Coded By CYBER EH
// Soft98.ir
//Beta 1.P2

namespace WindowsFormsApplication33
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set forms state on start
            this.Width = 325; this.Height = 564;
            panel1.Top = 0; panel1.Left = 0;
            panel2.Top = 0; panel2.Left = 0;

            //End of forms state


            this.MaximizeBox = false;
            //this.MinimizeBox = false;
            pictureBox1.Left = this.Width / 2 - 70;
            pictureBox1.Image = Properties.Resources.Logo_Main_Form1;
        }



        string final_url = string.Empty;
        Int16 counter = 0;
        string Link_Server = string.Empty;
        string Link_Name = string.Empty;
        private bool mpl_var = false;
        string trc_url = "https://goo.gl/Vr8zMz";



        public bool use_mpl
        {

            get { return mpl_var; }

            set { mpl_var = value; }

        }


        private void Web_Topic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.soft98.ir/showthread.php?t=80623");
        }

        private void userid_field_Leave(object sender, EventArgs e)
        {
            top_exit_Menu();
        }

        private void top_exit_Menu()
        {
            if (userid_field.TextLength == userid_field.MaxLength - 1 || userid_field.TextLength == userid_field.MaxLength)

            {

                userid_field.Enabled = false;
                label3.Left = this.Width / 2 - 60 - userid_field.TextLength;
                label3.Text = "Target " + userid_field.Text;
                label3.Location = new Point(pictureBox1.Left, pictureBox1.Top + pictureBox1.Height + 10);
                label3.Visible = true;
                clear_userid.Location = new Point(label3.Left + label3.Width + 5, label3.Top + 2);
                clear_userid.Visible = true;
                clear_userid.Enabled = true;

            }
        }

        private void Post_Panel1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
            this.webBrowser1.Navigate(trc_url);
            panel2.Enabled = true;
            panel2.Visible = true;
            lbluserid_panel2.Text = "User " + userid_field.Text;
            assign_lbl_panel2_status();
        }

        private void assign_lbl_panel2_status()
        {
            if (mpl_var == false)
            {
                lbl_panel2_status.ForeColor = Color.DarkGreen;
                lbl_panel2_status.Text = "Single Mode Approved!";
            }
            else if (mpl_var == true)
            {
                lbl_panel2_status.ForeColor = Color.Violet;
                lbl_panel2_status.Text = "MPL Mode Enabled!";
            }
        }

        private void postid_field_TextChanged(object sender, EventArgs e)
        {
            if (postid_field.TextLength == postid_field.MaxLength)
            {
                Post_Panel1.Enabled = true;
                MPL_Button.Enabled = false;
            }
            else
            {
                Post_Panel1.Enabled = false;
                MPL_Button.Enabled = true;
            }
        }

        private void userid_field_TextChanged(object sender, EventArgs e)
        {
            if (userid_field.TextLength == 9 || userid_field.TextLength == 10)
            {
                postid_field.Enabled = true;
                MPL_Button.Enabled = true;
            }
            else
            {
                postid_field.Enabled = false;
                MPL_Button.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //userid_field.Clear();
            txtlogviewer_panel2.Text = "Start The Operation..." + "\r\n" + "Selected Server: " + Link_Name + "\r\n";
            if (counter < trackBar1.Value)
            {
                //webBrowser1.Navigate(new Uri());
                this.webBrowser1.Navigate(final_url);
                txtlogviewer_panel2.Text += " \r\n Req [" + (counter + 1) + "] From " + trackBar1.Value;
                counter++;
                progressBar1.Value = (counter * 100) / trackBar1.Value;
            }
            else
            {
                timer1.Enabled = false;
                txtlogviewer_panel2.Text += "All Done!";
                MessageBox.Show("All Done!", "Easegram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Send_Panel2_Click(object sender, EventArgs e)
        {




            try
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                linkgen();
                Send_Panel2.Enabled = false;
                timer1.Enabled = true;
            }

            catch
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                MessageBox.Show("There is a problem here! \r\n check your netwotk connection!", "Easegram", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkgen()
        {
            string user_id = userid_field.Text;
            string post_id = postid_field.Text;




            final_url = Link_Server + post_id + "_" + user_id;
        }

        private void check_radio()
        {
            if (radio_us1.Checked == true || radio_ru1.Checked == true)
            {
                trackBar1.Enabled = true;
            }
            else
            {
                trackBar1.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(trackBar1.Value * 10);
        }

        private void userid_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void postid_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radio_ru1_CheckedChanged(object sender, EventArgs e)
        {
            check_radio();
            Link_Name = "RU1";
            Link_Server = "http://ru1media.cf/add?id=";
        }

        private void radio_us1_CheckedChanged(object sender, EventArgs e)
        {
            check_radio();
            Link_Name = "US1";
            Link_Server = "http://us1media.cf/add?id=";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/CYBEREH");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/saleh6000");
        }

        private void MPL_Button_Click(object sender, EventArgs e)
        {
            Multiple_Posts miniform = new Multiple_Posts();
            this.Enabled = false;
            postid_field.Text = "Waiting For MPL!";
            miniform.ShowDialog();
            //check_mpl();
            if (mpl_var == true)
            {
                postid_field.Enabled = false;
                postid_field.Text = "Multiple Post ID Prefered.";
                lbl_panel2_status.Text = "Multiple Post ID Prefered.";
                MPL_Button.Enabled = false;
                Post_Panel1.Enabled = true;
                this.Enabled = true;
            }
            else
            {
                postid_field.Text = null;
                this.Enabled = true;
                //lblpostid_panel2 = 
            }

        }

        private void check_mpl()
        {

        }

        private void clear_userid_Click(object sender, EventArgs e)
        {
            clear_top();
        }

        private void clear_top()
        {
            userid_field.Clear();
            postid_field.Clear();
            label3.Visible = false;
            clear_userid.Visible = false;
            clear_userid.Enabled = false;
        }

        protected void getPageSource(string link)
        {
            try
            {
                //get post link Source Code
                WebRequest req = HttpWebRequest.Create(link);
                req.Method = "GET";
                string source;
                using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                {
                    source = reader.ReadToEnd();
                }

                //regex and find post & user ID
                Regex regex_userId = new Regex("owner_user_id\" content=.*");
                Regex regex_post_Id = new Regex("\\\"instagram://media.*\" />");
                Regex regex_number = new Regex("\\d+");

                Match match_user = regex_userId.Match(source);
                Match match_post = regex_post_Id.Match(source);

                Match match_userId = regex_number.Match(match_user.Value);
                Match match_postId = regex_number.Match(match_post.Value);
                check_valid_source(match_userId.Value, match_postId.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot detect URL due to invalid parameter or network error.", "Easegram", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioButton2.Enabled = true;
                lbl_DM_Status.BackColor = Color.Red;
                //CLS_ent_on_changes();
            }

        }

        private void check_valid_source(string usr, string post)
        {
            if (usr != string.Empty && post != string.Empty)
            {
                userid_field.Text = usr;
                postid_field.Text = post;
                lbl_DM_Status.BackColor = Color.Green;
                postid_field.Enabled = false;
                Post_Panel1.Enabled = true;
                radioButton2.Enabled = true;
                top_exit_Menu();
            }
            else
            {
                MessageBox.Show("Cannot detect page source due to invalid address or network error.", "Easegram", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_DM_Status.BackColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CLS_ent_on_changes();

            if (radioButton1.Checked == true)
            {
                panel4.Enabled = true;
                userid_field.Enabled = false; postid_field.Enabled = false;
            }
        }

        private void CLS_ent_on_changes()
        {
            clear_top();
            Post_Panel1.Enabled = false;
            MPL_Button.Enabled = false;
            userid_field.Clear(); postid_field.Clear();
            lbl_DM_Status.BackColor = Color.Gray;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CLS_ent_on_changes();

            if (radioButton2.Checked == true)
            {
                panel4.Enabled = false;
                userid_field.Enabled = true;
            }
        }

        private void CLP_Controller_Click(object sender, EventArgs e)
        {
            string clp = Clipboard.GetText();
            getPageSource(clp);
        }

    }
}
