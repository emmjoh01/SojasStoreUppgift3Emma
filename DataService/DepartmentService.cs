using DAL;
using DataService.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class DepartmentService
    {
        public List<DepartmentDTO> GetDepartmentsWithResponsibleEmails()
        {
            List<DepartmentDTO> departmentDTOs = new List<DepartmentDTO>();
            using (var data = new StoreContext())
            {
                List<string> listEmails = new List<string>();
                var departments = data.Departments.ToList();
                var emails = data.Emails.ToList();
                foreach (var department in departments)
                {
                    listEmails.Clear();

                    for (int i = 0; i < emails.Count(); i++)
                    {
                        if (emails[i].EmployeeId == department.EmployeeId)
                        {
                            listEmails.Add(emails[i].EmployeeEmail);
                        }
                    }
                    DepartmentDTO departmentDTO = new DepartmentDTO();
                    departmentDTO.DepartmentName = department.Name;
                    departmentDTO.ResponsibleEmployeesEmail.AddRange(listEmails);

                    departmentDTOs.Add(departmentDTO);

                }
            }
            return departmentDTOs;
        }
    }
}
