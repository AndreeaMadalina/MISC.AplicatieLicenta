using DTO_Licenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServerLicenta
{
    [ServiceContract]
    public interface IService1
    {
        #region Authenticate
        [OperationContract]
        LoginDTO Authenticate(string username, string password);
        #endregion

        //#region View informations from Database
        //#region FillGrid
        //[OperationContract]
        //List<ApplicantDTO> FillApplicantGrid();
        //[OperationContract]
        //List<EmployeeDTO> FillEmployeeGrid();
        //[OperationContract]
        //List<CustomerDTO> FillCustomerGrid();
        //[OperationContract]
        //List<ProjectDTO> FillProjectGrid();
        //[OperationContract]
        //List<InternDTO> FillInternGrid();
        //[OperationContract]
        //List<TaskDTO> FillTaskGrid(int userID);
        //[OperationContract]
        //List<HolidayDTO> FillHolidaysGrid();
        //[OperationContract]
        //List<EmployeeDTO> FillProjectEmployeesGrid(Int32 managerID);
        //#endregion

        //#region FillListBox
        //[OperationContract]
        //List<NoteDTO> FillNoteListBox(int userID);
        //[OperationContract]
        //List<NewsDTO> FillNewsBox();
        //#endregion

        //#region FillComboBox
        //[OperationContract]
        //List<ProjectDTO> FillProjectComboBox(int userID);
        //[OperationContract]
        //List<DepartmentDTO> FillComboBoxDepartment();
        //[OperationContract]
        //List<JobDTO> FillComboBoxJob();
        //[OperationContract]
        //List<ApplicantDTO> FillComboBoxApplicant();
        //[OperationContract]
        //List<EmployeeDTO> FillComboBoxEmployee();
        //[OperationContract]
        //List<CustomerDTO> FillComboBoxCustomer();
        //[OperationContract]
        //List<EmployeeDTO> FillComboBoxProjectManager(int departmentID);
        //#endregion
        //#endregion

        #region Insert into Database
        [OperationContract]
        Boolean InsertApplicant(ApplicantDTO applicantDTO, string job, string department, string observation);
        [OperationContract]
        Boolean InsertEmployee(EmployeeDTO employeeDTO, LoginDTO loginDTO);
        [OperationContract]
        Boolean InsertCustomer(CustomerDTO customerDTO);
        [OperationContract]
        Boolean InsertProject(ProjectDTO projectDTO);
        [OperationContract]
        Boolean InsertIntern(InternDTO internDTO);
        [OperationContract]
        Boolean InsertNotes(NoteDTO noteDTO);
        [OperationContract]
        Boolean InsertHoliday(HolidayDTO holidayDTO);
        [OperationContract]
        Boolean InsertTask(string title, string observation, int employeeID, int managerID);
        #endregion

        #region Update
        [OperationContract]
        void UpdateProjectStatus(double status, int projectID);
        [OperationContract]
        Boolean UpdateStatusTask(TaskDTO tasks);
        #endregion
    }
}
