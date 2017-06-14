using System.Collections.Generic;

namespace ProcessNote
{
    class Comment
    {
        private int id;
        private string content;
        public List<Comment> comments = new List<Comment>();

        public Comment(int ID, string content)
        {
            this.ID = ID;
            this.content = content;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
