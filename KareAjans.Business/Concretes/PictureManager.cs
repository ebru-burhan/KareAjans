using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class PictureManager : IPictureService
    {
        private readonly IPictureRepository _pictureRepository;
        public PictureManager(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }



        public List<PictureDTO> GetPictures()
        {
            throw new NotImplementedException();
        }

        public void AddPicture(PictureDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeletePicture(PictureDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdatePicture(PictureDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
