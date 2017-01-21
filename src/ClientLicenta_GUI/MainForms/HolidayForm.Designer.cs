namespace ClientLicenta_GUI
{
    partial class HolidayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidayForm));
            this.SubmitButton = new DevExpress.XtraEditors.SimpleButton();
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarDateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.StartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.SeeHollidaysSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 482);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 45);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 420);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 45);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(841, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(841, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "From:";
            // 
            // CalendarDateNavigator
            // 
            this.CalendarDateNavigator.AppearanceCalendar.BackColor = System.Drawing.Color.Silver;
            this.CalendarDateNavigator.AppearanceCalendar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalendarDateNavigator.AppearanceCalendar.Image = ((System.Drawing.Image)(resources.GetObject("CalendarDateNavigator.AppearanceCalendar.Image")));
            this.CalendarDateNavigator.AppearanceCalendar.Options.UseBackColor = true;
            this.CalendarDateNavigator.AppearanceCalendar.Options.UseFont = true;
            this.CalendarDateNavigator.AppearanceCalendar.Options.UseImage = true;
            this.CalendarDateNavigator.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalendarDateNavigator.AppearanceHeader.Options.UseFont = true;
            this.CalendarDateNavigator.AppearanceWeekNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalendarDateNavigator.AppearanceWeekNumber.ForeColor = System.Drawing.Color.Green;
            this.CalendarDateNavigator.AppearanceWeekNumber.Options.UseFont = true;
            this.CalendarDateNavigator.AppearanceWeekNumber.Options.UseForeColor = true;
            this.CalendarDateNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CalendarDateNavigator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.CalendarDateNavigator.DateTime = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.CalendarDateNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalendarDateNavigator.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.CalendarDateNavigator.HotDate = null;
            this.CalendarDateNavigator.Location = new System.Drawing.Point(12, 12);
            this.CalendarDateNavigator.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CalendarDateNavigator.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CalendarDateNavigator.LookAndFeel.UseWindowsXPTheme = true;
            this.CalendarDateNavigator.Name = "CalendarDateNavigator";
            this.CalendarDateNavigator.Size = new System.Drawing.Size(331, 299);
            this.CalendarDateNavigator.TabIndex = 25;
            // 
            // StartDateEdit
            // 
            this.StartDateEdit.EditValue = new System.DateTime(2016, 7, 1, 23, 28, 27, 353);
            this.StartDateEdit.Location = new System.Drawing.Point(846, 55);
            this.StartDateEdit.Name = "StartDateEdit";
            this.StartDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.StartDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.StartDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.StartDateEdit.Properties.Appearance.Options.UseFont = true;
            this.StartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateEdit.Size = new System.Drawing.Size(177, 28);
            this.StartDateEdit.TabIndex = 26;
            // 
            // EndDateEdit
            // 
            this.EndDateEdit.EditValue = new System.DateTime(2016, 7, 1, 23, 21, 48, 946);
            this.EndDateEdit.Location = new System.Drawing.Point(846, 145);
            this.EndDateEdit.Name = "EndDateEdit";
            this.EndDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.EndDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.EndDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.EndDateEdit.Properties.Appearance.Options.UseFont = true;
            this.EndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateEdit.Size = new System.Drawing.Size(177, 28);
            this.EndDateEdit.TabIndex = 27;
            // 
            // SeeHollidaysSimpleButton
            // 
            this.SeeHollidaysSimpleButton.Location = new System.Drawing.Point(12, 545);
            this.SeeHollidaysSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SeeHollidaysSimpleButton.Name = "SeeHollidaysSimpleButton";
            this.SeeHollidaysSimpleButton.Size = new System.Drawing.Size(125, 45);
            this.SeeHollidaysSimpleButton.TabIndex = 28;
            this.SeeHollidaysSimpleButton.Text = "See all holidays";
            this.SeeHollidaysSimpleButton.Click += new System.EventHandler(this.SeeHollidaysSimpleButton_Click);
            // 
            // HolidayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 697);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SeeHollidaysSimpleButton);
            this.Controls.Add(this.EndDateEdit);
            this.Controls.Add(this.CalendarDateNavigator);
            this.Controls.Add(this.StartDateEdit);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HolidayForm";
            this.Text = "Holiday";
            ((System.ComponentModel.ISupportInitialize)(this.CalendarDateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SubmitButton;
        private DevExpress.XtraEditors.SimpleButton BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.DateNavigator CalendarDateNavigator;
        private DevExpress.XtraEditors.DateEdit StartDateEdit;
        private DevExpress.XtraEditors.DateEdit EndDateEdit;
        private DevExpress.XtraEditors.SimpleButton SeeHollidaysSimpleButton;

    }
}