using System.Collections.Generic;
using ReAl.Template.SbAdmin2.Dal.Entidades;
using ReAl.Template.SbAdmin2.Models;

namespace ReAl.Template.SbAdmin2.Pages.Template
{
    public class FormsModel: BasePageModel
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
    }
}