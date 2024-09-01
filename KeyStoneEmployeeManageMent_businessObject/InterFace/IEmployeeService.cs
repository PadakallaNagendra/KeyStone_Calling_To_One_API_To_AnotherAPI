using KeyStoneEmployeeManageMent_businessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployeeManageMent_businessObject.InterFace
{
    public interface IEmployeeService
    {
        Task<string> InvokeCMSEmployeesList();
        Task<string> InvokeCMSEmployeesById(int id);
        Task<string> InsertCMSEmployeesData(Employee employee);
        Task<string> UpdateCMSEmployeesData(Employee employee, int id);
        Task<string> DeleteCMSEmployeesData(int id);
    }
}
