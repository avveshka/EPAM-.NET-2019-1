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
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public List<Award> AwardList { get; set; }

        private bool clicked = false;

        public UserForm()
        {
            InitializeComponent();
            ctlUserAwards.Items.AddRange(AwardInicilazation());
        }

        public UserForm(User user)
        {
            InitializeComponent();
            ctlUserAwards.Items.AddRange(AwardInicilazation());
            string[] ischecked = user.ShowAwardUser.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int k = 0; k < ischecked.Length; k++)
            {
                ischecked[k] = ischecked[k].Trim();
            }
            List<int> ischeckedindex = new List<int>();
            var i = 0;
            if (ischecked != null)
            {
                for (int j = 0; j < AwardInicilazation().Length; j++)
                {
                    if (ischecked.Length != i)
                    {
                        if (AwardInicilazation()[j] == ischecked[i])
                        {
                            ischeckedindex.Add(j);
                            i++;
                        }
                    }

                }
            }
            foreach (var item in ischeckedindex)
            {
                ctlUserAwards.SetItemChecked(item, true);
            }
            tbUserFirstName.Text = user.FirstName;
            tbUserLastName.Text = user.LastName;
            dtpUserBirthDay.Value = user.BirthDay;
        }

        private string[] AwardInicilazation()
        {
            var AwardTitle = new string[Storage.GetAwardList().Count];
            var i = 0;
            foreach (var item in Storage.GetAwardList())
            {
                AwardTitle[i] = item.Title;
                i++;
            }
            return AwardTitle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clicked = true;
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                BirthDay = dtpUserBirthDay.Value;
                List<Award> tempList = new List<Award>();
                foreach (var item in ctlUserAwards.CheckedItems.OfType<string>().ToList())
                {
                    tempList.Add(Storage.GetAwardByTitle(item));
                }
                AwardList = tempList;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void tbUserLastName_Validated(object sender, EventArgs e)
        {
            LastName = tbUserLastName.Text;
        }

        private void tbUserLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = tbUserLastName.Text;

            if (String.IsNullOrEmpty(input) && clicked)
            {
                ctlUserLastNameError.SetError(tbUserLastName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlUserLastNameError.SetError(tbUserLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void tbUserFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = tbUserFirstName.Text;
        }

        private void tbUserFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = tbUserFirstName.Text;

            if (String.IsNullOrEmpty(input) && clicked)
            {
                ctlUserFirstNameError.SetError(tbUserFirstName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                ctlUserFirstNameError.SetError(tbUserFirstName, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
