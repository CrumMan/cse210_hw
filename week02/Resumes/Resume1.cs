using System.ComponentModel.DataAnnotations;
namespace week02.Resumes
{
    public class Resume
    {
        public List<Job> jobs = new List<Job>();
        public string _name = "";
        public void DisplayResume()
        {
            System.Console.WriteLine($"Name: {_name}\n  Jobs:");
            foreach (Job jobprops in jobs)
            {
                jobprops.Display();
            }
        }

    }
}