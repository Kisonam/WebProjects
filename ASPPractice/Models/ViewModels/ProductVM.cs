using ASPPractice.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPPractice.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> ApplicationSelectList { get; set; }
    }
}
