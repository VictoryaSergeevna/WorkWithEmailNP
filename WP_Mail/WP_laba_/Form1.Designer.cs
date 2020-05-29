namespace WP_laba_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnNewLetter = new System.Windows.Forms.Button();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.listBoxAttach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(207, 90);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(26, 358);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnNewLetter
            // 
            this.btnNewLetter.Location = new System.Drawing.Point(141, 358);
            this.btnNewLetter.Name = "btnNewLetter";
            this.btnNewLetter.Size = new System.Drawing.Size(75, 23);
            this.btnNewLetter.TabIndex = 5;
            this.btnNewLetter.Text = "New Letter";
            this.btnNewLetter.UseVisualStyleBackColor = true;
            this.btnNewLetter.Click += new System.EventHandler(this.btnNewLetter_Click);
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Location = new System.Drawing.Point(73, 14);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFrom.TabIndex = 6;
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(73, 51);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTo.TabIndex = 7;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Location = new System.Drawing.Point(73, 93);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubject.TabIndex = 8;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(26, 140);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(457, 212);
            this.txtBoxMessage.TabIndex = 9;
            // 
            // listBoxAttach
            // 
            this.listBoxAttach.FormattingEnabled = true;
            this.listBoxAttach.Location = new System.Drawing.Point(318, 12);
            this.listBoxAttach.Name = "listBoxAttach";
            this.listBoxAttach.Size = new System.Drawing.Size(165, 108);
            this.listBoxAttach.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 393);
            this.Controls.Add(this.listBoxAttach);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.txtBoxTo);
            this.Controls.Add(this.txtBoxFrom);
            this.Controls.Add(this.btnNewLetter);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnNewLetter;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.ListBox listBoxAttach;
    }
}

