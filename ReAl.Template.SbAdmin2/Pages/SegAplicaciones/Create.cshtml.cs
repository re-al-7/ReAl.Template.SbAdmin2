using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.SbAdmin2.Dal.Entidades;
using ReAl.Template.SbAdmin2.Models;

namespace ReAl.Template.SbAdmin2.Pages.SegAplicaciones
{
    public class CreateModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }
        public string Usuario { get; private set; }

        public void OnGet()
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
        }
        
        [BindProperty]
        public EntSegAplicaciones MiAplicacion { get; set; }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ListApp = this.GetAplicaciones();
                ListPages = this.GetPages();
                Usuario = this.getUserName();
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}