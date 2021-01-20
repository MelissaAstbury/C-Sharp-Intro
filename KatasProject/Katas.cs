using System;
using System.Collections.Generic;
using Katas.Models;

namespace Katas
{
    public class KatasClass
    {
        public bool? AreCatsDominant(List<Animal> animals)
        {
            // Do a count
            int i = 0;

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                var answer = animal.GetType();
                if (answer == typeof(Cat)) i++;
                if (answer == typeof(Dog)) i--;
            }
            if (i > 0) return true;
            if (i < 0) return false;
            return null;
        }

        //public string ConvertToSassCase(string input)
        //{
        //    return "";
        //}

        //public List<Customer> CheckHeight(List<Customer> customers)
        //{
        //    return new List<Customer>();
        //}

        //public Dictionary<string, int> TwitterFeedAnalysis(IEnumerable<string> twitterFeed)
        //{
        //    return new Dictionary<string, int>();
        //}

        //public List<User> UpdateUserNotes(IEnumerable<User> users, IEnumerable<Note> updatedNotes)
        //{
        //    return new List<User>();
        //}

        //public Dictionary<string, List<string>> CategoriseCustomerIds(List<Customer> customers, List<Guid> currentGuids)
        //{
        //    return new Dictionary<string, List<string>>();
        //}

        //public Artwork[] TriageArtworks(List<Artwork> submissions, DateTime cutoffDate)
        //{
        //    return new Artwork[0];
        //}
    }
}

