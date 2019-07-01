using MinhasIdeias.DTOS;
using MinhasIdeias.Entities;
using MinhasIdeias.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasIdeias.Data
{
    public class IdeasRepository
    {
        public static IdeasRepository Build()
        {
            return new IdeasRepository();
        }
        public int Create(Idea entityModel)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Idea>();
                return conn.Insert(entityModel); 
            }
        }

        public int Update(Idea entityModel)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Idea>();
                return conn.Update(entityModel);
            }
        }

        public int Delete(Idea entityModel)
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Idea>();
                return conn.Delete(entityModel);
            }
        }

        public List<IdeaDTO> GetAll()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Idea>();
                List<Idea> ideas = conn.Table<Idea>().ToList();
                List<IdeaDTO> ideaDTOs = new List<IdeaDTO>();
                foreach(Idea idea in ideas)
                {
                    ideaDTOs.Add(IdeasMapper.ToDto(idea));
                }
                return ideaDTOs;
            }
        }

    }
}
