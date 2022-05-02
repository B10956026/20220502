
namespace _20220502
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_onlineuser = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_onlineuser
            // 
            this.lbl_onlineuser.AutoSize = true;
            this.lbl_onlineuser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_onlineuser.Location = new System.Drawing.Point(13, 19);
            this.lbl_onlineuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_onlineuser.Name = "lbl_onlineuser";
            this.lbl_onlineuser.Size = new System.Drawing.Size(134, 31);
            this.lbl_onlineuser.TabIndex = 0;
            this.lbl_onlineuser.Text = "線上使用者";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(18, 63);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 244);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IP.Location = new System.Drawing.Point(310, 63);
            this.lbl_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(115, 31);
            this.lbl_IP.TabIndex = 2;
            this.lbl_IP.Text = "Server IP";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Port.Location = new System.Drawing.Point(285, 130);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(141, 31);
            this.lbl_Port.TabIndex = 3;
            this.lbl_Port.Text = "Server Port";
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IP.Location = new System.Drawing.Point(435, 51);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(238, 39);
            this.tb_IP.TabIndex = 4;
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Port.Location = new System.Drawing.Point(435, 126);
            this.tb_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(238, 39);
            this.tb_Port.TabIndex = 5;
            // 
            // btn_Run
            // 
            this.btn_Run.AutoSize = true;
            this.btn_Run.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Run.Location = new System.Drawing.Point(435, 262);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(240, 46);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "啟動伺服器";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 321);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_onlineuser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_onlineuser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Button btn_Run;
    }
}

