using MinhasIdeias.DTOS;
using MinhasIdeias.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasIdeias.Mapper
{
    public class IdeasMapper
    {
        public Idea ToModel(IdeaDTO entityDTO)
        {
            return new Idea()
            {
                Id = entityDTO.Id,
                Description = entityDTO.Description,
                Comment = entityDTO.Comment
            };
        }

        public IdeaDTO ToDto(Idea entityModel)
        {
            return new IdeaDTO()
            {
                Id = entityModel.Id,
                Description = entityModel.Description,
                Comment = entityModel.Comment
            };
        }
    }
}
