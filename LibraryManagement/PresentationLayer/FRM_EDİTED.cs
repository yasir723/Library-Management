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
    public partial class FRM_EDİTED : Form
    {
        public FRM_EDİTED()
        {
            InitializeComponent();
        }

        private void FRM_EDİTED_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(lblEdited);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_EDİTED_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
