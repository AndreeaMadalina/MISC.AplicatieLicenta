using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO_Licenta;
using DB_Licenta.Models;
using System.Collections.Concurrent;

namespace ServerLicenta
{
    public class Service1 : IService1
    {
        //Functia de Autentificare
        #region Authenticate
        public LoginDTO Authenticate(string username, string password)
        {
            // Aceasta functie verifica daca cel care urmeaza sa se conecteze la aplicatie este un user in baza de date.
            // Atunci cand user-ul vrea sa se intre in aplicatie, acesta isi scrie username-ul si parola, care vor fi preluate mai departe 
            // de serviciu si verificate in baza de date.
            LoginDTO exists = new LoginDTO();
            EmployeeDTO employee = new EmployeeDTO();
            exists.Employee = employee;
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se cauta in baza de date user-ul cu username-ul si parola trimise de client
                    var login = context.Logins.FirstOrDefault(x => x.Username == username && x.Password == password);
                    //Daca se gaseste se converteste de la tipul Login la LoginDTO si se returneaza mai departe cu detaliile specifice lui
                    if (login != null)
                    {
                        exists.EmployeeID = Convert.ToInt32(login.EmployeeID);
                        exists.LoginID = Convert.ToInt32(login.LoginID);
                        exists.Username = login.Username;
                        exists.SecurityLevel = Convert.ToInt32(login.SecurityLevel);

                        exists.Employee.Address = login.Employee.Address;
                        exists.Employee.BirthDate = Convert.ToDateTime(login.Employee.BirthDate);
                        exists.Employee.FirstName = login.Employee.FirstName;
                        exists.Employee.Gender = login.Employee.Gender;
                        exists.Employee.HireDate = Convert.ToDateTime(login.Employee.HireDate);
                        exists.Employee.LastName = login.Employee.LastName;
                        exists.Employee.Mail = login.Employee.Mail;
                        exists.Employee.Nationality = login.Employee.Nationality;
                        exists.Employee.PhoneNumber = login.Employee.PhoneNumber;
                        exists.Employee.Studies = login.Employee.Studies;
                        
                        //Se returneaza user-ul 
                        return exists;
                    }
                    // Daca nu exista, returneaza null
                    else
                        return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

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
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        DepartmentDTO departmentDTO = new DepartmentDTO();
                        JobDTO jobDTO = new JobDTO();

                        employeeDTO.Department = departmentDTO;
                        employeeDTO.Job = jobDTO;

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
                        employeeDTO.Department.DepartmentName = employee.Department.DepartmentName;
                        employeeDTO.Department.Location = employee.Department.Location;
                        employeeDTO.Job.JobTitle = employee.Job.JobTitle;

                        employeeList.Add(employeeDTO);
                    }
                    return employeeList;
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                    // Pentru fiecate proiect gasit se face coversia la Data Transfer Object (DTO) si se adauga in lista projectList
                    foreach (var project in p)
                    {
                        CustomerDTO customerDTO = new CustomerDTO();
                        ProjectDTO projectDTO = new ProjectDTO();
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        projectDTO.Customer = customerDTO;
                        projectDTO.Employee = employeeDTO;

                        projectDTO.ProjectID = Convert.ToInt32(project.ProjectID);
                        projectDTO.Customer.Name = project.Customer.Name;
                        projectDTO.Description = project.Description;
                        projectDTO.Employee.FirstName = project.Employee.FirstName;
                        projectDTO.Employee.LastName = project.Employee.LastName;
                        projectDTO.EndDate = Convert.ToDateTime(project.EndDate);
                        projectDTO.Price = project.Price;
                        projectDTO.ProjectName = project.ProjectName;
                        projectDTO.StartDate = Convert.ToDateTime(project.StartDate);
                        projectDTO.Status = Convert.ToDouble(project.Status);

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

                            taskDTO.TaskID = Convert.ToInt32(task.TaskID);
                            taskDTO.TaskName = task.TaskName;
                            taskDTO.Status = Convert.ToBoolean(task.Status);
                            taskDTO.ProjectID = Convert.ToInt32(task.ProjectID);
                            taskDTO.Project.ProjectName = task.Project.ProjectName;
                            taskDTO.Observations = task.Observations;

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
                List<EmployeeDTO> employeesList = new List<EmployeeDTO>();
                using (var context = new DatabaseLicentaContext())
                {
                    var project = context.Projects.FirstOrDefault(x => x.EmployeeID == managerID);
                    if(project != null)
                    {
                        var result = context.Employees;
                        if(result != null)
                        {
                            foreach (var employee in result)
                            {
                                var exists = context.Tasks.FirstOrDefault(x => x.EmployeeID == employee.EmployeeID && x.ProjectID == project.ProjectID);
                                if(exists != null)
                                {
                                    EmployeeDTO employeeDTO = new EmployeeDTO();
                                    DepartmentDTO departmentDTO = new DepartmentDTO();
                                    JobDTO jobDTO = new JobDTO();

                                    employeeDTO.Department = departmentDTO;
                                    employeeDTO.Job = jobDTO;

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
                                    employeeDTO.Department.DepartmentName = employee.Department.DepartmentName;
                                    employeeDTO.Department.Location = employee.Department.Location;
                                    employeeDTO.Job.JobTitle = employee.Job.JobTitle;

                                    employeesList.Add(employeeDTO);
                                }
                            }
                        }
                    }
                    return employeesList;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
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
                    if(result != null)
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

        #region INSERT
        //Functia pentru inserarea unui aplicant
        #region InsertApplicant
        public bool InsertApplicant(ApplicantDTO applicantDTO, string job, string department, string observation)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    // Se pregateste baza de date pentru inserarea unui nou aplicant creandu-se cate o entitate pentru tabelele
                    // Applicant si Registration
                    Applicant applicant = context.Applicants.Create();
                    Registration registration = context.Registrations.Create();

                    // Se adauga datele despre aplicant care vor a fi inserate in baza 
                    applicant.FirstName = applicantDTO.FirstName;
                    applicant.LastName = applicantDTO.LastName;
                    applicant.Mail = applicantDTO.Mail;
                    applicant.Nationality = applicantDTO.Nationality;
                    applicant.PhoneNumber = applicantDTO.PhoneNumber;
                    applicant.Studies = applicantDTO.Studies;
                    applicant.BirthDate = applicantDTO.BirthDate;

                    // Se adauga in tabela si se salveaza schimbaile
                    context.Applicants.Add(applicant);
                    context.SaveChanges();

                    // Inregistreaza optiunea aplicantului
                    // Aici se fac legaturile cu tabele Jobs si Departments
                    // Se pastreaza id-ul aplicantului deja inserat
                    // Se completeaza field-urile tabelei Registrations
                    registration.ApplicantID = applicant.ApplicantID;
                    // Se cauta in baza job-ul ales de aplicant si i se adauga ID-ul in instanta registration
                    var findJob = context.Jobs.FirstOrDefault(x => x.JobTitle == job);
                    if(findJob != null)
                    {
                        registration.JobID = findJob.JobID;
                    }
                    // Se cauta in baza departamentul ales de aplicant si i se adauga ID-ul in registration
                    var findDepartment = context.Departments.FirstOrDefault(x => x.DepartmentName == department);
                    if(findDepartment != null)
                    {
                        registration.DepartmentID = findDepartment.DepartmentID;
                    }
                    registration.AppliedDate = DateTime.Now;
                    registration.Observation = observation;
                    // Se adauga recordul in tabela si se salveaza modificarile
                    context.Registrations.Add(registration);
                    context.SaveChanges();
                }
                // Se returneaza true in cazul in care inserarea s-a facut cu succes
                return true;
            }
            catch (Exception)
            {
                // Se returneaza false daca record-ul nu a putut fi inserat
                return false;
            }
        }
        #endregion

