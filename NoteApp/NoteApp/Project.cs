using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{

    /// <summary>
    /// Все заметки список
    /// </summary>
    public class Project
    {
        public List<Note> Notes = new List<Note>();



        public void Sort()
        {
         Notes.Sort((y, x) => x.TimeChanged.CompareTo(y.TimeChanged));
        }



        public List<Note> Sort(NoteType type)
        {
            var findedNotes = Notes.FindAll(a => a.NoteType == type);
            findedNotes.Sort((y, x) => x.TimeChanged.CompareTo(y.TimeChanged));

            return findedNotes;

        }
    }

}
