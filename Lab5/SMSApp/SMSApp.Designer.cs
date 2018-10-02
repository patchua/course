namespace SMSApp
{
    partial class MainForm
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.messageSender = new System.Windows.Forms.ComboBox();
            this.messageFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFormating = new System.Windows.Forms.ComboBox();
            this.applyAllFilters = new System.Windows.Forms.CheckBox();
            this.messageView = new System.Windows.Forms.DataGridView();
            this.btnSMS = new System.Windows.Forms.Button();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageView)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutPanel.ColumnCount = 3;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPanel.Controls.Add(this.fromDatePicker, 1, 2);
            this.layoutPanel.Controls.Add(this.toDatePicker, 2, 2);
            this.layoutPanel.Controls.Add(this.messageSender, 1, 0);
            this.layoutPanel.Controls.Add(this.messageFilter, 1, 1);
            this.layoutPanel.Controls.Add(this.comboBoxFormating, 0, 1);
            this.layoutPanel.Controls.Add(this.applyAllFilters, 0, 2);
            this.layoutPanel.Controls.Add(this.messageView, 0, 3);
            this.layoutPanel.Controls.Add(this.btnSMS, 0, 0);
            this.layoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 4;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(661, 556);
            this.layoutPanel.TabIndex = 0;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDatePicker.Location = new System.Drawing.Point(172, 59);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.ShowCheckBox = true;
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 2;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDatePicker.Location = new System.Drawing.Point(418, 59);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.ShowCheckBox = true;
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 3;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // messageSender
            // 
            this.messageSender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.layoutPanel.SetColumnSpan(this.messageSender, 2);
            this.messageSender.FormattingEnabled = true;
            this.messageSender.Location = new System.Drawing.Point(537, 4);
            this.messageSender.Name = "messageSender";
            this.messageSender.Size = new System.Drawing.Size(121, 21);
            this.messageSender.TabIndex = 5;
            this.messageSender.SelectedIndexChanged += new System.EventHandler(this.messageSender_SelectedIndexChanged);
            // 
            // messageFilter
            // 
            this.messageFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.layoutPanel.SetColumnSpan(this.messageFilter, 2);
            this.messageFilter.Location = new System.Drawing.Point(558, 32);
            this.messageFilter.Name = "messageFilter";
            this.messageFilter.Size = new System.Drawing.Size(100, 20);
            this.messageFilter.TabIndex = 6;
            this.messageFilter.TextChanged += new System.EventHandler(this.messageFilter_TextChanged);
            // 
            // comboBoxFormating
            // 
            this.comboBoxFormating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFormating.FormattingEnabled = true;
            this.comboBoxFormating.Location = new System.Drawing.Point(24, 32);
            this.comboBoxFormating.Name = "comboBoxFormating";
            this.comboBoxFormating.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormating.TabIndex = 0;
            // 
            // applyAllFilters
            // 
            this.applyAllFilters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyAllFilters.AutoSize = true;
            this.applyAllFilters.Location = new System.Drawing.Point(3, 60);
            this.applyAllFilters.Name = "applyAllFilters";
            this.applyAllFilters.Size = new System.Drawing.Size(163, 17);
            this.applyAllFilters.TabIndex = 7;
            this.applyAllFilters.Text = "Apply all filters simultaneously";
            this.applyAllFilters.UseVisualStyleBackColor = true;
            this.applyAllFilters.CheckedChanged += new System.EventHandler(this.applyAllFilters_CheckedChanged);
            // 
            // messageView
            // 
            this.messageView.AllowUserToAddRows = false;
            this.messageView.AllowUserToDeleteRows = false;
            this.messageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layoutPanel.SetColumnSpan(this.messageView, 3);
            this.messageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageView.Location = new System.Drawing.Point(3, 85);
            this.messageView.Name = "messageView";
            this.messageView.ReadOnly = true;
            this.messageView.Size = new System.Drawing.Size(655, 470);
            this.messageView.TabIndex = 8;
            // 
            // btnSMS
            // 
            this.btnSMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSMS.Location = new System.Drawing.Point(47, 3);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSMS.TabIndex = 9;
            this.btnSMS.Text = "Start SMS";
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 556);
            this.Controls.Add(this.layoutPanel);
            this.Name = "MainForm";
            this.Text = "SMA Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMSApp_FormClosing);
            this.Load += new System.EventHandler(this.SMSApp_Load);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.ComboBox comboBoxFormating;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.ComboBox messageSender;
        private System.Windows.Forms.TextBox messageFilter;
        private System.Windows.Forms.CheckBox applyAllFilters;
        private System.Windows.Forms.DataGridView messageView;
        private System.Windows.Forms.Button btnSMS;
    }
}

