using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class BugRepository : IBugRepository
    {
        BugEntities bugDB = new BugEntities();

        //Add
        void IBugRepository.AddBug(BugLog bug)
        {
            bugDB.BugLogs.Add(bug);
            bugDB.SaveChanges();
        }

        void IBugRepository.AddDepartment(Department department)
        {
            bugDB.Departments.Add(department);
            bugDB.SaveChanges();
        }

        void IBugRepository.AddPrincipal(Principal principal)
        {
            bugDB.Principals.Add(principal);
            bugDB.SaveChanges();
        }

        void IBugRepository.AddPriority(Priority priority)
        {
            bugDB.Priorities.Add(priority);
            bugDB.SaveChanges();
        }
        void IBugRepository.AddStatus(Status status)
        {
            bugDB.Status.Add(status);
            bugDB.SaveChanges();
        }
        //Delete
        void IBugRepository.DeleteBug(BugLog bug)
        {
            bugDB.BugLogs.Remove(bug);
            bugDB.SaveChanges();
        }

        void IBugRepository.DeleteDepartment(Department department)
        {
            bugDB.Departments.Remove(department);
            bugDB.SaveChanges();
        }

        void IBugRepository.DeletePrincipal(Principal principal)
        {
            bugDB.Principals.Remove(principal);
            bugDB.SaveChanges();
        }

        void IBugRepository.DeletePriority(Priority priority)
        {
            bugDB.Priorities.Remove(priority);
            bugDB.SaveChanges();
        }
        void IBugRepository.DeleteStatus(Status status)
        {
            bugDB.Status.Remove(status);
            bugDB.SaveChanges();
        }

        //Get all
        IEnumerable<BugLog> IBugRepository.GetAllBugs()
        {
            return bugDB.BugLogs.ToList();
        }

        IEnumerable<Department> IBugRepository.GetAllDepartments()
        {
            return bugDB.Departments.ToList();
        }

        IEnumerable<Principal> IBugRepository.GetAllPrincipals()
        {
            return bugDB.Principals.ToList();
        }

        IEnumerable<Priority> IBugRepository.GetAllPriorities()
        {
            return bugDB.Priorities.ToList();
        }
        IEnumerable<Status> IBugRepository.GetAllStatuses()
        {
            return bugDB.Status.ToList();
        }

        //Get By ID
        BugLog IBugRepository.GetBugByID(int BugID)
        {
            return bugDB.BugLogs.Single(b => b.BugID == BugID);
        }

        Department IBugRepository.GetDepartmentByID(int DepartmentID)
        {
            return bugDB.Departments.Single(d => d.DepartmentID == DepartmentID);
        }

        Principal IBugRepository.GetPrincipalByID(int UserID)
        {
            return bugDB.Principals.Single(p => p.UserID == UserID);
        }

        Priority IBugRepository.GetPriorityByID(int PriorityID)
        {
            return bugDB.Priorities.Single(pr => pr.PriorityID == PriorityID);
        }
        Status IBugRepository.GetStatusByID(int StatusID)
        {
            return bugDB.Status.Single(s => s.StatusID == StatusID);
        }

        //Update / Edit
        void IBugRepository.UpdateBug(BugLog bug)
        {
            BugLog tmpBug = bugDB.BugLogs.Single(b => b.BugID == bug.BugID);

            tmpBug.Title = bug.Title;
            tmpBug.Description = bug.Description;
            tmpBug.Created = bug.Created;
            tmpBug.UserID = bug.UserID;
            tmpBug.PriorityID = bug.PriorityID;
            tmpBug.StatusID = bug.StatusID;

            bugDB.SaveChanges();
        }

        void IBugRepository.UpdateDepartment(Department department)
        {
            Department tmpDepartment = bugDB.Departments.Single(d => d.DepartmentID == department.DepartmentID);
            tmpDepartment.DepartmentName = department.DepartmentName;
            tmpDepartment.DepartmentManager = department.DepartmentManager;

            bugDB.SaveChanges();
        }

        void IBugRepository.UpdatePrincipal(Principal principal)
        {
            Principal tmpPrincipal = bugDB.Principals.Single(p => p.UserID == principal.UserID);
            tmpPrincipal.Forename = principal.Forename;
            tmpPrincipal.Surname = principal.Surname;
            tmpPrincipal.Address = principal.Address;
            tmpPrincipal.PostCode = principal.PostCode;
            tmpPrincipal.Phone_Number = principal.Phone_Number;
            tmpPrincipal.JobDescription = principal.JobDescription;
            tmpPrincipal.DepartmentID = principal.DepartmentID;

            bugDB.SaveChanges();

        }

        void IBugRepository.UpdatePriority(Priority priority)
        {
            Priority tmpPriority = bugDB.Priorities.Single(pr => pr.PriorityID == priority.PriorityID);
            tmpPriority.PriorityName = priority.PriorityName;
            tmpPriority.Description = priority.Description;

            bugDB.SaveChanges();
        }
        void IBugRepository.UpdateStatus(Status status)
        {
            Status tmpStatus = bugDB.Status.Single(s => s.StatusID == status.StatusID);
            tmpStatus.Title = status.Title;

            bugDB.SaveChanges();
        }
    }
}