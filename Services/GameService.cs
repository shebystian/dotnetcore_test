using System;
using System.Collections.Generic;
using MyMicroservice.Models;

namespace MyMicroservice.Services
{
    public class GameServices
    {
        public Game GetGame(string gameName)
        {
            Repository.GameDao gameDAO = new Repository.GameDao();
            var result = gameDAO.GetGame(gameName);
            return result;
        }

        public bool InsertGame(Game article)
        {
            try{
                Repository.GameDao gameDAO = new Repository.GameDao();
                bool result = gameDAO.InsertGame(article);
                return result;
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public List<Game> GetGames()
        {
            Repository.GameDao gameDAO = new Repository.GameDao();
            List<Game> result = gameDAO.GetGames();
            return result;
        }
    }
}