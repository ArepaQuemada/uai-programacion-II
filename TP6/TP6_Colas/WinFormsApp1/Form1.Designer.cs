namespace WinFormsApp1
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
            listMujeres = new ListBox();
            listHombres = new ListBox();
            labelFemenina = new Label();
            labelMasculina = new Label();
            buttonEncolar = new Button();
            textNadadores = new TextBox();
            labelTexto = new Label();
            btnDesencolarFemenino = new Button();
            btnDesencolarMasculino = new Button();
            SuspendLayout();
            // 
            // listMujeres
            // 
            listMujeres.FormattingEnabled = true;
            listMujeres.ItemHeight = 15;
            listMujeres.Location = new Point(42, 32);
            listMujeres.Name = "listMujeres";
            listMujeres.Size = new Size(200, 184);
            listMujeres.TabIndex = 0;
            // 
            // listHombres
            // 
            listHombres.FormattingEnabled = true;
            listHombres.ItemHeight = 15;
            listHombres.Location = new Point(40, 254);
            listHombres.Name = "listHombres";
            listHombres.Size = new Size(200, 184);
            listHombres.TabIndex = 1;
            // 
            // labelFemenina
            // 
            labelFemenina.AutoSize = true;
            labelFemenina.Location = new Point(42, 14);
            labelFemenina.Name = "labelFemenina";
            labelFemenina.Size = new Size(86, 15);
            labelFemenina.TabIndex = 2;
            labelFemenina.Text = "Cola Femenina";
            // 
            // labelMasculina
            // 
            labelMasculina.AutoSize = true;
            labelMasculina.Location = new Point(40, 231);
            labelMasculina.Name = "labelMasculina";
            labelMasculina.Size = new Size(88, 15);
            labelMasculina.TabIndex = 3;
            labelMasculina.Text = "Cola Masculina";
            // 
            // buttonEncolar
            // 
            buttonEncolar.Location = new Point(625, 302);
            buttonEncolar.Name = "buttonEncolar";
            buttonEncolar.Size = new Size(75, 23);
            buttonEncolar.TabIndex = 4;
            buttonEncolar.Text = "Encolar";
            buttonEncolar.UseVisualStyleBackColor = true;
            buttonEncolar.Click += buttonEncolar_Click;
            // 
            // textNadadores
            // 
            textNadadores.Location = new Point(625, 254);
            textNadadores.Name = "textNadadores";
            textNadadores.Size = new Size(100, 23);
            textNadadores.TabIndex = 5;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Location = new Point(626, 219);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(64, 15);
            labelTexto.TabIndex = 6;
            labelTexto.Text = "Nadadores";
            // 
            // btnDesencolarFemenino
            // 
            btnDesencolarFemenino.Location = new Point(253, 35);
            btnDesencolarFemenino.Name = "btnDesencolarFemenino";
            btnDesencolarFemenino.Size = new Size(75, 23);
            btnDesencolarFemenino.TabIndex = 7;
            btnDesencolarFemenino.Text = "Desencolar";
            btnDesencolarFemenino.UseVisualStyleBackColor = true;
            btnDesencolarFemenino.Click += btnDesencolarFemenino_Click;
            // 
            // btnDesencolarMasculino
            // 
            btnDesencolarMasculino.Location = new Point(253, 254);
            btnDesencolarMasculino.Name = "btnDesencolarMasculino";
            btnDesencolarMasculino.Size = new Size(75, 23);
            btnDesencolarMasculino.TabIndex = 8;
            btnDesencolarMasculino.Text = "Desencolar";
            btnDesencolarMasculino.UseVisualStyleBackColor = true;
            btnDesencolarMasculino.Click += btnDesencolarMasculino_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 487);
            Controls.Add(btnDesencolarMasculino);
            Controls.Add(btnDesencolarFemenino);
            Controls.Add(labelTexto);
            Controls.Add(textNadadores);
            Controls.Add(buttonEncolar);
            Controls.Add(labelMasculina);
            Controls.Add(labelFemenina);
            Controls.Add(listHombres);
            Controls.Add(listMujeres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listMujeres;
        private ListBox listHombres;
        private Label labelFemenina;
        private Label labelMasculina;
        private Button buttonEncolar;
        private TextBox textNadadores;
        private Label labelTexto;
        private Button btnDesencolarFemenino;
        private Button btnDesencolarMasculino;
    }
}