namespace Interface
{
    partial class Recipe
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbRecipe = new System.Windows.Forms.Label();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.tbSearchRecipe = new System.Windows.Forms.TextBox();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.btnAddRcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(551, 361);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 77);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbRecipe
            // 
            this.lbRecipe.AutoSize = true;
            this.lbRecipe.Location = new System.Drawing.Point(60, 52);
            this.lbRecipe.Name = "lbRecipe";
            this.lbRecipe.Size = new System.Drawing.Size(68, 13);
            this.lbRecipe.TabIndex = 3;
            this.lbRecipe.Text = "Recipe Load";
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(252, 49);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(62, 20);
            this.btnSearchRecipe.TabIndex = 4;
            this.btnSearchRecipe.Text = "Search";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // tbSearchRecipe
            // 
            this.tbSearchRecipe.Location = new System.Drawing.Point(134, 49);
            this.tbSearchRecipe.Name = "tbSearchRecipe";
            this.tbSearchRecipe.Size = new System.Drawing.Size(112, 20);
            this.tbSearchRecipe.TabIndex = 5;
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.Location = new System.Drawing.Point(70, 361);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(216, 77);
            this.btnConnectPLC.TabIndex = 6;
            this.btnConnectPLC.Text = "Connect to PLC";
            this.btnConnectPLC.UseVisualStyleBackColor = true;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // btnAddRcp
            // 
            this.btnAddRcp.Location = new System.Drawing.Point(310, 361);
            this.btnAddRcp.Name = "btnAddRcp";
            this.btnAddRcp.Size = new System.Drawing.Size(216, 77);
            this.btnAddRcp.TabIndex = 6;
            this.btnAddRcp.Text = "Add Recipe";
            this.btnAddRcp.UseVisualStyleBackColor = true;
            this.btnAddRcp.Click += new System.EventHandler(this.btnAddRcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddRcp);
            this.Controls.Add(this.btnConnectPLC);
            this.Controls.Add(this.tbSearchRecipe);
            this.Controls.Add(this.btnSearchRecipe);
            this.Controls.Add(this.lbRecipe);
            this.Controls.Add(this.btnStart);
            this.Name = "Recipe";
            this.Text = "Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbRecipe;
        private System.Windows.Forms.Button btnSearchRecipe;
        private System.Windows.Forms.TextBox tbSearchRecipe;
        private System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.Button btnAddRcp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}