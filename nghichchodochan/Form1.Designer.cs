namespace nghichchodochan
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
            this.btnTl1 = new System.Windows.Forms.Button();
            this.btnTl2 = new System.Windows.Forms.Button();
            this.btnTl4 = new System.Windows.Forms.Button();
            this.btnTl3 = new System.Windows.Forms.Button();
            this.gbCauhoi = new System.Windows.Forms.GroupBox();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviou = new System.Windows.Forms.Button();
            this.pnlCQues = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbCauhoi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTl1
            // 
            this.btnTl1.Location = new System.Drawing.Point(8, 27);
            this.btnTl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTl1.Name = "btnTl1";
            this.btnTl1.Size = new System.Drawing.Size(403, 78);
            this.btnTl1.TabIndex = 0;
            this.btnTl1.UseVisualStyleBackColor = true;
            this.btnTl1.Click += new System.EventHandler(this.btnTl1_Click);
            // 
            // btnTl2
            // 
            this.btnTl2.Location = new System.Drawing.Point(424, 27);
            this.btnTl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTl2.Name = "btnTl2";
            this.btnTl2.Size = new System.Drawing.Size(403, 78);
            this.btnTl2.TabIndex = 2;
            this.btnTl2.UseVisualStyleBackColor = true;
            this.btnTl2.Click += new System.EventHandler(this.btnTl2_Click);
            // 
            // btnTl4
            // 
            this.btnTl4.Location = new System.Drawing.Point(424, 112);
            this.btnTl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTl4.Name = "btnTl4";
            this.btnTl4.Size = new System.Drawing.Size(403, 78);
            this.btnTl4.TabIndex = 4;
            this.btnTl4.UseVisualStyleBackColor = true;
            this.btnTl4.Click += new System.EventHandler(this.btnTl4_Click);
            // 
            // btnTl3
            // 
            this.btnTl3.Location = new System.Drawing.Point(8, 112);
            this.btnTl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTl3.Name = "btnTl3";
            this.btnTl3.Size = new System.Drawing.Size(403, 78);
            this.btnTl3.TabIndex = 3;
            this.btnTl3.UseVisualStyleBackColor = true;
            this.btnTl3.Click += new System.EventHandler(this.btnTl3_Click);
            // 
            // gbCauhoi
            // 
            this.gbCauhoi.Controls.Add(this.btnCauHoi);
            this.gbCauhoi.Location = new System.Drawing.Point(16, 15);
            this.gbCauhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCauhoi.Name = "gbCauhoi";
            this.gbCauhoi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCauhoi.Size = new System.Drawing.Size(833, 183);
            this.gbCauhoi.TabIndex = 5;
            this.gbCauhoi.TabStop = false;
            this.gbCauhoi.Text = "Câu Hỏi";
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Location = new System.Drawing.Point(8, 23);
            this.btnCauHoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(819, 153);
            this.btnCauHoi.TabIndex = 0;
            this.btnCauHoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTl1);
            this.groupBox1.Controls.Add(this.btnTl3);
            this.groupBox1.Controls.Add(this.btnTl4);
            this.groupBox1.Controls.Add(this.btnTl2);
            this.groupBox1.Location = new System.Drawing.Point(16, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(835, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu trả lời";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(743, 418);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviou
            // 
            this.btnPreviou.Location = new System.Drawing.Point(635, 418);
            this.btnPreviou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviou.Name = "btnPreviou";
            this.btnPreviou.Size = new System.Drawing.Size(100, 28);
            this.btnPreviou.TabIndex = 8;
            this.btnPreviou.Text = "Trước";
            this.btnPreviou.UseVisualStyleBackColor = true;
            this.btnPreviou.Click += new System.EventHandler(this.btnPreviou_Click);
            // 
            // pnlCQues
            // 
            this.pnlCQues.Location = new System.Drawing.Point(8, 18);
            this.pnlCQues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCQues.Name = "pnlCQues";
            this.pnlCQues.Size = new System.Drawing.Size(121, 370);
            this.pnlCQues.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCQues);
            this.groupBox2.Location = new System.Drawing.Point(859, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(137, 396);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(859, 418);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 28);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Nộp bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 459);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPreviou);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCauhoi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbCauhoi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTl1;
        private System.Windows.Forms.Button btnTl2;
        private System.Windows.Forms.Button btnTl4;
        private System.Windows.Forms.Button btnTl3;
        private System.Windows.Forms.GroupBox gbCauhoi;
        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviou;
        private System.Windows.Forms.Panel pnlCQues;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinish;
    }
}

