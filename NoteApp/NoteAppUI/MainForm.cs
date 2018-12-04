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
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();


            TypeComboBox.Items.Add("All");

            TypeComboBox.SelectedIndex = 0;
            foreach (var e in Enum.GetValues(typeof(NoteType)))
            {
                TypeComboBox.Items.Add(e);
            }



            _project = ProjectManager.LoadFromFile("c:\\Users\\User\\Desktop\\txt.json");
            AllNotes();
        }
  
        private void AllNotes()
        {
           


            NotesListBox.Items.Clear();
            _project.Sort();

                foreach (var note in _project.Notes)
                {
                    NotesListBox.Items.Add(note.Title);
                }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
                _project.Notes.Add(note);
                NotesListBox.Items.Add(note.Title);
                ProjectManager.SaveToFile(_project, "c:\\Users\\User\\Desktop\\txt.json");
                AllNotes();

            }
        }

        /// <summary>
        /// Редактировать заметку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {       
            var notes = new NotesForm();
            notes.Note = _project.Notes[NotesListBox.SelectedIndex];
            if (notes.ShowDialog() == DialogResult.OK)
            {
                _project.Notes[NotesListBox.SelectedIndex] = notes.Note;
                ProjectManager.SaveToFile(_project, "c:\\Users\\User\\Desktop\\txt.json");
                AllNotes();
            }
            else
            {
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
                _project.Notes.Remove(_project.Notes[NotesListBox.SelectedIndex]);
                NotesListBox.Items.Remove(NotesListBox.SelectedIndex);

                ProjectManager.SaveToFile(_project, "c:\\Users\\User\\Desktop\\txt.json");
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
            Titlelabel.Text = _project.Notes[NotesListBox.SelectedIndex].Title;
            NoteCategorylabel.Text = _project.Notes[NotesListBox.SelectedIndex].NoteType.ToString();
            CreateddateTime.Value = _project.Notes[NotesListBox.SelectedIndex].TimeCreated;
            ChangeddateTime.Value = _project.Notes[NotesListBox.SelectedIndex].TimeChanged; 
            TextTextBox.Text = _project.Notes[NotesListBox.SelectedIndex].Text;
        }

        /// <summary>
        ///  сортировка категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
            if (TypeComboBox.SelectedItem.ToString() == "All")
            {
                AllNotes();
            }
            else
            {
                NoteType selectedNoteType;
                selectedNoteType = (NoteType)TypeComboBox.SelectedItem;
                var findedNotes = _project.Sort(selectedNoteType);
                NotesListBox.Items.Clear();
                foreach (Note note in findedNotes)
                {
                    NotesListBox.Items.Add(note.Title);
                }
            }

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