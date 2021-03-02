using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IPictureService : IService
    {
        List<PictureDTO> GetComments();
        void AddComment(PictureDTO dto);
        void DeleteComment(PictureDTO dto);
        void UpdateComment(PictureDTO dto);
    }
}
