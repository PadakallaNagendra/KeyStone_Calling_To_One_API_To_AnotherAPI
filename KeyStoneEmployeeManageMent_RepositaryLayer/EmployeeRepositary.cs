using KeyStoneEmployeeManageMent_businessObject.Entities;
using KeyStoneEmployeeManageMent_businessObject.InterFace;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployeeManageMent_RepositaryLayer
{
    public class EmployeeRepositary : IEmployeeRepositary
    {
        public async Task<string> DeleteCMSEmployeesData(int id)
        {
            string url = string.Format("https://dummy.restapiexample.com/api/v1/delete/{0}", id);
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "application/json");
            HttpResponseMessage response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode(); 
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }

        public async Task<string> InsertCMSEmployeesData(Employee employee)
        {
            string url = "https://dummy.restapiexample.com/api/v1/create";
            var serializedata = JsonConvert.SerializeObject(employee);
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("accept", "application/json");
            StringContent content = new StringContent(serializedata, null, "application/json");
            request.Content = content;
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }

        public async Task<string> InvokeCMSEmployeesById(int id)
        {
            string url = string.Format("https://dummy.restapiexample.com/api/v1/employees/{0}", id);

            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "application/json");
            HttpResponseMessage response = await client.SendAsync(request);
            // response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }

        public async Task<string> InvokeCMSEmployeesList()
        {
            string url = "https://dummy.restapiexample.com/api/v1/employees";
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "application/json");
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }

        public async Task<string> UpdateCMSEmployeesData(Employee employee, int id)
        {
            string url = string.Format("https://dummy.restapiexample.com/api/v1/update/{0}", id);
            var serializedata = JsonConvert.SerializeObject(employee);
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Put, url);
            request.Headers.Add("accept", "application/json");
            StringContent content = new StringContent(serializedata, null, "application/json");
            request.Content = content;
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }
    }
}
