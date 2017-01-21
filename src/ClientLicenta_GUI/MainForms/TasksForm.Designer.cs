namespace ClientLicenta_GUI
{
    partial class TasksForm
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
            this.BackSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.UpdateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackSimpleButton
            // 
            this.BackSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSimpleButton.Location = new System.Drawing.Point(734, 3);
            this.BackSimpleButton.Name = "BackSimpleButton";
            this.BackSimpleButton.Size = new System.Drawing.Size(75, 32);
            this.BackSimpleButton.TabIndex = 1;
            this.BackSimpleButton.Text = "Back";
            this.BackSimpleButton.Click += new System.EventHandler(this.BackSimpleButton_Click);
            // 
            // UpdateSimpleButton
            // 
            this.UpdateSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateSimpleButton.Location = new System.Drawing.Point(906, 3);
            this.UpdateSimpleButton.Name = "UpdateSimpleButton";
            this.UpdateSimpleButton.Size = new System.Drawing.Size(75, 32);
            this.UpdateSimpleButton.TabIndex = 2;
            this.UpdateSimpleButton.Text = "Update";
            this.UpdateSimpleButton.Click += new System.EventHandler(this.UpdateSimpleButton_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.AutoSize = true;
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPanel.Location = new System.Drawing.Point(3, 33);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(984, 492);
            this.TaskPanel.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(795, 3);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status";
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(465, 3);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(52, 17);
            this.ProjectLabel.TabIndex = 1;
            this.ProjectLabel.Text = "Project";
            // 
            // TaskLabel
            // 
            this.TaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(144, 3);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(39, 17);
            this.TaskLabel.TabIndex = 0;
            this.TaskLabel.Text = "Task";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TaskPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 584);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.62195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37805F));
            this.tableLayoutPanel2.Controls.Add(this.UpdateSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BackSimpleButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 531);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 50);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.StatusLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TaskLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ProjectLabel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(984, 24);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TasksForm";
            this.Text = "Tasks";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BackSimpleButton;
        private DevExpress.XtraEditors.SimpleButton UpdateSimpleButton;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;



    }
}