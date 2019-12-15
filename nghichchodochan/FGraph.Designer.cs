namespace nghichchodochan
{
    partial class FGraph
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
            this.btnGraph1 = new System.Windows.Forms.Button();
            this.btnGraph2 = new System.Windows.Forms.Button();
            this.btnGraph3 = new System.Windows.Forms.Button();
            this.btnGraph4 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbxListQue = new System.Windows.Forms.GroupBox();
            this.pnlListQue = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.gbxListQue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGraph1
            // 
            this.btnGraph1.Location = new System.Drawing.Point(12, 415);
            this.btnGraph1.Name = "btnGraph1";
            this.btnGraph1.Size = new System.Drawing.Size(30, 20);
            this.btnGraph1.TabIndex = 0;
            this.btnGraph1.UseVisualStyleBackColor = true;
            // 
            // btnGraph2
            // 
            this.btnGraph2.Location = new System.Drawing.Point(54, 415);
            this.btnGraph2.Name = "btnGraph2";
            this.btnGraph2.Size = new System.Drawing.Size(30, 20);
            this.btnGraph2.TabIndex = 0;
            this.btnGraph2.UseVisualStyleBackColor = true;
            // 
            // btnGraph3
            // 
            this.btnGraph3.Location = new System.Drawing.Point(96, 415);
            this.btnGraph3.Name = "btnGraph3";
            this.btnGraph3.Size = new System.Drawing.Size(30, 20);
            this.btnGraph3.TabIndex = 0;
            this.btnGraph3.UseVisualStyleBackColor = true;
            // 
            // btnGraph4
            // 
            this.btnGraph4.Location = new System.Drawing.Point(138, 415);
            this.btnGraph4.Name = "btnGraph4";
            this.btnGraph4.Size = new System.Drawing.Size(30, 20);
            this.btnGraph4.TabIndex = 0;
            this.btnGraph4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(499, 438);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // gbxListQue
            // 
            this.gbxListQue.Controls.Add(this.pnlListQue);
            this.gbxListQue.Location = new System.Drawing.Point(373, 12);
            this.gbxListQue.Name = "gbxListQue";
            this.gbxListQue.Size = new System.Drawing.Size(210, 425);
            this.gbxListQue.TabIndex = 9;
            this.gbxListQue.TabStop = false;
            this.gbxListQue.Text = "Danh sách câu hỏi";
            // 
            // pnlListQue
            // 
            this.pnlListQue.Location = new System.Drawing.Point(5, 19);
            this.pnlListQue.Name = "pnlListQue";
            this.pnlListQue.Size = new System.Drawing.Size(199, 401);
            this.pnlListQue.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlGraph);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 425);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi";
            // 
            // pnlGraph
            // 
            this.pnlGraph.Location = new System.Drawing.Point(5, 19);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(161, 400);
            this.pnlGraph.TabIndex = 2;
            // 
            // FGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxListQue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGraph4);
            this.Controls.Add(this.btnGraph3);
            this.Controls.Add(this.btnGraph2);
            this.Controls.Add(this.btnGraph1);
            this.Name = "FGraph";
            this.Text = "FGraph";
            this.gbxListQue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraph1;
        private System.Windows.Forms.Button btnGraph2;
        private System.Windows.Forms.Button btnGraph3;
        private System.Windows.Forms.Button btnGraph4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbxListQue;
        private System.Windows.Forms.Panel pnlListQue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlGraph;
    }
}