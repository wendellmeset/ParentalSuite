
namespace ParantelFixWin
{
    partial class ParantelFixWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParantelFixWin));
            this.MainLabel = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainLabel.Location = new System.Drawing.Point(71, 57);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1529, 156);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Welcome To The Built In Automatic ParantelFixWin Application! \r\nThis helpful Micr" +
    "osoft utility should restore your parantel control settings.\r\n And repair your d" +
    "evice.\r\n";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(652, 776);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(366, 96);
            this.button0.TabIndex = 1;
            this.button0.Text = "Start Fix";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(662, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 330);
            this.panel1.TabIndex = 2;
            // 
            // ParantelFixWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1682, 1002);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.MainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParantelFixWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParantelFixWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Panel panel1;
    }
}

