// // <copyright file="CMenus.cs" company="INTEGRATE - Soluciones Informaticas">
// // Copyright (c) 2016 Todos los derechos reservados
// // </copyright>
// // <author>re-al </author>
// // <date>2017-11-17 23:18</date>

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ReAl.Template.SbAdmin2.Dal.Entidades;

namespace ReAl.Template.SbAdmin2.Helpers
{
    public static class CMenus
    {
        public static List<EntSegAplicaciones> GetAplicaciones()
        {
            List<EntSegAplicaciones> lista = new List<EntSegAplicaciones>();

            var obj = new EntSegAplicaciones();
            obj.aplicacionsap = "CLA";
            obj.descripcionsap = "CLASIFICADORES";
            lista.Add(obj);

            obj = new EntSegAplicaciones();
            obj.aplicacionsap = "SEG";
            obj.descripcionsap = "SEGURIDAD";
            lista.Add(obj);

            return lista;
        }
        
        public static List<EntSegPaginas> GetPages(HttpContext miContexto)
        {
            List<EntSegPaginas> lstPaginas = new List<EntSegPaginas>();

            EntSegPaginas obj = null;
            if (miContexto.Session.GetString("currentApp") == "CLA")
            {
                obj = new EntSegPaginas();
                obj.descripcionspg = "Aplicaciones";
                obj.nombrespg = "SegAplicaciones";
                obj.nombremenuspg = "index";
                lstPaginas.Add(obj);
            }
            obj = new EntSegPaginas();
            obj.descripcionspg = "Usuarios";
            obj.nombrespg = "segusuario";
            obj.nombremenuspg = "index";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Dashboard";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Dashboard";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Charts - Flot";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Flot";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Charts - MorrisJs";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Morris";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Forms";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Forms";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Tables";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Tables";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Panels & Wells";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Panels";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Buttons";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Buttons";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Notifications";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Notifications";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Typography";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Typography";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Icons";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Icons";
            lstPaginas.Add(obj);
            
            obj = new EntSegPaginas();
            obj.descripcionspg = "Grid";
            obj.nombrespg = "Template";
            obj.nombremenuspg = "Grid";
            lstPaginas.Add(obj);

            return lstPaginas;
        }
    }
}