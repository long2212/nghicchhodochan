﻿namespace nghichchodochan
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
            this.btnTl1.Location = new System.Drawing.Point(6, 22);
            this.btnTl1.Name = "btnTl1";
            this.btnTl1.Size = new System.Drawing.Size(302, 63);
            this.btnTl1.TabIndex = 0;
            this.btnTl1.UseVisualStyleBackColor = true;
            this.btnTl1.Click += new System.EventHandler(this.btnTl1_Click);
            // 
            // btnTl2
            // 
            this.btnTl2.Location = new System.Drawing.Point(318, 22);
            this.btnTl2.Name = "btnTl2";
            this.btnTl2.Size = new System.Drawing.Size(302, 63);
            this.btnTl2.TabIndex = 2;
            this.btnTl2.UseVisualStyleBackColor = true;
            this.btnTl2.Click += new System.EventHandler(this.btnTl2_Click);
            // 
            // btnTl4
            // 
            this.btnTl4.Location = new System.Drawing.Point(318, 91);
            this.btnTl4.Name = "btnTl4";
            this.btnTl4.Size = new System.Drawing.Size(302, 63);
            this.btnTl4.TabIndex = 4;
            this.btnTl4.UseVisualStyleBackColor = true;
            this.btnTl4.Click += new System.EventHandler(this.btnTl4_Click);
            // 
            // btnTl3
            // 
            this.btnTl3.Location = new System.Drawing.Point(6, 91);
            this.btnTl3.Name = "btnTl3";
            this.btnTl3.Size = new System.Drawing.Size(302, 63);
            this.btnTl3.TabIndex = 3;
            this.btnTl3.UseVisualStyleBackColor = true;
            this.btnTl3.Click += new System.EventHandler(this.btnTl3_Click);
            // 
            // gbCauhoi
            // 
            this.gbCauhoi.Controls.Add(this.btnCauHoi);
            this.gbCauhoi.Location = new System.Drawing.Point(12, 12);
            this.gbCauhoi.Name = "gbCauhoi";
            this.gbCauhoi.Size = new System.Drawing.Size(625, 149);
            this.gbCauhoi.TabIndex = 5;
            this.gbCauhoi.TabStop = false;
            this.gbCauhoi.Text = "Câu Hỏi";
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Location = new System.Drawing.Point(6, 19);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(614, 124);
            this.btnCauHoi.TabIndex = 0;
            this.btnCauHoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTl1);
            this.groupBox1.Controls.Add(this.btnTl3);
            this.groupBox1.Controls.Add(this.btnTl4);
            this.groupBox1.Controls.Add(this.btnTl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu trả lời";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(557, 340);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviou
            // 
            this.btnPreviou.Location = new System.Drawing.Point(476, 340);
            this.btnPreviou.Name = "btnPreviou";
            this.btnPreviou.Size = new System.Drawing.Size(75, 23);
            this.btnPreviou.TabIndex = 8;
            this.btnPreviou.Text = "Trước";
            this.btnPreviou.UseVisualStyleBackColor = true;
            this.btnPreviou.Click += new System.EventHandler(this.btnPreviou_Click);
            // 
            // pnlCQues
            // 
            this.pnlCQues.Location = new System.Drawing.Point(6, 13);
            this.pnlCQues.Name = "pnlCQues";
            this.pnlCQues.Size = new System.Drawing.Size(63, 301);
            this.pnlCQues.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlCQues);
            this.groupBox2.Location = new System.Drawing.Point(644, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 322);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(644, 340);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Nộp bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 373);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPreviou);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCauhoi);
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

