using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheWorld.Entities{

    public interface IWorldRepository{
        IEnumerable<Trip> GetAllTrips();
        void AddTrip(Trip newTrip);
         Task<bool> SaveChangesAsync();
  
    }
}