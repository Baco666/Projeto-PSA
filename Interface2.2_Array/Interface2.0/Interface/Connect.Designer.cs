namespace Interface
{
    partial class Connect
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbCpuType = new System.Windows.Forms.ComboBox();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.tbRack = new System.Windows.Forms.TextBox();
            this.tbIPaddress = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDisconnect_ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCpuType_ = new System.Windows.Forms.ComboBox();
            this.tbSlot_ = new System.Windows.Forms.TextBox();
            this.tbRack_ = new System.Windows.Forms.TextBox();
            this.tbIPadd = new System.Windows.Forms.TextBox();
            this.lbStatus_ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.cbCpuType);
            this.panel1.Controls.Add(this.tbSlot);
            this.panel1.Controls.Add(this.tbRack);
            this.panel1.Controls.Add(this.tbIPaddress);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(248, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 216);
            this.panel1.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(152, 169);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(124, 39);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(22, 169);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 39);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // cbCpuType
            // 
            this.cbCpuType.FormattingEnabled = true;
            this.cbCpuType.Location = new System.Drawing.Point(96, 11);
            this.cbCpuType.Name = "cbCpuType";
            this.cbCpuType.Size = new System.Drawing.Size(161, 21);
            this.cbCpuType.TabIndex = 5;
            // 
            // tbSlot
            // 
            this.tbSlot.Location = new System.Drawing.Point(96, 102);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.Size = new System.Drawing.Size(161, 20);
            this.tbSlot.TabIndex = 4;
            // 
            // tbRack
            // 
            this.tbRack.Location = new System.Drawing.Point(96, 72);
            this.tbRack.Name = "tbRack";
            this.tbRack.Size = new System.Drawing.Size(161, 20);
            this.tbRack.TabIndex = 4;
            // 
            // tbIPaddress
            // 
            this.tbIPaddress.Location = new System.Drawing.Point(96, 42);
            this.tbIPaddress.Name = "tbIPaddress";
            this.tbIPaddress.Size = new System.Drawing.Size(161, 20);
            this.tbIPaddress.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(60, 134);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU type";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDisconnect_);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cbCpuType_);
            this.panel2.Controls.Add(this.tbSlot_);
            this.panel2.Controls.Add(this.tbRack_);
            this.panel2.Controls.Add(this.tbIPadd);
            this.panel2.Controls.Add(this.lbStatus_);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(186, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 216);
            this.panel2.TabIndex = 1;
            // 
            // btnDisconnect_
            // 
            this.btnDisconnect_.Location = new System.Drawing.Point(152, 169);
            this.btnDisconnect_.Name = "btnDisconnect_";
            this.btnDisconnect_.Size = new System.Drawing.Size(124, 39);
            this.btnDisconnect_.TabIndex = 6;
            this.btnDisconnect_.Text = "Disconnect";
            this.btnDisconnect_.UseVisualStyleBackColor = true;
            this.btnDisconnect_.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCpuType_
            // 
            this.cbCpuType_.FormattingEnabled = true;
            this.cbCpuType_.Location = new System.Drawing.Point(96, 11);
            this.cbCpuType_.Name = "cbCpuType_";
            this.cbCpuType_.Size = new System.Drawing.Size(161, 21);
            this.cbCpuType_.TabIndex = 5;
            // 
            // tbSlot_
            // 
            this.tbSlot_.Location = new System.Drawing.Point(96, 102);
            this.tbSlot_.Name = "tbSlot_";
            this.tbSlot_.Size = new System.Drawing.Size(161, 20);
            this.tbSlot_.TabIndex = 4;
            // 
            // tbRack_
            // 
            this.tbRack_.Location = new System.Drawing.Point(96, 72);
            this.tbRack_.Name = "tbRack_";
            this.tbRack_.Size = new System.Drawing.Size(161, 20);
            this.tbRack_.TabIndex = 4;
            // 
            // tbIPadd
            // 
            this.tbIPadd.Location = new System.Drawing.Point(96, 42);
            this.tbIPadd.Name = "tbIPadd";
            this.tbIPadd.Size = new System.Drawing.Size(161, 20);
            this.tbIPadd.TabIndex = 4;
            // 
            // lbStatus_
            // 
            this.lbStatus_.AutoSize = true;
            this.lbStatus_.Location = new System.Drawing.Point(60, 134);
            this.lbStatus_.Name = "lbStatus_";
            this.lbStatus_.Size = new System.Drawing.Size(0, 13);
            this.lbStatus_.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Slot";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rack";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "IP Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "CPU type";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(537, 294);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 57);
            this.btnGoBack.TabIndex = 26;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Connect
            // 
            this.ClientSize = new System.Drawing.Size(660, 383);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel2);
            this.Name = "Connect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbCpuType;
        private System.Windows.Forms.TextBox tbSlot;
        private System.Windows.Forms.TextBox tbRack;
        private System.Windows.Forms.TextBox tbIPaddress;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDisconnect_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbCpuType_;
        private System.Windows.Forms.TextBox tbSlot_;
        private System.Windows.Forms.TextBox tbRack_;
        private System.Windows.Forms.TextBox tbIPadd;
        private System.Windows.Forms.Label lbStatus_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGoBack;
    }
}