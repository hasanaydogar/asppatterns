using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;

namespace Model
{
    public class Post : ActiveRecordBase<Post>
    {
        [PrimaryKey]
        public int Id { get; set; }

        [Property]
        public string Subject { get; set; }

        [Property]
        public string Text { get; set; }

        public string ShortText
        {
            get {
                if (Text.Length > 20)
                {
                    return Text.Substring(0, 20) + "...";
                }
                return Text;
            }
        }
        [HasMany]
        public IList<Comment> Comments { get; set; }

        public DateTime DateAdded { get; set; }

        public static Post FindLatestPost()
        {
            SimpleQuery<Post> q = new SimpleQuery<Post>(@"from Post p order by p.DateAdded desc");

            return (Post) q.Execute()[0];
        }
    }
}
