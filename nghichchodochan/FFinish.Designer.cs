namespace nghichchodochan
{
    partial class FFinish
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
            this.dgwListAns = new System.Windows.Forms.DataGridView();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListAns)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListAns
            // 
            this.dgwListAns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListAns.Location = new System.Drawing.Point(12, 12);
            this.dgwListAns.Name = "dgwListAns";
            this.dgwListAns.Size = new System.Drawing.Size(776, 405);
            this.dgwListAns.TabIndex = 0;
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.LightGreen;
            this.btnPre.Location = new System.Drawing.Point(632, 423);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Quay Lại";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LightGreen;
            this.btnFinish.Location = new System.Drawing.Point(713, 423);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Nộp bài";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // FFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.dgwListAns);
            this.Name = "FFinish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFinish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFinish_FormClosing);
            this.Load += new System.EventHandler(this.FFinish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListAns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListAns;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFinish;
    }
}