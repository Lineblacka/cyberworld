namespace Cybersecurity
{
    partial class Form2
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
            this.projectName = new System.Windows.Forms.Label();
            this.sniffer = new System.Windows.Forms.Button();
            this.exploits = new System.Windows.Forms.Button();
            this.request = new System.Windows.Forms.Button();
            this.razdelitel1 = new System.Windows.Forms.Label();
            this.razdelitel2 = new System.Windows.Forms.Label();
            this.pinglabel = new System.Windows.Forms.Label();
            this.ipinput = new System.Windows.Forms.TextBox();
            this.podipinput = new System.Windows.Forms.Label();
            this.pingresult = new System.Windows.Forms.Label();
            this.latestupdatelabel = new System.Windows.Forms.Label();
            this.latestupdate = new System.Windows.Forms.Label();
            this.snifferlabel = new System.Windows.Forms.Label();
            this.sniffstart = new System.Windows.Forms.Button();
            this.sniffed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Bloody Durian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.projectName.Location = new System.Drawing.Point(12, 9);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(179, 67);
            this.projectName.TabIndex = 4;
            this.projectName.Text = "CyberWorld";
            // 
            // sniffer
            // 
            this.sniffer.FlatAppearance.BorderSize = 0;
            this.sniffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sniffer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.sniffer.Location = new System.Drawing.Point(614, 25);
            this.sniffer.Name = "sniffer";
            this.sniffer.Size = new System.Drawing.Size(91, 37);
            this.sniffer.TabIndex = 5;
            this.sniffer.Text = "Sniffer";
            this.sniffer.UseVisualStyleBackColor = true;
            this.sniffer.Click += new System.EventHandler(this.sniffer_Click);
            // 
            // exploits
            // 
            this.exploits.FlatAppearance.BorderSize = 0;
            this.exploits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exploits.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exploits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.exploits.Location = new System.Drawing.Point(711, 25);
            this.exploits.Name = "exploits";
            this.exploits.Size = new System.Drawing.Size(95, 37);
            this.exploits.TabIndex = 6;
            this.exploits.Text = "Exploits";
            this.exploits.UseVisualStyleBackColor = true;
            this.exploits.Click += new System.EventHandler(this.exploits_Click);
            // 
            // request
            // 
            this.request.FlatAppearance.BorderSize = 0;
            this.request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.request.Location = new System.Drawing.Point(812, 25);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(101, 37);
            this.request.TabIndex = 7;
            this.request.Text = "Request";
            this.request.UseVisualStyleBackColor = true;
            // 
            // razdelitel1
            // 
            this.razdelitel1.AutoSize = true;
            this.razdelitel1.BackColor = System.Drawing.Color.Transparent;
            this.razdelitel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razdelitel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.razdelitel1.Location = new System.Drawing.Point(694, 32);
            this.razdelitel1.Name = "razdelitel1";
            this.razdelitel1.Size = new System.Drawing.Size(21, 22);
            this.razdelitel1.TabIndex = 8;
            this.razdelitel1.Text = "|";
            // 
            // razdelitel2
            // 
            this.razdelitel2.AutoSize = true;
            this.razdelitel2.BackColor = System.Drawing.Color.Transparent;
            this.razdelitel2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razdelitel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.razdelitel2.Location = new System.Drawing.Point(798, 32);
            this.razdelitel2.Name = "razdelitel2";
            this.razdelitel2.Size = new System.Drawing.Size(21, 22);
            this.razdelitel2.TabIndex = 9;
            this.razdelitel2.Text = "|";
            // 
            // pinglabel
            // 
            this.pinglabel.BackColor = System.Drawing.Color.Transparent;
            this.pinglabel.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinglabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.pinglabel.Location = new System.Drawing.Point(74, 123);
            this.pinglabel.Name = "pinglabel";
            this.pinglabel.Size = new System.Drawing.Size(84, 31);
            this.pinglabel.TabIndex = 10;
            this.pinglabel.Text = "PING";
            // 
            // ipinput
            // 
            this.ipinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ipinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipinput.ForeColor = System.Drawing.SystemColors.Menu;
            this.ipinput.Location = new System.Drawing.Point(153, 123);
            this.ipinput.Name = "ipinput";
            this.ipinput.Size = new System.Drawing.Size(230, 27);
            this.ipinput.TabIndex = 11;
            // 
            // podipinput
            // 
            this.podipinput.BackColor = System.Drawing.Color.Transparent;
            this.podipinput.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podipinput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.podipinput.Location = new System.Drawing.Point(150, 148);
            this.podipinput.Name = "podipinput";
            this.podipinput.Size = new System.Drawing.Size(233, 16);
            this.podipinput.TabIndex = 12;
            this.podipinput.Text = "_________________________________";
            // 
            // pingresult
            // 
            this.pingresult.BackColor = System.Drawing.Color.Black;
            this.pingresult.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingresult.ForeColor = System.Drawing.Color.White;
            this.pingresult.Location = new System.Drawing.Point(528, 148);
            this.pingresult.Name = "pingresult";
            this.pingresult.Size = new System.Drawing.Size(417, 308);
            this.pingresult.TabIndex = 13;
            this.pingresult.Text = "label1";
            this.pingresult.Visible = false;
            // 
            // latestupdatelabel
            // 
            this.latestupdatelabel.AutoSize = true;
            this.latestupdatelabel.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestupdatelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.latestupdatelabel.Location = new System.Drawing.Point(74, 211);
            this.latestupdatelabel.Name = "latestupdatelabel";
            this.latestupdatelabel.Size = new System.Drawing.Size(160, 26);
            this.latestupdatelabel.TabIndex = 14;
            this.latestupdatelabel.Text = "Latest update:";
            // 
            // latestupdate
            // 
            this.latestupdate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestupdate.ForeColor = System.Drawing.Color.White;
            this.latestupdate.Location = new System.Drawing.Point(37, 250);
            this.latestupdate.Name = "latestupdate";
            this.latestupdate.Size = new System.Drawing.Size(346, 206);
            this.latestupdate.TabIndex = 15;
            this.latestupdate.Text = "label1";
            // 
            // snifferlabel
            // 
            this.snifferlabel.BackColor = System.Drawing.Color.Transparent;
            this.snifferlabel.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snifferlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.snifferlabel.Location = new System.Drawing.Point(413, 78);
            this.snifferlabel.Name = "snifferlabel";
            this.snifferlabel.Size = new System.Drawing.Size(115, 34);
            this.snifferlabel.TabIndex = 16;
            this.snifferlabel.Text = "Sniffer";
            this.snifferlabel.Visible = false;
            // 
            // sniffstart
            // 
            this.sniffstart.FlatAppearance.BorderSize = 0;
            this.sniffstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sniffstart.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniffstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.sniffstart.Location = new System.Drawing.Point(844, 407);
            this.sniffstart.Name = "sniffstart";
            this.sniffstart.Size = new System.Drawing.Size(91, 37);
            this.sniffstart.TabIndex = 17;
            this.sniffstart.Text = "Start";
            this.sniffstart.UseVisualStyleBackColor = true;
            this.sniffstart.Visible = false;
            // 
            // sniffed
            // 
            this.sniffed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sniffed.ForeColor = System.Drawing.Color.White;
            this.sniffed.Location = new System.Drawing.Point(65, 119);
            this.sniffed.Name = "sniffed";
            this.sniffed.Size = new System.Drawing.Size(848, 337);
            this.sniffed.TabIndex = 18;
            this.sniffed.Text = "IP PORT PROTOCOL";
            this.sniffed.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(978, 481);
            this.Controls.Add(this.sniffed);
            this.Controls.Add(this.sniffstart);
            this.Controls.Add(this.snifferlabel);
            this.Controls.Add(this.latestupdate);
            this.Controls.Add(this.latestupdatelabel);
            this.Controls.Add(this.pingresult);
            this.Controls.Add(this.podipinput);
            this.Controls.Add(this.ipinput);
            this.Controls.Add(this.pinglabel);
            this.Controls.Add(this.razdelitel2);
            this.Controls.Add(this.razdelitel1);
            this.Controls.Add(this.request);
            this.Controls.Add(this.exploits);
            this.Controls.Add(this.sniffer);
            this.Controls.Add(this.projectName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Button sniffer;
        private System.Windows.Forms.Button exploits;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.Label razdelitel1;
        private System.Windows.Forms.Label razdelitel2;
        private System.Windows.Forms.Label pinglabel;
        private System.Windows.Forms.TextBox ipinput;
        private System.Windows.Forms.Label podipinput;
        private System.Windows.Forms.Label pingresult;
        private System.Windows.Forms.Label latestupdatelabel;
        private System.Windows.Forms.Label latestupdate;
        private System.Windows.Forms.Label snifferlabel;
        private System.Windows.Forms.Button sniffstart;
        private System.Windows.Forms.Label sniffed;
    }
}