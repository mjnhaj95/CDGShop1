using AutoMapper;
using CDGShop.Data.Migrations;
using CDGShop.Model.Models;
using CDGShop.Service;
using CDGShop.Web.Models;
using System.Web.Mvc;

namespace CDGShop.Web.Controllers
{
    public class ContactController : Controller
    {
        private IContactDetailService _contactDetailService;

        public ContactController(IContactDetailService contactDetailService)
        {
            this._contactDetailService = contactDetailService;
        }

        // GET: Contact
        public ActionResult Index()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
            return View(contactViewModel);
        }
    }
}