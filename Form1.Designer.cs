namespace HarfNotu
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
            cmbArasinav = new ComboBox();
            cmbFinal = new ComboBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Ara Sınav:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Final:";
            // 
            // cmbArasinav
            // 
            cmbArasinav.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArasinav.FormattingEnabled = true;
            cmbArasinav.Location = new Point(114, 42);
            cmbArasinav.Margin = new Padding(4);
            cmbArasinav.Name = "cmbArasinav";
            cmbArasinav.Size = new Size(154, 29);
            cmbArasinav.TabIndex = 2;
            // 
            // cmbFinal
            // 
            cmbFinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFinal.FormattingEnabled = true;
            cmbFinal.Location = new Point(114, 106);
            cmbFinal.Margin = new Padding(4);
            cmbFinal.Name = "cmbFinal";
            cmbFinal.Size = new Size(154, 29);
            cmbFinal.TabIndex = 3;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(285, 42);
            btnHesapla.Margin = new Padding(4);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(197, 93);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Harf Notunu Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 181);
            Controls.Add(btnHesapla);
            Controls.Add(cmbFinal);
            Controls.Add(cmbArasinav);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Harf Notu Hesaplayıcı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbArasinav;
        private ComboBox cmbFinal;
        private Button btnHesapla;
    }
}