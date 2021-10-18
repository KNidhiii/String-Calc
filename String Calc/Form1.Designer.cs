
namespace String_Calc
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
            this.string1text = new System.Windows.Forms.TextBox();
            this.string2text = new System.Windows.Forms.TextBox();
            this.concatebutton1 = new System.Windows.Forms.Button();
            this.comparebutton2 = new System.Windows.Forms.Button();
            this.palindromebutton3 = new System.Windows.Forms.Button();
            this.reversebutton4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputtext = new System.Windows.Forms.TextBox();
            this.clearbutton5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // string1text
            // 
            this.string1text.Location = new System.Drawing.Point(154, 53);
            this.string1text.Name = "string1text";
            this.string1text.Size = new System.Drawing.Size(220, 22);
            this.string1text.TabIndex = 0;
            // 
            // string2text
            // 
            this.string2text.Location = new System.Drawing.Point(154, 94);
            this.string2text.Name = "string2text";
            this.string2text.Size = new System.Drawing.Size(220, 22);
            this.string2text.TabIndex = 1;
            this.string2text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // concatebutton1
            // 
            this.concatebutton1.Location = new System.Drawing.Point(33, 127);
            this.concatebutton1.Name = "concatebutton1";
            this.concatebutton1.Size = new System.Drawing.Size(110, 39);
            this.concatebutton1.TabIndex = 2;
            this.concatebutton1.Text = "Concatinate";
            this.concatebutton1.UseVisualStyleBackColor = true;
            this.concatebutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comparebutton2
            // 
            this.comparebutton2.Location = new System.Drawing.Point(224, 127);
            this.comparebutton2.Name = "comparebutton2";
            this.comparebutton2.Size = new System.Drawing.Size(95, 39);
            this.comparebutton2.TabIndex = 3;
            this.comparebutton2.Text = "Compare";
            this.comparebutton2.UseVisualStyleBackColor = true;
            this.comparebutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // palindromebutton3
            // 
            this.palindromebutton3.Location = new System.Drawing.Point(33, 110);
            this.palindromebutton3.Name = "palindromebutton3";
            this.palindromebutton3.Size = new System.Drawing.Size(110, 49);
            this.palindromebutton3.TabIndex = 4;
            this.palindromebutton3.Text = " Check Palindrome";
            this.palindromebutton3.UseVisualStyleBackColor = true;
            this.palindromebutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reversebutton4
            // 
            this.reversebutton4.Location = new System.Drawing.Point(224, 110);
            this.reversebutton4.Name = "reversebutton4";
            this.reversebutton4.Size = new System.Drawing.Size(95, 49);
            this.reversebutton4.TabIndex = 5;
            this.reversebutton4.Text = "Reverse";
            this.reversebutton4.UseVisualStyleBackColor = true;
            this.reversebutton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "String 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "String 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input String :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputtext
            // 
            this.inputtext.Location = new System.Drawing.Point(138, 53);
            this.inputtext.Name = "inputtext";
            this.inputtext.Size = new System.Drawing.Size(220, 22);
            this.inputtext.TabIndex = 9;
            this.inputtext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // clearbutton5
            // 
            this.clearbutton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearbutton5.Location = new System.Drawing.Point(138, 188);
            this.clearbutton5.Name = "clearbutton5";
            this.clearbutton5.Size = new System.Drawing.Size(89, 40);
            this.clearbutton5.TabIndex = 14;
            this.clearbutton5.Text = "Clear";
            this.clearbutton5.UseVisualStyleBackColor = true;
            this.clearbutton5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.concatebutton1);
            this.groupBox1.Controls.Add(this.comparebutton2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 199);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Two String Operation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputtext);
            this.groupBox2.Controls.Add(this.clearbutton5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.palindromebutton3);
            this.groupBox2.Controls.Add(this.reversebutton4);
            this.groupBox2.Location = new System.Drawing.Point(16, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 244);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "One String Operation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(405, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.string2text);
            this.Controls.Add(this.string1text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox string1text;
        private System.Windows.Forms.TextBox string2text;
        private System.Windows.Forms.Button concatebutton1;
        private System.Windows.Forms.Button comparebutton2;
        private System.Windows.Forms.Button palindromebutton3;
        private System.Windows.Forms.Button reversebutton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputtext;
        private System.Windows.Forms.Button clearbutton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

