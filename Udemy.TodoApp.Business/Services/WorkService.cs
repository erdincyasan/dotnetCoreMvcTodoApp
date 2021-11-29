using AutoMapper;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy.TodoApp.Business.Extensions;
using Udemy.TodoApp.Business.Interfaces;
using Udemy.TodoApp.Common.Enums;
using Udemy.TodoApp.Common.ResponseObjects;
using Udemy.TodoApp.DataAccess.UnitOfWork;
using Udemy.TodoApp.Dtos.WorkDtos;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<WorkCreateDto> _createValidator;
        private readonly IValidator<WorkUpdateDto> _updateValidator;
        public WorkService(IUow uow, IMapper mapper, IValidator<WorkCreateDto> createValidator, IValidator<WorkUpdateDto> updateValidator)
        {
            _uow = uow;
            _mapper = mapper;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        public async Task<IResponse<WorkCreateDto>> Create(WorkCreateDto workCreateDto)
        {

            var validationResult = _createValidator.Validate(workCreateDto);
            if (validationResult.IsValid)
            {
                await _uow.GetRepository<Work>().Create(_mapper.Map<Work>(workCreateDto));
                await _uow.SaveChanges();
            return new Response<WorkCreateDto>(ResponseType.Success, workCreateDto);
            }
            else
            {
               
                return new Response<WorkCreateDto>(ResponseType.ValidationError, workCreateDto,validationResult.ConvertToCustomValidationError());
            }
        }

        public async Task<IResponse<List<WorkListDto>>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();
            var mappedList = _mapper.Map<List<WorkListDto>>(list);
            if (mappedList.Count>0)
            {
                return new Response<List<WorkListDto>>(ResponseType.Success,mappedList);
            }
            else
            {
                return new Response<List<WorkListDto>>(ResponseType.NotFound,"Veri bulunamadı");
            }
        }
        public async Task<IResponse<IDto>> GetById<IDto>(int id)
        {
            var workEntity = await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id);
            var workDto = _mapper.Map<IDto>(workEntity);
            if (workDto==null)
            {
                return new Response<IDto>(ResponseType.NotFound, "Bulunamadı");
            }
            else
            {
                return new Response<IDto>(ResponseType.Success, workDto);
            }
        }

        public async Task<IResponse> Remove(int id)
        {
            var removedEntity = await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id);
            if (removedEntity != null)
            {
                _uow.GetRepository<Work>().Remove(removedEntity);
                await _uow.SaveChanges();
                return new Response(ResponseType.Success);
            }
            else
            {
                return new Response(ResponseType.NotFound);
            }
        }

        public async Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto workUpdateDto)
        {
            var validationResult = _updateValidator.Validate(workUpdateDto);
            if (validationResult.IsValid)
            {
                var unchangedEntity = await _uow.GetRepository<Work>().Find(workUpdateDto.Id);
                if (unchangedEntity != null)
                {
                    _uow.GetRepository<Work>().Update(unchangedEntity, _mapper.Map<Work>(workUpdateDto));
                    await _uow.SaveChanges();
                    return new Response<WorkUpdateDto>(ResponseType.Success, workUpdateDto);
                }
                else
                {
                    return new Response<WorkUpdateDto>(ResponseType.NotFound, $"İlgili idye ait kayıt bulunamadı {workUpdateDto.Id}");
                }
            }
            else
            {
                return new Response<WorkUpdateDto>(ResponseType.ValidationError, workUpdateDto, validationResult.ConvertToCustomValidationError());
            }
        }
    }
}
