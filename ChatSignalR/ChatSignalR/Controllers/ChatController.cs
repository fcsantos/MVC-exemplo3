using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatSignalR.Controllers
{
    [AllowAnonymous]
    public class ChatController : Controller
    {
        // GET: Chat/Conversacao
        public ActionResult Conversacao()
        {
            return View();
        }
    }
}