        //Functia pentru inserarea unui angajat
        #region InsertEmployee
        public bool InsertEmployee(EmployeeDTO employeeDTO, LoginDTO loginDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    Employee employee = context.Employees.Create();
                    
                    employee.Address = employeeDTO.Address;
                    employee.BirthDate = employeeDTO.BirthDate;
                    employee.FileNumber = employeeDTO.FileNumber;
                    employee.FirstName = employeeDTO.FirstName;
                    employee.Gender = employeeDTO.Gender;
                    employee.HireDate = DateTime.Now;
                    employee.LastName = employeeDTO.LastName;
                    employee.Mail = employeeDTO.Mail;
                    employee.Nationality = employeeDTO.Nationality;
                    employee.PhoneNumber = employeeDTO.PhoneNumber;
                    employee.PNC = employeeDTO.PNC;
                    employee.Salary = employeeDTO.Salary;
                    employee.Studies = employeeDTO.Studies;
                    employee.DepartmentID = employeeDTO.Department.DepartmentID;
                    employee.JobID = employeeDTO.Job.JobID;
                    
                    context.Employees.Add(employee);
                    context.SaveChanges();

                    Login login = context.Logins.Create();
                    login.EmployeeID = employee.EmployeeID;
                    login.Password = loginDTO.Password;
                    login.Username = loginDTO.Username;
                    login.SecurityLevel = loginDTO.SecurityLevel;

                    context.Logins.Add(login);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region InsertCustomer
        public bool InsertCustomer(CustomerDTO customerDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    Customer customer = context.Customers.Create();

                    customer.Name = customerDTO.Name;
                    customer.Institution = customerDTO.Institution;
                    customer.Address = customerDTO.Address;
                    customer.Mail = customerDTO.Mail;
                    customer.PhoneNumber = customerDTO.PhoneNumber;

                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region InsertProject
        public bool InsertProject(ProjectDTO projectDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    Project project = context.Projects.Create();

                    project.CustomerID = Convert.ToInt32(projectDTO.CustomerID);
                    project.ProjectName = projectDTO.ProjectName;
                    project.Description = projectDTO.Description;
                    project.Price = Convert.ToInt32(projectDTO.Price);
                    project.EmployeeID = Convert.ToInt32(projectDTO.EmployeeID);
                    project.StartDate = Convert.ToDateTime(projectDTO.StartDate);
                    project.EndDate = Convert.ToDateTime(projectDTO.EndDate);
                    project.Technology = projectDTO.Technology;

                    context.Projects.Add(project);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
        }
        #endregion

        #region InsertIntern
        public bool InsertIntern(InternDTO internDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    Intern intern = context.Interns.Create();

                    intern.ApplicantID = internDTO.Applicant.ApplicantID;
                    intern.EmployeeID = internDTO.Employee.EmployeeID;
                    intern.EndDate = internDTO.EndDate;
                    intern.StartDate = internDTO.StartDate;
                    intern.Observation = internDTO.Observation;
                    intern.StartDate = internDTO.StartDate;

                    context.Interns.Add(intern);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region InsertNotes
        public bool InsertNotes(NoteDTO noteDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    Note note = context.Notes.Create();
                    note.Date = noteDTO.Date;
                    note.Description = noteDTO.Description;
                    note.UserID = noteDTO.UserID;

                    context.Notes.Add(note);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
        }
        #endregion

        #region InsertHoliday
        public Boolean InsertHoliday(HolidayDTO holidayDTO)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var holiday = context.Holidays.Create();
                    holiday.EmployeeID = holidayDTO.EmployeeID;
                    holiday.StartDate = Convert.ToDateTime(holidayDTO.StartDate);
                    holiday.EndDate = Convert.ToDateTime(holidayDTO.EndDate);
                    holiday.Type = "M";
                    context.Holidays.Add(holiday);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region InsertTask
        public Boolean InsertTask(string title, string observation, int employeeID, int managerID)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var task = context.Tasks.Create();
                    task.TaskName = title;
                    task.Observations = observation;
                    task.Status = false;
                    task.EmployeeID = employeeID;
                    var project = context.Projects.FirstOrDefault(x => x.EmployeeID == managerID);
                    if(project != null)
                    {
                        task.ProjectID = project.ProjectID;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
        #endregion

        #region UPDATE
        #region UpdateProjectStatus
        public void UpdateProjectStatus(double status, int projectID)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var project = context.Projects.FirstOrDefault(x => x.ProjectID == projectID);
                    if(project != null)
                    {
                        project.Status = status;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region UpdateStatusTask
        public Boolean UpdateStatusTask(TaskDTO task)
        {
            try
            {
                using (var context = new DatabaseLicentaContext())
                {
                    var findTask = context.Tasks.FirstOrDefault(x => x.TaskID == task.TaskID);
                    if (findTask != null)
                    {
                        findTask.Status = task.Status;
                    }

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
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
