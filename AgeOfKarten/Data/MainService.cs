using AgeOfKarten.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfKarten.Data
{
    public class MainService
    {
        private readonly AgeOfRandomContext _context;

        //public List<Card> GetCardsForNationAndAge(int nationId, int age)
        //{

        //}

        public Nation CreateNation(string name)
        {
            var newNation = new Nation();
            newNation.Name = name;
            _context.Nations.Add(newNation);
            _context.SaveChanges();
            return newNation;
        }

        public Card CreateCard(string name, string imageName)
        {
            var newCard = new Card();
            newCard.Name = name;
            newCard.ImageName = imageName;
            _context.Cards.Add(newCard);
            _context.SaveChanges();
            return newCard;
        }

        public List<Card> GetCards()
        {
            return _context.Cards.AsNoTracking().ToList();
        }

        public List<Nation> GetNations()
        {
            return _context.Nations.AsNoTracking().ToList();
        }

        public NationCard AssignCardToNation(int cardId, int nationId, int age, int propability)
        {
            var assignment = new NationCard();
            assignment.Card = _context.Cards.FirstOrDefault(n => n.CardId == cardId);
            assignment.Nation = _context.Nations.FirstOrDefault(n => n.NationId == nationId);
            assignment.Age = age;
            assignment.Propability = propability;
            _context.NationCards.Add(assignment);
            _context.SaveChanges();
            return assignment;
        }

        public List<Card> GetCardsForNationAndAge(int nationId, int age)
        {
            return _context.NationCards
                .Where(n => n.Nation.NationId == nationId &&
                n.Age == age).Select(n => n.Card).ToList();
        }

        public List<string> GetImageNames()
        {
            string path = AppContext.BaseDirectory + "wwwroot/img/icons";
            
            if (!System.IO.Directory.Exists(path))
                return new List<string>() { $"pathNotFound: {path}" };

            var dir = new System.IO.DirectoryInfo(path);
            var files = dir.GetFiles("*.png");
            return files.Select(n => n.Name).ToList();
        }

        public MainService(AgeOfRandomContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
    }
}
