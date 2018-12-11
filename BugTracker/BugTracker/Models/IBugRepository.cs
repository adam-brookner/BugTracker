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

        //Get by ID
        BugLog GetBugByID(int BugID);
        Department GetDepartmentByID(int DepartmentID);
        Principal GetPrincipalByID(int UserID);
        Priority GetPriorityByID(int PriorityID);

        //Create
        void AddBug(BugLog bug);
        void AddDepartment(Department department);
        void AddPrincipal(Principal principal);
        void AddPriority(Priority priority);

        //Update
        void UpdateBug(BugLog bug);
        void UpdateDepartment(Department department);
        void UpdatePrincipal(Principal principal);
        void UpdatePriority(Priority priority);

        //Delete
        void DeleteBug(BugLog bug);
        void DeleteDepartment(Department department);
        void DeletePrincipal(Principal principal);
        void DeletePriority(Priority priority);
    }
}
