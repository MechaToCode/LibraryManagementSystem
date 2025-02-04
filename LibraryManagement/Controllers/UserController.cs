
using LibraryManagement.DataEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(User model, IFormFile imageFile)
        {
            var allowedExtensions = new[]{".jpg", ".jpeg", ".png"};
            var extensions = Path.GetExtension(imageFile.FileName);
            var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extensions}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);

            if (imageFile != null)
            {
                if (allowedExtensions.Contains(extensions))
                {
                    ModelState.AddModelError("", "Please enter a valid format!");
                }
            }
            if (ModelState.IsValid)
            {
                if (imageFile != null)
                {

                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }
                }
model.Image = randomFileName;
_context.Users.Add(model);
await _context.SaveChangesAsync();
return RedirectToAction("Index","Home");

            }
            return View(model);
        }
    }
}
