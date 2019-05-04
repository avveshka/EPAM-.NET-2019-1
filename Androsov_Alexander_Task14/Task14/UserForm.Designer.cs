using System.Windows.Forms;

namespace Task14
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserBirthDay = new System.Windows.Forms.Label();
            this.lblUserAwards = new System.Windows.Forms.Label();
            this.tbUserFirstName = new System.Windows.Forms.TextBox();
            this.tbUserLastName = new System.Windows.Forms.TextBox();
            this.dtpUserBirthDay = new System.Windows.Forms.DateTimePicker();
            this.ctlUserLastNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlUserFirstNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlUserAwards = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserLastNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserFirstNameError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(143, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Location = new System.Drawing.Point(64, 5);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblUserFirstName.TabIndex = 2;
            this.lblUserFirstName.Text = "Имя";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Location = new System.Drawing.Point(37, 31);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(56, 13);
            this.lblUserLastName.TabIndex = 3;
            this.lblUserLastName.Text = "Фамилия";
            // 
            // lblUserBirthDay
            // 
            this.lblUserBirthDay.AutoSize = true;
            this.lblUserBirthDay.Location = new System.Drawing.Point(6, 57);
            this.lblUserBirthDay.Name = "lblUserBirthDay";
            this.lblUserBirthDay.Size = new System.Drawing.Size(86, 13);
            this.lblUserBirthDay.TabIndex = 4;
            this.lblUserBirthDay.Text = "Дата рождения";
            // 
            // lblUserAwards
            // 
            this.lblUserAwards.AutoSize = true;
            this.lblUserAwards.Location = new System.Drawing.Point(41, 83);
            this.lblUserAwards.Name = "lblUserAwards";
            this.lblUserAwards.Size = new System.Drawing.Size(52, 13);
            this.lblUserAwards.TabIndex = 5;
            this.lblUserAwards.Text = "Награды";
            // 
            // tbUserFirstName
            // 
            this.tbUserFirstName.Location = new System.Drawing.Point(99, 5);
            this.tbUserFirstName.Name = "tbUserFirstName";
            this.tbUserFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbUserFirstName.TabIndex = 6;
            this.tbUserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserFirstName_Validating);
            this.tbUserFirstName.Validated += new System.EventHandler(this.tbUserFirstName_Validated);
            // 
            // tbUserLastName
            // 
            this.tbUserLastName.Location = new System.Drawing.Point(99, 31);
            this.tbUserLastName.Name = "tbUserLastName";
            this.tbUserLastName.Size = new System.Drawing.Size(200, 20);
            this.tbUserLastName.TabIndex = 7;
            this.tbUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserLastName_Validating);
            this.tbUserLastName.Validated += new System.EventHandler(this.tbUserLastName_Validated);
            // 
            // dtpUserBirthDay
            // 
            this.dtpUserBirthDay.Location = new System.Drawing.Point(99, 57);
            this.dtpUserBirthDay.Name = "dtpUserBirthDay";
            this.dtpUserBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dtpUserBirthDay.TabIndex = 8;
            // 
            // ctlUserLastNameError
            // 
            this.ctlUserLastNameError.ContainerControl = this;
            // 
            // ctlUserFirstNameError
            // 
            this.ctlUserFirstNameError.ContainerControl = this;
            // 
            // ctlUserAwards
            // 
            this.ctlUserAwards.FormattingEnabled = true;
            this.ctlUserAwards.Location = new System.Drawing.Point(99, 83);
            this.ctlUserAwards.Name = "ctlUserAwards";
            this.ctlUserAwards.Size = new System.Drawing.Size(200, 214);
            this.ctlUserAwards.TabIndex = 9;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.ctlUserAwards);
            this.Controls.Add(this.dtpUserBirthDay);
            this.Controls.Add(this.tbUserLastName);
            this.Controls.Add(this.tbUserFirstName);
            this.Controls.Add(this.lblUserAwards);
            this.Controls.Add(this.lblUserBirthDay);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.lblUserFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximumSize = new System.Drawing.Size(340, 389);
            this.MinimumSize = new System.Drawing.Size(340, 389);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserLastNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUserFirstNameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserBirthDay;
        private System.Windows.Forms.Label lblUserAwards;
        private System.Windows.Forms.TextBox tbUserFirstName;
        private System.Windows.Forms.TextBox tbUserLastName;
        private System.Windows.Forms.DateTimePicker dtpUserBirthDay;
        private System.Windows.Forms.ErrorProvider ctlUserLastNameError;
        private System.Windows.Forms.ErrorProvider ctlUserFirstNameError;
        private CheckedListBox ctlUserAwards;
    }
}