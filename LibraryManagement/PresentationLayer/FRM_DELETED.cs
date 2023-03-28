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
    public partial class FRM_DELETED : Form
    {
        public FRM_DELETED()
        {
            InitializeComponent();
        }

        private void FRM_DELETED_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(lblDeleted);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_DELETED_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
