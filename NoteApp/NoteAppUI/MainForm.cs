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
    public partial class MainForm : Form
    {
        private Project _noteslist = new Project();

        public MainForm()
        {
            InitializeComponent();
            
            foreach (var e in Enum.GetValues(typeof(NoteType)))
            {
                TypeComboBox.Items.Add(e);
            }

            //TypeComboBox.Items.Add(NoteType.Work);
            //TypeComboBox.Items.Add(NoteType.Home);
            //TypeComboBox.Items.Add(NoteType.Health_and_sport);
            //TypeComboBox.Items.Add(NoteType.People);
            //TypeComboBox.Items.Add(NoteType.Finance);
            //TypeComboBox.Items.Add(NoteType.Documents);
            //TypeComboBox.Items.Add(NoteType.Miscellaneous);
            AllNotes();
        }

        private void AllNotes()
        {
            _noteslist = ProjectManager.LoadFromFile("c:\\Users\\User\\Desktop\\txt.json");
            NotesListBox.Items.Clear();
            foreach (var note in _noteslist.Notes)
            {
                NotesListBox.Items.Add(note.Title);

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // _noteslist = ProjectManager.LoadFromFile("c:\\Users\\User\\Desktop\\txt.json");

        }

        /// <summary>
        /// Добавить заметку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddbButton_Click(object sender, EventArgs e)

        {
            var notes = new NotesForm();
            notes.Note = new Note(DateTime.Now);
            if (notes.ShowDialog() == DialogResult.OK)
            {

                var note = notes.Note;
                _noteslist.Notes.Add(note);
                NotesListBox.Items.Add(note.Title);
                ProjectManager.SaveToFile(_noteslist, "c:\\Users\\User\\Desktop\\txt.json");

            }


        }







        /// <summary>
        /// Редактировать заметку (НЕ РАБОТАЕТ ) !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {

            
            var notes = new NotesForm();
            notes.Note = _noteslist.Notes[NotesListBox.SelectedIndex];
            if (notes.ShowDialog() == DialogResult.OK)
            {
                _noteslist.Notes[NotesListBox.SelectedIndex] = notes.Note;
                ProjectManager.SaveToFile(_noteslist, "c:\\Users\\User\\Desktop\\txt.json");
                AllNotes();
            }
        }


        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ClearButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _noteslist.Notes.Remove(_noteslist.Notes[NotesListBox.SelectedIndex]);
                NotesListBox.Items.Remove(NotesListBox.SelectedIndex);

                ProjectManager.SaveToFile(_noteslist, "c:\\Users\\User\\Desktop\\txt.json");
                NotesListBox.Items.Clear();
                AllNotes();

              
            }
        }

        /// <summary>
        /// Предварительный просмотр выбранной заметки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titlelabel.Text = _noteslist.Notes[NotesListBox.SelectedIndex].Title;
            NoteCategorylabel.Text = _noteslist.Notes[NotesListBox.SelectedIndex].NoteType.ToString();
            //CreateddateTime.Value = _noteslist.Notes[NotesListBox.SelectedIndex].TimeCreated;
            //ChangeddateTime.Value = _noteslist.Notes[NotesListBox.SelectedIndex].TimeChanged; //?????????????????????????????????????????????????????????????
            TextTextBox.Text = _noteslist.Notes[NotesListBox.SelectedIndex].Text;
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            NoteType selectedNoteType;
            selectedNoteType = (NoteType)TypeComboBox.SelectedItem;
            //.NoteType = (NoteType)TypeComboBox.SelectedIndex; //???????????????????????????????????????
        }






        /// <summary>
        /// Вывод на экран формы при нажатии About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();

        }

        private void Titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddbButton_Click(sender, e);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditButton_Click(sender, e);
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }
    }
}