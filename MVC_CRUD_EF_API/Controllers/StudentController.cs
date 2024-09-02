using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_EF_API.Models;
using Newtonsoft.Json;

namespace MVC_CRUD_EF_API.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7070/api/StudentAPI/";
        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert
            }
        }
    }
}
