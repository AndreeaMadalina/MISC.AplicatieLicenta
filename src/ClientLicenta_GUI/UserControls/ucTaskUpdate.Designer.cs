namespace ClientLicenta_GUI.UserControls
{
    partial class ucTaskUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(144, 3);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(76, 17);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "TaskName";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(465, 3);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(52, 17);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Project";
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.AutoSize = true;
            this.StatusCheckBox.Location = new System.Drawing.Point(795, 3);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(64, 21);
            this.StatusCheckBox.TabIndex = 6;
            this.StatusCheckBox.Text = "Done";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ucTaskUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusCheckBox);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.TaskNameLabel);
            this.Name = "ucTaskUpdate";
            this.Size = new System.Drawing.Size(984, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.CheckBox StatusCheckBox;
    }
}
