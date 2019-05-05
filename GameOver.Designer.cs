namespace Breakout
{
    partial class GameOver
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
            this.continueButton = new System.Windows.Forms.Button();
            this.returnTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(328, 353);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(212, 80);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "コンティニュー";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // returnTitleButton
            // 
            this.returnTitleButton.Location = new System.Drawing.Point(328, 468);
            this.returnTitleButton.Name = "returnTitleButton";
            this.returnTitleButton.Size = new System.Drawing.Size(212, 80);
            this.returnTitleButton.TabIndex = 1;
            this.returnTitleButton.Text = "タイトルに戻る";
            this.returnTitleButton.UseVisualStyleBackColor = true;
            this.returnTitleButton.Click += new System.EventHandler(this.ReturnTitleButton_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 674);
            this.Controls.Add(this.returnTitleButton);
            this.Controls.Add(this.continueButton);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button returnTitleButton;
    }
}