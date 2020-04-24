using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhosOnTheDecks.API.Models;

namespace WhosOnTheDecks.API.Data
{
    //Event Context will provide all Database methods to create, update, retrieve and cancel events/bookings
    public class EventContext : IEventCrudRepository
    {
        //Property created to access databse
        private readonly DataContext _context;

        //Contructor accepts datacontext as argument and insitialise is to the 
        //above property
        public EventContext(DataContext context)
        {
            _context = context;
        }

        //Add will take in any type of entity that matches a class
        //The entity will be added from the databse 
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        //GetBooking will take in an integer of id and returnt he matching booking
        //from the database
        public async Task<Booking> GetBooking(int id)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.BookingId == id);

            return booking;
        }

        public async Task<IEnumerable<Booking>> GetBookings()
        {
            var bookings = await _context.Bookings.ToListAsync();

            return bookings;
        }

        public async Task<Event> GetEvent(int id)
        {
            var event = await _context.Events.FirstOrDefaultAsync(e => e.EventId == id);

            return event;
        }

        public async Task<IEnumerable<Event>> GetEvents()
        {
            var events = await _context.Events.ToListAsync();

            return events;
        }

        //SaveAll will save any changes to context resulting in the number
        //being greater than 0 and therefore true
        //if there are no changes the number will be equal to 0
        //and will return false
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}