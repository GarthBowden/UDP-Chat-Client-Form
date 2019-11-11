namespace UDPChatClientForm
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
            this.btnSendBroadcast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.tbBroadcastText = new System.Windows.Forms.TextBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendBroadcast
            // 
            this.btnSendBroadcast.Location = new System.Drawing.Point(9, 135);
            this.btnSendBroadcast.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendBroadcast.Name = "btnSendBroadcast";
            this.btnSendBroadcast.Size = new System.Drawing.Size(168, 19);
            this.btnSendBroadcast.TabIndex = 0;
            this.btnSendBroadcast.Text = "Send Broadcast";
            this.btnSendBroadcast.UseVisualStyleBackColor = true;
            this.btnSendBroadcast.Click += new System.EventHandler(this.BtnSendBroadcast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(76, 2);
            this.tbLocalPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(87, 20);
            this.tbLocalPort.TabIndex = 4;
            this.tbLocalPort.Text = "23001";
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.Location = new System.Drawing.Point(76, 28);
            this.tbRemotePort.Margin = new System.Windows.Forms.Padding(2);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(87, 20);
            this.tbRemotePort.TabIndex = 5;
            this.tbRemotePort.Text = "23000";
            // 
            // tbBroadcastText
            // 
            this.tbBroadcastText.Location = new System.Drawing.Point(9, 83);
            this.tbBroadcastText.Margin = new System.Windows.Forms.Padding(2);
            this.tbBroadcastText.Multiline = true;
            this.tbBroadcastText.Name = "tbBroadcastText";
            this.tbBroadcastText.Size = new System.Drawing.Size(167, 48);
            this.tbBroadcastText.TabIndex = 6;
            this.tbBroadcastText.Text = "<discover>";
            // 
            // tbConsole
            // 
            this.tbConsole.Location = new System.Drawing.Point(181, 6);
            this.tbConsole.Margin = new System.Windows.Forms.Padding(2);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(415, 214);
            this.tbConsole.TabIndex = 7;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(9, 159);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(167, 20);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 229);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.tbBroadcastText);
            this.Controls.Add(this.tbRemotePort);
            this.Controls.Add(this.tbLocalPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendBroadcast);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendBroadcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.TextBox tbBroadcastText;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnSendMessage;
    }
}

