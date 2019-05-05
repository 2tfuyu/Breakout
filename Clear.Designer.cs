namespace Breakout
{
    partial class Clear
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
            this.returnTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnTitleButton
            // 
            this.returnTitleButton.Location = new System.Drawing.Point(332, 382);
            this.returnTitleButton.Name = "returnTitleButton";
            this.returnTitleButton.Size = new System.Drawing.Size(192, 106);
            this.returnTitleButton.TabIndex = 0;
            this.returnTitleButton.Text = "タイトルに戻る";
            this.returnTitleButton.UseVisualStyleBackColor = true;
            this.returnTitleButton.Click += new System.EventHandler(this.ReturnTitleButton_Click);
            // 
            // Clear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 674);
            this.Controls.Add(this.returnTitleButton);
            this.Name = "Clear";
            this.Text = "Clear";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnTitleButton;
    }
}