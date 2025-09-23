using System.Net;
namespace youtube
{
    public class Video
    {
        public string _title;
        public string _author;
        public List<Comment> Comments = new List<Comment>();
        public Video()
        {
            instateComments();
        }
        public void instateComments()
        {
            Comment comment = new();
            Random random = new Random();
            int randomnum = random.Next(3, 5);
            for (int i = 0; i < randomnum; i++)
            {
                comment.SetCommentAttributes($"User{i}", $"User{i} comment is here!");
                Comments.Add(comment);
                comment._comment.Clear();
            }
        }
        public void DisplayTitleAuthorAndCommentsNumber()
        {
            int CommentsNum = 0;
            foreach (Comment comment in Comments)
            {
                CommentsNum++;
            }
            System.Console.WriteLine($"Title: {_title}\nBy: {_author}\nNumber of comments {CommentsNum} \n\n");
        }
    }
}