namespace TP5_Pilas
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
            btnNumber = new Button();
            txtNumber = new TextBox();
            listNumbers = new ListBox();
            SuspendLayout();
            // 
            // btnNumber
            // 
            btnNumber.Location = new Point(275, 191);
            btnNumber.Name = "btnNumber";
            btnNumber.Size = new Size(270, 38);
            btnNumber.TabIndex = 0;
            btnNumber.Text = "Add Number";
            btnNumber.UseVisualStyleBackColor = true;
            btnNumber.Click += button1_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(275, 131);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(271, 23);
            txtNumber.TabIndex = 1;
            // 
            // listNumbers
            // 
            listNumbers.FormattingEnabled = true;
            listNumbers.ItemHeight = 15;
            listNumbers.Location = new Point(20, 31);
            listNumbers.Name = "listNumbers";
            listNumbers.Size = new Size(223, 379);
            listNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listNumbers);
            Controls.Add(txtNumber);
            Controls.Add(btnNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumber;
        private TextBox txtNumber;
        private ListBox listNumbers;
    }
}