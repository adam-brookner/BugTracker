using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IBugRepository 
    {
        //Get all at once
        IEnumerable<BugLog> GetAllBugs();
        IEnumerable<Department> GetAllDepartments();
        IEnumerable<Principal> GetAllPrincipals();
        IEnumerable<Priority> GetAllPriorities();
        IEnumerable<Status> GetAllStatuses();

        //Get by ID
        BugLog GetBugByID(int BugID);
        Department GetDepartmentByID(int DepartmentID);
        Principal GetPrincipalByID(int UserID);
        Priority GetPriorityByID(int PriorityID);
        Status GetStatusByID(int StatusID);

        //Create
        void AddBug(BugLog bug);
        void AddDepartment(Department department);
        void AddPrincipal(Principal principal);
        void AddPriority(Priority priority);
        void AddStatus(Status status);

        //Update
        void UpdateBug(BugLog bug);
        void UpdateDepartment(Department department);
        void UpdatePrincipal(Principal principal);
        void UpdatePriority(Priority priority);
        void UpdateStatus(Status status);

        //Delete
        void DeleteBug(BugLog bug);
        void DeleteDepartment(Department department);
        void DeletePrincipal(Principal principal);
        void DeletePriority(Priority priority);
        void DeleteStatus(Status status);
    }
}
