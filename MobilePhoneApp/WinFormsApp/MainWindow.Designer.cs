namespace WinFormsApp
{
    partial class MainWindow
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxChargers = new System.Windows.Forms.GroupBox();
            this.btnApplyAudio = new System.Windows.Forms.Button();
            this.groupBoxPlaybackDevices = new System.Windows.Forms.GroupBox();
            this.btnApplyCharger = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxOutput, 2);
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 64);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(602, 277);
            this.textBoxOutput.TabIndex = 3;
            // 
            // groupBoxChargers
            // 
            this.groupBoxChargers.AutoSize = true;
            this.groupBoxChargers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxChargers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChargers.Location = new System.Drawing.Point(3, 3);
            this.groupBoxChargers.Name = "groupBoxChargers";
            this.groupBoxChargers.Size = new System.Drawing.Size(72, 19);
            this.groupBoxChargers.TabIndex = 6;
            this.groupBoxChargers.TabStop = false;
            this.groupBoxChargers.Text = "Charging devices";
            // 
            // btnApplyAudio
            // 
            this.btnApplyAudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplyAudio.Location = new System.Drawing.Point(307, 28);
            this.btnApplyAudio.Name = "btnApplyAudio";
            this.btnApplyAudio.Size = new System.Drawing.Size(72, 30);
            this.btnApplyAudio.TabIndex = 9;
            this.btnApplyAudio.Text = "Apply";
            this.btnApplyAudio.UseVisualStyleBackColor = true;
            this.btnApplyAudio.Click += new System.EventHandler(this.btnApplyAudio_Click);
            // 
            // groupBoxPlaybackDevices
            // 
            this.groupBoxPlaybackDevices.AutoSize = true;
            this.groupBoxPlaybackDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxPlaybackDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPlaybackDevices.Location = new System.Drawing.Point(81, 3);
            this.groupBoxPlaybackDevices.Name = "groupBoxPlaybackDevices";
            this.groupBoxPlaybackDevices.Size = new System.Drawing.Size(524, 19);
            this.groupBoxPlaybackDevices.TabIndex = 8;
            this.groupBoxPlaybackDevices.TabStop = false;
            this.groupBoxPlaybackDevices.Text = "Playback devices";
            // 
            // btnApplyCharger
            // 
            this.btnApplyCharger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplyCharger.Location = new System.Drawing.Point(3, 28);
            this.btnApplyCharger.Name = "btnApplyCharger";
            this.btnApplyCharger.Size = new System.Drawing.Size(72, 30);
            this.btnApplyCharger.TabIndex = 2;
            this.btnApplyCharger.Text = "Apply";
            this.btnApplyCharger.UseVisualStyleBackColor = true;
            this.btnApplyCharger.Click += new System.EventHandler(this.btnApplyCharger_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnApplyCharger, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPlaybackDevices, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnApplyAudio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxChargers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOutput, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 344);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(608, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "MobilePhoneApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnApplyCharger;
        private System.Windows.Forms.GroupBox groupBoxPlaybackDevices;
        private System.Windows.Forms.Button btnApplyAudio;
        private System.Windows.Forms.GroupBox groupBoxChargers;
    }
}

