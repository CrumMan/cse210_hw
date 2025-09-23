using System.Dynamic;

namespace youtube
{
    public class Comment()
    {
        public List<string> _comment = new List<string>();
        public List<String> SetCommentAttributes(string username, string comment)
        {
            _comment.Add(username);
            _comment.Add(comment);
            return _comment;
        }
    }
}