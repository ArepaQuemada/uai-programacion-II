namespace TP3
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
            listboxArr1 = new ListBox();
            listboxArr2 = new ListBox();
            listboxArr3 = new ListBox();
            buttonAdd1 = new Button();
            buttonAdd2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // listboxArr1
            // 
            listboxArr1.FormattingEnabled = true;
            listboxArr1.ItemHeight = 15;
            listboxArr1.Location = new Point(38, 38);
            listboxArr1.Name = "listboxArr1";
            listboxArr1.Size = new Size(157, 244);
            listboxArr1.TabIndex = 0;
            // 
            // listboxArr2
            // 
            listboxArr2.FormattingEnabled = true;
            listboxArr2.ItemHeight = 15;
            listboxArr2.Location = new Point(284, 38);
            listboxArr2.Name = "listboxArr2";
            listboxArr2.Size = new Size(157, 244);
            listboxArr2.TabIndex = 1;
            // 
            // listboxArr3
            // 
            listboxArr3.FormattingEnabled = true;
            listboxArr3.ItemHeight = 15;
            listboxArr3.Location = new Point(523, 38);
            listboxArr3.Name = "listboxArr3";
            listboxArr3.Size = new Size(157, 244);
            listboxArr3.TabIndex = 2;
            // 
            // buttonAdd1
            // 
            buttonAdd1.Location = new Point(38, 344);
            buttonAdd1.Name = "buttonAdd1";
            buttonAdd1.Size = new Size(157, 39);
            buttonAdd1.TabIndex = 3;
            buttonAdd1.Text = "Agregar";
            buttonAdd1.UseVisualStyleBackColor = true;
            buttonAdd1.Click += button1_Click;
            // 
            // buttonAdd2
            // 
            buttonAdd2.Location = new Point(284, 344);
            buttonAdd2.Name = "buttonAdd2";
            buttonAdd2.Size = new Size(157, 39);
            buttonAdd2.TabIndex = 4;
            buttonAdd2.Text = "Agregar";
            buttonAdd2.UseVisualStyleBackColor = true;
            buttonAdd2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(523, 344);
            button3.Name = "button3";
            button3.Size = new Size(157, 39);
            button3.TabIndex = 5;
            button3.Text = "Mostrar Suma";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(buttonAdd2);
            Controls.Add(buttonAdd1);
            Controls.Add(listboxArr3);
            Controls.Add(listboxArr2);
            Controls.Add(listboxArr1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listboxArr1;
        private ListBox listboxArr2;
        private ListBox listboxArr3;
        private Button buttonAdd1;
        private Button buttonAdd2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}