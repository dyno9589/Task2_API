using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {

        Uri BaseAddress = new Uri("http://localhost:65432/api");
        HttpClient client;

        public EmployeeController() {
            client = new HttpClient();
            client.BaseAddress = BaseAddress;
        }
        // GET: Employee
        public ActionResult Index()
        {

            List<Employee> modelList = new List<Employee>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employees").Result;
            if (response.IsSuccessStatusCode) {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<Employee>>(data);
            }
            return View(modelList);
        }

        public ActionResult Edit(int id) {
            Employee model = new Employee();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employees?id="+id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model= JsonConvert.DeserializeObject<Employee>(data);
            }
            return View(model);

        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            string data = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress+"/employees/"+employee.ID,content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();

        }
    }
}