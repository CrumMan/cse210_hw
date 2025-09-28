using System;
namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string name, string topic, string title)
        {
            SetStudent(name, topic);
            SetWritingInfo(title);
            System.Console.WriteLine(GetSummary());
            System.Console.WriteLine(GetHomeworklist());
        }
        private void SetWritingInfo(string title)
        {
            _title = title;
        }
        private string GetTitle()
        {
            return _title;
        }
        private string GetHomeworklist()
        {
            return $"{GetTitle()}";
        }


    }
}