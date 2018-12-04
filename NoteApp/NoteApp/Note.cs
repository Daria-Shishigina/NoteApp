using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NoteApp 
{
    /// <summary>
    /// Класс заметки.
    /// </summary>
    public class Note : ICloneable
    {
        private string _title = "Без названия";  
        private string _text;
        private DateTime _timeCreated;
        private NoteType _noteType;
        private DateTime _timeChanged;
        
        /// <summary>
        /// Создание экземпляра заметки.
        /// </summary>
        /// <param name="dateTime">Время создания.</param>
        public Note(DateTime dateTime)
        {
            TimeCreated = dateTime;
            TimeChanged = dateTime;
            //this._timeCreated = dateTime;
            //this._timeChanged = dateTime;
        }
        public Note()
        {

        }
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length>0 && value.Length<50)
                {
                    _title = value;
                    //TimeChanged = DateTime.Now;
                }
                else
                {
                    if (value.Length >= 50)
                    {
                        throw new ArgumentException("Длина заголовка не можнт быть больше 50 символов.");
                    }
                }
            }
        }


        public NoteType NoteType
        {
            get
            {
                return _noteType;
            }
            set
            {
                if (value >= 0)
              
                {
                    _noteType = value;
                    //TimeChanged = DateTime.Now;
                }
                else
                {
                    
                        throw new ArgumentException("Выбор из списка");
                    
                }
            }
        }

        /// <summary>
        /// Текст заметки.
        /// </summary>

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (value.Length > 0)
                {
                    _text = value;
                   // TimeChanged = DateTime.Now;
                }
                else
                {
                    if (value.Length <= 0) 
                    {
                        throw new ArgumentException("Текст заметки пуст.");
                    }
                }
            }
        }


        /// <summary>
        /// Время создания заметки.
        /// </summary>
        public DateTime TimeCreated
        {
            get
            {
                return _timeCreated; 
            }
            set
            {
                 if (value <= DateTime.Now )
                {
                    _timeCreated = value;
                }
                else
                {
                      if (value > DateTime.Now )

                    {
                        throw new ArgumentException("Дата создания заметки не должна быть позже реального времени.");
                    }
                }
            }
        }


        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>

        public DateTime TimeChanged
        {
            get
            {
                return _timeChanged;
            }
            set
            {
                if (value <= DateTime.Now && value >= TimeCreated)
                {
                    _timeChanged = value;
                }
                else
                {
                    if (value > DateTime.Now || value < TimeCreated)

                    {
                        throw new ArgumentException("Время последнего игменения заметки не должна быть позже реального времени.");
                    }
                }
            }
        }

        public object Clone()

        {
            var newNote = new Note(TimeCreated);
            newNote.Title = _title;
            newNote.NoteType = _noteType;
            newNote.Text = _text;
            newNote.TimeCreated = _timeCreated;
            newNote.TimeChanged = _timeChanged;
            return newNote;
        }
    }
}
