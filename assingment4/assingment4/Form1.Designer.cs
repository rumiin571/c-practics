namespace assingment4
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
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtcustumer = new System.Windows.Forms.TextBox();
            this.txtuntiprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lblcurrent = new System.Windows.Forms.Label();
            this.lblprevious = new System.Windows.Forms.Label();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.txtusage = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(471, 128);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(100, 29);
            this.txtprevious.TabIndex = 1;
            this.txtprevious.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(471, 163);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(100, 29);
            this.txtcurrent.TabIndex = 2;
            this.txtcurrent.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtcustumer
            // 
            this.txtcustumer.Location = new System.Drawing.Point(471, 93);
            this.txtcustumer.Name = "txtcustumer";
            this.txtcustumer.Size = new System.Drawing.Size(100, 29);
            this.txtcustumer.TabIndex = 3;
            // 
            // txtuntiprice
            // 
            this.txtuntiprice.Location = new System.Drawing.Point(471, 198);
            this.txtuntiprice.Name = "txtuntiprice";
            this.txtuntiprice.Size = new System.Drawing.Size(100, 29);
            this.txtuntiprice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(107, 357);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(117, 25);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax amoun:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(338, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Electricity Bill calculate";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.Location = new System.Drawing.Point(107, 316);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(219, 25);
            this.lblusage.TabIndex = 8;
            this.lblusage.Text = "Electricity usage (units):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(107, 393);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Bill:";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(198, 93);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(197, 25);
            this.lblcustomer.TabIndex = 10;
            this.lblcustomer.Text = "Enter custumer name";
            // 
            // lblcurrent
            // 
            this.lblcurrent.AutoSize = true;
            this.lblcurrent.Location = new System.Drawing.Point(198, 163);
            this.lblcurrent.Name = "lblcurrent";
            this.lblcurrent.Size = new System.Drawing.Size(200, 25);
            this.lblcurrent.TabIndex = 11;
            this.lblcurrent.Text = "Enter current Reading";
            this.lblcurrent.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblprevious
            // 
            this.lblprevious.AutoSize = true;
            this.lblprevious.Location = new System.Drawing.Point(198, 128);
            this.lblprevious.Name = "lblprevious";
            this.lblprevious.Size = new System.Drawing.Size(214, 25);
            this.lblprevious.TabIndex = 12;
            this.lblprevious.Text = "Enter previous Reading";
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Location = new System.Drawing.Point(198, 188);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(174, 25);
            this.lblunitprice.TabIndex = 13;
            this.lblunitprice.Text = "Enter price per unit";
            // 
            // txtusage
            // 
            this.txtusage.Location = new System.Drawing.Point(482, 325);
            this.txtusage.Name = "txtusage";
            this.txtusage.Size = new System.Drawing.Size(100, 29);
            this.txtusage.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(482, 388);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 15;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(482, 353);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 29);
            this.txtTax.TabIndex = 16;
            this.txtTax.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(218, 240);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(194, 51);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "calculate Bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtusage);
            this.Controls.Add(this.lblunitprice);
            this.Controls.Add(this.lblprevious);
            this.Controls.Add(this.lblcurrent);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuntiprice);
            this.Controls.Add(this.txtcustumer);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtcustumer;
        private System.Windows.Forms.TextBox txtuntiprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label lblcurrent;
        private System.Windows.Forms.Label lblprevious;
        private System.Windows.Forms.Label lblunitprice;
        private System.Windows.Forms.TextBox txtusage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btncalculate;
    }
}

