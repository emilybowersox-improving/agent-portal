using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Agent_Portal.Controllers
{
    public class AllAgentsController : Controller

    {
        // GET /AllAgents/ 
        public IActionResult Index()
        {
            return View();
        }


        // GET /AllAgents/Welcome
        public IActionResult WelcomeAgent(string name, int code = 1)
        {
            ViewData["AgentName"] = "Welcome Agent " + name;
            ViewData["AgentCode"] = code;

            return View();
        }
    }
}
