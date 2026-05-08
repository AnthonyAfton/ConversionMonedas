namespace ConversorDeMonedas
{
    partial class FormPrincipal
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
            monedasCbox = new ComboBox();
            montoBox = new TextBox();
            calcularBtn = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            resultadosBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // monedasCbox
            // 
            monedasCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            monedasCbox.FormattingEnabled = true;
            monedasCbox.Location = new Point(12, 27);
            monedasCbox.Name = "monedasCbox";
            monedasCbox.Size = new Size(167, 23);
            monedasCbox.TabIndex = 2;
            // 
            // montoBox
            // 
            montoBox.Location = new Point(206, 27);
            montoBox.Name = "montoBox";
            montoBox.Size = new Size(173, 23);
            montoBox.TabIndex = 3;
            // 
            // calcularBtn
            // 
            calcularBtn.Location = new Point(206, 56);
            calcularBtn.Name = "calcularBtn";
            calcularBtn.Size = new Size(173, 23);
            calcularBtn.TabIndex = 4;
            calcularBtn.Text = "Calcular";
            calcularBtn.UseVisualStyleBackColor = true;
            calcularBtn.Click += calcularBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Conversiones";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resultadosBox);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 244);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conversiones";
            // 
            // resultadosBox
            // 
            resultadosBox.BackColor = SystemColors.ControlDark;
            resultadosBox.BorderStyle = BorderStyle.None;
            resultadosBox.Location = new Point(6, 19);
            resultadosBox.Multiline = true;
            resultadosBox.Name = "resultadosBox";
            resultadosBox.Size = new Size(355, 219);
            resultadosBox.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(391, 344);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(calcularBtn);
            Controls.Add(montoBox);
            Controls.Add(monedasCbox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormPrincipal";
            ShowIcon = false;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox monedasCbox;
        private TextBox montoBox;
        private Button calcularBtn;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox resultadosBox;
    }
}
