using System;
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
    }
}