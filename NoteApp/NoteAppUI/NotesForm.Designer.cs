namespace NoteAppUI
{
    partial class NotesForm
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
            this.TimeChanged = new System.Windows.Forms.Label();
            this.TimeCreated = new System.Windows.Forms.Label();
            this.ChangedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreategDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TimeChanged
            // 
            this.TimeChanged.AutoSize = true;
            this.TimeChanged.Location = new System.Drawing.Point(199, 67);
            this.TimeChanged.Name = "TimeChanged";
            this.TimeChanged.Size = new System.Drawing.Size(50, 13);
            this.TimeChanged.TabIndex = 38;
            this.TimeChanged.Text = "Modified:";
            // 
            // TimeCreated
            // 
            this.TimeCreated.AutoSize = true;
            this.TimeCreated.Location = new System.Drawing.Point(12, 67);
            this.TimeCreated.Name = "TimeCreated";
            this.TimeCreated.Size = new System.Drawing.Size(47, 13);
            this.TimeCreated.TabIndex = 37;
            this.TimeCreated.Text = "Created:";
            // 
            // ChangedDateTimePicker
            // 
            this.ChangedDateTimePicker.Enabled = false;
            this.ChangedDateTimePicker.Location = new System.Drawing.Point(255, 64);
            this.ChangedDateTimePicker.Name = "ChangedDateTimePicker";
            this.ChangedDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.ChangedDateTimePicker.TabIndex = 35;
            
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(451, 343);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(79, 23);
            this.ClearButton.TabIndex = 34;
            this.ClearButton.Text = "Cancel";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(366, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(79, 23);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "OK";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreategDateTimePicker
            // 
            this.CreategDateTimePicker.Enabled = false;
            this.CreategDateTimePicker.Location = new System.Drawing.Point(65, 64);
            this.CreategDateTimePicker.Name = "CreategDateTimePicker";
            this.CreategDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.CreategDateTimePicker.TabIndex = 31;
           
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 40);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(52, 13);
            this.Type.TabIndex = 30;
            this.Type.Text = "Category:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 29;
            this.Title.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(65, 11);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(465, 20);
            this.TitleTextBox.TabIndex = 28;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(65, 37);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(158, 21);
            this.TypeComboBox.TabIndex = 27;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // TextTextBox
            // 
            this.TextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTextBox.Location = new System.Drawing.Point(13, 90);
            this.TextTextBox.Multiline = true;
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(517, 247);
            this.TextTextBox.TabIndex = 32;
            this.TextTextBox.TextChanged += new System.EventHandler(this.TextTextBox_TextChanged);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 372);
            this.Controls.Add(this.TimeChanged);
            this.Controls.Add(this.TimeCreated);
            this.Controls.Add(this.ChangedDateTimePicker);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextTextBox);
            this.Controls.Add(this.CreategDateTimePicker);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "NotesForm";
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeChanged;
        private System.Windows.Forms.Label TimeCreated;
        private System.Windows.Forms.DateTimePicker ChangedDateTimePicker;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker CreategDateTimePicker;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox TextTextBox;
    }
}