using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Models.ConvertUrl;
using WebManager.Models.Language;

namespace WebManager.Pages.Shared.Components.Navbar
{
    public class Navbar : ViewComponent
    {
    
        private List<NavbarItemTop> _options { get; }
        private List<NavbarItemLogin> _navbarItemLogins { get; }
        private List<ConvertUrl> _OptionConvertUrl { get; }

       
        public Navbar(IOptions<List<NavbarItemTop>> options ,
                      IOptions<List<ConvertUrl>> OptionConvertUrl,
                      IOptions<List<NavbarItemLogin>> navbarItemLogins
                        )
        {
            _options = options.Value;
            _OptionConvertUrl = OptionConvertUrl.Value;
            _navbarItemLogins = navbarItemLogins.Value;
        }

        public IViewComponentResult Invoke(string prString)
        {
           
            var pathCurrent = HttpContext.Request.Path.ToString();
            foreach (var item in _OptionConvertUrl)
            {
                if (pathCurrent.StartsWith(item.CurrentUrl))
                {
                    pathCurrent = item.DefaultUrl;
                    break;
                }
            }
            //lấy giá trị Query
            //string page = HttpContext.Request.Query["trang"].ToString();

            // Lấy url địa chỉ Hostings
            //var c = HttpContext.Request.Path.ToUriComponent();
            //Console.WriteLine("Hosti
            //ngs " + c);

            //var path = HttpContext.Request.Path.ToString();

            //Console.WriteLine("path = " + path);

            string[] arrListStr = pathCurrent.Split('/');
            var addarrListStr = new string[arrListStr.Length + 2];
           
            for (int i = 0; i < arrListStr.Length; i++)
            {
                addarrListStr[i] = arrListStr[i];
            }

            var data = new Input()
            {

                CurentUrlAreas = addarrListStr[1],
                CurentUrlPage = addarrListStr[2],
                Items = _options,
                ItemsLogin = _navbarItemLogins
            };

            if (String.Compare("Navbar", prString, true) == 0)
            {
                return View(data);
            }

            if(String.Compare("NavbarCollapse", prString, true) == 0)
            {
                return View("NavbarCollapse", data);
            }


            return View("NavbarLogin", data);
        }

        public class Input
        {
            public string CurentUrlPage { get; set; }
            public string CurentUrlAreas { get; set; }
            public List<NavbarItemTop> Items { get; set; }
            public List<NavbarItemLogin> ItemsLogin { get; set; }
        }
    }
}
