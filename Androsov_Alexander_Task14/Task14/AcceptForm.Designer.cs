namespace Task14
{
    partial class AcceptForm
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
            this.lblAccept = new System.Windows.Forms.Label();
            this.btnAcceptingOk = new System.Windows.Forms.Button();
            this.btnAcceptingNone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccept
            // 
            this.lblAccept.AutoSize = true;
            this.lblAccept.Location = new System.Drawing.Point(76, 9);
            this.lblAccept.Name = "lblAccept";
            this.lblAccept.Size = new System.Drawing.Size(74, 13);
            this.lblAccept.TabIndex = 0;
            this.lblAccept.Text = "Вы уверены?";
            // 
            // btnAcceptingOk
            // 
            this.btnAcceptingOk.Location = new System.Drawing.Point(12, 42);
            this.btnAcceptingOk.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnAcceptingOk.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAcceptingOk.Name = "btnAcceptingOk";
            this.btnAcceptingOk.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptingOk.TabIndex = 1;
            this.btnAcceptingOk.Text = "Да";
            this.btnAcceptingOk.UseVisualStyleBackColor = true;
            this.btnAcceptingOk.Click += new System.EventHandler(this.btnAcceptingOk_Click);
            // 
            // btnAcceptingNone
            // 
            this.btnAcceptingNone.Location = new System.Drawing.Point(140, 42);
            this.btnAcceptingNone.Name = "btnAcceptingNone";
            this.btnAcceptingNone.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptingNone.TabIndex = 2;
            this.btnAcceptingNone.Text = "Нет";
            this.btnAcceptingNone.UseVisualStyleBackColor = true;
            this.btnAcceptingNone.Click += new System.EventHandler(this.btnAcceptingNone_Click);
            // 
            // AcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 77);
            this.Controls.Add(this.btnAcceptingNone);
            this.Controls.Add(this.btnAcceptingOk);
            this.Controls.Add(this.lblAccept);
            this.MaximumSize = new System.Drawing.Size(243, 115);
            this.MinimumSize = new System.Drawing.Size(243, 115);
            this.Name = "AcceptForm";
            this.Text = "Подтверждение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccept;
        private System.Windows.Forms.Button btnAcceptingOk;
        private System.Windows.Forms.Button btnAcceptingNone;
    }
}