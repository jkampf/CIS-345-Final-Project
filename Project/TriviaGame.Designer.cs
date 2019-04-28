namespace TriviaNow
{
    partial class TriviaGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaGame));
            this.choice1RadioButton = new System.Windows.Forms.RadioButton();
            this.choicesGroupBox = new System.Windows.Forms.GroupBox();
            this.choice4Label = new System.Windows.Forms.Label();
            this.choice3Label = new System.Windows.Forms.Label();
            this.choice2Label = new System.Windows.Forms.Label();
            this.choice1Label = new System.Windows.Forms.Label();
            this.choice4RadioButton = new System.Windows.Forms.RadioButton();
            this.choice3RadioButton = new System.Windows.Forms.RadioButton();
            this.choice2RadioButton = new System.Windows.Forms.RadioButton();
            this.questiontextLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.questionmarkPictureBox = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.correctchoiceLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.choicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionmarkPictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // choice1RadioButton
            // 
            this.choice1RadioButton.AutoSize = true;
            this.choice1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1RadioButton.Location = new System.Drawing.Point(29, 17);
            this.choice1RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.choice1RadioButton.Name = "choice1RadioButton";
            this.choice1RadioButton.Size = new System.Drawing.Size(14, 13);
            this.choice1RadioButton.TabIndex = 1;
            this.choice1RadioButton.UseVisualStyleBackColor = true;
            this.choice1RadioButton.CheckedChanged += new System.EventHandler(this.Choice1RadioButton_CheckedChanged);
            // 
            // choicesGroupBox
            // 
            this.choicesGroupBox.BackColor = System.Drawing.Color.White;
            this.choicesGroupBox.Controls.Add(this.choice4Label);
            this.choicesGroupBox.Controls.Add(this.choice3Label);
            this.choicesGroupBox.Controls.Add(this.choice2Label);
            this.choicesGroupBox.Controls.Add(this.choice1Label);
            this.choicesGroupBox.Controls.Add(this.choice4RadioButton);
            this.choicesGroupBox.Controls.Add(this.choice3RadioButton);
            this.choicesGroupBox.Controls.Add(this.choice2RadioButton);
            this.choicesGroupBox.Controls.Add(this.choice1RadioButton);
            this.choicesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicesGroupBox.ForeColor = System.Drawing.Color.Black;
            this.choicesGroupBox.Location = new System.Drawing.Point(11, 174);
            this.choicesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.choicesGroupBox.Name = "choicesGroupBox";
            this.choicesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.choicesGroupBox.Size = new System.Drawing.Size(603, 109);
            this.choicesGroupBox.TabIndex = 8;
            this.choicesGroupBox.TabStop = false;
            this.choicesGroupBox.Text = "Choices";
            // 
            // choice4Label
            // 
            this.choice4Label.AutoSize = true;
            this.choice4Label.Location = new System.Drawing.Point(6, 86);
            this.choice4Label.Name = "choice4Label";
            this.choice4Label.Size = new System.Drawing.Size(18, 13);
            this.choice4Label.TabIndex = 12;
            this.choice4Label.Text = "4.";
            // 
            // choice3Label
            // 
            this.choice3Label.AutoSize = true;
            this.choice3Label.Location = new System.Drawing.Point(6, 63);
            this.choice3Label.Name = "choice3Label";
            this.choice3Label.Size = new System.Drawing.Size(18, 13);
            this.choice3Label.TabIndex = 11;
            this.choice3Label.Text = "3.";
            // 
            // choice2Label
            // 
            this.choice2Label.AutoSize = true;
            this.choice2Label.Location = new System.Drawing.Point(6, 40);
            this.choice2Label.Name = "choice2Label";
            this.choice2Label.Size = new System.Drawing.Size(18, 13);
            this.choice2Label.TabIndex = 10;
            this.choice2Label.Text = "2.";
            // 
            // choice1Label
            // 
            this.choice1Label.AutoSize = true;
            this.choice1Label.Location = new System.Drawing.Point(6, 17);
            this.choice1Label.Name = "choice1Label";
            this.choice1Label.Size = new System.Drawing.Size(18, 13);
            this.choice1Label.TabIndex = 9;
            this.choice1Label.Text = "1.";
            // 
            // choice4RadioButton
            // 
            this.choice4RadioButton.AutoSize = true;
            this.choice4RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice4RadioButton.Location = new System.Drawing.Point(29, 86);
            this.choice4RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.choice4RadioButton.Name = "choice4RadioButton";
            this.choice4RadioButton.Size = new System.Drawing.Size(14, 13);
            this.choice4RadioButton.TabIndex = 4;
            this.choice4RadioButton.UseVisualStyleBackColor = true;
            this.choice4RadioButton.CheckedChanged += new System.EventHandler(this.Choice4RadioButton_CheckedChanged);
            // 
            // choice3RadioButton
            // 
            this.choice3RadioButton.AutoSize = true;
            this.choice3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice3RadioButton.Location = new System.Drawing.Point(29, 63);
            this.choice3RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.choice3RadioButton.Name = "choice3RadioButton";
            this.choice3RadioButton.Size = new System.Drawing.Size(14, 13);
            this.choice3RadioButton.TabIndex = 3;
            this.choice3RadioButton.UseVisualStyleBackColor = true;
            this.choice3RadioButton.CheckedChanged += new System.EventHandler(this.Choice3RadioButton_CheckedChanged);
            // 
            // choice2RadioButton
            // 
            this.choice2RadioButton.AutoSize = true;
            this.choice2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2RadioButton.Location = new System.Drawing.Point(29, 40);
            this.choice2RadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.choice2RadioButton.Name = "choice2RadioButton";
            this.choice2RadioButton.Size = new System.Drawing.Size(14, 13);
            this.choice2RadioButton.TabIndex = 2;
            this.choice2RadioButton.UseVisualStyleBackColor = true;
            this.choice2RadioButton.CheckedChanged += new System.EventHandler(this.Choice2RadioButton_CheckedChanged);
            // 
            // questiontextLabel
            // 
            this.questiontextLabel.AutoSize = true;
            this.questiontextLabel.BackColor = System.Drawing.Color.White;
            this.questiontextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questiontextLabel.ForeColor = System.Drawing.Color.Black;
            this.questiontextLabel.Location = new System.Drawing.Point(9, 138);
            this.questiontextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questiontextLabel.Name = "questiontextLabel";
            this.questiontextLabel.Size = new System.Drawing.Size(76, 13);
            this.questiontextLabel.TabIndex = 7;
            this.questiontextLabel.Text = "Question Text:";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BackColor = System.Drawing.Color.White;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLabel.ForeColor = System.Drawing.Color.Black;
            this.feedbackLabel.Location = new System.Drawing.Point(8, 303);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(67, 13);
            this.feedbackLabel.TabIndex = 13;
            this.feedbackLabel.Text = "Feedback:";
            // 
            // questionmarkPictureBox
            // 
            this.questionmarkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("questionmarkPictureBox.Image")));
            this.questionmarkPictureBox.Location = new System.Drawing.Point(276, 12);
            this.questionmarkPictureBox.Name = "questionmarkPictureBox";
            this.questionmarkPictureBox.Size = new System.Drawing.Size(100, 100);
            this.questionmarkPictureBox.TabIndex = 6;
            this.questionmarkPictureBox.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(241, 360);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // correctchoiceLabel
            // 
            this.correctchoiceLabel.AutoSize = true;
            this.correctchoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctchoiceLabel.Location = new System.Drawing.Point(8, 339);
            this.correctchoiceLabel.Name = "correctchoiceLabel";
            this.correctchoiceLabel.Size = new System.Drawing.Size(80, 13);
            this.correctchoiceLabel.TabIndex = 14;
            this.correctchoiceLabel.Text = "Correct Choice:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(338, 360);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 399);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(632, 22);
            this.StatusStrip.TabIndex = 10;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Maximum = 3;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Value = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(75, 17);
            this.StatusLabel.Text = "Question 1/3";
            // 
            // TriviaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 421);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.correctchoiceLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionmarkPictureBox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.questiontextLabel);
            this.Controls.Add(this.choicesGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TriviaGame";
            this.Text = "Trivia Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TriviaGame_FormClosed);
            this.Load += new System.EventHandler(this.TriviaGame_Load);
            this.choicesGroupBox.ResumeLayout(false);
            this.choicesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionmarkPictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton choice1RadioButton;
        private System.Windows.Forms.GroupBox choicesGroupBox;
        private System.Windows.Forms.RadioButton choice4RadioButton;
        private System.Windows.Forms.RadioButton choice3RadioButton;
        private System.Windows.Forms.RadioButton choice2RadioButton;
        private System.Windows.Forms.Label questiontextLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.PictureBox questionmarkPictureBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label correctchoiceLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label choice2Label;
        private System.Windows.Forms.Label choice1Label;
        private System.Windows.Forms.Label choice3Label;
        private System.Windows.Forms.Label choice4Label;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}