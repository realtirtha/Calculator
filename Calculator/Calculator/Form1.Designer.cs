namespace Calculator
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
            this.Display = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnAC = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Location = new System.Drawing.Point(236, 92);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(322, 63);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(236, 281);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(58, 51);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn2.Location = new System.Drawing.Point(300, 281);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(58, 51);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3.Location = new System.Drawing.Point(364, 281);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(58, 51);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEquals.Location = new System.Drawing.Point(435, 337);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(58, 51);
            this.BtnEquals.TabIndex = 4;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.btnequals_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMultiply.Location = new System.Drawing.Point(499, 224);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(58, 51);
            this.BtnMultiply.TabIndex = 5;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPlus.Location = new System.Drawing.Point(499, 281);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(58, 107);
            this.BtnPlus.TabIndex = 6;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // BtnAC
            // 
            this.BtnAC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAC.Location = new System.Drawing.Point(499, 167);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Size = new System.Drawing.Size(58, 51);
            this.BtnAC.TabIndex = 7;
            this.BtnAC.Text = "ac";
            this.BtnAC.UseVisualStyleBackColor = true;
            this.BtnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn6.Location = new System.Drawing.Point(364, 224);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(58, 51);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn7.Location = new System.Drawing.Point(236, 167);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(58, 51);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn9.Location = new System.Drawing.Point(364, 167);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(58, 51);
            this.Btn9.TabIndex = 10;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn4.Location = new System.Drawing.Point(236, 224);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(58, 51);
            this.Btn4.TabIndex = 11;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn0.Location = new System.Drawing.Point(300, 337);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(58, 51);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn5.Location = new System.Drawing.Point(300, 224);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(58, 51);
            this.Btn5.TabIndex = 13;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn8.Location = new System.Drawing.Point(300, 167);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(58, 51);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMinus.Location = new System.Drawing.Point(435, 280);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(58, 51);
            this.BtnMinus.TabIndex = 15;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnAC);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Display;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnEquals;
        private Button BtnMultiply;
        private Button BtnPlus;
        private Button BtnAC;
        private Button Btn6;
        private Button Btn7;
        private Button Btn9;
        private Button Btn4;
        private Button Btn0;
        private Button Btn5;
        private Button Btn8;
        private Button BtnMinus;
    }
}