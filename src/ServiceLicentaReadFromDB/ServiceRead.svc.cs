using DB_Licenta.Models;
using DTO_Licenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceLicentaReadFromDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceRead
    {
        #region READ
        #region FillGrid
        //Functia pentru vizualizarea aplicantilor din baza de date
        #region FillApplicantGrid
        public List<ApplicantDTO> FillApplicantGrid()
        {
            List<ApplicantDTO> applicantList = new List<ApplicantDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var a = context.Applicants;
                    foreach (var applicant in a)
                    {
                        ApplicantDTO applicantDTO = new ApplicantDTO();
                        applicantDTO.ApplicantID = Convert.ToInt32(applicant.ApplicantID);
                        applicantDTO.BirthDate = Convert.ToDateTime(applicant.BirthDate);
                        applicantDTO.FirstName = applicant.FirstName;
                        applicantDTO.LastName = applicant.LastName;
                        applicantDTO.Mail = applicant.Mail;
                        applicantDTO.Nationality = applicant.Nationality;
                        applicantDTO.PhoneNumber = applicant.PhoneNumber;
                        applicantDTO.Studies = applicant.Studies;

                        applicantList.Add(applicantDTO);
                    }
                    return applicantList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        //Functia pentru vizualizarea angajatilor din baza de date
        #region FillEmployeeGrid
        public List<EmployeeDTO> FillEmployeeGrid()
        {
            // Creez o noua lista de tipul EmployeeDTO in care urmeaza sa pun toti angajatii firmei selectati din baza de date
            List<EmployeeDTO> employeeList = new List<EmployeeDTO>();

            try
            {
                //Creez un context de tipul bazei de date si prin intermediul lui selectez toti angajatii
                using (var context = new DatabaseLicentaContext())
                {
                    var e = context.Employees;
                    //Fac conversia din Employee in EmployeeDTO pentru a-mi putea popula lista de angajati
                    foreach (var employee in e)
                    {
                        // Se adauga in lista creata mai sus
                        employeeList.Add(ConversionForFillEmployeeGrid(employee));
                    }
                    // Se returneaza lista de angajati
                    return employeeList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region ConversionForFillEmployeeGrid
        private EmployeeDTO ConversionForFillEmployeeGrid(Employee employee)
        {
            // Se creaza o instanta de tipul EmployeeDTO
            EmployeeDTO employeeDTO = new EmployeeDTO();
            // Se creaza o instanta de tipul DepartmentDTO unde se vor pune datele departamentului de care apartine angajatul
            DepartmentDTO departmentDTO = new DepartmentDTO();
            // Se creaza o instanta de tipul JobDTO unde se vor pune datele job-ului pe care il are angajatul
            JobDTO jobDTO = new JobDTO();

            employeeDTO.Department = departmentDTO;
            employeeDTO.Job = jobDTO;
            // Se iau detalile selectate din baza de date si se populeaza proprietatile instantei de tipul DTO
            employeeDTO.EmployeeID = Convert.ToInt32(employee.EmployeeID);
            employeeDTO.FirstName = employee.FirstName;
            employeeDTO.LastName = employee.LastName;
            employeeDTO.PNC = employee.PNC;
            employeeDTO.Address = employee.Address;
            employeeDTO.BirthDate = employee.BirthDate;
            employeeDTO.Gender = employee.Gender;
            employeeDTO.HireDate = employee.HireDate;
            employeeDTO.Mail = employee.Mail;
            employeeDTO.Nationality = employee.Nationality;
            employeeDTO.PhoneNumber = employee.PhoneNumber;
            employeeDTO.Studies = employee.Studies;
            employeeDTO.Salary = employee.Salary;
            employeeDTO.FileNumber = employee.FileNumber;
            // Se ia numele si locatia departamentul unde lucreaza angajatul
            employeeDTO.Department.DepartmentName = employee.Department.DepartmentName;
            employeeDTO.Department.Location = employee.Department.Location;
            // Se ia numele job-ului pe care acesta il are
            employeeDTO.Job.JobTitle = employee.Job.JobTitle;

            // Se returneaza angajatul
            return employeeDTO;
        }
        #endregion

        //Functia pentru vizualizarea clientilor 
        #region FillCustomerGrid
        public List<CustomerDTO> FillCustomerGrid()
        {
            List<CustomerDTO> customerList = new List<CustomerDTO>();

            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var c = context.Customers;
                    foreach (var customer in c)
                    {
                        CustomerDTO customerDTO = new CustomerDTO();
                        customerDTO.CustomerID = Convert.ToInt32(customer.CustomerID);
                        customerDTO.Name = customer.Name;
                        customerDTO.Address = customer.Address;
                        customerDTO.Mail = customer.Mail;
                        customerDTO.PhoneNumber = customer.PhoneNumber;
                        customerDTO.Institution = customer.Institution;

                        customerList.Add(customerDTO);
                    }
                }
                return customerList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        //Functia pentru vizualizarea proiectelor
        #region FillProjectGrid
        public List<ProjectDTO> FillProjectGrid()
        {
            List<ProjectDTO> projectList = new List<ProjectDTO>();


            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se selecteaza din baza de date toate proiectele firmei
                    var p = context.Projects;
                    // Pentru fiecate proiect gasit se face coversia la Data Transfer Object (DTO)
                    foreach (var project in p)
                    {
                        CustomerDTO customerDTO = new CustomerDTO();
                        ProjectDTO projectDTO = new ProjectDTO();
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        projectDTO.Customer = customerDTO;
                        projectDTO.Employee = employeeDTO;

                        // Se iau detaliile despre proiect
                        projectDTO.ProjectID = Convert.ToInt32(project.ProjectID);
                        // Se ia clientul caruia ii apartine proiectul
                        projectDTO.Customer.Name = project.Customer.Name;
                        projectDTO.Description = project.Description;
                        // Se ia numele angajatului care este responsabil de proiect (manager-ul)
                        projectDTO.Employee.FirstName = project.Employee.FirstName;
                        projectDTO.Employee.LastName = project.Employee.LastName;
                        projectDTO.EndDate = Convert.ToDateTime(project.EndDate);
                        projectDTO.Price = project.Price;
                        projectDTO.ProjectName = project.ProjectName;
                        projectDTO.StartDate = Convert.ToDateTime(project.StartDate);
                        projectDTO.Status = Convert.ToDouble(project.Status);

                        // Se adauga in tabela creata mai sus
                        projectList.Add(projectDTO);
                    }
                    // Se returneaza lista de proiecte 
                    return projectList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        //Functia pentru vizualizarea stagiarilor
        #region FillInternGrid
        public List<InternDTO> FillInternGrid()
        {
            // Se creaza O lista de stagiari de tipul Data Transfer Object  
            List<InternDTO> internList = new List<InternDTO>();

            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se selecteaza toti stagiarii din baza de date
                    var i = context.Interns;
                    //Pentru fiecare stagiar se face conversia la tipul DTO
                    foreach (var intern in i)
                    {
                        // Pentru ca fiecare stagiar este un aplicant prima data, se creaza un obiect de tipul AplicantDTO
                        // Si pentru ca de fiecare stagiar este responsabil un anumit angajat, cream un obiect de tipul EmployeeDTO
                        InternDTO internDTO = new InternDTO();
                        ApplicantDTO applicantDTO = new ApplicantDTO();
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        internDTO.Applicant = applicantDTO;
                        internDTO.Employee = employeeDTO;

                        // Se ia datele din tabela Intern
                        internDTO.InternID = Convert.ToInt32(intern.InternID);
                        internDTO.StartDate = Convert.ToDateTime(intern.StartDate);
                        internDTO.EndDate = Convert.ToDateTime(intern.EndDate);
                        internDTO.Observation = intern.Observation;
                        // Se iau datele angajatului care se ocupa de stagiar
                        internDTO.Employee.FirstName = intern.Employee.FirstName;
                        internDTO.Employee.LastName = intern.Employee.LastName;
                        // Se iau datele personale ale stagiarului din Aplicant
                        internDTO.Applicant.FirstName = intern.Applicant.FirstName;
                        internDTO.Applicant.LastName = intern.Applicant.LastName;
                        internDTO.Applicant.Mail = intern.Applicant.Mail;
                        internDTO.Applicant.Nationality = intern.Applicant.Nationality;
                        internDTO.Applicant.PhoneNumber = intern.Applicant.PhoneNumber;
                        internDTO.Applicant.Studies = intern.Applicant.Studies;

                        // Se adauga in lista
                        internList.Add(internDTO);
                    }
                    // Se returneaza lista de stagiari
                    return internList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        //Functia pentru vizualizarea Task-urilor unui angajat
        #region FillTaskGrid
        public List<TaskDTO> FillTaskGrid(int userID)
        {
            // Se creaza o lista de task-uri de tipui DTO
            List<TaskDTO> taskList = new List<TaskDTO>();

            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se cauta in baza de date toate task-urile asignate unui user, dupa userID si care nu au fost finalizate
                    // Apoi se convertesc intr-o lista 
                    var find = context.Tasks.Where(x => x.EmployeeID == userID && x.Status == false).ToList();
                    if (find != null)
                    {
                        // Pentru fiecare task gasit, se face conversia la DTO si se adauga in lista creata mai sus
                        foreach (var task in find)
                        {
                            TaskDTO taskDTO = new TaskDTO();
                            PriorityDTO priorityDTO = new PriorityDTO();
                            ProjectDTO projectDTO = new ProjectDTO();
                            taskDTO.Priority = priorityDTO;
                            taskDTO.Project = projectDTO;

                            // Iau datele despre tassk
                            taskDTO.TaskID = Convert.ToInt32(task.TaskID);
                            taskDTO.TaskName = task.TaskName;
                            taskDTO.Status = Convert.ToBoolean(task.Status);
                            taskDTO.ProjectID = Convert.ToInt32(task.ProjectID);
                            // Iau numele proiectului caruia ii apartine task-ul respectiv
                            taskDTO.Project.ProjectName = task.Project.ProjectName;
                            taskDTO.Observations = task.Observations;

                            // Adaug task-ul in lista de task-uri
                            taskList.Add(taskDTO);
                        }
                    }
                }
                // Se returneaza lista de task-uri
                return taskList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillHolidaysGrid
        public List<HolidayDTO> FillHolidaysGrid()
        {
            // Se creaza o lista de zile de concediu de tipul DTO
            List<HolidayDTO> holidayList = new List<HolidayDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se selecteaza din baza de date toate zilele de concediu
                    var result = context.Holidays;
                    // Pentru fiecare zi de concediu selectata, se face conversia la DTO
                    foreach (var holiday in result)
                    {
                        HolidayDTO holidayDTO = new HolidayDTO();
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        holidayDTO.Employee = employeeDTO;

                        // Se selecteaza numele, prenumele si ID-ul angajatului
                        holidayDTO.Employee.FirstName = holiday.Employee.FirstName;
                        holidayDTO.Employee.LastName = holiday.Employee.LastName;
                        holidayDTO.EmployeeID = holiday.EmployeeID;
                        // Se selecteaza detalile zilei/zilelor de concediu
                        holidayDTO.HolidayID = holiday.HolidayID;
                        holidayDTO.StartDate = holiday.StartDate;
                        holidayDTO.EndDate = holiday.EndDate;
                        holidayDTO.Type = holiday.Type;

                        // Se adauga selectia in lista de concediu
                        holidayList.Add(holidayDTO);
                    }
                }
                // Se returneaza zilele de concediu impreuna cu angajatii care le-au solicitat
                return holidayList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillProjectEmployeesGrid
        public List<EmployeeDTO> FillProjectEmployeesGrid(Int32 managerID)
        {
            try
            {
                // Creez o lista de angajati de tipul DTO
                List<EmployeeDTO> employeesList = new List<EmployeeDTO>();
                // Se creaza o instanta de tipul context al bazei de date prin care se pot accesa tabelele
                using (var context = new DatabaseLicentaContext())
                {
                    // Selectez din baza de date proiectele asignate unui manager
                    var project = context.Projects.FirstOrDefault(x => x.EmployeeID == managerID);
                    if (project != null)
                    {
                        // Se selecteaza toti angajatii din baza
                        var result = context.Employees;
                        if (result != null)
                        {
                            // Pentru fiecare angajat din lista se face conversia la DTO
                            foreach (var employee in result)
                            {
                                // Pentru fiecare angajat se selecteaza din baza task-ul la care acesta lucreaza, in fuctie de proiect
                                var exists = context.Tasks.FirstOrDefault(x => x.EmployeeID == employee.EmployeeID && x.ProjectID == project.ProjectID);
                                if (exists != null)
                                {
                                    // Se adauga in lista de angajati creata mai sus
                                    employeesList.Add(ConvertEmployeeToDTO(employee));
                                }
                            }
                        }
                    }
                    // Se returneaza lista de angajati de pe un anumit proiect
                    return employeesList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region
        private EmployeeDTO ConvertEmployeeToDTO(Employee employee)
        {
            // Se creaza o instanta de tipul EmployeeDTO
            EmployeeDTO employeeDTO = new EmployeeDTO();
            // Se creaza o instanta de tipul DeparmentDTO in care se vor pune datele departamentului unde lucreaza angajatul
            DepartmentDTO departmentDTO = new DepartmentDTO();
            // Se creaza o instanta de tipul JobDTO care va contine date despre job-ul angajatului
            JobDTO jobDTO = new JobDTO();

            employeeDTO.Department = departmentDTO;
            employeeDTO.Job = jobDTO;

            // Se iau detalile despre angajat
            employeeDTO.EmployeeID = Convert.ToInt32(employee.EmployeeID);
            employeeDTO.FirstName = employee.FirstName;
            employeeDTO.LastName = employee.LastName;
            employeeDTO.PNC = employee.PNC;
            employeeDTO.Address = employee.Address;
            employeeDTO.BirthDate = employee.BirthDate;
            employeeDTO.Gender = employee.Gender;
            employeeDTO.HireDate = employee.HireDate;
            employeeDTO.Mail = employee.Mail;
            employeeDTO.Nationality = employee.Nationality;
            employeeDTO.PhoneNumber = employee.PhoneNumber;
            employeeDTO.Studies = employee.Studies;
            employeeDTO.Salary = employee.Salary;
            employeeDTO.FileNumber = employee.FileNumber;
            // Se ia departamentul si locatia departamentului unde lucreaza angajatul
            employeeDTO.Department.DepartmentName = employee.Department.DepartmentName;
            employeeDTO.Department.Location = employee.Department.Location;
            // Se ia job-ul pe care acesta il are
            employeeDTO.Job.JobTitle = employee.Job.JobTitle;

            return employeeDTO;
        }
        #endregion
        #endregion

        #region FillComboBox
        //Functiile pentru popularea comboBox-urilor din proiectul Client cu numele departamentelor si functiilor
        #region FillComboBoxDepartment
        public List<DepartmentDTO> FillComboBoxDepartment()
        {
            List<DepartmentDTO> departmentList = new List<DepartmentDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var d = context.Departments;
                    foreach (var department in d)
                    {
                        DepartmentDTO departmentDTO = new DepartmentDTO();

                        departmentDTO.DepartmentID = Convert.ToInt32(department.DepartmentID);
                        departmentDTO.DepartmentName = department.DepartmentName;
                        departmentDTO.Location = department.Location;

                        departmentList.Add(departmentDTO);
                    }
                }
                return departmentList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillComboBoxJob
        public List<JobDTO> FillComboBoxJob()
        {
            List<JobDTO> jobList = new List<JobDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var j = context.Jobs;
                    foreach (var job in j)
                    {
                        JobDTO jobDTO = new JobDTO();

                        jobDTO.JobID = Convert.ToInt32(job.JobID);
                        jobDTO.JobTitle = job.JobTitle;

                        jobList.Add(jobDTO);
                    }
                }
                return jobList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillComboBoxEmployee
        public List<EmployeeDTO> FillComboBoxEmployee()
        {
            List<EmployeeDTO> employeeList = new List<EmployeeDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var e = context.Employees;
                    foreach (var employee in e)
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO();

                        employeeDTO.EmployeeID = Convert.ToInt32(employee.EmployeeID);
                        employeeDTO.FirstName = employee.FirstName;
                        employeeDTO.LastName = employee.LastName;

                        employeeList.Add(employeeDTO);
                    }
                }
                return employeeList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillComboBoxCustomer
        public List<CustomerDTO> FillComboBoxCustomer()
        {
            List<CustomerDTO> customerList = new List<CustomerDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var c = context.Customers;
                    foreach (var customer in c)
                    {
                        CustomerDTO customerDTO = new CustomerDTO();

                        customerDTO.CustomerID = Convert.ToInt32(customer.CustomerID);
                        customerDTO.Address = customer.Address;
                        customerDTO.Institution = customer.Institution;
                        customerDTO.Name = customer.Name;

                        customerList.Add(customerDTO);
                    }
                }
                return customerList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillComboBoxProjectManager
        public List<EmployeeDTO> FillComboBoxProjectManager(int departmentID)
        {
            List<EmployeeDTO> employeeList = new List<EmployeeDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var result = (from e in context.Employees
                                  join l in context.Logins on e.EmployeeID equals l.EmployeeID
                                  where l.SecurityLevel == 2 && l.EmployeeID == departmentID
                                  select e).Distinct().ToList();
                    foreach (var employee in result)
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO();

                        employeeDTO.EmployeeID = Convert.ToInt32(employee.EmployeeID);
                        employeeDTO.FirstName = employee.FirstName;
                        employeeDTO.LastName = employee.LastName;

                        employeeList.Add(employeeDTO);
                    }
                }
                return employeeList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FillProjectComboBox
        public List<ProjectDTO> FillProjectComboBox(int userID)
        {
            List<ProjectDTO> projectList = new List<ProjectDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var result = context.Projects.Where(x => x.EmployeeID == userID);
                    if (result != null)
                    {
                        List<ProjectDTO> projects = result.Select(x => new ProjectDTO()
                        {
                            ProjectID = x.ProjectID,
                            Description = x.Description,
                            ProjectName = x.ProjectName,
                            Status = x.Status,
                            CustomerID = x.CustomerID,
                            EmployeeID = x.EmployeeID,
                            EndDate = x.EndDate,
                            Price = x.Price,
                            StartDate = x.StartDate,
                            Technology = x.Technology
                        }).ToList();
                        return projects;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        #endregion

        #region FillListBox
        #region FillNoteListBox
        public List<NoteDTO> FillNoteListBox(int userID)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var result = context.Notes.Where(x => x.UserID == userID);
                    if (result != null)
                    {
                        List<NoteDTO> notes = result.Select(x => new NoteDTO()
                        {
                            NoteID = x.NoteID,
                            Date = x.Date,
                            Description = x.Description
                        }).ToList();
                        return notes;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region FillNewsBox
        public List<NewsDTO> FillNewsBox()
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var result = context.News;
                    if (result != null)
                    {
                        List<NewsDTO> news = result.Select(x => new NewsDTO()
                        {
                            NewsID = x.NewsID,
                            Date = x.Date,
                            Title = x.Title,
                            Description = x.Description
                        }).ToList();
                        return news;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #endregion
        #endregion

        //Fill comboBox with applicants that requires an internship
        #region FillComboBoxApplicant
        public List<ApplicantDTO> FillComboBoxApplicant()
        {
            List<ApplicantDTO> applicantList = new List<ApplicantDTO>();
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var result = (from a in context.Applicants
                                  join r in context.Registrations on a.ApplicantID equals r.ApplicantID
                                  where r.Observation == "internship"
                                  select a).Distinct().ToList();
                    foreach (var applicant in result)
                    {
                        ApplicantDTO applicantDTO = new ApplicantDTO();

                        applicantDTO.ApplicantID = Convert.ToInt32(applicant.ApplicantID);
                        applicantDTO.FirstName = applicant.FirstName;
                        applicantDTO.LastName = applicant.LastName;
                        applicantDTO.Mail = applicant.Mail;
                        applicantDTO.Nationality = applicant.Nationality;
                        applicantDTO.PhoneNumber = applicant.PhoneNumber;
                        applicantDTO.Studies = applicant.Studies;
                        applicantDTO.BirthDate = applicant.BirthDate;

                        applicantList.Add(applicantDTO);
                    }
                }
                return applicantList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
