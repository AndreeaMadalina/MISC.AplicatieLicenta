namespace ClientLicenta_GUI
{
    partial class EmployeesListForm
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
            this.gridControlEmployees = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlEmployees
            // 
            this.gridControlEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployees.Location = new System.Drawing.Point(3, 3);
            this.gridControlEmployees.MainView = this.gridViewEmployees;
            this.gridControlEmployees.Name = "gridControlEmployees";
            this.gridControlEmployees.Size = new System.Drawing.Size(803, 521);
            this.gridControlEmployees.TabIndex = 0;
            this.gridControlEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployees});
            // 
            // gridViewEmployees
            // 
            this.gridViewEmployees.GridControl = this.gridControlEmployees;
            this.gridViewEmployees.Name = "gridViewEmployees";
            this.gridViewEmployees.OptionsView.ShowGroupPanel = false;
            this.gridViewEmployees.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewEmployees_RowClick);
            this.gridViewEmployees.DoubleClick += new System.EventHandler(this.gridViewEmployees_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlEmployees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 577);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonBack, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 530);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(803, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonBack
            // 
            this.simpleButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonBack.Location = new System.Drawing.Point(725, 3);
            this.simpleButtonBack.Name = "simpleButtonBack";
            this.simpleButtonBack.Size = new System.Drawing.Size(75, 32);
            this.simpleButtonBack.TabIndex = 0;
            this.simpleButtonBack.Text = "Back";
            this.simpleButtonBack.Click += new System.EventHandler(this.simpleButtonBack_Click);
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeesListForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployees)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBack;

    }
}