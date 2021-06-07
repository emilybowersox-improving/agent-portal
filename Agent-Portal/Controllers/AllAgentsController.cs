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

/*        // GET /AllAgents/
        public string Index()
        {
            return "here's all the agents";
        }

        // GET /AllAgents/Welcome
        public string Welcome(string agentName, int agentNumber = 1)
        {
            return HtmlEncoder.Default.Encode($"Hi {agentName} your agent number is {agentNumber}"); 
        }*/
    }
}
