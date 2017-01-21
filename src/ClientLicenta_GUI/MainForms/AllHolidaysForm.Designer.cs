namespace ClientLicenta_GUI
{
    partial class AllHolidaysForm
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
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.HolidaysGridControl = new DevExpress.XtraGrid.GridControl();
            this.HolidaysGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.HolidaysGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolidaysGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(697, 4);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 39);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            // 
            // HolidaysGridControl
            // 
            this.HolidaysGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HolidaysGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.HolidaysGridControl.Location = new System.Drawing.Point(4, 4);
            this.HolidaysGridControl.MainView = this.HolidaysGridView;
            this.HolidaysGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.HolidaysGridControl.Name = "HolidaysGridControl";
            this.HolidaysGridControl.Size = new System.Drawing.Size(800, 338);
            this.HolidaysGridControl.TabIndex = 2;
            this.HolidaysGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HolidaysGridView});
            // 
            // HolidaysGridView
            // 
            this.HolidaysGridView.GridControl = this.HolidaysGridControl;
            this.HolidaysGridView.Name = "HolidaysGridView";
            this.HolidaysGridView.OptionsView.ShowGroupPanel = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HolidaysGridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.32407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.67593F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 432);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.BackButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 349);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(802, 80);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // AllHolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AllHolidaysForm";
            this.Text = "All Holidays";
            this.Load += new System.EventHandler(this.AllHolidaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HolidaysGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HolidaysGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BackButton;
        private DevExpress.XtraGrid.GridControl HolidaysGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView HolidaysGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    }
}