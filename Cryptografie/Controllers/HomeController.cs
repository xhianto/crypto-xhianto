using Cryptografie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Sodium;
using System.Net;

namespace Cryptografie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public CryptedMessage cMessage { get; set; }
        public DecodedMessage dMessage { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Challange()
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest();
            cMessage = new CryptedMessage();
            dMessage = new DecodedMessage();
            client.BaseUrl = new Uri("https://79vo67ipp9.execute-api.eu-west-1.amazonaws.com/Prod/decrypt/challenges");
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                cMessage = JsonConvert.DeserializeObject<CryptedMessage>(response.Content);
            }
            byte[] challange64 = Convert.FromBase64String(cMessage.challenge);
            byte[] nonce64 = Convert.FromBase64String(cMessage.nonce);
            byte[] key64 = Convert.FromBase64String(cMessage.key);
            byte[] test = SecretBox.Open(challange64, nonce64, key64);
            dMessage.plaintext = Convert.ToBase64String(test);
            ViewBag.Plaintext = dMessage.plaintext;
            ViewBag.Link = "https://79vo67ipp9.execute-api.eu-west-1.amazonaws.com/Prod/decrypt/challenges/" + cMessage.kid;
            return View(cMessage);
        }
        [HttpPost]
        public IActionResult Solve(string kid, string key, string challange, string nonce, string plaintext)
        {
            CryptedMessage cMessage = new CryptedMessage { kid = kid, key = key, challenge = challange, nonce = nonce };
            DecodedMessage dMessage = new DecodedMessage { plaintext = plaintext };
            {
                RestClient client = new RestClient();
                RestRequest request = new RestRequest();
                client.BaseUrl = new Uri("https://79vo67ipp9.execute-api.eu-west-1.amazonaws.com/Prod/decrypt/challenges/" + cMessage.kid);
                var json = JsonConvert.SerializeObject(dMessage);
                request = new RestRequest();
                request.AddJsonBody(json);
                var response = client.Delete(request);
                ViewBag.Plaintext = dMessage.plaintext;
                ViewBag.StatusCode = response.StatusCode;
                ViewBag.Link = "https://79vo67ipp9.execute-api.eu-west-1.amazonaws.com/Prod/decrypt/challenges/" + cMessage.kid;
            }
            return View(cMessage);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
