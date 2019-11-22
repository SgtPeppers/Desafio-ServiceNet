﻿using DesafioServiceNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioServiceNetAPI.Repository.ClientR
{
    public interface IClientRepository<T>
    {
        Task<T> AddAsync(T Client);

        Task<T> UpdateAsync(T Client);

        Task<T> DeleteAsync(int ClientId);

        Task<T> GetByIdAsync(int Id);

        Task<ICollection<T>> GetByNameAsync(string Name);

        Task<ICollection<T>> GetAllAsync();

        Task<CEP> AddCep(CEP Cep);
    }
}
