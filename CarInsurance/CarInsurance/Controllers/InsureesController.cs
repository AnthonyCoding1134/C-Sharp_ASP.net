using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance;
using CarInsurance.Data;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public InsureesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        //// GET: Insurees/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var insurees = await _context.Insurees
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (insurees == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(insurees);
        //}

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,PhoneNumber,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,Coverage,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                insurees.Id = Guid.NewGuid();

                // Calculate the quote based on the provided information

                var quote = CalculateQuote(insurees);
                insurees.Quote = quote;
                _context.Add(insurees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

           
            


            return View(insurees);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurees = await _context.Insurees.FindAsync(id);
            if (insurees == null)
            {
                return NotFound();
            }
            return View(insurees);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,Coverage,Quote")] Insurees insurees)
        {
            if (id != insurees.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureesExists(insurees.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insurees);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurees = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insurees == null)
            {
                return NotFound();
            }

            return View(insurees);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insurees = await _context.Insurees.FindAsync(id);
            if (insurees != null)
            {
                _context.Insurees.Remove(insurees);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureesExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        // Admin page to view all quotes
        public async Task<IActionResult> Admin()
        {
            var quotes = await _context.Insurees.ToListAsync();
            return View(quotes);
        }




        public decimal CalculateQuote(Insurees insuree)
        {
            decimal baseQuote = 50;
            // Age factor
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
            {
                baseQuote += 100;
            }
            else if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
            {
                baseQuote += 50;
            }
            else
            {
                baseQuote += 25;
            }


            // Car year factor
            if (insuree.CarYear < DateTime.Now.Year - 25)
            {
                baseQuote += 25;
            }
            else if (insuree.CarYear > DateTime.Now.Year - 10)
            {
                baseQuote += 25;
            }

            // Car make factor
            if (insuree.CarMake.ToLower() == "porsche")
            {
                baseQuote += 25;

            }

            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 Carrera")
            {
                baseQuote += 25;
            }

            // Speeding tickets factor
            baseQuote += insuree.SpeedingTickets * 10;

            if (insuree.DUI)
            {
                // baseQuote += baseQuote * 0.25m; // 25% increase for DUI
                baseQuote *= 1.25m;   // 25% increase for DUI  
            }

            if (insuree.Coverage == CoverageType.Full)
            {

                baseQuote *= 1.5m; // Adds 50% to the base quote for full coverage
            }

            return baseQuote;
        }



    }

}