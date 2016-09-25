namespace FindNoRepeatedWordsFilesCollections
{
    partial class MainForm
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
            this.openFileDialog_Btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textChosenFile_Lbl = new System.Windows.Forms.Label();
            this.textChosenFile_RichTb = new System.Windows.Forms.RichTextBox();
            this.textMadeFile_Lbl = new System.Windows.Forms.RichTextBox();
            this.txtMadeFile_Lbl = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog_Btn
            // 
            this.openFileDialog_Btn.Location = new System.Drawing.Point(12, 259);
            this.openFileDialog_Btn.Name = "openFileDialog_Btn";
            this.openFileDialog_Btn.Size = new System.Drawing.Size(75, 23);
            this.openFileDialog_Btn.TabIndex = 0;
            this.openFileDialog_Btn.Text = "Open";
            this.openFileDialog_Btn.UseVisualStyleBackColor = true;
            this.openFileDialog_Btn.Click += new System.EventHandler(this.openFileDialog_Btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textChosenFile_Lbl
            // 
            this.textChosenFile_Lbl.AutoSize = true;
            this.textChosenFile_Lbl.Location = new System.Drawing.Point(46, 19);
            this.textChosenFile_Lbl.Name = "textChosenFile_Lbl";
            this.textChosenFile_Lbl.Size = new System.Drawing.Size(62, 13);
            this.textChosenFile_Lbl.TabIndex = 1;
            this.textChosenFile_Lbl.Text = "Chosen file:";
            // 
            // textChosenFile_RichTb
            // 
            this.textChosenFile_RichTb.BackColor = System.Drawing.SystemColors.Window;
            this.textChosenFile_RichTb.Location = new System.Drawing.Point(12, 35);
            this.textChosenFile_RichTb.Name = "textChosenFile_RichTb";
            this.textChosenFile_RichTb.ReadOnly = true;
            this.textChosenFile_RichTb.Size = new System.Drawing.Size(151, 202);
            this.textChosenFile_RichTb.TabIndex = 2;
            this.textChosenFile_RichTb.Text = "";
            // 
            // textMadeFile_Lbl
            // 
            this.textMadeFile_Lbl.BackColor = System.Drawing.SystemColors.Window;
            this.textMadeFile_Lbl.Location = new System.Drawing.Point(198, 35);
            this.textMadeFile_Lbl.Name = "textMadeFile_Lbl";
            this.textMadeFile_Lbl.ReadOnly = true;
            this.textMadeFile_Lbl.Size = new System.Drawing.Size(150, 202);
            this.textMadeFile_Lbl.TabIndex = 3;
            this.textMadeFile_Lbl.Text = "";
            // 
            // txtMadeFile_Lbl
            // 
            this.txtMadeFile_Lbl.AutoSize = true;
            this.txtMadeFile_Lbl.Location = new System.Drawing.Point(239, 19);
            this.txtMadeFile_Lbl.Name = "txtMadeFile_Lbl";
            this.txtMadeFile_Lbl.Size = new System.Drawing.Size(53, 13);
            this.txtMadeFile_Lbl.TabIndex = 4;
            this.txtMadeFile_Lbl.Text = "Made file:";
            // 
            // saveFileDialog_Btn
            // 
            this.saveFileDialog_Btn.Location = new System.Drawing.Point(273, 259);
            this.saveFileDialog_Btn.Name = "saveFileDialog_Btn";
            this.saveFileDialog_Btn.Size = new System.Drawing.Size(75, 23);
            this.saveFileDialog_Btn.TabIndex = 6;
            this.saveFileDialog_Btn.Text = "Save";
            this.saveFileDialog_Btn.UseVisualStyleBackColor = true;
            this.saveFileDialog_Btn.Click += new System.EventHandler(this.saveFileDialog_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 291);
            this.Controls.Add(this.saveFileDialog_Btn);
            this.Controls.Add(this.txtMadeFile_Lbl);
            this.Controls.Add(this.textMadeFile_Lbl);
            this.Controls.Add(this.textChosenFile_RichTb);
            this.Controls.Add(this.textChosenFile_Lbl);
            this.Controls.Add(this.openFileDialog_Btn);
            this.Name = "MainForm";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileDialog_Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label textChosenFile_Lbl;
        private System.Windows.Forms.RichTextBox textChosenFile_RichTb;
        private System.Windows.Forms.RichTextBox textMadeFile_Lbl;
        private System.Windows.Forms.Label txtMadeFile_Lbl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button saveFileDialog_Btn;
    }
}

