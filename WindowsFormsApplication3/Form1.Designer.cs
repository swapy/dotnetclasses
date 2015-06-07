namespace WindowsFormsApplication3
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 24);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(244, 20);
            this.txtResult.TabIndex = 0;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(149, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "6";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(83, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(12, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 35);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "4";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(149, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 35);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(83, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 35);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 167);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 34);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(83, 167);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 34);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(149, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 34);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.onNumClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 218);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 32);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.onNumClick);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(83, 218);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(39, 32);
            this.btnplus.TabIndex = 15;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(149, 218);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(39, 32);
            this.btnsub.TabIndex = 16;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(207, 118);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(39, 32);
            this.btnmul.TabIndex = 17;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(207, 65);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(39, 32);
            this.btndiv.TabIndex = 19;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.onOperatorClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onEqualToClick);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(207, 167);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(39, 31);
            this.btndot.TabIndex = 21;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btndot;
    }
}

