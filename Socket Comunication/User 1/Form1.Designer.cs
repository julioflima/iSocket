namespace User_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text = new System.Windows.Forms.RichTextBox();
            this.content = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.RichTextBox();
            this.connect = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.subject = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.send)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.White;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(238)))), ((int)(((byte)(121)))));
            this.text.Location = new System.Drawing.Point(9, 456);
            this.text.Margin = new System.Windows.Forms.Padding(10);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(658, 106);
            this.text.TabIndex = 0;
            this.text.Text = "";
            this.text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.content.HideSelection = false;
            this.content.Location = new System.Drawing.Point(9, 31);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.content.Size = new System.Drawing.Size(776, 396);
            this.content.TabIndex = 2;
            this.content.Text = "";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.White;
            this.send.Image = global::User_1.Properties.Resources.image3874_12;
            this.send.Location = new System.Drawing.Point(686, 472);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(87, 80);
            this.send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.send.TabIndex = 3;
            this.send.TabStop = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.White;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.status.Location = new System.Drawing.Point(625, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(58, 13);
            this.status.TabIndex = 5;
            this.status.Text = "OFFLINE";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(238)))), ((int)(((byte)(121)))));
            this.user.Location = new System.Drawing.Point(9, 12);
            this.user.Margin = new System.Windows.Forms.Padding(10);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(600, 13);
            this.user.TabIndex = 6;
            this.user.Text = "user3432423";
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.White;
            this.connect.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.connect.Location = new System.Drawing.Point(686, 7);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(99, 23);
            this.connect.TabIndex = 7;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(9, 7);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(776, 23);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(238)))), ((int)(((byte)(121)))));
            this.richTextBox1.Location = new System.Drawing.Point(636, 456);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(149, 106);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.Color.White;
            this.subject.Location = new System.Drawing.Point(9, 429);
            this.subject.Margin = new System.Windows.Forms.Padding(10);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(776, 25);
            this.subject.TabIndex = 11;
            this.subject.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 569);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.status);
            this.Controls.Add(this.send);
            this.Controls.Add(this.content);
            this.Controls.Add(this.text);
            this.Controls.Add(this.user);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iSocket";
            ((System.ComponentModel.ISupportInitialize)(this.send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.PictureBox send;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.RichTextBox user;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox subject;
    }
}

