namespace WinFormsApp5
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
            label2 = new Label();
            txtAge = new TextBox();
            txtPrice = new TextBox();
            chkDiscount = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 0;
            label1.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Base Price";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(129, 22);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(199, 27);
            txtAge.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(129, 55);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(199, 27);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // chkDiscount
            // 
            chkDiscount.AutoSize = true;
            chkDiscount.Location = new Point(21, 101);
            chkDiscount.Name = "chkDiscount";
            chkDiscount.Size = new Size(144, 24);
            chkDiscount.TabIndex = 4;
            chkDiscount.Text = "Receive Discount";
            chkDiscount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.Location = new Point(129, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Press Me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(button1);
            Controls.Add(chkDiscount);
            Controls.Add(txtPrice);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private TextBox txtPrice;
        private CheckBox chkDiscount;
        private Button button1;
    }
}
