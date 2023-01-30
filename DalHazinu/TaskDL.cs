using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class TaskDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<Task> GetAllTask()
        {
            try
            {

                return _context.Task.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
       public bool DeleteTask(int id)
        {
            try
            {
                Task task = _context.Task.SingleOrDefault(x => x.Id == id);
                _context.Task.Remove(task);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddTask(Task a)
        {

            try
            {
                _context.Task.Add(a);
                _context.SaveChanges();
                return a.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTask(int id, Task a)
        {
            try
            {
                Task currentTask = _context.Task.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentTask).CurrentValues.SetValues(a);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }


        }
    }
}
