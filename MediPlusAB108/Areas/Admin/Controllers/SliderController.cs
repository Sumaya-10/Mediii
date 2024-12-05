using MediPlusAB108.Data;
using MediPlusAB108.Models;
using MediPlusAB108.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediPlusAB108.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(MediPlusAB108Context _context) : Controller
    {
        public async Task<IActionResult> Index()
        { 
            return View(await _context.Sliders.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateVM vm)
        {
            Slider slider = new Slider
            {
                Title = vm.Title,
                Subtitle = vm.Subtitle,
                Link = vm.Link,
                ImageUrl = vm.ImageUrl
            };

           await  _context.Sliders.AddAsync(slider);
           await _context.SaveChangesAsync();
           return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
          var data = await _context.Sliders.FindAsync(id);
         if(data is null)
            {
                return NotFound();
            }
         _context.Sliders.Remove(data);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var data = await _context.Sliders.FindAsync(id);
            if( data is null) return NotFound();
            return View(data);

        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, SliderCreateVM vm)
        {
            var entity = await _context.Sliders.FindAsync(id);
            if (entity is null) return NotFound();
            entity.Title = vm.Title;
            entity.Subtitle = vm.Subtitle;
            entity.Link = vm.Link;
            entity.ImageUrl = vm.ImageUrl;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
