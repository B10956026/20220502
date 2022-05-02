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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Broadcast = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.btn_Login_Server = new System.Windows.Forms.Button();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.tb_player = new System.Windows.Forms.TextBox();
            this.lbl_player = new System.Windows.Forms.Label();
            this.lbl_onlineuser = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Kanban = new System.Windows.Forms.TextBox();
            this.tb_Msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Broadcast
            // 
            this.btn_Broadcast.AutoSize = true;
            this.btn_Broadcast.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Broadcast.Location = new System.Drawing.Point(692, 12);
            this.btn_Broadcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Broadcast.Name = "btn_Broadcast";
            this.btn_Broadcast.Size = new System.Drawing.Size(225, 46);
            this.btn_Broadcast.TabIndex = 112;
            this.btn_Broadcast.Text = "廣播";
            this.btn_Broadcast.UseVisualStyleBackColor = true;
            this.btn_Broadcast.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Msg.Location = new System.Drawing.Point(18, 586);
            this.lbl_Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(110, 31);
            this.lbl_Msg.TabIndex = 111;
            this.lbl_Msg.Text = "發言內容";
            // 
            // btn_Login_Server
            // 
            this.btn_Login_Server.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login_Server.Location = new System.Drawing.Point(504, 76);
            this.btn_Login_Server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login_Server.Name = "btn_Login_Server";
            this.btn_Login_Server.Size = new System.Drawing.Size(174, 46);
            this.btn_Login_Server.TabIndex = 110;
            this.btn_Login_Server.Text = "登入伺服器";
            this.btn_Login_Server.UseVisualStyleBackColor = true;
            this.btn_Login_Server.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Port.Location = new System.Drawing.Point(504, 15);
            this.tb_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(172, 39);
            this.tb_Port.TabIndex = 109;
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Port.Location = new System.Drawing.Point(360, 20);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(134, 31);
            this.lbl_Port.TabIndex = 108;
            this.lbl_Port.Text = "伺服器Port";
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IP.Location = new System.Drawing.Point(136, 15);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(172, 39);
            this.tb_IP.TabIndex = 107;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IP.Location = new System.Drawing.Point(18, 20);
            this.lbl_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(108, 31);
            this.lbl_IP.TabIndex = 106;
            this.lbl_IP.Text = "伺服器IP";
            // 
            // tb_player
            // 
            this.tb_player.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_player.Location = new System.Drawing.Point(136, 80);
            this.tb_player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_player.Name = "tb_player";
            this.tb_player.Size = new System.Drawing.Size(170, 39);
            this.tb_player.TabIndex = 105;
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_player.Location = new System.Drawing.Point(16, 84);
            this.lbl_player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(110, 31);
            this.lbl_player.TabIndex = 104;
            this.lbl_player.Text = "玩家名稱";
            // 
            // lbl_onlineuser
            // 
            this.lbl_onlineuser.AutoSize = true;
            this.lbl_onlineuser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_onlineuser.Location = new System.Drawing.Point(738, 92);
            this.lbl_onlineuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_onlineuser.Name = "lbl_onlineuser";
            this.lbl_onlineuser.Size = new System.Drawing.Size(134, 31);
            this.lbl_onlineuser.TabIndex = 103;
            this.lbl_onlineuser.Text = "線上使用者";
            // 
            // ListBox1
            // 
            this.ListBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 30;
            this.ListBox1.Location = new System.Drawing.Point(705, 160);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(210, 394);
            this.ListBox1.TabIndex = 102;
            // 
            // btn_Submit
            // 
            this.btn_Submit.AutoSize = true;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.Location = new System.Drawing.Point(789, 579);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(128, 46);
            this.btn_Submit.TabIndex = 101;
            this.btn_Submit.Text = "送出";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tb_Kanban
            // 
            this.tb_Kanban.Location = new System.Drawing.Point(24, 160);
            this.tb_Kanban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Kanban.Multiline = true;
            this.tb_Kanban.Name = "tb_Kanban";
            this.tb_Kanban.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Kanban.Size = new System.Drawing.Size(652, 394);
            this.tb_Kanban.TabIndex = 100;
            // 
            // tb_Msg
            // 
            this.tb_Msg.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Msg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Msg.Location = new System.Drawing.Point(138, 582);
            this.tb_Msg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Msg.Name = "tb_Msg";
            this.tb_Msg.Size = new System.Drawing.Size(634, 39);
            this.tb_Msg.TabIndex = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 642);
            this.Controls.Add(this.btn_Broadcast);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.btn_Login_Server);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.tb_player);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.lbl_onlineuser);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Kanban);
            this.Controls.Add(this.tb_Msg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP 聊天室客戶端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Broadcast;
        internal System.Windows.Forms.Label lbl_Msg;
        internal System.Windows.Forms.Button btn_Login_Server;
        internal System.Windows.Forms.TextBox tb_Port;
        internal System.Windows.Forms.Label lbl_Port;
        internal System.Windows.Forms.TextBox tb_IP;
        internal System.Windows.Forms.Label lbl_IP;
        internal System.Windows.Forms.TextBox tb_player;
        internal System.Windows.Forms.Label lbl_player;
        internal System.Windows.Forms.Label lbl_onlineuser;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button btn_Submit;
        internal System.Windows.Forms.TextBox tb_Kanban;
        internal System.Windows.Forms.TextBox tb_Msg;
    }
}

