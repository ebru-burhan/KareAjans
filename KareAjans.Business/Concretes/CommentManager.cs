using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }


        public List<CommentDTO> GetComments()
        {
            throw new NotImplementedException();
        }

        public void AddComment(CommentDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(CommentDTO dto)
        {
            throw new NotImplementedException();
        }



        public void UpdateComment(CommentDTO dto)
        {
            throw new NotImplementedException();
        }



        //--------------dto dan entity ve enttyden dto çevrme methodlar----------------------
        private CommentDTO ConvertToDto(Comment comment)
        {
            CommentDTO dto = new CommentDTO()
            {
                Message = comment.Message,
                // TODO:Modelleri nası mapleyeceeezzzzz automapper ama howwwwwww
                //ModelEmployee = comment.ModelEmployee 
            };

            return dto;
        }

        private Comment ConvertToEntity(CommentDTO dto)
        {
            Comment entity = new Comment()
            {
               
            };

            return entity;
        }

    }
}
