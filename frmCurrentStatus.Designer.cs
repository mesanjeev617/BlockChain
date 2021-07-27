
namespace DHANA
{
    partial class frmCurrentStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrentStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalCirculating = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.llDetails = new System.Windows.Forms.LinkLabel();
            this.btnMine = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbRemaining = new System.Windows.Forms.Label();
            this.lbCurrentHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Circulating:";
            // 
            // lbTotalCirculating
            // 
            this.lbTotalCirculating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCirculating.Location = new System.Drawing.Point(542, 128);
            this.lbTotalCirculating.Name = "lbTotalCirculating";
            this.lbTotalCirculating.Size = new System.Drawing.Size(77, 23);
            this.lbTotalCirculating.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date && Time of Creation of Genesis Block:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Curent Block Hash:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Remaining to be mined:";
            // 
            // llDetails
            // 
            this.llDetails.AutoSize = true;
            this.llDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDetails.LinkColor = System.Drawing.Color.Red;
            this.llDetails.Location = new System.Drawing.Point(49, 402);
            this.llDetails.Name = "llDetails";
            this.llDetails.Size = new System.Drawing.Size(369, 20);
            this.llDetails.TabIndex = 8;
            this.llDetails.TabStop = true;
            this.llDetails.Text = "CHECK INFO ABOUT THE CURRENT BLOCK CHAIN";
            this.llDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDetails_LinkClicked);
            // 
            // btnMine
            // 
            this.btnMine.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMine.Location = new System.Drawing.Point(53, 463);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(167, 38);
            this.btnMine.TabIndex = 9;
            this.btnMine.Text = "Mine a New Block";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "CURRENT STATUS OF DHANA COIN";
            // 
            // lbDateTime
            // 
            this.lbDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDateTime.Location = new System.Drawing.Point(542, 238);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(231, 23);
            this.lbDateTime.TabIndex = 11;
            // 
            // lbRemaining
            // 
            this.lbRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRemaining.Location = new System.Drawing.Point(542, 188);
            this.lbRemaining.Name = "lbRemaining";
            this.lbRemaining.Size = new System.Drawing.Size(77, 23);
            this.lbRemaining.TabIndex = 12;
            // 
            // lbCurrentHash
            // 
            this.lbCurrentHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrentHash.Location = new System.Drawing.Point(38, 326);
            this.lbCurrentHash.Name = "lbCurrentHash";
            this.lbCurrentHash.Size = new System.Drawing.Size(651, 23);
            this.lbCurrentHash.TabIndex = 13;
            // 
            // frmCurrentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1194, 585);
            this.Controls.Add(this.lbCurrentHash);
            this.Controls.Add(this.lbRemaining);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.llDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotalCirculating);
            this.Controls.Add(this.label1);
            this.Name = "frmCurrentStatus";
            this.Text = "frmCurrentStatus";
            this.Load += new System.EventHandler(this.frmCurrentStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalCirculating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel llDetails;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbRemaining;
        private System.Windows.Forms.Label lbCurrentHash;
    }
}