using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JustLogin
{
    public class ServiceWrapper : IServiceWrapper
    {
        public async Task<Employee> GetData(int id)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("http://192.168.0.130:5555/api/Employees/2");
                var employee = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Employee>(employee);
            }
        }

        public async Task<List<Employee>> GetData()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("http://192.168.0.130:5555/api/Employees");
                var employee = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Employee>>(employee);
            }
        }

    }
}
