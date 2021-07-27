
namespace DHANA
{
    partial class frmMined
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMined));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDate_Time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMiningTime = new System.Windows.Forms.Label();
            this.lbPreviousHash = new System.Windows.Forms.Label();
            this.lbBlockHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW MINED BLOCK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time to Mine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Previous Block Hash:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Block Hash:";
            // 
            // lbDate_Time
            // 
            this.lbDate_Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDate_Time.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate_Time.Location = new System.Drawing.Point(315, 249);
            this.lbDate_Time.Name = "lbDate_Time";
            this.lbDate_Time.Size = new System.Drawing.Size(229, 23);
            this.lbDate_Time.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date && Time of Creation:";
            // 
            // lbMiningTime
            // 
            this.lbMiningTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMiningTime.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiningTime.Location = new System.Drawing.Point(315, 392);
            this.lbMiningTime.Name = "lbMiningTime";
            this.lbMiningTime.Size = new System.Drawing.Size(90, 23);
            this.lbMiningTime.TabIndex = 9;
            // 
            // lbPreviousHash
            // 
            this.lbPreviousHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPreviousHash.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviousHash.Location = new System.Drawing.Point(315, 336);
            this.lbPreviousHash.Name = "lbPreviousHash";
            this.lbPreviousHash.Size = new System.Drawing.Size(613, 23);
            this.lbPreviousHash.TabIndex = 10;
            // 
            // lbBlockHash
            // 
            this.lbBlockHash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBlockHash.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlockHash.Location = new System.Drawing.Point(315, 285);
            this.lbBlockHash.Name = "lbBlockHash";
            this.lbBlockHash.Size = new System.Drawing.Size(613, 23);
            this.lbBlockHash.TabIndex = 11;
            // 
            // frmMined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 570);
            this.Controls.Add(this.lbBlockHash);
            this.Controls.Add(this.lbPreviousHash);
            this.Controls.Add(this.lbMiningTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDate_Time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmMined";
            this.Text = "Mined";
            this.Load += new System.EventHandler(this.frmMined_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDate_Time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMiningTime;
        private System.Windows.Forms.Label lbPreviousHash;
        private System.Windows.Forms.Label lbBlockHash;
    }
}