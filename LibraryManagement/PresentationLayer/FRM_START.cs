using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.PresentationLayer
{
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void FRM_START_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(picBook);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (timereneble == 2)
            //{
            //    timer1.Enabled = false;
            //    PresentationLayer.FRM_MAIN FrmMain = new FRM_MAIN();
            //    FrmMain.Show();
            //    this.Hide();
            //}


            BL.CLS_USERS CLSUSER = new BL.CLS_USERS();
            DataTable dt = new DataTable();
            dt = CLSUSER.StartLoadDate();
            if (dt.Rows.Count > 0)
            {
                PresentationLayer.FRM_MAIN FrmMain = new FRM_MAIN();
                object LbName = dt.Rows[0]["CNAME"];
                object LbPrem = dt.Rows[0]["CPREM"];
                FrmMain.lblName.Text = LbName.ToString();
                FrmMain.lblPrem.Text = LbPrem.ToString();
                FrmMain.Show();
                this.Hide();
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                PresentationLayer.FRM_LOGİN FrmLogin = new FRM_LOGİN();
                FrmLogin.Show();
                this.Hide();
                timer1.Enabled = false;
                timer2.Enabled = false;
            }







        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Left += 10;

            if (panel2.Left > 745)
            {
                panel2.Left = -50;
            }
        }
    }
}
