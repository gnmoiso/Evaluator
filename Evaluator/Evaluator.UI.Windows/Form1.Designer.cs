namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btnZero = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btnClosedPharentesis = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnMultiplication = new Button();
            btnDivition = new Button();
            btnOpenPharentesis = new Button();
            btnPhow = new Button();
            btnClear = new Button();
            btnDel = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.InactiveCaption;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 23);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(287, 39);
            txtDisplay.TabIndex = 0;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.LightBlue;
            btnZero.FlatStyle = FlatStyle.Popup;
            btnZero.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(12, 271);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(108, 40);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightBlue;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(69, 225);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 40);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightBlue;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 225);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 40);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.LightBlue;
            btnDot.FlatStyle = FlatStyle.Popup;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(126, 271);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(51, 40);
            btnDot.TabIndex = 4;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 192, 128);
            btnPlus.FlatStyle = FlatStyle.Popup;
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(183, 271);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(51, 40);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 0);
            btnEqual.FlatStyle = FlatStyle.Popup;
            btnEqual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(240, 271);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 40);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightBlue;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(126, 225);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 40);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 192, 128);
            btnMinus.FlatStyle = FlatStyle.Popup;
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(183, 225);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(51, 40);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClosedPharentesis
            // 
            btnClosedPharentesis.BackColor = Color.FromArgb(255, 192, 128);
            btnClosedPharentesis.FlatStyle = FlatStyle.Popup;
            btnClosedPharentesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClosedPharentesis.Location = new Point(240, 225);
            btnClosedPharentesis.Name = "btnClosedPharentesis";
            btnClosedPharentesis.Size = new Size(51, 40);
            btnClosedPharentesis.TabIndex = 9;
            btnClosedPharentesis.Text = ")";
            btnClosedPharentesis.UseVisualStyleBackColor = false;
            btnClosedPharentesis.Click += btnClosedPharentesis_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightBlue;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 179);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 40);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightBlue;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 133);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 40);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightBlue;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(69, 133);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 40);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightBlue;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(69, 179);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 40);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightBlue;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(126, 179);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 40);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightBlue;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(126, 133);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 40);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.FromArgb(255, 192, 128);
            btnMultiplication.FlatStyle = FlatStyle.Popup;
            btnMultiplication.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplication.Location = new Point(183, 179);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(51, 40);
            btnMultiplication.TabIndex = 16;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDivition
            // 
            btnDivition.BackColor = Color.FromArgb(255, 192, 128);
            btnDivition.FlatStyle = FlatStyle.Popup;
            btnDivition.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivition.Location = new Point(183, 133);
            btnDivition.Name = "btnDivition";
            btnDivition.Size = new Size(51, 40);
            btnDivition.TabIndex = 17;
            btnDivition.Text = "/";
            btnDivition.UseVisualStyleBackColor = false;
            btnDivition.Click += btnDivition_Click;
            // 
            // btnOpenPharentesis
            // 
            btnOpenPharentesis.BackColor = Color.FromArgb(255, 192, 128);
            btnOpenPharentesis.FlatStyle = FlatStyle.Popup;
            btnOpenPharentesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenPharentesis.Location = new Point(240, 179);
            btnOpenPharentesis.Name = "btnOpenPharentesis";
            btnOpenPharentesis.Size = new Size(51, 40);
            btnOpenPharentesis.TabIndex = 18;
            btnOpenPharentesis.Text = "(";
            btnOpenPharentesis.UseVisualStyleBackColor = false;
            btnOpenPharentesis.Click += btnOpenPharentesis_Click;
            // 
            // btnPhow
            // 
            btnPhow.BackColor = Color.FromArgb(255, 192, 128);
            btnPhow.FlatStyle = FlatStyle.Popup;
            btnPhow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhow.Location = new Point(240, 133);
            btnPhow.Name = "btnPhow";
            btnPhow.Size = new Size(51, 40);
            btnPhow.TabIndex = 19;
            btnPhow.Text = "^";
            btnPhow.UseVisualStyleBackColor = false;
            btnPhow.Click += btnPhow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 128);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(183, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 40);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(255, 192, 128);
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ActiveCaptionText;
            btnDel.Location = new Point(12, 87);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(165, 40);
            btnDel.TabIndex = 21;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(311, 323);
            Controls.Add(btnDel);
            Controls.Add(btnClear);
            Controls.Add(btnPhow);
            Controls.Add(btnOpenPharentesis);
            Controls.Add(btnDivition);
            Controls.Add(btnMultiplication);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btnClosedPharentesis);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btnZero);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnZero;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btnPlus;
        private Button btnEqual;
        private Button btn3;
        private Button btnMinus;
        private Button btnClosedPharentesis;
        private Button btn4;
        private Button btn7;
        private Button btn8;
        private Button btn5;
        private Button btn6;
        private Button btn9;
        private Button btnMultiplication;
        private Button btnDivition;
        private Button btnOpenPharentesis;
        private Button btnPhow;
        private Button btnClear;
        private Button btnDel;
    }
}
