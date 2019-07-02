using MinhasIdeias.Data;
using MinhasIdeias.DTOS;
using MinhasIdeias.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasIdeias.Services
{
    public class IdeasService
    {
        public static IdeasService Build()
        {
            return new IdeasService();
        }
        public int Create(IdeaDTO entityDto)
        {
            return IdeasRepository.Build().Create(IdeasMapper.ToModel(entityDto));
        }

        public int Update(IdeaDTO entityDto)
        {
            return IdeasRepository.Build().Update(IdeasMapper.ToModel(entityDto));
        }

        public int CreateOrUpdate(IdeaDTO entityDto)
        {
            return entityDto.Id > 0 ? Update(entityDto) : Create(entityDto);
        }

        public List<IdeaDTO> GetAll()
        {
            return IdeasRepository.Build().GetAll();
        }

        public int Delete(IdeaDTO entityDto)
        {
            return IdeasRepository.Build().Delete(IdeasMapper.ToModel(entityDto));
        }

    }
}
