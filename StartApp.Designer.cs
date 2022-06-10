namespace DownloadNetWorkImage
{
    partial class StartApp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartApp));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationHref = new System.Windows.Forms.TextBox();
            this.firstIndex = new System.Windows.Forms.TextBox();
            this.lastIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileExt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveAddress = new System.Windows.Forms.TextBox();
            this.processTips = new System.Windows.Forms.RichTextBox();
            this.errorNumberTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "批量下载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "下载文件的路径头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始序号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束序号：";
            // 
            // locationHref
            // 
            this.locationHref.AccessibleDescription = "例如：http://camnpr.com/download/image/";
            this.locationHref.Location = new System.Drawing.Point(145, 28);
            this.locationHref.Name = "locationHref";
            this.locationHref.Size = new System.Drawing.Size(420, 21);
            this.locationHref.TabIndex = 4;
            this.locationHref.Text = "http://camnpr.com/TuiJianTools/html5/img/pic/5699/";
            // 
            // firstIndex
            // 
            this.firstIndex.Location = new System.Drawing.Point(97, 68);
            this.firstIndex.Name = "firstIndex";
            this.firstIndex.Size = new System.Drawing.Size(100, 21);
            this.firstIndex.TabIndex = 5;
            this.firstIndex.Text = "1";
            // 
            // lastIndex
            // 
            this.lastIndex.Location = new System.Drawing.Point(293, 68);
            this.lastIndex.Name = "lastIndex";
            this.lastIndex.Size = new System.Drawing.Size(100, 21);
            this.lastIndex.TabIndex = 6;
            this.lastIndex.Text = "58";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "下载文件的扩展名：";
            // 
            // fileExt
            // 
            this.fileExt.Location = new System.Drawing.Point(145, 109);
            this.fileExt.Name = "fileExt";
            this.fileExt.Size = new System.Drawing.Size(100, 21);
            this.fileExt.TabIndex = 8;
            this.fileExt.Text = ".jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "保存到的地址：";
            // 
            // saveAddress
            // 
            this.saveAddress.Location = new System.Drawing.Point(123, 150);
            this.saveAddress.Name = "saveAddress";
            this.saveAddress.Size = new System.Drawing.Size(442, 21);
            this.saveAddress.TabIndex = 10;
            this.saveAddress.Text = "D:\\DownloadNetWorkImage\\download\\";
            // 
            // processTips
            // 
            this.processTips.Location = new System.Drawing.Point(30, 237);
            this.processTips.Name = "processTips";
            this.processTips.Size = new System.Drawing.Size(535, 153);
            this.processTips.TabIndex = 11;
            this.processTips.Text = "";
            // 
            // errorNumberTips
            // 
            this.errorNumberTips.AutoSize = true;
            this.errorNumberTips.ForeColor = System.Drawing.Color.Red;
            this.errorNumberTips.Location = new System.Drawing.Point(122, 201);
            this.errorNumberTips.Name = "errorNumberTips";
            this.errorNumberTips.Size = new System.Drawing.Size(0, 12);
            this.errorNumberTips.TabIndex = 12;
            // 
            // StartApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 413);
            this.Controls.Add(this.errorNumberTips);
            this.Controls.Add(this.processTips);
            this.Controls.Add(this.saveAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileExt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastIndex);
            this.Controls.Add(this.firstIndex);
            this.Controls.Add(this.locationHref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartApp";
            this.Text = "批量下载网络图（来源：camnpr）";
            this.Load += new System.EventHandler(this.StartApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationHref;
        private System.Windows.Forms.TextBox firstIndex;
        private System.Windows.Forms.TextBox lastIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileExt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox saveAddress;
		private System.Windows.Forms.RichTextBox processTips;
        private System.Windows.Forms.Label errorNumberTips;
    }
}

