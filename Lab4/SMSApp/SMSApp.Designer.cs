namespace SMSApp
{
    partial class SMSApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.messageListView = new System.Windows.Forms.ListView();
            this.messageSender = new System.Windows.Forms.ComboBox();
            this.messageFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFormating = new System.Windows.Forms.ComboBox();
            this.applyAllFilters = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.fromDatePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toDatePicker, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.messageListView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.messageSender, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.messageFilter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFormating, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.applyAllFilters, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDatePicker.Location = new System.Drawing.Point(172, 57);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 2;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDatePicker.Location = new System.Drawing.Point(418, 57);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 3;
            // 
            // messageListView
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.messageListView, 3);
            this.messageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListView.Location = new System.Drawing.Point(3, 83);
            this.messageListView.Name = "messageListView";
            this.messageListView.Size = new System.Drawing.Size(655, 470);
            this.messageListView.TabIndex = 4;
            this.messageListView.UseCompatibleStateImageBehavior = false;
            this.messageListView.View = System.Windows.Forms.View.Tile;
            // 
            // messageSender
            // 
            this.messageSender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.messageSender, 2);
            this.messageSender.FormattingEnabled = true;
            this.messageSender.Location = new System.Drawing.Point(537, 3);
            this.messageSender.Name = "messageSender";
            this.messageSender.Size = new System.Drawing.Size(121, 21);
            this.messageSender.TabIndex = 5;
            // 
            // messageFilter
            // 
            this.messageFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.messageFilter, 2);
            this.messageFilter.Location = new System.Drawing.Point(558, 30);
            this.messageFilter.Name = "messageFilter";
            this.messageFilter.Size = new System.Drawing.Size(100, 20);
            this.messageFilter.TabIndex = 6;
            // 
            // comboBoxFormating
            // 
            this.comboBoxFormating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFormating.FormattingEnabled = true;
            this.comboBoxFormating.Location = new System.Drawing.Point(24, 30);
            this.comboBoxFormating.Name = "comboBoxFormating";
            this.comboBoxFormating.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormating.TabIndex = 0;
            // 
            // applyAllFilters
            // 
            this.applyAllFilters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyAllFilters.AutoSize = true;
            this.applyAllFilters.Location = new System.Drawing.Point(3, 58);
            this.applyAllFilters.Name = "applyAllFilters";
            this.applyAllFilters.Size = new System.Drawing.Size(163, 17);
            this.applyAllFilters.TabIndex = 7;
            this.applyAllFilters.Text = "Apply all filters simultaneously";
            this.applyAllFilters.UseVisualStyleBackColor = true;
            // 
            // SMSApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SMSApp";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMSApp_FormClosing);
            this.Load += new System.EventHandler(this.SMSApp_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxFormating;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.ListView messageListView;
        private System.Windows.Forms.ComboBox messageSender;
        private System.Windows.Forms.TextBox messageFilter;
        private System.Windows.Forms.CheckBox applyAllFilters;
    }
}

