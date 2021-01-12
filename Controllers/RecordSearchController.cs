using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcJazz.Data;
using MvcJazz.Models;

namespace MvcJazz.Controllers
{
    public class RecordSearchController : Controller
    {
        private readonly MvcJazzContext _context;

        public RecordSearchController(MvcJazzContext context)
        {
            _context = context;
        }

        // GET: Album
        public async Task<IActionResult> Index(string recordingYear, string searchString)
        {
            // Use LINQ to get list of years.
            IQueryable<int> yearQuery = from m in _context.Album
                select m.RecordingDate.Year;

            var albums = from m in _context.Album
                select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                albums = albums.Where(s => s.Title.ToLower().Contains(searchString.ToLower()) 
                                           || s.Artist.ToLower().Contains(searchString.ToLower())
                                           || s.Personnel.ToLower().Contains(searchString.ToLower()));
            }

            if (!string.IsNullOrEmpty(recordingYear))
            {
                albums = albums.Where(x => x.RecordingDate.Year == Int32.Parse(recordingYear));
            }

            var AlbumYearVM = new AlbumYearViewModel
            {
                Years = new SelectList(await yearQuery.Distinct().OrderBy(x => x).ToListAsync()),
                Albums = await albums.ToListAsync()
            };

            return View(AlbumYearVM);
        }

        // GET: RecordSearch/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // GET: RecordSearch/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RecordSearch/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Artist,Title,RecordingDate,Personnel,AlbumImage")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // GET: RecordSearch/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        // POST: RecordSearch/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Artist,Title,RecordingDate,Personnel,AlbumImage")] Album album)
        {
            if (id != album.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.Id))
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
            return View(album);
        }

        // GET: RecordSearch/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: RecordSearch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Album.FindAsync(id);
            _context.Album.Remove(album);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
            return _context.Album.Any(e => e.Id == id);
        }
    }
}
