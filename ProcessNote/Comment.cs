using System.Collections.Generic;

namespace ProcessNote
{
    class Comment
    {
        int ID;
        string content;

        public Comment(int ID, string content)
        {
            this.ID = ID;
            this.content = content;
        }

        public int getID()
        { return ID; }

        public string getContent()
        { return content; }
    }
}
