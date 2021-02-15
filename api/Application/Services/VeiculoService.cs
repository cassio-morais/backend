using api.Domain.ViewModels;
using api.Models.Entities;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _VeiculoRepository;

        public VeiculoService(IVeiculoRepository VeiculoRepository)
        {
            _VeiculoRepository = VeiculoRepository;
        }

        public async Task<IEnumerable<Veiculo>> GetVeiculos()
        {
            try
            {
                var result = await _VeiculoRepository.GetAll();
                
                if(result == null) return null;
                
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Veiculo> GetVeiculoById(int id)
        {
            try
            {
                var result = await _VeiculoRepository.GetById(id);
                if (result == null) return null;
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}