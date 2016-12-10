using AutoMapper;
using CDGShop.Model.Models;
using CDGShop.Service;
using CDGShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDGShop.Web.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        private IPageService _pageService;

        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }

        // GET: Page
        public ActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            var model = Mapper.Map<Page, PageViewModel>(page);
            return View(model);
        }
    }
}