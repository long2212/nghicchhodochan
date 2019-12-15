namespace nghichchodochan
{
    partial class FAdmin
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtwListQueOfData = new System.Windows.Forms.DataGridView();
            this.pnlListQue = new System.Windows.Forms.Panel();
            this.gbxListQue = new System.Windows.Forms.GroupBox();
            this.btnReLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtwListQueOfData)).BeginInit();
            this.gbxListQue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(405, 342);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(119, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Bắt đầu thi";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa Câu hỏi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(616, 342);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Biểu đồ";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // dtwListQueOfData
            // 
            this.dtwListQueOfData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwListQueOfData.Location = new System.Drawing.Point(12, 12);
            this.dtwListQueOfData.Name = "dtwListQueOfData";
            this.dtwListQueOfData.RowHeadersWidth = 51;
            this.dtwListQueOfData.Size = new System.Drawing.Size(512, 324);
            this.dtwListQueOfData.TabIndex = 1;
            // 
            // pnlListQue
            // 
            this.pnlListQue.Location = new System.Drawing.Point(6, 19);
            this.pnlListQue.Name = "pnlListQue";
            this.pnlListQue.Size = new System.Drawing.Size(150, 299);
            this.pnlListQue.TabIndex = 2;
            // 
            // gbxListQue
            // 
            this.gbxListQue.Controls.Add(this.pnlListQue);
            this.gbxListQue.Location = new System.Drawing.Point(530, 12);
            this.gbxListQue.Name = "gbxListQue";
            this.gbxListQue.Size = new System.Drawing.Size(161, 325);
            this.gbxListQue.TabIndex = 3;
            this.gbxListQue.TabStop = false;
            this.gbxListQue.Text = "groupBox1";
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(12, 342);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(55, 23);
            this.btnReLoad.TabIndex = 0;
            this.btnReLoad.Text = "Tải lại";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 370);
            this.Controls.Add(this.gbxListQue);
            this.Controls.Add(this.dtwListQueOfData);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnList);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dtwListQueOfData)).EndInit();
            this.gbxListQue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dtwListQueOfData;
        private System.Windows.Forms.Panel pnlListQue;
        private System.Windows.Forms.GroupBox gbxListQue;
        private System.Windows.Forms.Button btnReLoad;
    }
}