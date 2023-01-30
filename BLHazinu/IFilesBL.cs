using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IFilesBL
    {
        int AddFiles(FilesDTO u);
        bool DeleatFiles(int id);
        List<FilesDTO> GetAllFiles();
        bool UpdateFiles(int id, FilesDTO u);
    }
}