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
    public class PictureManager : IPictureService
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly IMapper _mapper;
        public PictureManager(IPictureRepository pictureRepository, IMapper mapper)
        {
            _pictureRepository = pictureRepository;
            _mapper = mapper;
        }

        public List<PictureDTO> GetPictures()
        {
            var pictures = _pictureRepository.GetAll();
            return _mapper.Map<List<PictureDTO>>(pictures);
        }

        public void AddPicture(PictureDTO dto)
        {
            _pictureRepository.Add(_mapper.Map<Picture>(dto));
        }

        public void DeletePicture(PictureDTO dto)
        {
            _pictureRepository.Delete(_mapper.Map<Picture>(dto));
        }

        public PictureDTO GetPictureById(int id)
        {
            var picture = _pictureRepository.Get(x => x.PictureID == id).FirstOrDefault();
            return _mapper.Map<PictureDTO>(picture);
        }
    }
}
