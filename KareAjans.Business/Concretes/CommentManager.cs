using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public CommentManager(ICommentRepository commentRepository , IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }


        public List<CommentDTO> GetComments()
        {
            var comments = _commentRepository.GetAll();
            return _mapper.Map<List<CommentDTO>>(comments);
        }

        public void AddComment(CommentDTO dto)
        {
            _commentRepository.Add(_mapper.Map<Comment>(dto));
        }

        public void DeleteComment(CommentDTO dto)
        {
            _commentRepository.Delete(_mapper.Map<Comment>(dto));
        }


        public void UpdateComment(CommentDTO dto)
        {
            _commentRepository.Update(_mapper.Map<Comment>(dto));
        }

        public List<CommentDTO> GetCommentsById(int id)
        {
            var comments = _commentRepository.GetFilteredIncluded(x => x.ModelEmployeeId == id , x => x.ModelEmployee);
            return _mapper.Map<List<CommentDTO>>(comments);
        }
    }
}
