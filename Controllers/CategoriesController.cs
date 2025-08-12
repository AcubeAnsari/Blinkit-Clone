using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Temp.Data;
using Temp.Models;

namespace Temp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cat = await _context.Categories.OrderBy(x => x.ShortOrder).ToListAsync();
            return View(cat);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> Create(Category category, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                if (photo!= null)
                {
                    // Get the file name and path
                    var fileName = Path.GetFileName(photo.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    // Create the images folder if it doesn't exist
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                    // Save the file
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }

                    // Save the filename to the database (or path if needed)
                    category.Image = "/images/" + fileName;
                }
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var cat = await _context.Categories.FindAsync(id);
            return View(cat);
        }


        [HttpPost]

        public async Task<IActionResult> Edit(int id, Category category, IFormFile photo)
        {
            var cat = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    // Get the file name and path
                    var fileName = Path.GetFileName(photo.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    // Create the images folder if it doesn't exist
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                    // Save the file
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await photo.CopyToAsync(stream);
                    }

                    // Save the filename to the database (or path if needed)
                    category.Image = "/images/" + fileName;
                }

                cat.Name = category.Name;
                cat.Description = category.Description;
                cat.Image = category.Image;
                cat.ShortOrder = category.ShortOrder;
                _context.Categories.Update(cat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();

            }

            var cat=await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (cat==null)
            {
                return NotFound();

            }

            return View(cat);

        }

        [HttpPost,ActionName ("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            _context.Remove(cat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        

    }
}


   


