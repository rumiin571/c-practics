namespace studentinformation
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
            this.components = new System.ComponentModel.Container();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Button();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(538, 185);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(100, 29);
            this.txtsemester.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(538, 150);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(100, 29);
            this.txtdepartment.TabIndex = 2;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(538, 115);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(100, 29);
            this.txtstudentid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(538, 80);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 29);
            this.txtname.TabIndex = 4;
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(92, 213);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(326, 73);
            this.lbloutput.TabIndex = 5;
            this.lbloutput.UseVisualStyleBackColor = true;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(92, 336);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(164, 73);
            this.btnshowinfo.TabIndex = 6;
            this.btnshowinfo.Text = "showinformation";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(538, 361);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 31);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(200, 48);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(303, 32);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "enterthestudentname";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(216, 150);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(251, 32);
            this.lblsemester.TabIndex = 9;
            this.lblsemester.Text = "enterthesemester";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(200, 115);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(281, 32);
            this.lbldepartment.TabIndex = 10;
            this.lbldepartment.Text = "enterthedepartment";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(226, 80);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(253, 32);
            this.lblstudentid.TabIndex = 11;
            this.lblstudentid.Text = "enterthestudentid";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(374, 376);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 33);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtsemester);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Button btnclear;
    }
}

