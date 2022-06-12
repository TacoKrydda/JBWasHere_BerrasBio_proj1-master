
using Microsoft.EntityFrameworkCore;
using FinalBio.Models;
using BerrasBio_proj1.Data;
using BerrasBio_proj1.DbModel;

namespace FinalBio.Models
{
    public class TestData
    {
        public static void Initialize(BerrasBio_proj1Context _context)
        {
            if (_context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            _context.Movie.AddRange
            (
                new Movie
                {
                    MovieTitle = "Face Off"
                },
                new Movie
                {
                    MovieTitle = "Con-Air"
                },
                new Movie
                {
                    MovieTitle = "National Treasure"
                }
            );

            if (_context.Salon.Any())
            {
                return;   // DB has been seeded
            }
            _context.Salon.AddRange(
                new Salon
                {
                    SalonSize = 50
                },
                new Salon
                {
                    SalonSize = 299
                }
                );

            if (_context.Showing.Any())
            {
                return;   // DB has been seeded
            }
            _context.Showing.AddRange(
                new Showing
                {
                    MovieId = 1,
                    SalonId = 1,
                    RemainingSeats = 50,
                    StartHour = DateTime.Today.AddHours(16)
                    
                },
                new Showing
                {
                    MovieId = 3,
                    SalonId = 2,
                    RemainingSeats = 157,
                    StartHour = DateTime.Today.AddHours(16)
                },
                new Showing
                {
                    MovieId = 2,
                    SalonId = 2,
                    RemainingSeats = 5,
                    StartHour = DateTime.Today.AddHours(18)
                    
                },
                new Showing
                {
                    MovieId = 1,
                    SalonId = 1,
                    RemainingSeats = 36,
                    StartHour = DateTime.Today.AddHours(21)

                }
                );
            _context.SaveChanges();
        }
    }
}
