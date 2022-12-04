using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
    public class FilesBL : IFilesBL
    {
        IMapper mapper;
        public FilesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        FilesDL _FilesDL = new FilesDL();

        public List<FilesDTO> GetAllFiles()
        {
            List<Files> AllFiles = _FilesDL.GetAllFiles();
            return mapper.Map<List<Files>, List<FilesDTO>>(AllFiles);
        }

        public bool AddFiles(FilesDTO u)
        {

            return _FilesDL.AddFiles(mapper.Map<FilesDTO, Files>(u));

        }
        public bool DeleatFiles(int id)
        {
            return _FilesDL.DeleteFiles(id);

        }
        public bool UpdateFiles(int id, FilesDTO u)
        {
            return _FilesDL.UpdateFiles(id, mapper.Map<FilesDTO, Files>(u));
        }

    }
}
