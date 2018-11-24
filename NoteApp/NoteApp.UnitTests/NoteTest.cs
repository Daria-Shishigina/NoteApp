using System;
using NUnit.Framework;

using NoteApp;


namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {



        [Test(Description = " тест  Note")]
        public void NoteTestNote()
        {
            var note = new Note();
          
        }


        [Test(Description = "Позитивный тест  Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "qqqqqqqq";
            var note = new Note();
            note.Title = expected;
            var actual = note.Title;
            Assert.AreEqual(expected, actual, "Возвращает неправильный заголовок");
        }




        [Test(Description = "Позитивный тест пустой Title")]
        public void TestTitleSet_CorrectValue()
        {
            var expected = "";
            var note = new Note();
            note.Title = expected;
            var actual = note.Title;

            Assert.AreEqual("Без названия", actual, "Возвращает неправильный заголовок");
        }


        [Test(Description = " Негативный тест Title Присвоение заголовка больше 50 символов")]

        public void TestTitleSet_Longer50Symbols()
        {
            var wrongTitle = "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq";
            var note = new Note();

            Assert.Throws<ArgumentException>(
               () => { note.Title = wrongTitle; });
        }




        [Test(Description = "Позитивный тест  Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = "qqqqqqqq";
            var note = new Note();
            note.Text = expected;
            var actual = note.Text;

            Assert.AreEqual(expected, actual, "Возвращает неправотный Text");
        }


        [Test(Description = " Негативный тест Text")]

        public void TestTextSet_Longer()
        {
            var wrongText = "";
            var note = new Note();

            Assert.Throws<ArgumentException>(
               () => { note.Text = wrongText; });
        }


        [Test(Description = "Позитивный тест  Type")]
        public void TestTypeGet_CorrectValue()
        {
            var expected = NoteType.Documents;
            var note = new Note();
            note.NoteType = expected;
            var actual = note.NoteType;

            Assert.AreEqual(expected, actual, "возвращает неправильный Type");
        }


        [Test(Description = "Позитивный тест  Clone")]
        public void TestClone_CorrectValue()
        {
            //var expected = "qqqqqqqq";
            var expected = new Note();
            expected.Text = "qqqqqqq";
            expected.Title = "Title";
            expected.NoteType = NoteType.Home;
            Note clone = (Note)expected.Clone();
            var actual = clone;
            Assert.AreEqual(expected.Text, actual.Text, "");
            Assert.AreEqual(expected.Title, actual.Title, "");
            Assert.AreEqual(expected.NoteType, actual.NoteType, "");
        }




        [Test(Description = "Позитивный тест TimeCreated")]
        public void TestNoteCreatedGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note(dateNow);
            var actual = note.TimeCreated;
            Assert.AreEqual(dateNow, actual, " TimeCreated возвращает неправильное значение");
        }




        [Test(Description = "Позитивный тест  TimeChanged")]
        public void TestNoteChangedGet_CorrectValue()
        {
            var dateNow = DateTime.Now;
            var note = new Note(dateNow);
            var actual = note.TimeChanged;
            var expected = dateNow;
            Assert.AreEqual(expected, actual, "TimeChanged возвращает неправильное значение");

        }





        [Test(Description = "Дата изменения больше текущей даты")]
        public void TestNoteChangedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note(DateTime.Now);
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(() => { note.TimeChanged = time; },"Должно возникать исключение");
        }





        [Test(Description = "Дата создания больше текущей дата")]
        public void TestNoteCreatedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note(DateTime.Now);
            time=time.AddYears(1000);
            Assert.Throws<ArgumentException>(() => { note.TimeCreated = time; },"Должно возникать исключение");
        }



        [Test(Description = "Дата изменения больше  даты создания")]
        public void TestNoteChangedSet_()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            time = time.AddDays(-100);
            Assert.Throws<ArgumentException>(() => { note.TimeChanged = time; },"Должно возникать исключение");
        }

    }
}

