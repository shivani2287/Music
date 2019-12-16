using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodCalculator.Data;
using PeriodCalculator.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeriodCalculator.Controllers
{
    public class ArtistsController : Controller
    {
        private MusicContext _musicContext { get; set; }

        public ArtistsController(MusicContext musicContext)
        {
            _musicContext = musicContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var artists = this._musicContext.Artists.ToList();
            //foreach(var item in artists)
            //{
            //    item.
            //}
            return View(artists);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _musicContext.Artists
                .FirstOrDefaultAsync(m => m.ArtistId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtistId,ArtistName,ActiveFrom")] Artists artists)
        {
            if (ModelState.IsValid)
            {
                _musicContext.Add(artists);
                await _musicContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artists);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artists = await _musicContext.Artists.FindAsync(id);
            if (artists == null)
            {
                return NotFound();
            }
            return View(artists);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtistId,ArtistName,ActiveFrom")] Artists artists)
        {
            if (id != artists.ArtistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _musicContext.Update(artists);
                    await _musicContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistsExists(artists.ArtistId))
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
            return View(artists);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artists = await _musicContext.Artists
                .FirstOrDefaultAsync(m => m.ArtistId == id);
            if (artists == null)
            {
                return NotFound();
            }

            return View(artists);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artists = await _musicContext.Artists.FindAsync(id);
            _musicContext.Artists.Remove(artists);
            await _musicContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistsExists(long id)
        {
            return _musicContext.Artists.Any(e => e.ArtistId == id);
        }
    }
}
