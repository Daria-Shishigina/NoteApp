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
    public class Note
    {
        private string _title = "Без названия";
        private NoteType _type;   
        private string _text;
        private DateTime _timeCreated;
        private DateTime _timeChanged;
        
        /// <summary>
        /// Создание экземпляра заметки.
        /// </summary>
        /// <param name="dateTime">Время создания.</param>
        public Note(DateTime dateTime)
        {
            this._timeCreated = dateTime;
            this._timeChanged = dateTime;
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
                }
                else
                {
                    if (value.Length = 0) //???????????????????????????????????????
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
               // if (value.Length > 0 && value.Length < 50)
                {
                    _timeCreated = value;
                }
                else
                {
                  //  if (value.Length >= 50)

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
                // if (value.Length > 0 && value.Length < 50)
                {
                    _timeChanged = value;
                }
                else
                {
                    //  if (value.Length >= 50)

                    {
                        throw new ArgumentException("Время последнего игменения заметки не должна быть позже реального времени.");
                    }
                }
            }
        }







    }
}
