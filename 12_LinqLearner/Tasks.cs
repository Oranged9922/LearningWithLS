using HelperFunctions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _12_LinqLearner;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public HashSet<int> EmployeeIds { get; set; } = new HashSet<int>();
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int Age { get; set; }
    public List<int> ProjectIds { get; set; } = new List<int>();
    public Role Role { get; set; }
}

public enum Role { Developer, ProjectManager, QA, Designer, Analyst, Architect, DeliveryManager }

public class Tasks
{
    private static List<Project> projects = new List<Project>();
    private static List<Employee> employees = new List<Employee>();
    private static HelperFunctionsClass helper = new HelperFunctionsClass(1);

    public Tasks()
    {
        // Create 30 projects with random names and 5-10 employees each
        for (int i = 0; i < 100000; i++)
        {
            var project = new Project()
            {
                Id = i + 1,
                Name = helper.GetRandomProjectName(),
            };

            projects.Add(project);
        }

        // Create 100 employees
        for (int i = 0; i < 10000; i++)
        {
            var employee = new Employee()
            {
                Id = i + 1,
                Name = helper.GetRandomEmployeeName(),
                Age = helper.GetRandomInt(20, 60),
                Role = (Role)helper.GetRandomInt(0, 7)
            };

            // Assign 1-3 random projects to each employee
            int numberOfProjects = helper.GetRandomInt(1, 3);
            employee.ProjectIds = Enumerable.Range(0, numberOfProjects)
                                            .Select(_ => helper.GetRandomInt(1, 30))
                                            .ToList();

            // Update projects' EmployeeIds
            foreach (var projectId in employee.ProjectIds)
            {
                projects.First(p => p.Id == projectId).EmployeeIds.Add(employee.Id);
            }

            employees.Add(employee);
        }
    }

    // Get all Project Managers(PM).
    public List<Employee> GetProjectManagers()
    {
        return employees.Where(e => e.Role == Role.ProjectManager).ToList();
    }
    // Get all Developers who are older than 30 and are working on a project with a Tester.
    public List<Employee> GetDevelopersOlderThan30WithTester()
    {
        return employees.Where(
            e => e.Role == Role.Developer &&
            e.Age > 30 &&
            projects.First(
                p => p.EmployeeIds.Contains(e.Id))
            .EmployeeIds.Any(
                eId => employees.First(
                    e => e.Id == eId).Role == Role.QA))
            .ToList();
    }
    // Get all projects.
    public List<Project> GetProjectsForDeliveryManager()
    {
        return null;
    }
    // Get all Developers who are not working on a project with a Tester.
    public List<Employee> GetDevelopersWithoutTester()
    {
        return null;
    }
    // Get all projects that have at least 2 Designers and at least 2 Developers.
    public List<Project> GetProjectsWith2DesignersAnd2Developers()
    {
        return null;
    }
    // Get all projects that have at least 2 Developers and at least 2 QAs.
    public List<Project> GetProjectsWith2DevelopersAnd2QAs()
    {
        return null;
    }
    // Group employees by their roles and count them.
    public Dictionary<Role, int> GetEmployeesByRole()
    {
        return null;
    }
    // Group projects by the number of employees.
    public Dictionary<int, List<Project>> GetProjectsByNumberOfEmployeesLINQ()
    {
        return projects.GroupBy(p => p.EmployeeIds.Count)
                       .ToDictionary(g => g.Key, g => g.ToList());
    }
    // Group projects by the number of employees.
    public Dictionary<int, List<Project>> GetProjectsByNumberOfEmployeesNOTLINQ()
    {
        var result = new Dictionary<int, List<Project>>();
        foreach (var project in projects)
        {
            result.TryGetValue(project.EmployeeIds.Count - 1, out var projects);
            if (projects != null)
            {
                projects.Append(project);
            }
            else
            {
                result[project.EmployeeIds.Count] = new List<Project> { project };
            }
        }
        return result;
    }

    // Group employees by project.
    public Dictionary<int, List<Employee>> GetEmployeesByProject()
    {
        return null;
    }
    // Group employees by role, then by age range (20-30, 31-40, etc.), and count them.
    public Dictionary<Role, Dictionary<string, int>> GetEmployeesByRoleAndAgeRange()
    {
        return null;
    }
    // Group projects by the presence of specific roles(e.g., projects that have at least one QA, Developer, etc.).
    public Dictionary<string, List<Project>> GetProjectsByRolePresence()
    {
        return null;
    }
    // Group projects by the average age of employees.
    public Dictionary<int, List<Project>> GetProjectsByAverageEmployeeAge()
    {
        return null;
    }

    internal void Run(Action<string> writeLine)
    {
        // Get list of all delegates in this class
        var methods = this.GetType()
            .GetMethods()
            .Where(
                m => m.ReturnType == typeof(List<Project>) ||
                m.ReturnType == typeof(List<Employee>) ||
                m.ReturnType == typeof(Dictionary<Role, int>) ||
                m.ReturnType == typeof(Dictionary<int, List<Project>>) ||
                m.ReturnType == typeof(Dictionary<int, List<Employee>>) ||
                m.ReturnType == typeof(Dictionary<Role, Dictionary<string, int>>) ||
                m.ReturnType == typeof(Dictionary<string, List<Project>>) ||
                m.ReturnType == typeof(Dictionary<int, List<Project>>))
            .ToList();

        // Run each delegate and print the result
        foreach (var method in methods)
        {
            var result = method.Invoke(this, null);
            writeLine($"Method: {method.Name}");
            writeLine($"Result:\n{helper.ToJson(result)}");
        }
    }
}
