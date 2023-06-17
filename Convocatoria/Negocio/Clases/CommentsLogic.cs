using Datos;
using Microsoft.EntityFrameworkCore;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clases
{
    public class CommentsLogic : IComments
    {
        private FakeDataContext db;

        public CommentsLogic(FakeDataContext db)
        {
            this.db = db;
        }

        public List<Comment> GetComments()
        {
            return db.Comments.ToList();
        }

        public void setComment(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }
       
        public void DeleteComment(Comment comment)
        {
            db.Comments.Remove(comment);
            db.SaveChanges(true);
        }
    }
}
