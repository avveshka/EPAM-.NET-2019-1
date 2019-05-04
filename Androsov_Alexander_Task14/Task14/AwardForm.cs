using Entities;
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
    public partial class AwardForm : Form
    {
        public string Title { get; set; }

        public string Description { get; set; }

        private bool clicked = false;

        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Award award)
        {
            InitializeComponent();
            tbAwardTitle.Text = award.Title;
            tbAwardDescription.Text = award.Description;
        }

        private void tbAwardTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = tbAwardTitle.Text;

            if (String.IsNullOrEmpty(input) && clicked)
            {
                ctlAwardTitleError.SetError(tbAwardTitle, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlAwardTitleError.SetError(tbAwardTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void tbAwardTitle_Validated(object sender, EventArgs e)
        {
            Title = tbAwardTitle.Text;
        }

        private void btnAwardAdd_Click(object sender, EventArgs e)
        {
            clicked = true;
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Description = tbAwardDescription.Text;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void btnAwardClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
