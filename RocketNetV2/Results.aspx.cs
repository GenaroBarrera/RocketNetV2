using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RocketNetV2.Models;
using System.Web.ModelBinding;
using System.Web.Routing;

namespace RocketNetV2
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts( 
            [QueryString("id")] int? categoryId, [RouteData] string categoryName)
        {
         
            var _db = new RocketNetV2.Models.ProductContext();

            var Types = new List<string>() {"Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", 
                "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water"};

            
            var query = from m  in _db.Products
                        select m;


            if(!String.IsNullOrEmpty(Request.QueryString["srch"]))
            {
                if (categoryId.HasValue && categoryId > 0)
                {
                    query = query.Where(p => p.CategoryID == categoryId);
                }

                if (!String.IsNullOrEmpty(categoryName))
                {
                    query = query.Where(p =>
                                        String.Compare(p.Category.CategoryName,
                                        categoryName) == 0);
                }

           

                return query;
            }

            return null;
        }
    }
}