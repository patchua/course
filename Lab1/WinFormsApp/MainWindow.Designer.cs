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
            this.Chargers = new System.Windows.Forms.ListBox();
            this.PlaybackDevices = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Chargers
            // 
            this.Chargers.FormattingEnabled = true;
            this.Chargers.Location = new System.Drawing.Point(3, 6);
            this.Chargers.Name = "Chargers";
            this.Chargers.Size = new System.Drawing.Size(280, 173);
            this.Chargers.TabIndex = 0;
            this.Chargers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PlaybackDevices
            // 
            this.PlaybackDevices.FormattingEnabled = true;
            this.PlaybackDevices.Location = new System.Drawing.Point(0, 212);
            this.PlaybackDevices.Name = "PlaybackDevices";
            this.PlaybackDevices.Size = new System.Drawing.Size(282, 173);
            this.PlaybackDevices.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 424);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlaybackDevices);
            this.Controls.Add(this.Chargers);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Chargers;
        private System.Windows.Forms.ListBox PlaybackDevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

