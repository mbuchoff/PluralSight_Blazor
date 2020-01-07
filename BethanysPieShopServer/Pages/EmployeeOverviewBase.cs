using BethanysPieShopHRM.Shared;
using BethanysPieShopServer.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopServer.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList(); ;
        }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
