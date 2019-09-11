namespace bfitts17301e1
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
            this.txtTestone = new System.Windows.Forms.TextBox();
            this.txtTesttwo = new System.Windows.Forms.TextBox();
            this.txtTestthree = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAveragescore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 3:";
            // 
            // txtTestone
            // 
            this.txtTestone.Location = new System.Drawing.Point(103, 34);
            this.txtTestone.Name = "txtTestone";
            this.txtTestone.Size = new System.Drawing.Size(66, 20);
            this.txtTestone.TabIndex = 3;
            this.txtTestone.Text = "0";
            this.txtTestone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTesttwo
            // 
            this.txtTesttwo.Location = new System.Drawing.Point(103, 63);
            this.txtTesttwo.Name = "txtTesttwo";
            this.txtTesttwo.Size = new System.Drawing.Size(66, 20);
            this.txtTesttwo.TabIndex = 4;
            this.txtTesttwo.Text = "0";
            this.txtTesttwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestthree
            // 
            this.txtTestthree.Location = new System.Drawing.Point(103, 89);
            this.txtTestthree.Name = "txtTestthree";
            this.txtTestthree.Size = new System.Drawing.Size(66, 20);
            this.txtTestthree.TabIndex = 5;
            this.txtTestthree.Text = "0";
            this.txtTestthree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "C&lear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtAveragescore
            // 
            this.txtAveragescore.Location = new System.Drawing.Point(103, 135);
            this.txtAveragescore.Name = "txtAveragescore";
            this.txtAveragescore.ReadOnly = true;
            this.txtAveragescore.Size = new System.Drawing.Size(66, 20);
            this.txtAveragescore.TabIndex = 9;
            this.txtAveragescore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAveragescore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTestthree);
            this.Controls.Add(this.txtTesttwo);
            this.Controls.Add(this.txtTestone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "bfitts1e1: Averages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestone;
        private System.Windows.Forms.TextBox txtTesttwo;
        private System.Windows.Forms.TextBox txtTestthree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAveragescore;
        private System.Windows.Forms.Label label4;
    }
}

