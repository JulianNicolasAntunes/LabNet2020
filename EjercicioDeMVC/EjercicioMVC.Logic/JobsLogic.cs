using EjercicioMVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class JobsLogic : Logic, ILogic<JOBS>
    {
        public void Delete(int entity)
        {
            try
            {
                JOBS deleteJob = GetOne(entity);
                context.JOBS.Remove(deleteJob);
                context.SaveChanges();
            }
            catch { throw new Exception("Error"); }
        }

        public List<JOBS> GetAll()
        {
            return context.JOBS.ToList();
        }


        public JOBS GetOne(int id)
        {
            return context.JOBS.First(r => r.ID.Equals(id));
        }

        public JOBS Insert(JOBS entity)
        {
            try
            {
                JOBS newJob = context.JOBS.Add(entity);
                context.SaveChanges();
                return newJob;
            }
            catch { throw new Exception("Error"); }
        }

        public void Update(JOBS entity)
        {
          //  JOBS editJob = GetOne(entity.ID);
            //editJob.JOB_NAME = entity.JOB_NAME;
            context.SaveChanges();
        }
    }
}
