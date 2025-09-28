using System;
namespace Homework
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string name, string topic, string section, string problems)
        {
            SetStudent(name, topic);
            SetMathInfo(section, problems);
            System.Console.WriteLine(GetSummary());
            System.Console.WriteLine(GetHomeworklist());
        }
        private void SetMathInfo(string section, string problems)
        {
            _textbookSection = section;
            _problems = problems;
        }
        private string GetTextbookSection()
        {
            return _textbookSection;
        }
        private string GetProblems()
        {
            return _problems;
        }
        private string GetHomeworklist()
        {
            return $"Section {GetTextbookSection()} Problems {GetProblems()}";
        }


    }
}