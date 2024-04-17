namespace Lab7OOP
{
    partial class FindForm
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
            txtFind = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            cbMatchCase = new CheckBox();
            cbMatchWhole = new CheckBox();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(12, 12);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(193, 27);
            txtFind.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(238, 17);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(78, 32);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(238, 63);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbMatchCase
            // 
            cbMatchCase.AutoSize = true;
            cbMatchCase.Location = new Point(12, 59);
            cbMatchCase.Name = "cbMatchCase";
            cbMatchCase.Size = new Size(100, 24);
            cbMatchCase.TabIndex = 3;
            cbMatchCase.Text = "Math Case";
            cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // cbMatchWhole
            // 
            cbMatchWhole.AutoSize = true;
            cbMatchWhole.Location = new Point(118, 59);
            cbMatchWhole.Name = "cbMatchWhole";
            cbMatchWhole.Size = new Size(103, 24);
            cbMatchWhole.TabIndex = 4;
            cbMatchWhole.Text = "Math word";
            cbMatchWhole.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 107);
            Controls.Add(cbMatchWhole);
            Controls.Add(cbMatchCase);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtFind);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FindForm";
            Text = "Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Button btnOK;
        private Button btnCancel;
        private CheckBox cbMatchCase;
        private CheckBox cbMatchWhole;
    }
}