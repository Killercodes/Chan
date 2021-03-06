namespace Chanmongler
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fAlt2 = new System.Windows.Forms.GroupBox();
            this.cmdThread = new System.Windows.Forms.Button();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fAlt1 = new System.Windows.Forms.GroupBox();
            this.cbBoard = new System.Windows.Forms.ComboBox();
            this.cmdBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fStatus = new System.Windows.Forms.GroupBox();
            this.lPicture = new System.Windows.Forms.Label();
            this.lPUrl = new System.Windows.Forms.Label();
            this.lThread = new System.Windows.Forms.Label();
            this.tThreadState = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lTarget = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lState = new System.Windows.Forms.Label();
            this.tDownload = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdContact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdNews = new System.Windows.Forms.Button();
            this.lbDummy = new System.Windows.Forms.Label();
            this.fAlt2.SuspendLayout();
            this.fAlt1.SuspendLayout();
            this.fStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fAlt2
            // 
            this.fAlt2.Controls.Add(this.cmdThread);
            this.fAlt2.Controls.Add(this.txtThread);
            this.fAlt2.Controls.Add(this.label2);
            this.fAlt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fAlt2.ForeColor = System.Drawing.Color.Azure;
            this.fAlt2.Location = new System.Drawing.Point(12, 255);
            this.fAlt2.Name = "fAlt2";
            this.fAlt2.Size = new System.Drawing.Size(268, 46);
            this.fAlt2.TabIndex = 4;
            this.fAlt2.TabStop = false;
            this.fAlt2.Text = "Alt 2: Get thread";
            // 
            // cmdThread
            // 
            this.cmdThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmdThread.ForeColor = System.Drawing.Color.Azure;
            this.cmdThread.Location = new System.Drawing.Point(238, 17);
            this.cmdThread.Name = "cmdThread";
            this.cmdThread.Size = new System.Drawing.Size(24, 23);
            this.cmdThread.TabIndex = 0;
            this.cmdThread.Text = "->";
            this.cmdThread.UseVisualStyleBackColor = false;
            this.cmdThread.Click += new System.EventHandler(this.cmdThread_Click);
            // 
            // txtThread
            // 
            this.txtThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtThread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThread.ForeColor = System.Drawing.Color.Azure;
            this.txtThread.Location = new System.Drawing.Point(56, 19);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(176, 20);
            this.txtThread.TabIndex = 1;
            this.txtThread.Text = "Doubleclick here to paste URL";
            this.txtThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThread.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtThread_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thread:";
            // 
            // fAlt1
            // 
            this.fAlt1.Controls.Add(this.cbBoard);
            this.fAlt1.Controls.Add(this.cmdBoard);
            this.fAlt1.Controls.Add(this.label1);
            this.fAlt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fAlt1.ForeColor = System.Drawing.Color.Azure;
            this.fAlt1.Location = new System.Drawing.Point(12, 177);
            this.fAlt1.Name = "fAlt1";
            this.fAlt1.Size = new System.Drawing.Size(268, 46);
            this.fAlt1.TabIndex = 3;
            this.fAlt1.TabStop = false;
            this.fAlt1.Text = "Alt 1: Get entire board";
            // 
            // cbBoard
            // 
            this.cbBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cbBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBoard.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoard.ForeColor = System.Drawing.Color.Azure;
            this.cbBoard.FormattingEnabled = true;
            this.cbBoard.Location = new System.Drawing.Point(56, 19);
            this.cbBoard.Name = "cbBoard";
            this.cbBoard.Size = new System.Drawing.Size(176, 19);
            this.cbBoard.TabIndex = 1;
            this.cbBoard.Text = "Select a chan first";
            // 
            // cmdBoard
            // 
            this.cmdBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmdBoard.ForeColor = System.Drawing.Color.Azure;
            this.cmdBoard.Location = new System.Drawing.Point(238, 17);
            this.cmdBoard.Name = "cmdBoard";
            this.cmdBoard.Size = new System.Drawing.Size(24, 23);
            this.cmdBoard.TabIndex = 0;
            this.cmdBoard.Text = "->";
            this.cmdBoard.UseVisualStyleBackColor = false;
            this.cmdBoard.Click += new System.EventHandler(this.cmdBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board:";
            // 
            // fStatus
            // 
            this.fStatus.Controls.Add(this.lPicture);
            this.fStatus.Controls.Add(this.lPUrl);
            this.fStatus.Controls.Add(this.lThread);
            this.fStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fStatus.ForeColor = System.Drawing.Color.Azure;
            this.fStatus.Location = new System.Drawing.Point(12, 333);
            this.fStatus.Name = "fStatus";
            this.fStatus.Size = new System.Drawing.Size(268, 46);
            this.fStatus.TabIndex = 7;
            this.fStatus.TabStop = false;
            this.fStatus.Text = "Application status";
            // 
            // lPicture
            // 
            this.lPicture.Location = new System.Drawing.Point(142, 16);
            this.lPicture.Name = "lPicture";
            this.lPicture.Size = new System.Drawing.Size(120, 13);
            this.lPicture.TabIndex = 2;
            this.lPicture.Text = "Pics left: ";
            // 
            // lPUrl
            // 
            this.lPUrl.Location = new System.Drawing.Point(6, 29);
            this.lPUrl.Name = "lPUrl";
            this.lPUrl.Size = new System.Drawing.Size(120, 13);
            this.lPUrl.TabIndex = 1;
            this.lPUrl.Text = "Pic. url";
            // 
            // lThread
            // 
            this.lThread.Location = new System.Drawing.Point(6, 16);
            this.lThread.Name = "lThread";
            this.lThread.Size = new System.Drawing.Size(120, 13);
            this.lThread.TabIndex = 0;
            this.lThread.Text = "Thread";
            // 
            // tThreadState
            // 
            this.tThreadState.Interval = 10;
            this.tThreadState.Tick += new System.EventHandler(this.tThreadState_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lTarget);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.Color.Azure;
            this.groupBox3.Location = new System.Drawing.Point(400, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 202);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target URL";
            // 
            // lTarget
            // 
            this.lTarget.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTarget.Location = new System.Drawing.Point(6, 16);
            this.lTarget.Name = "lTarget";
            this.lTarget.Size = new System.Drawing.Size(258, 183);
            this.lTarget.TabIndex = 1;
            this.lTarget.Text = "Client 01\r\nClient 02\r\nClient 03\r\nClient 04\r\nClient 05\r\nClient 06\r\nClient 07\r\nClie" +
                "nt 08\r\nClient 09\r\nClient 10\r\nClient 11\r\nClient 12\r\nClient 13";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lState);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(318, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // lState
            // 
            this.lState.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(6, 16);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(64, 183);
            this.lState.TabIndex = 1;
            this.lState.Text = "Client 01\r\nClient 02\r\nClient 03\r\nClient 04\r\nClient 05\r\nClient 06\r\nClient 07\r\nClie" +
                "nt 08\r\nClient 09\r\nClient 10\r\nClient 11\r\nClient 12\r\nClient 13";
            this.lState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tDownload
            // 
            this.tDownload.Interval = 10;
            this.tDownload.Tick += new System.EventHandler(this.tDownload_Tick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 26);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 26);
            this.label5.TabIndex = 13;
            // 
            // cmdContact
            // 
            this.cmdContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmdContact.Location = new System.Drawing.Point(595, 47);
            this.cmdContact.Name = "cmdContact";
            this.cmdContact.Size = new System.Drawing.Size(75, 29);
            this.cmdContact.TabIndex = 16;
            this.cmdContact.Text = "Contact me";
            this.cmdContact.UseVisualStyleBackColor = false;
            this.cmdContact.Click += new System.EventHandler(this.cmdContact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 65);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(286, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbChan);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select *chan";
            // 
            // cbChan
            // 
            this.cbChan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cbChan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbChan.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChan.ForeColor = System.Drawing.Color.Azure;
            this.cbChan.FormattingEnabled = true;
            this.cbChan.Location = new System.Drawing.Point(6, 19);
            this.cbChan.Name = "cbChan";
            this.cbChan.Size = new System.Drawing.Size(256, 19);
            this.cbChan.TabIndex = 1;
            this.cbChan.Text = "Please select chan";
            this.cbChan.SelectedIndexChanged += new System.EventHandler(this.cbChan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 26);
            this.label7.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Controls.Add(this.cmdPath);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.ForeColor = System.Drawing.Color.Azure;
            this.groupBox4.Location = new System.Drawing.Point(318, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 46);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save images to...";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.ForeColor = System.Drawing.Color.Azure;
            this.txtPath.Location = new System.Drawing.Point(6, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(310, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // cmdPath
            // 
            this.cmdPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmdPath.ForeColor = System.Drawing.Color.Azure;
            this.cmdPath.Location = new System.Drawing.Point(322, 17);
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(24, 23);
            this.cmdPath.TabIndex = 0;
            this.cmdPath.Text = "...";
            this.cmdPath.UseVisualStyleBackColor = false;
            this.cmdPath.Click += new System.EventHandler(this.cmdPath_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(324, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 26);
            this.label9.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(286, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 26);
            this.label8.TabIndex = 22;
            // 
            // cmdNews
            // 
            this.cmdNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmdNews.Location = new System.Drawing.Point(595, 12);
            this.cmdNews.Name = "cmdNews";
            this.cmdNews.Size = new System.Drawing.Size(75, 29);
            this.cmdNews.TabIndex = 23;
            this.cmdNews.Text = "News";
            this.cmdNews.UseVisualStyleBackColor = false;
            this.cmdNews.Click += new System.EventHandler(this.cmdNews_Click);
            // 
            // lbDummy
            // 
            this.lbDummy.AutoSize = true;
            this.lbDummy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDummy.Location = new System.Drawing.Point(12, -100);
            this.lbDummy.Name = "lbDummy";
            this.lbDummy.Size = new System.Drawing.Size(0, 14);
            this.lbDummy.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(682, 391);
            this.Controls.Add(this.lbDummy);
            this.Controls.Add(this.cmdNews);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdContact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fStatus);
            this.Controls.Add(this.fAlt2);
            this.Controls.Add(this.fAlt1);
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Chanmongler | v";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.fAlt2.ResumeLayout(false);
            this.fAlt2.PerformLayout();
            this.fAlt1.ResumeLayout(false);
            this.fAlt1.PerformLayout();
            this.fStatus.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fAlt2;
        private System.Windows.Forms.Button cmdThread;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox fAlt1;
        private System.Windows.Forms.Button cmdBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoard;
        private System.Windows.Forms.GroupBox fStatus;
        private System.Windows.Forms.Label lPUrl;
        private System.Windows.Forms.Label lThread;
        private System.Windows.Forms.Timer tThreadState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Timer tDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lPicture;
        private System.Windows.Forms.Button cmdContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbChan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdNews;
        private System.Windows.Forms.Label lbDummy;
    }
}

