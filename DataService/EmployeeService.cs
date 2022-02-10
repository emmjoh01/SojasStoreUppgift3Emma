using DAL;
using DataService.DTOS;


namespace DataService
{
    public class EmployeeService
    {
        public string Name { get; set; }
        public bool IsResponsibleForDepartment { get; set; }

        //För VG - Skriv ut antal anställda i butiken samt en lista som för varje anställd som innehåller
        //information om dess namn och om den är ansvarig för någon avdelning

        public AllEmployeesDTO GetEmployeeISResponsibleList()
        {
            List<EmployeeInfoDTO> employeeInfoDTOs = new List<EmployeeInfoDTO>();

            using(var data = new StoreContext())
            {
                var employees = data.Employees.ToList();
                var departments = data.Departments.ToList();

                foreach (var employee in employees)
                {
                    bool isResponsible = false;
                    foreach (var department in departments)
                    {
                        if(department.EmployeeId == employee.EmployeeId)
                            isResponsible = true;
                    }
                    employeeInfoDTOs.Add(new EmployeeInfoDTO { Name = employee.FirstName + " " + employee.LastName, ResponsibleForDepartment = isResponsible });
                }
            }
            AllEmployeesDTO allEmployeesDTO = new AllEmployeesDTO() {EmployeeCount = employeeInfoDTOs.Count, EmployeeList = employeeInfoDTOs };
            
            return allEmployeesDTO;
        }


    }
}