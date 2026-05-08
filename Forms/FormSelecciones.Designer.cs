namespace ConversorDeMonedas
{
    partial class FormSelecciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelBtn = new Button();
            acceptBtn = new Button();
            monedasListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 297);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(140, 23);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtnClick;
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(251, 297);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(140, 23);
            acceptBtn.TabIndex = 1;
            acceptBtn.Text = "Aceptar";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtnClick;
            // 
            // monedasListBox
            // 
            monedasListBox.FormattingEnabled = true;
            monedasListBox.Location = new Point(12, 12);
            monedasListBox.Name = "monedasListBox";
            monedasListBox.Size = new Size(379, 274);
            monedasListBox.TabIndex = 2;
            // 
            // FormSelecciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 332);
            Controls.Add(monedasListBox);
            Controls.Add(acceptBtn);
            Controls.Add(cancelBtn);
            Name = "FormSelecciones";
            ResumeLayout(false);
        }

        #endregion

        private Button cancelBtn;
        private Button acceptBtn;
        private CheckedListBox monedasListBox;
    }
}