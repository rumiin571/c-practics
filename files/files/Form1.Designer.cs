namespace files
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
            this.bttread = new System.Windows.Forms.Button();
            this.bttreadall = new System.Windows.Forms.Button();
            this.bttfile = new System.Windows.Forms.Button();
            this.bttwrite = new System.Windows.Forms.Button();
            this.bttitems = new System.Windows.Forms.Button();
            this.fist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttread
            // 
            this.bttread.Location = new System.Drawing.Point(68, 113);
            this.bttread.Name = "bttread";
            this.bttread.Size = new System.Drawing.Size(152, 42);
            this.bttread.TabIndex = 1;
            this.bttread.Text = "Read line";
            this.bttread.UseVisualStyleBackColor = true;
            this.bttread.Click += new System.EventHandler(this.bttread_Click);
            // 
            // bttreadall
            // 
            this.bttreadall.Location = new System.Drawing.Point(68, 200);
            this.bttreadall.Name = "bttreadall";
            this.bttreadall.Size = new System.Drawing.Size(179, 48);
            this.bttreadall.TabIndex = 3;
            this.bttreadall.Text = "Read all line";
            this.bttreadall.UseVisualStyleBackColor = true;
            this.bttreadall.Click += new System.EventHandler(this.bttreadall_Click);
            // 
            // bttfile
            // 
            this.bttfile.Location = new System.Drawing.Point(40, 282);
            this.bttfile.Name = "bttfile";
            this.bttfile.Size = new System.Drawing.Size(214, 44);
            this.bttfile.TabIndex = 4;
            this.bttfile.Text = "Delete file";
            this.bttfile.UseVisualStyleBackColor = true;
            this.bttfile.Click += new System.EventHandler(this.bttfile_Click);
            // 
            // bttwrite
            // 
            this.bttwrite.Location = new System.Drawing.Point(84, 48);
            this.bttwrite.Name = "bttwrite";
            this.bttwrite.Size = new System.Drawing.Size(136, 33);
            this.bttwrite.TabIndex = 5;
            this.bttwrite.Text = "write line";
            this.bttwrite.UseVisualStyleBackColor = true;
            this.bttwrite.Click += new System.EventHandler(this.bttwrite_Click);
            // 
            // bttitems
            // 
            this.bttitems.Location = new System.Drawing.Point(40, 403);
            this.bttitems.Name = "bttitems";
            this.bttitems.Size = new System.Drawing.Size(197, 54);
            this.bttitems.TabIndex = 6;
            this.bttitems.Text = "Delete item";
            this.bttitems.UseVisualStyleBackColor = true;
            this.bttitems.Click += new System.EventHandler(this.bttitems_Click);
            // 
            // fist
            // 
            this.fist.FormattingEnabled = true;
            this.fist.ItemHeight = 24;
            this.fist.Location = new System.Drawing.Point(587, 22);
            this.fist.Name = "fist";
            this.fist.Size = new System.Drawing.Size(276, 388);
            this.fist.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 553);
            this.Controls.Add(this.fist);
            this.Controls.Add(this.bttitems);
            this.Controls.Add(this.bttwrite);
            this.Controls.Add(this.bttfile);
            this.Controls.Add(this.bttreadall);
            this.Controls.Add(this.bttread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttread;
        private System.Windows.Forms.Button bttreadall;
        private System.Windows.Forms.Button bttfile;
        private System.Windows.Forms.Button bttwrite;
        private System.Windows.Forms.Button bttitems;
        private System.Windows.Forms.ListBox fist;
    }
}

