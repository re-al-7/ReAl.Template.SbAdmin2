using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.SbAdmin2.Dal.Entidades;
using ReAl.Template.SbAdmin2.Models;

namespace ReAl.Template.SbAdmin2.Pages.SegAplicaciones
{
    public class EditModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }
        public string Usuario { get; private set; }

        [BindProperty]
        public EntSegAplicaciones MiAplicacion { get; set; }
        
        [HttpGet]
        public IActionResult OnGetAsync(string id)
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
            
            //Obtenemos el objeto
            MiAplicacion= new EntSegAplicaciones();
            MiAplicacion.aplicacionsap = "SAP";
            MiAplicacion.descripcionsap = "Descripcion";
            
            if (MiAplicacion == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            
            //Guardamos el registro
            
            //Redireccionamos
            return RedirectToPage("./Index");
        }
    }
}