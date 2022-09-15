using DigitalRetailersInc.DAL;
using DigitalRetailersInc.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace DigitalRetailersInc.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        digitalretailersincEntities context = new digitalretailersincEntities();
        public IEnumerable<laptop> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search)
        {
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@search",search??(Object)DBNull.Value)
            };
            IEnumerable<laptop> data = context.Database.SqlQuery<laptop>("GetBySearch @search", param).ToList();
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
    }
}