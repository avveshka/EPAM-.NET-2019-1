using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task14
{
    public partial class AcceptForm : Form
    {
        public AcceptForm()
        {
            InitializeComponent();
        }

        private void btnAcceptingOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAcceptingNone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
