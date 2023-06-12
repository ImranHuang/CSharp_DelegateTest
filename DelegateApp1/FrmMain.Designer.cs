namespace DelegateApp1
{
    partial class FrmMain
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
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBroadCast = new System.Windows.Forms.Button();
            this.btnCreateChildForm = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(387, 173);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(121, 41);
            this.btnCloseAll.TabIndex = 10;
            this.btnCloseAll.Text = "关闭子窗体";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 41);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清空消息";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "广播的消息：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "收到的消息：";
            // 
            // btnBroadCast
            // 
            this.btnBroadCast.Location = new System.Drawing.Point(386, 277);
            this.btnBroadCast.Name = "btnBroadCast";
            this.btnBroadCast.Size = new System.Drawing.Size(121, 41);
            this.btnBroadCast.TabIndex = 6;
            this.btnBroadCast.Text = "广播消息";
            this.btnBroadCast.UseVisualStyleBackColor = true;
            this.btnBroadCast.Click += new System.EventHandler(this.btnBroadCast_Click);
            // 
            // btnCreateChildForm
            // 
            this.btnCreateChildForm.Location = new System.Drawing.Point(387, 49);
            this.btnCreateChildForm.Name = "btnCreateChildForm";
            this.btnCreateChildForm.Size = new System.Drawing.Size(121, 41);
            this.btnCreateChildForm.TabIndex = 7;
            this.btnCreateChildForm.Text = "创建子窗体";
            this.btnCreateChildForm.UseVisualStyleBackColor = true;
            this.btnCreateChildForm.Click += new System.EventHandler(this.btnCreateChildForm_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(17, 269);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(348, 57);
            this.txtSend.TabIndex = 4;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Black;
            this.txtContent.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(17, 49);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(348, 165);
            this.txtContent.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 350);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBroadCast);
            this.Controls.Add(this.btnCreateChildForm);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtContent);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于委托实现多窗体通信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBroadCast;
        private System.Windows.Forms.Button btnCreateChildForm;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtContent;
    }
}

