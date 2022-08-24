using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApp2
{
    public partial class frmLogin : Form
    {
        private bool rememberMe = false;
        public frmLogin()
        {
            InitializeComponent();

        }
        private void frmLogin_Load(object sender,EventArgs e)
        {
            if(testApp2.Properties.Settings.Default.UserSaved.Equals("")==false)
            {
                string dat=testApp2.Properties.Settings.Default.UserSaved;
                string user = dat.Split('|')[0];
                string pass = dat.Split('|')[1];
                txt_Username.Text=user;
                txt_pass.Text=pass;
                txt_Username
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text!=""&&txt_pass.Text!="")
            {
                if(txt_Username.Text=="admin"&&txt_pass.Text=="123456")
                {
                    if(rememberMe==true)
                    {
                        testApp2.Properties.Settings.Default.UserSaved = txt_Username.Text +"|"+ txt_pass.Text;
                        testApp2.Properties.Settings.Default.Save();
                    }
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                } 
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }    
            }
            else 
            {
                if(txt_Username.Text==""&&txt_pass.Text!="")
                {
                    MessageBox.Show("Bạn đã không nhập tài khoản");
                }    
                else if (txt_Username.Text != "" && txt_pass.Text == "")
                {

                    MessageBox.Show("Bạn đã không nhập mật khẩu");
                }
                else
                {

                    MessageBox.Show("Bạn đã không nhập cái j cả");
                }    
            } 
                
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(rememberMe==true) rememberMe=false;
            else rememberMe=true;
        }
    }
}
