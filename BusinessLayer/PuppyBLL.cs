﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Repository;
using BLL1.DTO;

namespace BLL1
{
    public class PuppyBLL
    {
        public List<PuppyDTO> getAllPuppies()
        {
            List<PuppyDTO> result = new List<PuppyDTO>();

            IPuppy puppyRepo = new PuppyImpl();
            List<Puppy> puppyList = puppyRepo.getAllPuppies();
            
            for(int i = 0; i < puppyList.Count; i++)
            {
                Puppy onePuppy = puppyList[i];
                PuppyDTO onePuppyDTO = new PuppyDTO()
                {
                    Id = onePuppy.Id,
                    Gender = onePuppy.Gender,
                    Breed = onePuppy.Breed,
                    Color = onePuppy.Color,
                    OwnerName = onePuppy.OwnerName,
                    Weight = onePuppy.Weight,
                    DOB = onePuppy.DOB,
                    DaysLived = getPuppyDaysSinceBirth(onePuppy),
                };
                result.Add(onePuppyDTO);
            }
            return result;
        }


        public int getPuppyDaysSinceBirth(Puppy onePuppy)
        {
            //this is a calculation and all these kind of methods should be 
            //placed in the business layer
            return 120;
        }
    }
}
