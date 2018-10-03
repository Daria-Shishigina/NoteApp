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
//


namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Note note = new Note(DateTime.Now);
            note.Text = "jsdhfg";
            note.Title = "sdjfhdf";
            note.NoteType = NoteType.Documants;
            //MessageBox.Show(note.Text);
            Project project = new Project();
            project.Notes.Add(note);
            ProjectManager.SaveToFile(project, "c:\\Users\\User\\Desktop\\txt.json");
        }
    }
}
