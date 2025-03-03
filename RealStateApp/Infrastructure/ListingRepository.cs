using RealStateApp.Model;
using System.Reflection;

namespace RealStateApp.Infrastructure
{
    public interface IListingRepository
    {
        List<Listing> GetAll();
        Listing? GetById(int id);
        Listing Create(Listing listing);
        bool Update(int id, Listing updatedListing);
        public bool Delete(int id);

    }

    public class ListingRepository : IListingRepository
    {
        private static readonly List<Listing> _listings = new();
        private static int _nextId = 1;

        public List<Listing> GetAll()
        {
            return _listings;
        }
        public Listing? GetById(int id)
        {
            try
            {
                var FFList = _listings.FirstOrDefault(l => l.Id == id);

                return FFList;
            }
            catch
            {
                return new();
            }
        } 
        public Listing Create(Listing listing)
        {
            try
            {

                listing.Id = _nextId++;
                _listings.Add(listing);
                return listing;
            }
            catch
            {
                return new();
            }
        }
        public bool Update(int id, Listing updatedListing)
        {
            try
            {

                var existing = _listings.FirstOrDefault(l => l.Id == id);
                if (existing == null) return false;
                existing.Title = updatedListing.Title;
                existing.Description = updatedListing.Description;
                existing.Price = updatedListing.Price;
                existing.Location = updatedListing.Location;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {

                var existing = _listings.FirstOrDefault(l => l.Id == id);
                if (existing == null) return false;
                _listings.Remove(existing);
                return true;
            }
            catch
            {
                return false;
            }
        } 
    }
}
