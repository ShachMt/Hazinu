﻿using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
 public class AddressDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<Address> GetAllAddress()
        {
            try
            {

                return _context.Address.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public List<string> GetAllCities()
        {
            try
            {
                List<string> cities = new List<string>();
                cities.Add("לא מעוניין למסור פרטים");
                foreach (var item in GetAllAddress())
                {
                   if(!cities.Contains(item.City))
                    if (item.City != "")
                        cities.Add(item.City);
                }
                cities.Add("אחר");
                return cities;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetIdAddressByCity(string nameCity)
        {
            try
            {
                Address a = GetAllAddress().FirstOrDefault(x => x.City == nameCity);

                return a.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Address> GetAllAddressByNameCity(string city)
        {
            try
            {
                List<Address> LAddress = _context.Address.Where(x => x.City == city).ToList();
                return LAddress;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
            public bool DeleteAddress(int id)
          {
            try
            {
                Address address = _context.Address.SingleOrDefault(x => x.Id == id);
                _context.Address.Remove(address);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddAddress(Address a)
        {

            try
            {
                _context.Address.Add(a);
                _context.SaveChanges();
                return a.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateAddress(int id, Address a)
        {
            try
            {
                Address currentAddress = _context.Address.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentAddress).CurrentValues.SetValues(a);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }


        }
    }
}
