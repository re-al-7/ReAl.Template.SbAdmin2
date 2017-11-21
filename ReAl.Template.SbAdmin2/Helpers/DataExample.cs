// // <copyright file="DataExample.cs" company="INTEGRATE - Soluciones Informaticas">
// // Copyright (c) 2016 Todos los derechos reservados
// // </copyright>
// // <author>re-al </author>
// // <date>2017-11-21 9:20</date>

using System.Collections.Generic;
using ReAl.Template.SbAdmin2.Dal.Entidades;

namespace ReAl.Template.SbAdmin2.Helpers
{
    public static class DataExample
    {
        public static List<EntSegAplicaciones> AppListado = new List<EntSegAplicaciones>();

        public static void CargarListadoApp()
        {
            for (int i = 0; i < 500; i++)
            {
                var obj = new EntSegAplicaciones();
                obj.aplicacionsap =  i.ToString();
                obj.descripcionsap = "Descripcion " + i;
                AppListado.Add(obj);
            }
        }
    }
}