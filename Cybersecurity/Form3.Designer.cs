namespace Cybersecurity
{
    partial class Form3
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
            this.razdelitel2 = new System.Windows.Forms.Label();
            this.razdelitel1 = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.Button();
            this.exploits = new System.Windows.Forms.Button();
            this.sniffer = new System.Windows.Forms.Button();
            this.exploitlabel = new System.Windows.Forms.Label();
            this.cve = new System.Windows.Forms.TextBox();
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
            this.projectName.TabIndex = 5;
            this.projectName.Text = "CyberWorld";
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
            this.razdelitel2.TabIndex = 14;
            this.razdelitel2.Text = "|";
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
            this.razdelitel1.TabIndex = 13;
            this.razdelitel1.Text = "|";
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
            this.request.TabIndex = 12;
            this.request.Text = "Request";
            this.request.UseVisualStyleBackColor = true;
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
            this.exploits.TabIndex = 11;
            this.exploits.Text = "Exploits";
            this.exploits.UseVisualStyleBackColor = true;
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
            this.sniffer.TabIndex = 10;
            this.sniffer.Text = "Sniffer";
            this.sniffer.UseVisualStyleBackColor = true;
            // 
            // exploitlabel
            // 
            this.exploitlabel.BackColor = System.Drawing.Color.Transparent;
            this.exploitlabel.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exploitlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(129)))), ((int)(((byte)(16)))));
            this.exploitlabel.Location = new System.Drawing.Point(345, 74);
            this.exploitlabel.Name = "exploitlabel";
            this.exploitlabel.Size = new System.Drawing.Size(212, 34);
            this.exploitlabel.TabIndex = 17;
            this.exploitlabel.Text = "Exploit library";
            this.exploitlabel.Visible = false;
            // 
            // cve
            // 
            this.cve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.cve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cve.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cve.ForeColor = System.Drawing.Color.White;
            this.cve.Location = new System.Drawing.Point(71, 130);
            this.cve.Multiline = true;
            this.cve.Name = "cve";
            this.cve.ReadOnly = true;
            this.cve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cve.Size = new System.Drawing.Size(878, 308);
            this.cve.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(978, 481);
            this.Controls.Add(this.cve);
            this.Controls.Add(this.exploitlabel);
            this.Controls.Add(this.razdelitel2);
            this.Controls.Add(this.razdelitel1);
            this.Controls.Add(this.request);
            this.Controls.Add(this.exploits);
            this.Controls.Add(this.sniffer);
            this.Controls.Add(this.projectName);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label razdelitel2;
        private System.Windows.Forms.Label razdelitel1;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.Button exploits;
        private System.Windows.Forms.Button sniffer;
        private System.Windows.Forms.Label exploitlabel;
        private System.Windows.Forms.TextBox cve;
    }
}