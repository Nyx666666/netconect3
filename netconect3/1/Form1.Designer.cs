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
            this.SuspendLayout();
            // 
            // msg_boxset
            // 
            this.msg_boxset.Location = new System.Drawing.Point(220, 12);
            this.msg_boxset.Name = "msg_boxset";
            this.msg_boxset.Size = new System.Drawing.Size(568, 426);
            this.msg_boxset.TabIndex = 0;
            this.msg_boxset.TabStop = false;
            this.msg_boxset.Enter += new System.EventHandler(this.msg_boxset_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg_boxset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox msg_boxset;
    }
}