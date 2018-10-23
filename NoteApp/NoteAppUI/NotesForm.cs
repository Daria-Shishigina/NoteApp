using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{

    public partial class NotesForm : Form
    {
        public Note _note ;

        public NotesForm()
        {
            InitializeComponent();

            this.Text = "Add/Edit Note";

            TypeComboBox.Items.Add(NoteType.Work);
            TypeComboBox.Items.Add(NoteType.Home);
            TypeComboBox.Items.Add(NoteType.Health_and_sport);
            TypeComboBox.Items.Add(NoteType.People);
            TypeComboBox.Items.Add(NoteType.Finance);
            TypeComboBox.Items.Add(NoteType.Documents);
            TypeComboBox.Items.Add(NoteType.Miscellaneous);
        }

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                TitleTextBox.Text = _note.Title;
                TextTextBox.Text = _note.Text;
                CreategDateTimePicker.Value = _note.TimeCreated;
                TypeComboBox.SelectedIndex = (int)_note.NoteType;
                //  _note.Title = value.Title;
            }
        }
        /// <summary>
        /// Добавление заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Note note = new Note(DateTime.Now);
            note.Title = TitleTextBox.Text;
            note.NoteType = (NoteType)TypeComboBox.SelectedIndex;
            note.Text = TextTextBox.Text;
            _note = note;
            this.DialogResult = DialogResult.OK;
            this.Close();  
        }


        
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                TitleTextBox.BackColor = Color.LightSalmon;
            }

            ////string text = TitleTextBox.Text;
            ////if (text.Length < 50 && text.Length > 0)
            ////{
            ////        TitleTextBox.BackColor = Color.White;
            ////    }
            ////    else
            ////    {
            ////        TitleTextBox.BackColor = Color.LightSalmon;
            ////    }

        }
        private void NotesForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// закрытие формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // НЕ ДАЕТ СОЗДАТЬ НОВУЮ ЗАМЕТКУ (НЕ ДАЮТ ОГРАНИЧЕНИЯ (УБРАТЬ -РАБОТАЕТ ))

        private void TextTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {

                _note.Text = TextTextBox.Text;
                TextTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                TextTextBox.BackColor = Color.LightSalmon;
            }

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _note.NoteType = (NoteType)TypeComboBox.SelectedIndex;
                TypeComboBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                TypeComboBox.BackColor = Color.LightSalmon;
            }
        }
        
    }
}

