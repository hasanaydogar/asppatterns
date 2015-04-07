using System;
using Castle.ActiveRecord;

namespace Model
{
   [ActiveRecord("Comments")]
   public class Comment : ActiveRecordBase<Comment>
   {
       [PrimaryKey]
       public int Id { get; set; }

       [Property]
       public string Text { get; set; }

       [Property]
       public string Author { get; set; }

       [Property]
       public DateTime DateAdded { get; set; }

       [BelongsTo("PostID")]
       public Post Post { get; set; }
   }
}
