namespace Calculator_Application
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
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox1.Location = new Point(331, 61);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(150, 39);
            txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            txtBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox2.Location = new Point(331, 192);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(150, 39);
            txtBox2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(368, 131);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(75, 36);
            cbOperator.TabIndex = 2;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(204, 303);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(178, 38);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(331, 248);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(25, 28);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 74);
            label1.Name = "label1";
            label1.Size = new Size(240, 26);
            label1.TabIndex = 5;
            label1.Text = "Enter First number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 205);
            label2.Name = "label2";
            label2.Size = new Size(252, 26);
            label2.TabIndex = 6;
            label2.Text = "Enter Second number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 248);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(640, 365);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private TextBox txtBox2;
        private ComboBox cbOperator;
        private Button btnEqual;
        private Label lblDisplayTotal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}