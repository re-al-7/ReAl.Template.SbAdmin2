using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.SbAdmin2.Dal.Entidades;
using ReAl.Template.SbAdmin2.Models;

namespace ReAl.Template.SbAdmin2.Pages.SegAplicaciones
{
    public class IndexModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }        
        public string Usuario { get; private set; }
        
        public List<EntSegAplicaciones> Listado { get; private set; }

        public void OnGet()
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
            
            Listado = new List<EntSegAplicaciones>();

            for (int i = 0; i < 500; i++)
            {
                var obj = new EntSegAplicaciones();
                obj.aplicacionsap = "APP" + i;
                obj.descripcionsap = "Descripcion " + i;
                Listado.Add(obj);
            }
        }
        
        [HttpPost]
        public IActionResult OnPostDeleteAsync(string id)
        {
            //Eliminamos el registro
            
            return RedirectToPage();
        }
    }
}