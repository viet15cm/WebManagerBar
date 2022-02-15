using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Models.ConvertUrl;
using WebManager.Models.Language;
using WebManager.Models.Language.NavbarCollapse;

namespace WebManager.Pages.Shared.Components.NavbarLeft
{
    public class NavbarLeft : ViewComponent
    {
        private List<ConvertUrl> _OptionConvertUrl { get; }
        //private HttpContext currentContext { get; set; }
        private List<NavbarItemLeft> _options { get; }

        private List<NavbarItemLeftCollapse> _navbarItemLeftCollapses { get; }
        public NavbarLeft(IOptions<List<NavbarItemLeft>> options ,
                            //IHttpContextAccessor httpContextAccessor,
                            IOptions<List<ConvertUrl>> OptionConvertUrl,
                            IOptions<List<NavbarItemLeftCollapse>> navbarItemLeftCollapses
                            )
        {
            _options = options.Value;
            //currentContext = httpContextAccessor.HttpContext;
            _OptionConvertUrl = OptionConvertUrl.Value;
            _navbarItemLeftCollapses = navbarItemLeftCollapses.Value;
        }

        public IViewComponentResult Invoke()
        {
            //string currentPage = System.IO.Path.GetFileName(HttpContext.Request.Path.ToString());
            //Console.WriteLine("currentPage" + currentPage);

            //string page = HttpContext.Request.Query["trang"].ToString();

            //var url = HttpContext.Request.GetEncodedUrl();
            //Console.WriteLine(url);
            var pathCurrent = HttpContext.Request.Path.ToString();
            foreach (var item in _OptionConvertUrl)
            {
                if (pathCurrent.StartsWith(item.CurrentUrl))
                {
                    pathCurrent = item.DefaultUrl;
                    break;
                }
            }

            string[] arrListStr = pathCurrent.Split('/');
            var addarrListStr = new string[arrListStr.Length + 2];

            for (int i = 0; i < arrListStr.Length; i++)
            {
                addarrListStr[i] = arrListStr[i];
            }
            for (int i = 0; i < addarrListStr.Length; i++)
            {
                if (string.IsNullOrEmpty(addarrListStr[i]))
                {
                    addarrListStr[i] = "";
                }
                
            }

            var data = new Input()
            {

                CurentUrlAreas = addarrListStr[1],

                CurentUrlPage = addarrListStr[2],
                CurentUrlPageChild = addarrListStr[3],
                Items = _options,
                Items_1 = _navbarItemLeftCollapses

            };

            return View(data);
        }

        public class Input
        {
            public string CurentUrlAreas { get; set; }
            public string CurentUrlPage { get; set; }
            public string CurentUrlPageChild { get; set; }
            public List<NavbarItemLeft> Items { get; set; }

            public List<NavbarItemLeftCollapse> Items_1 { get; set; }

        }

        public string GetBaseUrl()
        {
            //var request = currentContext.Request;

            //var host = request.Host.ToUriComponent();

            //var pathBase = request.PathBase.ToUriComponent();

            //return $"{request.Scheme}://{host}{pathBase}";

            return null;
        }
    }
}
