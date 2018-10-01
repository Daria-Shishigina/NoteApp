using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Сохранение заметок в отдельный файл
        /// </summary>
        /// <param name="listNotes">Список заметок.</param>
        /// <param name="fileName">Имя файла назначения.</param>
        public static void SaveToFile(Project listNotes, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для записи в файл с указанием пути

            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, (Project)listNotes);
            }
        }

        /// <summary>
        /// Получение списка заметок из файла
        /// </summary>
        /// <param name="filename">Имя файла.</param>
        /// <returns></returns>
        public static Project LoadFromFile(string fileName)
        {
            Project notes = new Project();

            //Создаём экземпляр сериализатора.

            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для чтения из файла с указанием пути.

            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                var noteList = (Project)serializer.Deserialize<Project>(reader);
                notes = noteList;
            }
            return notes;
        }

    }
}
