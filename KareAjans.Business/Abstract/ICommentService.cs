using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface ICommentService : IService
    {
        List<CommentDTO> GetComments();
        void AddComment(CommentDTO dto);
        void DeleteComment(CommentDTO dto);
        void UpdateComment(CommentDTO dto);
        List<CommentDTO> GetCommentsByModelEmployeeId(int id);

        CommentDTO GetCommentById(int id);
    }
}
