using AutoMapper;
using AutoMapperDropDown.DataAccess;
using AutoMapperDropDown.Models;
using AutoMapperDropDown.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

public class DepartmentsService : IDepartmentsService
{
    private readonly UserEmpNationalityContext _dbContext;
    private readonly IMapper _mapper;

    public DepartmentsService(
        UserEmpNationalityContext dbContext,
        IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<DepartmentViewModel>> GetAllAsync()
    {
        //var departments = await _dbContext.Departments.ToListAsync();

        var departments = await _dbContext.Departments
            .Select(d => _mapper.Map<DepartmentViewModel>(d))
            .ToListAsync();

        return departments;
    }

    public async Task<DepartmentViewModel?> GetByIdAsync(int id)
    {
        //var department = await _dbContext.Departments.FirstOrDefaultAsync(m => m.Id == id);

        var department = await _dbContext.Departments.FirstOrDefaultAsync(m => m.Id == id);

        return _mapper.Map<DepartmentViewModel>(department);
    }

    public async Task CreateAsync(DepartmentViewModel department)
    {
        var departmentDataModel = _mapper.Map<Department>(department);

        _dbContext.Add(departmentDataModel);
        await _dbContext.SaveChangesAsync();
    }
}
