using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArch.APPLICATION.Dtos.Categories;
using OnionArch.APPLICATION.Managers;

namespace OnionArch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            List<CategoryDto> categories = await _categoryManager.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            CategoryDto category = await _categoryManager.GetByIdAsync(id);
            return Ok(category);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDto category)
        {
            await _categoryManager.CreateAsync(category);
            return Ok("Kategori eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDto category)
        {
            await _categoryManager.UpdateAsync(category);
            return Ok("Kategori Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            CategoryDto category = await _categoryManager.GetByIdAsync(id);
            string mesaj = await _categoryManager.RemoveAsync(category);
            return Ok(mesaj);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>PacifyCategory(int id)
        {
            CategoryDto category = await _categoryManager.GetByIdAsync(id);
            await _categoryManager.MakePassiveAsync(category);
            return Ok("Veri Pasife Çekilmiştir");

        }
    }
}
