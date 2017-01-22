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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceRead
    {
        #region View informations from Database
        #region FillGrid
        [OperationContract]
        List<ApplicantDTO> FillApplicantGrid();
        [OperationContract]
        List<EmployeeDTO> FillEmployeeGrid();
        [OperationContract]
        List<CustomerDTO> FillCustomerGrid();
        [OperationContract]
        List<ProjectDTO> FillProjectGrid();
        [OperationContract]
        List<InternDTO> FillInternGrid();
        [OperationContract]
        List<TaskDTO> FillTaskGrid(int userID);
        [OperationContract]
        List<HolidayDTO> FillHolidaysGrid();
        [OperationContract]
        List<EmployeeDTO> FillProjectEmployeesGrid(Int32 managerID);
        #endregion

        #region FillListBox
        [OperationContract]
        List<NoteDTO> FillNoteListBox(int userID);
        [OperationContract]
        List<NewsDTO> FillNewsBox();
        #endregion

        #region FillComboBox
        [OperationContract]
        List<ProjectDTO> FillProjectComboBox(int userID);
        [OperationContract]
        List<DepartmentDTO> FillComboBoxDepartment();
        [OperationContract]
        List<JobDTO> FillComboBoxJob();
        [OperationContract]
        List<ApplicantDTO> FillComboBoxApplicant();
        [OperationContract]
        List<EmployeeDTO> FillComboBoxEmployee();
        [OperationContract]
        List<CustomerDTO> FillComboBoxCustomer();
        [OperationContract]
        List<EmployeeDTO> FillComboBoxProjectManager(int departmentID);
        #endregion
        #endregion
    }
}
