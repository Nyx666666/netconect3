namespace _1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msg_boxset = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msg_in_box = new System.Windows.Forms.RichTextBox();
            this.msg_out_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msg_boxset.SuspendLayout();
            this.SuspendLayout();
            // 
            // msg_boxset
            // 
            this.msg_boxset.Controls.Add(this.button1);
            this.msg_boxset.Controls.Add(this.msg_in_box);
            this.msg_boxset.Controls.Add(this.msg_out_box);
            this.msg_boxset.Location = new System.Drawing.Point(220, 12);
            this.msg_boxset.Name = "msg_boxset";
            this.msg_boxset.Size = new System.Drawing.Size(568, 426);
            this.msg_boxset.TabIndex = 0;
            this.msg_boxset.TabStop = false;
            this.msg_boxset.Enter += new System.EventHandler(this.msg_boxset_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msg_in_box
            // 
            this.msg_in_box.Location = new System.Drawing.Point(6, 22);
            this.msg_in_box.Name = "msg_in_box";
            this.msg_in_box.Size = new System.Drawing.Size(556, 369);
            this.msg_in_box.TabIndex = 1;
            this.msg_in_box.Text = "";
            this.msg_in_box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // msg_out_box
            // 
            this.msg_out_box.Location = new System.Drawing.Point(6, 397);
            this.msg_out_box.Name = "msg_out_box";
            this.msg_out_box.Size = new System.Drawing.Size(475, 23);
            this.msg_out_box.TabIndex = 0;
            this.msg_out_box.Text = "type msg here";
            this.msg_out_box.TextChanged += new System.EventHandler(this.msg_out_box_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msg_boxset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.msg_boxset.ResumeLayout(false);
            this.msg_boxset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox msg_boxset;
        private RichTextBox msg_in_box;
        private TextBox msg_out_box;
        private Button button1;
        private GroupBox groupBox1;
    }
}