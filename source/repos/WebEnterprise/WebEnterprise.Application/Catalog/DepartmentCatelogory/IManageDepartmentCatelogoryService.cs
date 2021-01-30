using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Application.Catalog.DepartmentCatelogory.Dtos;
using WebEnterprise.Application.Dtos;

namespace WebEnterprise.Application.Catalog.DepartmentCatelogory
{
    public interface IManageDepartmentCatelogoryService
    {
        int Create(DepartmentCreateRequest request);
        int Update(DepartmentEditRequest request);
        int Delete(int departmentId);
        List<DepartmentCatelogoryViewModel> GetAll();
        PageViewModels<DepartmentCatelogoryViewModel> GetAllPaging(string keyword, int pageIndex, int pageSize);

    }
}
