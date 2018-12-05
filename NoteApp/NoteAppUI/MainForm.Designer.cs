namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Categorylable = new System.Windows.Forms.Label();
            this.NoteCategorylabel = new System.Windows.Forms.Label();
            this.Createdlabel = new System.Windows.Forms.Label();
            this.Modifiedlabel = new System.Windows.Forms.Label();
            this.CreateddateTime = new System.Windows.Forms.DateTimePicker();
            this.ChangeddateTime = new System.Windows.Forms.DateTimePicker();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddbButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(12, 30);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(207, 329);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(89, 3);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(130, 21);
            this.TypeComboBox.TabIndex = 4;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(3, 6);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(82, 13);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Show Category:";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTextBox.Location = new System.Drawing.Point(3, 94);
            this.TextTextBox.Multiline = true;
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.ReadOnly = true;
            this.TextTextBox.Size = new System.Drawing.Size(436, 316);
            this.TextTextBox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.Location = new System.Drawing.Point(10, 6);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(408, 38);
            this.Titlelabel.TabIndex = 8;
            this.Titlelabel.Click += new System.EventHandler(this.Titlelabel_Click);
            // 
            // Categorylable
            // 
            this.Categorylable.AutoSize = true;
            this.Categorylable.Location = new System.Drawing.Point(12, 44);
            this.Categorylable.Name = "Categorylable";
            this.Categorylable.Size = new System.Drawing.Size(52, 13);
            this.Categorylable.TabIndex = 9;
            this.Categorylable.Text = "Category:";
            // 
            // NoteCategorylabel
            // 
            this.NoteCategorylabel.AutoSize = true;
            this.NoteCategorylabel.Location = new System.Drawing.Point(70, 44);
            this.NoteCategorylabel.Name = "NoteCategorylabel";
            this.NoteCategorylabel.Size = new System.Drawing.Size(0, 13);
            this.NoteCategorylabel.TabIndex = 10;
            // 
            // Createdlabel
            // 
            this.Createdlabel.AutoSize = true;
            this.Createdlabel.Location = new System.Drawing.Point(12, 74);
            this.Createdlabel.Name = "Createdlabel";
            this.Createdlabel.Size = new System.Drawing.Size(47, 13);
            this.Createdlabel.TabIndex = 11;
            this.Createdlabel.Text = "Created:";
            // 
            // Modifiedlabel
            // 
            this.Modifiedlabel.AutoSize = true;
            this.Modifiedlabel.Location = new System.Drawing.Point(203, 74);
            this.Modifiedlabel.Name = "Modifiedlabel";
            this.Modifiedlabel.Size = new System.Drawing.Size(50, 13);
            this.Modifiedlabel.TabIndex = 12;
            this.Modifiedlabel.Text = "Modified:";
            // 
            // CreateddateTime
            // 
            this.CreateddateTime.Enabled = false;
            this.CreateddateTime.Location = new System.Drawing.Point(73, 68);
            this.CreateddateTime.Name = "CreateddateTime";
            this.CreateddateTime.Size = new System.Drawing.Size(115, 20);
            this.CreateddateTime.TabIndex = 13;
            // 
            // ChangeddateTime
            // 
            this.ChangeddateTime.Enabled = false;
            this.ChangeddateTime.Location = new System.Drawing.Point(269, 68);
            this.ChangeddateTime.Name = "ChangeddateTime";
            this.ChangeddateTime.Size = new System.Drawing.Size(117, 20);
            this.ChangeddateTime.TabIndex = 14;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_удалить_свойство_64;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(79, 365);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(30, 30);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_редактировать_свойство_64;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(43, 365);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddbButton
            // 
            this.AddbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddbButton.BackgroundImage = global::NoteAppUI.Properties.Resources.icons8_добавить_свойство_64;
            this.AddbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddbButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AddbButton.FlatAppearance.BorderSize = 0;
            this.AddbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddbButton.Location = new System.Drawing.Point(7, 365);
            this.AddbButton.Name = "AddbButton";
            this.AddbButton.Size = new System.Drawing.Size(30, 30);
            this.AddbButton.TabIndex = 1;
            this.AddbButton.UseVisualStyleBackColor = true;
            this.AddbButton.Click += new System.EventHandler(this.AddbButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.TypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.AddbButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.ClearButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeddateTime);
            this.splitContainer1.Panel2.Controls.Add(this.Titlelabel);
            this.splitContainer1.Panel2.Controls.Add(this.Modifiedlabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreateddateTime);
            this.splitContainer1.Panel2.Controls.Add(this.Categorylable);
            this.splitContainer1.Panel2.Controls.Add(this.NoteCategorylabel);
            this.splitContainer1.Panel2.Controls.Add(this.Createdlabel);
            this.splitContainer1.Size = new System.Drawing.Size(675, 420);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(675, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Button AddbButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label Categorylable;
        private System.Windows.Forms.Label NoteCategorylabel;
        private System.Windows.Forms.Label Createdlabel;
        private System.Windows.Forms.Label Modifiedlabel;
        private System.Windows.Forms.DateTimePicker CreateddateTime;
        private System.Windows.Forms.DateTimePicker ChangeddateTime;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

