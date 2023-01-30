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
    public class StylesInstitutionBL : IStylesInstitutionBL
    {
        IMapper mapper;
        public StylesInstitutionBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        StylesInstitutionDL _StylesInstitutionDL = new StylesInstitutionDL();

        public List<StylesInstitutionDTO> GetAllStylesInstitution()
        {
            List<StylesInstitution> AllStylesInstitution = _StylesInstitutionDL.GetAllStylesInstitution();
            return mapper.Map<List<StylesInstitution>, List<StylesInstitutionDTO>>(AllStylesInstitution);
        }
        public bool DeleteStylesInstitution(int id)
        {
            return _StylesInstitutionDL.DeleteStylesInstitution(id);
        }
        public int AddStylesInstitution(StylesInstitutionDTO a)
        {
            return _StylesInstitutionDL.AddStylesInstitution(mapper.Map<StylesInstitutionDTO, StylesInstitution>(a));

        }
        public bool UpdateStylesInstitution(int id, StylesInstitutionDTO a)
        {
            return _StylesInstitutionDL.UpdateStylesInstitution(id, mapper.Map<StylesInstitutionDTO, StylesInstitution>(a));

        }
    }
}
