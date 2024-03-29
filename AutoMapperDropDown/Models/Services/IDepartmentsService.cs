﻿using AutoMapperDropDown.Models.ViewModel;

public interface IDepartmentsService
{
    Task<List<DepartmentViewModel>> GetAllAsync();
    Task<DepartmentViewModel?> GetByIdAsync(int id);
    Task CreateAsync(DepartmentViewModel department);
}