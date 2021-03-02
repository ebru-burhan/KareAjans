using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IPictureService : IService
    {
        List<PictureDTO> GetPictures();
        void AddPicture(PictureDTO dto);
        void DeletePicture(PictureDTO dto);
        void UpdatePicture(PictureDTO dto);
    }
}
