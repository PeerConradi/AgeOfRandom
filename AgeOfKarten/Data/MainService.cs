using AgeOfKarten.Models;
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
            return _context.Cards.ToList();
        }

        public List<Nation> GetNations()
        {
            return _context.Nations.ToList();
        }

        public NationCard AssignCardToNation(Card card, Nation nation, int propability)
        {
            var assignment = new NationCard();
            assignment.Card = card;
            assignment.Nation = nation;
            assignment.Propability = propability;
            _context.NationCards.Add(assignment);
            _context.SaveChanges();
            return assignment;
        }

        public MainService(AgeOfRandomContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
    }
}
