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
    public class TreatmentDetailsBL : ITreatmentDetailsBL
    {
        IMapper mapper;
        public TreatmentDetailsBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        TreatmentDetailsDL _TreatmentDetailsDL = new TreatmentDetailsDL();
        //החזרת פניות לפי סטטוס



        public List<TreatmentDetailsDTO> GetAllTreatmentDetails(int applyId)
        {
            List<TreatmentDetails> AllTreatmentDetails = _TreatmentDetailsDL.GetAllTreatmentDetailsByApply(applyId);
            return mapper.Map<List<TreatmentDetails>, List<TreatmentDetailsDTO>>(AllTreatmentDetails);
        }

        public bool AddTreatmentDetails(TreatmentDetailsDTO u)
        {

            return _TreatmentDetailsDL.AddTreatmentDetails(mapper.Map<TreatmentDetailsDTO, TreatmentDetails>(u));

        }
        public bool DeleatTreatmentDetails(int id)
        {
            return _TreatmentDetailsDL.DeleteTreatmentDetails(id);

        }
        public bool UpdateTreatmentDetails(int id, TreatmentDetailsDTO u)
        {
            return _TreatmentDetailsDL.UpdateTreatmentDetails(mapper.Map<TreatmentDetailsDTO, TreatmentDetails>(u), id);
        }
    }
}
