using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPass = Encrypt.GetSHA256(txtPass.Text.Trim());
            using (Models.TADSICondominiumEntities db = new Models.TADSICondominiumEntities())
            {
                var lst = from d in db.users
                          where d.userEmail == txtPass.Text
                          && d.userPassword == sPass
                          select d;
                if (lst.Count() > 0)
                {
                    this.Hide();
                    Principal frm = new Principal();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario no existe");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
