﻿using CRMS.Data;
using CRMS.Models;
using CRMS.Services;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Repository.MsSQL
{
    public class UserDbRepository : IRepository<User>
    {
        public Task<User> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetbyIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
