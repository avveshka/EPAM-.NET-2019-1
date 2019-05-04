using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Task14
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.clUserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserShowAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlUserMenu = new System.Windows.Forms.MenuStrip();
            this.ctlUserMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlUserMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlUserMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlUserMenuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlUserMenuEditEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlUserMenuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAwards = new System.Windows.Forms.TabPage();
            this.dgvAward = new System.Windows.Forms.DataGridView();
            this.clAwardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAwardTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAwardDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlAwardMenu = new System.Windows.Forms.MenuStrip();
            this.ctlAwardMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAwardMenuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAwardMenuEditEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAwardMenuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.ctlUserMenu.SuspendLayout();
            this.tpAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAward)).BeginInit();
            this.ctlAwardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpUsers);
            this.tcMain.Controls.Add(this.tpAwards);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(800, 450);
            this.tcMain.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.dgvUsers);
            this.tpUsers.Controls.Add(this.ctlUserMenu);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(792, 424);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Пользователи";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserFirstName,
            this.clUserLastName,
            this.clUserAge,
            this.clUserShowAward,
            this.clUserID});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 27);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(786, 394);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_ColumnHeaderMouseClick);
            // 
            // clUserFirstName
            // 
            this.clUserFirstName.DataPropertyName = "FirstName";
            this.clUserFirstName.HeaderText = "Имя";
            this.clUserFirstName.Name = "clUserFirstName";
            this.clUserFirstName.Width = 54;
            // 
            // clUserLastName
            // 
            this.clUserLastName.DataPropertyName = "LastName";
            this.clUserLastName.HeaderText = "Фамилия";
            this.clUserLastName.Name = "clUserLastName";
            this.clUserLastName.Width = 81;
            // 
            // clUserAge
            // 
            this.clUserAge.DataPropertyName = "Age";
            this.clUserAge.HeaderText = "Возраст";
            this.clUserAge.Name = "clUserAge";
            this.clUserAge.Width = 74;
            // 
            // clUserShowAward
            // 
            this.clUserShowAward.DataPropertyName = "ShowAwardUser";
            this.clUserShowAward.HeaderText = "Награды";
            this.clUserShowAward.Name = "clUserShowAward";
            this.clUserShowAward.Width = 77;
            // 
            // clUserID
            // 
            this.clUserID.DataPropertyName = "ID";
            this.clUserID.HeaderText = "ID";
            this.clUserID.Name = "clUserID";
            this.clUserID.ReadOnly = true;
            this.clUserID.Visible = false;
            this.clUserID.Width = 43;
            // 
            // ctlUserMenu
            // 
            this.ctlUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlUserMenuFile,
            this.ctlUserMenuEdit});
            this.ctlUserMenu.Location = new System.Drawing.Point(3, 3);
            this.ctlUserMenu.Name = "ctlUserMenu";
            this.ctlUserMenu.Size = new System.Drawing.Size(786, 24);
            this.ctlUserMenu.TabIndex = 2;
            this.ctlUserMenu.Text = "menuStrip1";
            // 
            // ctlUserMenuFile
            // 
            this.ctlUserMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlUserMenuFileExit});
            this.ctlUserMenuFile.Name = "ctlUserMenuFile";
            this.ctlUserMenuFile.Size = new System.Drawing.Size(48, 20);
            this.ctlUserMenuFile.Text = "Файл";
            // 
            // ctlUserMenuFileExit
            // 
            this.ctlUserMenuFileExit.Name = "ctlUserMenuFileExit";
            this.ctlUserMenuFileExit.Size = new System.Drawing.Size(108, 22);
            this.ctlUserMenuFileExit.Text = "Выход";
            this.ctlUserMenuFileExit.Click += new System.EventHandler(this.ctlUserMenuFileExit_Click);
            // 
            // ctlUserMenuEdit
            // 
            this.ctlUserMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlUserMenuEditAdd,
            this.ctlUserMenuEditEdit,
            this.ctlUserMenuEditDelete});
            this.ctlUserMenuEdit.Name = "ctlUserMenuEdit";
            this.ctlUserMenuEdit.Size = new System.Drawing.Size(73, 20);
            this.ctlUserMenuEdit.Text = "Изменить";
            // 
            // ctlUserMenuEditAdd
            // 
            this.ctlUserMenuEditAdd.Name = "ctlUserMenuEditAdd";
            this.ctlUserMenuEditAdd.Size = new System.Drawing.Size(180, 22);
            this.ctlUserMenuEditAdd.Text = "Добавить...";
            this.ctlUserMenuEditAdd.Click += new System.EventHandler(this.ctlUserMenuEditAdd_Click);
            // 
            // ctlUserMenuEditEdit
            // 
            this.ctlUserMenuEditEdit.Name = "ctlUserMenuEditEdit";
            this.ctlUserMenuEditEdit.Size = new System.Drawing.Size(180, 22);
            this.ctlUserMenuEditEdit.Text = "Редактировать...";
            this.ctlUserMenuEditEdit.Click += new System.EventHandler(this.ctlUserMenuEditEdit_Click);
            // 
            // ctlUserMenuEditDelete
            // 
            this.ctlUserMenuEditDelete.Name = "ctlUserMenuEditDelete";
            this.ctlUserMenuEditDelete.Size = new System.Drawing.Size(180, 22);
            this.ctlUserMenuEditDelete.Text = "Удалить...";
            this.ctlUserMenuEditDelete.Click += new System.EventHandler(this.ctlUserMenuEditDelete_Click);
            // 
            // tpAwards
            // 
            this.tpAwards.Controls.Add(this.dgvAward);
            this.tpAwards.Controls.Add(this.ctlAwardMenu);
            this.tpAwards.Location = new System.Drawing.Point(4, 22);
            this.tpAwards.Name = "tpAwards";
            this.tpAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tpAwards.Size = new System.Drawing.Size(792, 424);
            this.tpAwards.TabIndex = 1;
            this.tpAwards.Text = "Награды";
            this.tpAwards.UseVisualStyleBackColor = true;
            // 
            // dgvAward
            // 
            this.dgvAward.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvAward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAwardID,
            this.clAwardTitle,
            this.clAwardDescription});
            this.dgvAward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAward.Location = new System.Drawing.Point(3, 27);
            this.dgvAward.Name = "dgvAward";
            this.dgvAward.Size = new System.Drawing.Size(786, 394);
            this.dgvAward.TabIndex = 0;
            this.dgvAward.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAward_ColumnHeaderMouseClick);
            // 
            // clAwardID
            // 
            this.clAwardID.DataPropertyName = "ID";
            this.clAwardID.HeaderText = "ID";
            this.clAwardID.Name = "clAwardID";
            this.clAwardID.ReadOnly = true;
            this.clAwardID.Visible = false;
            // 
            // clAwardTitle
            // 
            this.clAwardTitle.DataPropertyName = "Title";
            this.clAwardTitle.HeaderText = "Название";
            this.clAwardTitle.Name = "clAwardTitle";
            this.clAwardTitle.Width = 21;
            // 
            // clAwardDescription
            // 
            this.clAwardDescription.DataPropertyName = "Description";
            this.clAwardDescription.HeaderText = "Описание";
            this.clAwardDescription.Name = "clAwardDescription";
            this.clAwardDescription.Width = 21;
            // 
            // ctlAwardMenu
            // 
            this.ctlAwardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAwardMenuEdit});
            this.ctlAwardMenu.Location = new System.Drawing.Point(3, 3);
            this.ctlAwardMenu.Name = "ctlAwardMenu";
            this.ctlAwardMenu.Size = new System.Drawing.Size(786, 24);
            this.ctlAwardMenu.TabIndex = 1;
            this.ctlAwardMenu.Text = "menuStrip2";
            // 
            // ctlAwardMenuEdit
            // 
            this.ctlAwardMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAwardMenuEditAdd,
            this.ctlAwardMenuEditEdit,
            this.ctlAwardMenuEditDelete});
            this.ctlAwardMenuEdit.Name = "ctlAwardMenuEdit";
            this.ctlAwardMenuEdit.Size = new System.Drawing.Size(73, 20);
            this.ctlAwardMenuEdit.Text = "Изменить";
            // 
            // ctlAwardMenuEditAdd
            // 
            this.ctlAwardMenuEditAdd.Name = "ctlAwardMenuEditAdd";
            this.ctlAwardMenuEditAdd.Size = new System.Drawing.Size(180, 22);
            this.ctlAwardMenuEditAdd.Text = "Добавить";
            this.ctlAwardMenuEditAdd.Click += new System.EventHandler(this.ctlAwardMenuEditAdd_Click);
            // 
            // ctlAwardMenuEditEdit
            // 
            this.ctlAwardMenuEditEdit.Name = "ctlAwardMenuEditEdit";
            this.ctlAwardMenuEditEdit.Size = new System.Drawing.Size(180, 22);
            this.ctlAwardMenuEditEdit.Text = "Редактировать";
            this.ctlAwardMenuEditEdit.Click += new System.EventHandler(this.ctlAwardMenuEditEdit_Click);
            // 
            // ctlAwardMenuEditDelete
            // 
            this.ctlAwardMenuEditDelete.Name = "ctlAwardMenuEditDelete";
            this.ctlAwardMenuEditDelete.Size = new System.Drawing.Size(180, 22);
            this.ctlAwardMenuEditDelete.Text = "Удалить";
            this.ctlAwardMenuEditDelete.Click += new System.EventHandler(this.ctlAwardMenuEditDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMain);
            this.MainMenuStrip = this.ctlUserMenu;
            this.Name = "MainForm";
            this.Text = "Пользователи и награды";
            this.tcMain.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ctlUserMenu.ResumeLayout(false);
            this.ctlUserMenu.PerformLayout();
            this.tpAwards.ResumeLayout(false);
            this.tpAwards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAward)).EndInit();
            this.ctlAwardMenu.ResumeLayout(false);
            this.ctlAwardMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpAwards;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.DataGridView dgvAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAwardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAwardTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAwardDescription;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.MenuStrip ctlUserMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuFile;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuEditEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlUserMenuEditDelete;
        private System.Windows.Forms.MenuStrip ctlAwardMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlAwardMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlAwardMenuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem ctlAwardMenuEditEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlAwardMenuEditDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserShowAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserID;
    }
}

