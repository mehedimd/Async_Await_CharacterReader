namespace CharacterReader_Async_Await
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
            btnProcessFile = new Button();
            lblBtn = new Label();
            SuspendLayout();
            // 
            // btnProcessFile
            // 
            btnProcessFile.Font = new Font("Segoe UI", 20F);
            btnProcessFile.Location = new Point(221, 73);
            btnProcessFile.Name = "btnProcessFile";
            btnProcessFile.Size = new Size(289, 55);
            btnProcessFile.TabIndex = 0;
            btnProcessFile.Text = "Process File";
            btnProcessFile.UseVisualStyleBackColor = true;
            btnProcessFile.Click += btnProcessFile_Click;
            // 
            // lblBtn
            // 
            lblBtn.AutoSize = true;
            lblBtn.Font = new Font("Segoe UI", 15F);
            lblBtn.Location = new Point(249, 174);
            lblBtn.Name = "lblBtn";
            lblBtn.Size = new Size(0, 28);
            lblBtn.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBtn);
            Controls.Add(btnProcessFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcessFile;
        private Label lblBtn;
    }
}
