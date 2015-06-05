namespace ChangeXMLConfig
{
    partial class frmConfigXML
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
            this.chkOnlineInsp = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkOnlineInsp
            // 
            this.chkOnlineInsp.AutoSize = true;
            this.chkOnlineInsp.Location = new System.Drawing.Point(78, 53);
            this.chkOnlineInsp.Name = "chkOnlineInsp";
            this.chkOnlineInsp.Size = new System.Drawing.Size(158, 24);
            this.chkOnlineInsp.TabIndex = 0;
            this.chkOnlineInsp.Text = "Online Inspection";
            this.chkOnlineInsp.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmConfigXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 244);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkOnlineInsp);
            this.Name = "frmConfigXML";
            this.Text = "ConfigXML";
            this.Load += new System.EventHandler(this.frmConfigXML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOnlineInsp;
        private System.Windows.Forms.Button btnSave;
    }
}

