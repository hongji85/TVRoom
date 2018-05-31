namespace TVRoom
{
    partial class Form1
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
            this.btnEnterTVRoom = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitTVRoom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSessions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculateTimeOn = new System.Windows.Forms.Button();
            this.lblTimeOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnterTVRoom
            // 
            this.btnEnterTVRoom.Location = new System.Drawing.Point(262, 4);
            this.btnEnterTVRoom.Name = "btnEnterTVRoom";
            this.btnEnterTVRoom.Size = new System.Drawing.Size(104, 23);
            this.btnEnterTVRoom.TabIndex = 0;
            this.btnEnterTVRoom.Text = "Enter TV Room";
            this.btnEnterTVRoom.UseVisualStyleBackColor = true;
            this.btnEnterTVRoom.Click += new System.EventHandler(this.btnEnterTVRoom_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(92, 6);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(164, 20);
            this.txtPersonName.TabIndex = 1;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(92, 32);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(164, 121);
            this.lbUsers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Person Name:";
            // 
            // btnExitTVRoom
            // 
            this.btnExitTVRoom.Location = new System.Drawing.Point(262, 130);
            this.btnExitTVRoom.Name = "btnExitTVRoom";
            this.btnExitTVRoom.Size = new System.Drawing.Size(104, 23);
            this.btnExitTVRoom.TabIndex = 4;
            this.btnExitTVRoom.Text = "Exit TV Room";
            this.btnExitTVRoom.UseVisualStyleBackColor = true;
            this.btnExitTVRoom.Click += new System.EventHandler(this.btnExitTVRoom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sessions:";
            // 
            // lbSessions
            // 
            this.lbSessions.FormattingEnabled = true;
            this.lbSessions.Location = new System.Drawing.Point(92, 168);
            this.lbSessions.Name = "lbSessions";
            this.lbSessions.Size = new System.Drawing.Size(601, 121);
            this.lbSessions.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total time on:";
            // 
            // btnCalculateTimeOn
            // 
            this.btnCalculateTimeOn.Location = new System.Drawing.Point(262, 299);
            this.btnCalculateTimeOn.Name = "btnCalculateTimeOn";
            this.btnCalculateTimeOn.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateTimeOn.TabIndex = 8;
            this.btnCalculateTimeOn.Text = "Calculate";
            this.btnCalculateTimeOn.UseVisualStyleBackColor = true;
            this.btnCalculateTimeOn.Click += new System.EventHandler(this.btnCalculateTimeOn_Click);
            // 
            // lblTimeOn
            // 
            this.lblTimeOn.AutoSize = true;
            this.lblTimeOn.Location = new System.Drawing.Point(89, 304);
            this.lblTimeOn.Name = "lblTimeOn";
            this.lblTimeOn.Size = new System.Drawing.Size(0, 13);
            this.lblTimeOn.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 353);
            this.Controls.Add(this.lblTimeOn);
            this.Controls.Add(this.btnCalculateTimeOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSessions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitTVRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnEnterTVRoom);
            this.Name = "Form1";
            this.Text = "TV Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterTVRoom;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitTVRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSessions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateTimeOn;
        private System.Windows.Forms.Label lblTimeOn;
    }
}

