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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            dgvAward.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            Storage.Initializestorage();
            dgvAward.DataSource = Storage.GetAwardList();
            dgvUsers.DataSource = Storage.GetUserList();
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = Storage.SortUser(e.ColumnIndex);
        }

        private void dgvAward_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAward.DataSource = null;
            dgvAward.DataSource = Storage.SortAward();
        }

        private void ctlUserMenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlUserMenuEditAdd_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.ShowDialog();
            if (userForm.DialogResult == DialogResult.OK)
            {
                Storage.AddUserToList(new User(userForm.FirstName, userForm.LastName, userForm.BirthDay));
                foreach (var item in userForm.AwardList)
                {
                    Storage.AddAwardForLastUser(item);
                }
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Storage.GetUserList();
            }
        }

        private void ctlUserMenuEditEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;
                UserForm userForm = new UserForm(user);
                userForm.ShowDialog();
                if (userForm.DialogResult == DialogResult.OK)
                {
                    Storage.EditUser(user, userForm.FirstName, userForm.LastName, userForm.BirthDay, userForm.AwardList);
                    dgvUsers.DataSource = null;
                    dgvUsers.DataSource = Storage.GetUserList();
                }
            }
        }

        private void ctlUserMenuEditDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                AcceptForm form = new AcceptForm();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;
                    Storage.RemoveUserFromList(user);
                }
            }
        }

        private void ctlAwardMenuEditAdd_Click(object sender, EventArgs e)
        {
            AwardForm awardForm = new AwardForm();
            awardForm.ShowDialog();
            if (awardForm.DialogResult == DialogResult.OK)
            {
                if (awardForm.Description == null)
                {
                    Storage.AddAwardToList(new Award(awardForm.Title));
                }
                else
                {
                    Storage.AddAwardToList(new Award(awardForm.Title, awardForm.Description));
                }
                dgvAward.DataSource = null;
                dgvAward.DataSource = Storage.GetAwardList();
            }
        }

        private void ctlAwardMenuEditEdit_Click(object sender, EventArgs e)
        {
            if (dgvAward.SelectedCells.Count > 0)
            {
                Award award = (Award)dgvAward.SelectedCells[0].OwningRow.DataBoundItem;
                AwardForm awardForm = new AwardForm(award);
                awardForm.ShowDialog();
                if (awardForm.DialogResult == DialogResult.OK)
                {
                    Storage.EditAward(award, awardForm.Title, awardForm.Description);
                    dgvAward.DataSource = null;
                    dgvAward.DataSource = Storage.GetAwardList();
                }
            }
        }

        private void ctlAwardMenuEditDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                AcceptForm form = new AcceptForm();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    Award award = (Award)dgvAward.SelectedCells[0].OwningRow.DataBoundItem;
                    Storage.RemoveAwardFromList(award);
                }
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = Storage.GetUserList();
            }
        }
    }
}
