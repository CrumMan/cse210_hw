using System.Collections.Concurrent;
using System.Reflection;

namespace Scripture_Memorizer
{
    public class Refrence
    {
        string _book;
        int _chapter;
        int _verse;
        int? _endVerse = null;
        public void SetRefrence(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public void SetRefrence(string book, int chapter, int startverse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startverse;
            _endVerse = endVerse;
        }
        public string GetBook()
        {
            return _book;
        }
        public int GetChapter()
        {
            return _chapter;
        }
        public int GetVerse()
        {
            return _verse;
        }
        public int? GetEndVerse()
        {
            return _endVerse;
        }
        public string Text()
        {
            string refrenceString = _endVerse == null ? $"{GetBook()} {GetChapter()}: {GetVerse()}" : $"{GetBook()} {GetChapter()}:{GetVerse()}-{GetEndVerse()}";
            return refrenceString;
        }
    }

}