using System.ComponentModel.DataAnnotations;

namespace week02.Resumes
{
    public class Job
    {
        public string _jobtitle = "";
        public string _company = "";
        public int _startDate;
        public int _endDate;
        public void Display()
        {
            System.Console.WriteLine($"{_jobtitle} ({_company}) {_startDate}-{_endDate}");
        }
    }
}