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
            this.btnApply = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxChargers = new System.Windows.Forms.GroupBox();
            this.groupBoxPlaybackDevices = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(308, 185);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(72, 30);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(3, 221);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(713, 175);
            this.textBoxOutput.TabIndex = 3;
            // 
            // groupBoxChargers
            // 
            this.groupBoxChargers.Location = new System.Drawing.Point(12, 13);
            this.groupBoxChargers.Name = "groupBoxChargers";
            this.groupBoxChargers.Size = new System.Drawing.Size(319, 163);
            this.groupBoxChargers.TabIndex = 6;
            this.groupBoxChargers.TabStop = false;
            this.groupBoxChargers.Text = "Charging devices";
            // 
            // groupBoxPlaybackDevices
            // 
            this.groupBoxPlaybackDevices.Location = new System.Drawing.Point(338, 13);
            this.groupBoxPlaybackDevices.Name = "groupBoxPlaybackDevices";
            this.groupBoxPlaybackDevices.Size = new System.Drawing.Size(378, 163);
            this.groupBoxPlaybackDevices.TabIndex = 8;
            this.groupBoxPlaybackDevices.TabStop = false;
            this.groupBoxPlaybackDevices.Text = "Playback devices";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 408);
            this.Controls.Add(this.groupBoxPlaybackDevices);
            this.Controls.Add(this.groupBoxChargers);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxChargers;
        private System.Windows.Forms.GroupBox groupBoxPlaybackDevices;
    }
}

