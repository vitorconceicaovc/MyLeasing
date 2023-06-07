﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public interface IOwnerRepository : IGenericRepository<Owner>
    {
        public IQueryable GetAllWithUsers();
        
    }
}
