namespace StudentInfoApplication
{
    partial class StudentInfoFRM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIDtxtbox = new System.Windows.Forms.TextBox();
            this.lastNametxtbox = new System.Windows.Forms.TextBox();
            this.firstNametxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentIDListBox = new System.Windows.Forms.ListBox();
            this.ClearInvalid = new System.Windows.Forms.Button();
            this.FirstNameListBox = new System.Windows.Forms.ListBox();
            this.LastNameListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name*";
            // 
            // studentIDtxtbox
            // 
            this.studentIDtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDtxtbox.Location = new System.Drawing.Point(12, 32);
            this.studentIDtxtbox.MaxLength = 11;
            this.studentIDtxtbox.Name = "studentIDtxtbox";
            this.studentIDtxtbox.Size = new System.Drawing.Size(187, 26);
            this.studentIDtxtbox.TabIndex = 3;
            this.studentIDtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentIDtxtbox_KeyPress);
            // 
            // lastNametxtbox
            // 
            this.lastNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNametxtbox.Location = new System.Drawing.Point(205, 32);
            this.lastNametxtbox.Name = "lastNametxtbox";
            this.lastNametxtbox.Size = new System.Drawing.Size(187, 26);
            this.lastNametxtbox.TabIndex = 4;
            this.lastNametxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNametxtbox_KeyPress);
            // 
            // firstNametxtbox
            // 
            this.firstNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametxtbox.Location = new System.Drawing.Point(398, 32);
            this.firstNametxtbox.Name = "firstNametxtbox";
            this.firstNametxtbox.Size = new System.Drawing.Size(187, 26);
            this.firstNametxtbox.TabIndex = 5;
            this.firstNametxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNametxtbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student List";
            // 
            // StudentIDListBox
            // 
            this.StudentIDListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDListBox.FormattingEnabled = true;
            this.StudentIDListBox.ItemHeight = 20;
            this.StudentIDListBox.Location = new System.Drawing.Point(26, 128);
            this.StudentIDListBox.Name = "StudentIDListBox";
            this.StudentIDListBox.Size = new System.Drawing.Size(173, 164);
            this.StudentIDListBox.TabIndex = 10;
            // 
            // ClearInvalid
            // 
            this.ClearInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearInvalid.Location = new System.Drawing.Point(398, 64);
            this.ClearInvalid.Name = "ClearInvalid";
            this.ClearInvalid.Size = new System.Drawing.Size(106, 28);
            this.ClearInvalid.TabIndex = 13;
            this.ClearInvalid.Text = "Clear Invalid";
            this.ClearInvalid.UseVisualStyleBackColor = true;
            this.ClearInvalid.Visible = false;
            this.ClearInvalid.Click += new System.EventHandler(this.ClearInvalid_Click);
            // 
            // FirstNameListBox
            // 
            this.FirstNameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameListBox.FormattingEnabled = true;
            this.FirstNameListBox.ItemHeight = 20;
            this.FirstNameListBox.Location = new System.Drawing.Point(212, 128);
            this.FirstNameListBox.Name = "FirstNameListBox";
            this.FirstNameListBox.Size = new System.Drawing.Size(173, 164);
            this.FirstNameListBox.TabIndex = 14;
            // 
            // LastNameListBox
            // 
            this.LastNameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameListBox.FormattingEnabled = true;
            this.LastNameListBox.ItemHeight = 20;
            this.LastNameListBox.Location = new System.Drawing.Point(398, 128);
            this.LastNameListBox.Name = "LastNameListBox";
            this.LastNameListBox.Size = new System.Drawing.Size(173, 164);
            this.LastNameListBox.TabIndex = 15;
            // 
            // StudentInfoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 308);
            this.Controls.Add(this.LastNameListBox);
            this.Controls.Add(this.FirstNameListBox);
            this.Controls.Add(this.ClearInvalid);
            this.Controls.Add(this.StudentIDListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstNametxtbox);
            this.Controls.Add(this.lastNametxtbox);
            this.Controls.Add(this.studentIDtxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StudentInfoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentIDtxtbox;
        private System.Windows.Forms.TextBox lastNametxtbox;
        private System.Windows.Forms.TextBox firstNametxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox StudentIDListBox;
        private System.Windows.Forms.Button ClearInvalid;
        private System.Windows.Forms.ListBox FirstNameListBox;
        private System.Windows.Forms.ListBox LastNameListBox;
    }
}

