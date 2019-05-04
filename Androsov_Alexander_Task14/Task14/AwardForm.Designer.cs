namespace Task14
{
    partial class AwardForm
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
            this.lblAwardTitle = new System.Windows.Forms.Label();
            this.lblAwardDescription = new System.Windows.Forms.Label();
            this.tbAwardDescription = new System.Windows.Forms.TextBox();
            this.tbAwardTitle = new System.Windows.Forms.TextBox();
            this.btnAwardAdd = new System.Windows.Forms.Button();
            this.btnAwardClose = new System.Windows.Forms.Button();
            this.ctlAwardTitleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlAwardDescriptionError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardTitleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardDescriptionError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAwardTitle
            // 
            this.lblAwardTitle.AutoSize = true;
            this.lblAwardTitle.Location = new System.Drawing.Point(13, 13);
            this.lblAwardTitle.Name = "lblAwardTitle";
            this.lblAwardTitle.Size = new System.Drawing.Size(57, 13);
            this.lblAwardTitle.TabIndex = 0;
            this.lblAwardTitle.Text = "Название";
            // 
            // lblAwardDescription
            // 
            this.lblAwardDescription.AutoSize = true;
            this.lblAwardDescription.Location = new System.Drawing.Point(12, 37);
            this.lblAwardDescription.Name = "lblAwardDescription";
            this.lblAwardDescription.Size = new System.Drawing.Size(57, 13);
            this.lblAwardDescription.TabIndex = 1;
            this.lblAwardDescription.Text = "Описание";
            // 
            // tbAwardDescription
            // 
            this.tbAwardDescription.Location = new System.Drawing.Point(78, 37);
            this.tbAwardDescription.Name = "tbAwardDescription";
            this.tbAwardDescription.Size = new System.Drawing.Size(149, 20);
            this.tbAwardDescription.TabIndex = 3;
            // 
            // tbAwardTitle
            // 
            this.tbAwardTitle.Location = new System.Drawing.Point(78, 13);
            this.tbAwardTitle.Name = "tbAwardTitle";
            this.tbAwardTitle.Size = new System.Drawing.Size(149, 20);
            this.tbAwardTitle.TabIndex = 2;
            this.tbAwardTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbAwardTitle_Validating);
            this.tbAwardTitle.Validated += new System.EventHandler(this.tbAwardTitle_Validated);
            // 
            // btnAwardAdd
            // 
            this.btnAwardAdd.Location = new System.Drawing.Point(71, 63);
            this.btnAwardAdd.Name = "btnAwardAdd";
            this.btnAwardAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAwardAdd.TabIndex = 4;
            this.btnAwardAdd.Text = "OK";
            this.btnAwardAdd.UseVisualStyleBackColor = true;
            this.btnAwardAdd.Click += new System.EventHandler(this.btnAwardAdd_Click);
            // 
            // btnAwardClose
            // 
            this.btnAwardClose.Location = new System.Drawing.Point(152, 63);
            this.btnAwardClose.Name = "btnAwardClose";
            this.btnAwardClose.Size = new System.Drawing.Size(75, 23);
            this.btnAwardClose.TabIndex = 5;
            this.btnAwardClose.Text = "Отмена";
            this.btnAwardClose.UseVisualStyleBackColor = true;
            this.btnAwardClose.Click += new System.EventHandler(this.btnAwardClose_Click);
            // 
            // ctlAwardTitleError
            // 
            this.ctlAwardTitleError.ContainerControl = this;
            // 
            // ctlAwardDescriptionError
            // 
            this.ctlAwardDescriptionError.ContainerControl = this;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 92);
            this.Controls.Add(this.btnAwardClose);
            this.Controls.Add(this.btnAwardAdd);
            this.Controls.Add(this.tbAwardTitle);
            this.Controls.Add(this.tbAwardDescription);
            this.Controls.Add(this.lblAwardDescription);
            this.Controls.Add(this.lblAwardTitle);
            this.Name = "AwardForm";
            this.Text = "Награда";
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardTitleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwardDescriptionError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAwardTitle;
        private System.Windows.Forms.Label lblAwardDescription;
        private System.Windows.Forms.TextBox tbAwardDescription;
        private System.Windows.Forms.TextBox tbAwardTitle;
        private System.Windows.Forms.Button btnAwardAdd;
        private System.Windows.Forms.Button btnAwardClose;
        private System.Windows.Forms.ErrorProvider ctlAwardTitleError;
        private System.Windows.Forms.ErrorProvider ctlAwardDescriptionError;
    }
}