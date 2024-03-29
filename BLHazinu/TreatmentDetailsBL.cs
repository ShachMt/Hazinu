﻿using AutoMapper;
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

        public int EmployeesApply(int apply)
        {
            return _TreatmentDetailsDL.EmployeesApply(apply);
        }
        public TreatmentDetailsDTO GetTreatmentDetailsByApplyTask(int apply, int idTratment)
        {
            TreatmentDetails t = _TreatmentDetailsDL.GetTreatmentDetailsByApplyTask(apply, idTratment);
             return mapper.Map<TreatmentDetails, TreatmentDetailsDTO>(t);
        }

        public List<TreatmentDetailsDTO> GetAllTreatmentDetails(int applyId)
        {
            List<TreatmentDetails> AllTreatmentDetails = _TreatmentDetailsDL.GetAllTreatmentDetailsByApply(applyId);
            return mapper.Map<List<TreatmentDetails>, List<TreatmentDetailsDTO>>(AllTreatmentDetails);
        }
        public TreatmentDetailsDTO GetTreatmentDetailsByApplyState(int applyId)
        {
            TreatmentDetails treatmentDetails = _TreatmentDetailsDL.GetTreatmentDetailsByApplyState(applyId);
            return mapper.Map<TreatmentDetails, TreatmentDetailsDTO>(treatmentDetails);
        }

        public bool AddTreatmentDetails(TreatmentDetailsDTO u)
        {

            return _TreatmentDetailsDL.AddTreatmentDetails(mapper.Map<TreatmentDetailsDTO, TreatmentDetails>(u));

        }
        public bool DeleatTreatmentDetails(int id,int applyId)
        {
            return _TreatmentDetailsDL.DeleteTreatmentDetails(id,applyId);

        }
        public bool UpdateTreatmentDetails(int id, TreatmentDetailsDTO u)
        {
            return _TreatmentDetailsDL.UpdateTreatmentDetails(mapper.Map<TreatmentDetailsDTO, TreatmentDetails>(u), id);
        }
    }
}
