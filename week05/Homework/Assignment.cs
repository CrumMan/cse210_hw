using System;
namespace Homework
{
    public class Assignment
    {
        protected string _studentName;
        protected string _topic;

        public Assignment()
        {
            _studentName = "Null Student";
            _topic = "Unknown Topic";

        }

        private string GetName()
        {
            return _studentName;
        }
        public void SetStudent(string name, string topic)
        {
            _studentName = name;
            _topic = topic;
        }
        private string GetTopic()
        {
            return _topic;
        }
        public string GetSummary()
        {
            return $"{GetName()} - {GetTopic()}";
        }
    }
}