namespace DateTimeChecker
{
    partial class Form
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
            titleLabel = new Label();
            dayLabel = new Label();
            monthLabel = new Label();
            yearLabel = new Label();
            dayTextBox = new TextBox();
            monthTextBox = new TextBox();
            yearTextBox = new TextBox();
            clearButton = new Button();
            checkButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = SystemColors.Control;
            titleLabel.Font = new Font("Arial", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.Highlight;
            titleLabel.Location = new Point(81, 68);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(391, 49);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Date Time Checker";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayLabel.Location = new Point(150, 184);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(43, 22);
            dayLabel.TabIndex = 1;
            dayLabel.Text = "Day";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthLabel.Location = new Point(146, 233);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(61, 22);
            monthLabel.TabIndex = 2;
            monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearLabel.Location = new Point(150, 281);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(47, 22);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Year";
            // 
            // dayTextBox
            // 
            dayTextBox.Font = new Font("Arial", 14.25F);
            dayTextBox.Location = new Point(232, 181);
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(170, 29);
            dayTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Font = new Font("Arial", 14.25F);
            monthTextBox.Location = new Point(232, 233);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(170, 29);
            monthTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Arial", 14.25F);
            yearTextBox.Location = new Point(232, 281);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(170, 29);
            yearTextBox.TabIndex = 6;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Arial", 14.25F);
            clearButton.Location = new Point(150, 348);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(103, 43);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Arial", 14.25F);
            checkButton.Location = new Point(299, 348);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(103, 43);
            checkButton.TabIndex = 8;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(checkButton);
            Controls.Add(clearButton);
            Controls.Add(yearTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayTextBox);
            Controls.Add(yearLabel);
            Controls.Add(monthLabel);
            Controls.Add(dayLabel);
            Controls.Add(titleLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            Text = "Date Time Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label dayLabel;
        private Label monthLabel;
        private Label yearLabel;
        private TextBox dayTextBox;
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Button clearButton;
        private Button checkButton;
    }
}
