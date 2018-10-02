namespace Calculator
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
            this.divisor_label = new System.Windows.Forms.Label();
            this.dividend_label = new System.Windows.Forms.Label();
            this.divisor_textbox = new System.Windows.Forms.TextBox();
            this.dividend_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divisor_label
            // 
            this.divisor_label.AutoSize = true;
            this.divisor_label.Location = new System.Drawing.Point(51, 50);
            this.divisor_label.Name = "divisor_label";
            this.divisor_label.Size = new System.Drawing.Size(29, 12);
            this.divisor_label.TabIndex = 0;
            this.divisor_label.Text = "除數";
            // 
            // dividend_label
            // 
            this.dividend_label.AutoSize = true;
            this.dividend_label.Location = new System.Drawing.Point(51, 94);
            this.dividend_label.Name = "dividend_label";
            this.dividend_label.Size = new System.Drawing.Size(41, 12);
            this.dividend_label.TabIndex = 1;
            this.dividend_label.Text = "被除數";
            // 
            // divisor_textbox
            // 
            this.divisor_textbox.Location = new System.Drawing.Point(108, 40);
            this.divisor_textbox.Name = "divisor_textbox";
            this.divisor_textbox.Size = new System.Drawing.Size(100, 22);
            this.divisor_textbox.TabIndex = 2;
            // 
            // dividend_textbox
            // 
            this.dividend_textbox.Location = new System.Drawing.Point(108, 84);
            this.dividend_textbox.Name = "dividend_textbox";
            this.dividend_textbox.Size = new System.Drawing.Size(100, 22);
            this.dividend_textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Location = new System.Drawing.Point(106, 182);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(41, 12);
            this.answer_label.TabIndex = 5;
            this.answer_label.Text = "答案是";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dividend_textbox);
            this.Controls.Add(this.divisor_textbox);
            this.Controls.Add(this.dividend_label);
            this.Controls.Add(this.divisor_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label divisor_label;
        private System.Windows.Forms.Label dividend_label;
        private System.Windows.Forms.TextBox divisor_textbox;
        private System.Windows.Forms.TextBox dividend_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answer_label;
    }
}

