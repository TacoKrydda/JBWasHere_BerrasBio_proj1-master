using BerrasBio_proj1.Data;
using BerrasBio_proj1.DbModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio_proj1.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly BerrasBio_proj1Context _context;

        public ConfirmationModel(BerrasBio_proj1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null || _context.Booking == null) // New Shit
            {
                return NotFound();
            }
            
            var _booking1 = await _context.Booking
                         .Include(s => s.Showing)
                         .FirstAsync(m => m.BookingId == id); // New Shit

            if (_booking1 == null) // New Shit
            {
                return NotFound();
            }
            else // New Shit
            {
                Booking = _booking1;
            }

            //if (_context.Booking != null)
            //{
            //    var _booking = await _context.Booking.FirstOrDefaultAsync(m => m.BookingId == id);
            //    if (_booking != null)
            //    {
            //        Booking = _booking;
            //        _booking = await _context.Booking
            //            .Include(s => s.Showing)
            //            .FirstAsync(x => x.ShowingId == _booking.ShowingId);
            //    }

            //}
            //else
            //{
            //    return NotFound("");
            //}

            return Page();
        }
    }
}
