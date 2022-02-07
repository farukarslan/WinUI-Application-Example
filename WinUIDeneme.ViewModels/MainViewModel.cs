using MvvmGen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDeneme.ViewModels
{
    [ViewModel] //MvvmGen
    public partial class MainViewModel
    {
        [Property]
        private EmployeeViewModel _selectedEmployee;

        partial void OnInitialize()
        {
            Employees.Add(new EmployeeViewModel { FirstName = "Ali", LastName = "Brown", IsDeveloper = true });
            Employees.Add(new EmployeeViewModel { FirstName = "Veli", LastName = "", IsDeveloper = false });
            Employees.Add(new EmployeeViewModel { FirstName = "Mehmet", LastName = "Black", IsDeveloper = true });
            Employees.Add(new EmployeeViewModel { FirstName = "Ahmet", LastName = "", IsDeveloper = false });
            Employees.Add(new EmployeeViewModel { FirstName = "Ömer", LastName = "Arslan", IsDeveloper = true });
        }

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
    }

    [ViewModel]
    public partial class EmployeeViewModel
    {
        [Property] private string _firstName;
        [Property] private string _lastName;
        [Property] private bool _IsDeveloper;
    }
}
