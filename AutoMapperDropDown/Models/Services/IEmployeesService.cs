﻿using AutoMapperDropDown.Models.ViewModel;

public interface IEmployeesService
{
    Task<List<EmployeeViewModel>> GetAllAsync();
    Task<EmployeeViewModel?> GetByIdAsync(int id);
    Task CreateAsync(EmployeeViewModel employee);

    Task<List<DropDownViewModel>> GetDepartmentForDropDownAsync();

    Task<List<DropDownViewModel>> GetNationalityForDropDownAsync();
}