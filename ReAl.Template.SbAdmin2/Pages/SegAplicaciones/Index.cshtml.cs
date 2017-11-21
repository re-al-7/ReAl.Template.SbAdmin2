using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.SbAdmin2.Dal.Entidades;
using ReAl.Template.SbAdmin2.Helpers;
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

            Listado = DataExample.AppListado;
        }
        
        [HttpPost]
        public IActionResult OnPost(string id)
        {
            try
            {
                //Eliminamos el registro
                var item = DataExample.AppListado.SingleOrDefault(x => x.aplicacionsap == id);
                if (item != null)
                    DataExample.AppListado.Remove(item);
            
                //Refrescamos
                TempData["Message"] = "Se ha eliminado el registro";
                return RedirectToPage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}