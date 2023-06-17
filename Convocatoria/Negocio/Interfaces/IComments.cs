using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Interfaces
{
    public interface IComments
    {
        List<Comment> GetComments();

        void setComment(Comment comment);


        void DeleteComment(Comment comment);
    }
}
