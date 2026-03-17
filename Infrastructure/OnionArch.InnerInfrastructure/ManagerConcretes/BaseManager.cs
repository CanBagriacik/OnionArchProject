using AutoMapper;
using OnionArch.APPLICATION.Dtos;
using OnionArch.APPLICATION.Managers;
using OnionArch.CONTRACT.Repositories;
using OnionArch.DOMAIN.Entities.Abstratcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnionArch.DOMAIN.Enums;

namespace OnionArch.InnerInfrastructure.ManagerConcretes
{
    public abstract class BaseManager<D, T> : IManager<D, T> where D : class, IEntity where T : class, IDto
    {
        readonly IRepository<D> _repository;
        readonly protected IMapper _mapper;

        protected BaseManager(IRepository<D> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> AnyAsync(Expression<Func<D, bool>> exp)
        {
            return await _repository.AnyAsync(exp);
        }

        public async Task<string> CreateAsync(T entity)
        {
            try
            {
                entity.CreatedDate = DateTime.Now;
                entity.Status = DataStatus.Inserted;

                D domainEntity = _mapper.Map<D>(entity);
                await _repository.CreateAsync(domainEntity);
                return "Ekleme Başarılıdır";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        /// <summary>
        /// Veriyi pasife çeken metottur
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> DeleteAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = DataStatus.Deleted;
            D newValue = _mapper.Map<D>(entity);
            D originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
            return "Veri Pasife Çekilmiştir.";

        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<D, bool>> exp)
        {
            D value = await _repository.FirstOrDefaultAsync(exp);
            return _mapper.Map<T>(value);
        }

        public async Task<List<T>> GetAllAsync()

        {
            List<D> values = await _repository.GetAllAsync();
            return _mapper.Map<List<T>>(values);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            D value = await _repository.GetByIdAsync(id);
            return _mapper.Map<T>(value);
        }

        /// <summary>
        /// Veriyi silen metottur
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<string> RemoveAsync(T entity)
        {
            if (entity.Status != DataStatus.Deleted)
            {
                return "Silme işlemi sadece pasif veriler üzerinde uygulanabilir";
            }
            D originalValue = await _repository.GetByIdAsync(entity.Id);
            await _repository.DeleteAsync(originalValue);
            return $"Silme işlemi başarıyla gerçekleştirildi....Silinen id:{entity.Id}";
        }

        public async Task<string> UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            entity.Status = DataStatus.Updated;
            D newValue = _mapper.Map<D>(entity);
            D originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
            return "Güncelleme İşlemi Başarıyla Gerçekleştirildi";
        }

        public IQueryable<T> Where(Expression<Func<D, bool>> exp)
        {
            IQueryable<D> values = _repository.Where(exp);
            return _mapper.Map<IQueryable<T>>(values);
        }

        public async Task MakePassiveAsync(T entity)
        {
            entity.DeletedDate= DateTime.Now;
            entity.Status = DataStatus.Deleted;

            D newValue =_mapper.Map<D>(entity);
            D originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);

        }
    }
}
