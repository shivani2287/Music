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
    public class GenresController : Controller
    {
        private MusicContext _musicContext { get; set; }

        public GenresController(MusicContext musicContext)
        {
            _musicContext = musicContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var genres = this._musicContext.Genres.ToList();
            //foreach(var item in Genres)
            //{
            //    item.
            //}
            return View(genres);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _musicContext.Genres
                .FirstOrDefaultAsync(m => m.GenreId == id);
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
        public async Task<IActionResult> Create([Bind("GenreId,Genre")] Genres genres)
        {
            if (ModelState.IsValid)
            {
                _musicContext.Add(genres);
                await _musicContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genres);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genres = await _musicContext.Genres.FindAsync(id);
            if (genres == null)
            {
                return NotFound();
            }
            return View(genres);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenreId,Genre")] Genres genres)
        {
            if (id != genres.GenreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _musicContext.Update(genres);
                    await _musicContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenresExists(genres.GenreId))
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
            return View(genres);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genres = await _musicContext.Genres
                .FirstOrDefaultAsync(m => m.GenreId == id);
            if (genres == null)
            {
                return NotFound();
            }

            return View(genres);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genres = await _musicContext.Genres.FindAsync(id);
            _musicContext.Genres.Remove(genres);
            await _musicContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenresExists(long id)
        {
            return _musicContext.Genres.Any(e => e.GenreId == id);
        }
    }
}
