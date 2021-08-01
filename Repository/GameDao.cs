using System;
using System.Data.Common;
using System.Linq;
using MyMicroservice.Models;

namespace MyMicroservice.Repository
{
    public class GameDao
    {
        public Game GetGame(string nameGame)
        {
            try
            {
                var game = new Game();

                using (var context = new CatalogContext()) 
                {
                    game = context.Games.Where(s => s.Nombre == nameGame).FirstOrDefault();
                }
                return game;
            }
            catch(DbException ex){
                throw new Exception(ex.Message);
            }
        }

        public bool InsertGame(Game gameToInsert) 
        {
            try{
                using (var context = new CatalogContext()) {

                    var gti = new Game()
                    {
                        Nombre=gameToInsert.Nombre, Categoria=gameToInsert.Categoria
                    };

                    context.Games.Add(gti);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(DbException ex){
                throw new Exception(ex.Message);
            }
        }

    }
}