namespace BasicCalculator
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
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperator = new ComboBox();
            panel1 = new Panel();
            lblResult = new Label();
            label2 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 67);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(285, 34);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(12, 141);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(285, 34);
            txtNum2.TabIndex = 2;
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(98, 107);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(104, 28);
            cmbOperator.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 125);
            panel1.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Black;
            lblResult.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Lime;
            lblResult.Location = new Point(12, 53);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(60, 26);
            lblResult.TabIndex = 1;
            lblResult.Text = "0000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 0;
            label2.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(98, 334);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(104, 41);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 387);
            Controls.Add(btnCompute);
            Controls.Add(panel1);
            Controls.Add(cmbOperator);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperator;
        private Panel panel1;
        private Label lblResult;
        private Label label2;
        private Button btnCompute;
    }
}
