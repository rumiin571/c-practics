namespace assignment2
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
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.yearpromptlabel = new System.Windows.Forms.Label();
            this.dayofmonthpromptlabel = new System.Windows.Forms.Label();
            this.monthpromptlabel = new System.Windows.Forms.Label();
            this.dayofweekpromptlabel = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.showdate = new System.Windows.Forms.Button();
            this.dayofmonthtextbox = new System.Windows.Forms.TextBox();
            this.dayofweektextbox = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.monthtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateoutputlabel.Location = new System.Drawing.Point(114, 240);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(365, 57);
            this.dateoutputlabel.TabIndex = 22;
            this.dateoutputlabel.Click += new System.EventHandler(this.dateoutputlabel_Click);
            // 
            // yearpromptlabel
            // 
            this.yearpromptlabel.AutoSize = true;
            this.yearpromptlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearpromptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearpromptlabel.Location = new System.Drawing.Point(114, 159);
            this.yearpromptlabel.Name = "yearpromptlabel";
            this.yearpromptlabel.Size = new System.Drawing.Size(188, 34);
            this.yearpromptlabel.TabIndex = 21;
            this.yearpromptlabel.Text = "entertheyear";
            this.yearpromptlabel.Click += new System.EventHandler(this.yearpromptlabel_Click);
            // 
            // dayofmonthpromptlabel
            // 
            this.dayofmonthpromptlabel.AutoSize = true;
            this.dayofmonthpromptlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayofmonthpromptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofmonthpromptlabel.Location = new System.Drawing.Point(114, 122);
            this.dayofmonthpromptlabel.Name = "dayofmonthpromptlabel";
            this.dayofmonthpromptlabel.Size = new System.Drawing.Size(439, 34);
            this.dayofmonthpromptlabel.TabIndex = 20;
            this.dayofmonthpromptlabel.Text = "enterthenumericdayofthemonth";
            this.dayofmonthpromptlabel.Click += new System.EventHandler(this.dayofmonthpromptlabel_Click);
            // 
            // monthpromptlabel
            // 
            this.monthpromptlabel.AutoSize = true;
            this.monthpromptlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthpromptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthpromptlabel.Location = new System.Drawing.Point(114, 87);
            this.monthpromptlabel.Name = "monthpromptlabel";
            this.monthpromptlabel.Size = new System.Drawing.Size(357, 34);
            this.monthpromptlabel.TabIndex = 19;
            this.monthpromptlabel.Text = "enterthenameofthemonth";
            this.monthpromptlabel.Click += new System.EventHandler(this.monthpromptlabel_Click);
            // 
            // dayofweekpromptlabel
            // 
            this.dayofweekpromptlabel.AutoSize = true;
            this.dayofweekpromptlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayofweekpromptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofweekpromptlabel.Location = new System.Drawing.Point(128, 53);
            this.dayofweekpromptlabel.Name = "dayofweekpromptlabel";
            this.dayofweekpromptlabel.Size = new System.Drawing.Size(317, 34);
            this.dayofweekpromptlabel.TabIndex = 18;
            this.dayofweekpromptlabel.Text = "enterthedayoftheweek";
            this.dayofweekpromptlabel.Click += new System.EventHandler(this.dayofweekpromptlabel_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(587, 361);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 42);
            this.clear.TabIndex = 17;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // showdate
            // 
            this.showdate.Location = new System.Drawing.Point(410, 350);
            this.showdate.Name = "showdate";
            this.showdate.Size = new System.Drawing.Size(102, 42);
            this.showdate.TabIndex = 16;
            this.showdate.Text = "showdate";
            this.showdate.UseVisualStyleBackColor = true;
            this.showdate.Click += new System.EventHandler(this.showdate_Click);
            // 
            // dayofmonthtextbox
            // 
            this.dayofmonthtextbox.Location = new System.Drawing.Point(587, 122);
            this.dayofmonthtextbox.Name = "dayofmonthtextbox";
            this.dayofmonthtextbox.Size = new System.Drawing.Size(100, 29);
            this.dayofmonthtextbox.TabIndex = 15;
            this.dayofmonthtextbox.TextChanged += new System.EventHandler(this.dayofmonthtextbox_TextChanged);
            // 
            // dayofweektextbox
            // 
            this.dayofweektextbox.Location = new System.Drawing.Point(587, 52);
            this.dayofweektextbox.Name = "dayofweektextbox";
            this.dayofweektextbox.Size = new System.Drawing.Size(100, 29);
            this.dayofweektextbox.TabIndex = 14;
            this.dayofweektextbox.TextChanged += new System.EventHandler(this.dayofweektextbox_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(587, 157);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 29);
            this.txtyear.TabIndex = 13;
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // monthtextbox
            // 
            this.monthtextbox.Location = new System.Drawing.Point(587, 87);
            this.monthtextbox.Name = "monthtextbox";
            this.monthtextbox.Size = new System.Drawing.Size(100, 29);
            this.monthtextbox.TabIndex = 12;
            this.monthtextbox.TextChanged += new System.EventHandler(this.monthtextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.yearpromptlabel);
            this.Controls.Add(this.dayofmonthpromptlabel);
            this.Controls.Add(this.monthpromptlabel);
            this.Controls.Add(this.dayofweekpromptlabel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showdate);
            this.Controls.Add(this.dayofmonthtextbox);
            this.Controls.Add(this.dayofweektextbox);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.monthtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateoutputlabel;
        private System.Windows.Forms.Label yearpromptlabel;
        private System.Windows.Forms.Label dayofmonthpromptlabel;
        private System.Windows.Forms.Label monthpromptlabel;
        private System.Windows.Forms.Label dayofweekpromptlabel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button showdate;
        private System.Windows.Forms.TextBox dayofmonthtextbox;
        private System.Windows.Forms.TextBox dayofweektextbox;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox monthtextbox;
    }
}

