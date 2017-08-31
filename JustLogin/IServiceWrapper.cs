using System.Collections.Generic;
using System.Threading.Tasks;


namespace JustLogin
{
    public interface IServiceWrapper
    {
        //Get a specific Employee
        Task<Employee> GetData(int id);

        //Get all Employee
        Task<List<Employee>> GetData();
    }

    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public string EmpAddress { get; set; }
        public int EmpPhone { get; set; }
        public string EmpEmail { get; set; }
    }
}
