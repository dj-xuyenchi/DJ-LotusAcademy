using DJ_WebDesignCore.Business.EmployeeManager;
using DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs;
using DJ_WebDesignCore.Entites.Employee;
using DJ_WebDesignCore.Entites.Properties;
using DJ_WebDesignCore.Entites.Properties.Address;
using DJ_WebDesignCore.Enums.EmployeeManagerEnums;

namespace DJ_UseCaseLayer.Business.EmployeeManager
{

    public class EmployeeCRUD : BaseDB, IEmployeeCRUD
    {
        //EmployeeCreateDTO IEmployeeCRUD.createEmployee(EmployeeLA newData)
        //{
        //    EmployeeCreateDTO res = new EmployeeCreateDTO();

        //    if (newData.EmployeeRoleId == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id cần tìm";
        //        return res;
        //    }
        //    EmployeeRole employeeRole = _context.employeeRoles.Find(newData.EmployeeRoleId);
        //    if (employeeRole == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại role nhân viên có id là {newData.EmployeeRoleId}";
        //        return res;
        //    }

        //    if (newData.WardCode == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id cần tìm";
        //        return res;
        //    }
        //    Ward ward = _context.wards.Find(newData.WardCode);
        //    if (ward == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại ward có id là {newData.WardCode}";
        //        return res;
        //    }

        //    if (newData.DistrictCode == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id cần tìm";
        //        return res;
        //    }
        //    District district = _context.districts.Find(newData.DistrictCode);
        //    if (district == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại district có id là {newData.DistrictCode}";
        //        return res;
        //    }

        //    if (newData.ProvinceCode == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id cần tìm";
        //        return res;
        //    }
        //    Province province = _context.provinces.Find(newData.ProvinceCode);
        //    if (province == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại province có id là {newData.ProvinceCode}";
        //        return res;
        //    }

        //    if (newData.GenderId == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id cần tìm";
        //        return res;
        //    }
        //    Gender gender = _context.genders.Find(newData.GenderId);
        //    if (gender == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại giới tính có id là {newData.GenderId}";
        //        return res;
        //    }

        //    if (newData.NumberPhone == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOT_VALUE;
        //        res.ShortDetail = "Không nhận được số điện thoại";
        //        return res;
        //    }
        //    if (newData.FacebookUrl == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOT_VALUE;
        //        res.ShortDetail = "Không nhận được link Facebook";
        //        return res;
        //    }
        //    if (newData.EmployeeLAName == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOT_VALUE;
        //        res.ShortDetail = "Không nhận được tên nhân viên";
        //        return res;
        //    }
        //    if (newData.EmployeeLAName.Length < 6)
        //    {
        //        res.Status = EmployeeCreateEnums.LENGTH_TOO_SHORT;
        //        res.ShortDetail = "Tên nhân viên tối thiểu là 6 ký tự";
        //        return res;
        //    }
        //    if (newData.EmployeeLABirthDay == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOT_VALUE;
        //        res.ShortDetail = "Không nhận được ngày tháng năm sinh";
        //        return res;
        //    }

        //    if (newData.EmployeeStatusId == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NULLID;
        //        res.ShortDetail = $"Không nhận được id cần tìm";
        //        return res;
        //    }
        //    EmployeeStatus employeeStatus = _context.employeeStatuses.Find(newData.EmployeeStatusId);
        //    if (employeeStatus == null)
        //    {
        //        res.Status = EmployeeCreateEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại status employee có id là {newData.EmployeeStatusId}";
        //        return res;
        //    }
        //    _context.employeeLA.Add(newData);
        //    _context.SaveChanges();
        //    res.Status = EmployeeCreateEnums.SUCCESSFULLY;
        //    res.ShortDetail = "Thêm nhân viên thành công!";
        //    res.Data = newData;
        //    return res;
        //}

        //EmployeeDeleteDTO IEmployeeCRUD.deleteEmployee(int? employeeId)
        //{
        //    EmployeeDeleteDTO res = new EmployeeDeleteDTO();

        //    if (employeeId == null)
        //    {
        //        res.Status = EmployeeDeleteEnums.NULLID;
        //        res.ShortDetail = "Không nhận được id nhân viên";
        //        return res;
        //    }
        //    EmployeeLA employee = _context.employeeLA.Find(employeeId);
        //    if (employee == null)
        //    {
        //        res.Status = EmployeeDeleteEnums.NOTFOUND;
        //        res.ShortDetail = $"Không tồn tại nhân viên có id là {employeeId}";
        //        return res;
        //    }

        //    EmployeeStatus employeeStatus = _context.employeeStatuses.FirstOrDefault(x => x.EmployeeStatusCode == "Resign");
        //    employee.EmployeeStatusId = employeeStatus.Id;
        //    _context.employeeLA.Update(employee);
        //    _context.SaveChanges();
        //    res.Status = EmployeeDeleteEnums.SUCCESSFULLY;
        //    res.ShortDetail = "Xóa nhân viên thành công!";
        //    res.Data = employee;
        //    return res;
        //}

        //EmployeeUpdateDTO IEmployeeCRUD.updateEmployee(EmployeeLA newData)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        EmployeeUpdateDTO res = new EmployeeUpdateDTO();

        //        if (newData.Id == null)
        //        {
        //            res.Status = EmployeeUpdateEnums.NULLID;
        //            res.ShortDetail = "Vui lòng nhập id nhân viên";
        //            return res;
        //        }
        //        EmployeeLA employee = _context.employeeLA.Find(newData.Id);
        //        if (employee == null)
        //        {
        //            res.Status = EmployeeUpdateEnums.NULLID;
        //            res.ShortDetail = $"Nhân viên có id {newData.Id} chưa tồn tại";
        //            return res;
        //        }

        //        if (newData.EmployeeLAUserName != null)
        //        {
        //            if (employee.EmployeeLAUserName != newData.EmployeeLAUserName)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTCHANGE_USERNAME;
        //                res.ShortDetail = $"Nhân viên ko được thay đổi tên username";
        //                return res;
        //            }
        //        }
        //        if (newData.EmployeeLAPassword != null)
        //        {
        //            if (newData.EmployeeLAPassword.Length < 6)
        //            {
        //                res.Status = EmployeeUpdateEnums.LENGTH_TOO_SHORT;
        //                res.ShortDetail = "Độ dài mật khẩu phải tối thiểu 6 ký tự";
        //                return res;
        //            }
        //            employee.EmployeeLAPassword = newData.EmployeeLAPassword;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.EmployeeRoleId != null)
        //        {
        //            if (_context.employeeRoles.Find(newData.EmployeeRoleId) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại role employee có id là {newData.EmployeeRoleId}";
        //                return res;
        //            }
        //            employee.EmployeeRoleId = newData.EmployeeRoleId;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.WardCode != null)
        //        {
        //            if (_context.wards.Find(newData.WardCode) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại ward có id là {newData.WardCode}";
        //                return res;
        //            }
        //            employee.WardCode = newData.WardCode;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.DistrictCode != null)
        //        {
        //            if (_context.districts.Find(newData.DistrictCode) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại district có id là {newData.DistrictCode}";
        //                return res;
        //            }
        //            employee.DistrictCode = newData.DistrictCode;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.ProvinceCode != null)
        //        {
        //            if (_context.provinces.Find(newData.ProvinceCode) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại province có id là {newData.ProvinceCode}";
        //                return res;
        //            }
        //            employee.ProvinceCode = newData.ProvinceCode;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.GenderId != null)
        //        {
        //            if (_context.genders.Find(newData.GenderId) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại giới tính có id là {newData.GenderId}";
        //                return res;
        //            }
        //            employee.GenderId = newData.GenderId;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.NumberPhone != null)
        //        {
        //            if (newData.NumberPhone.Length < 8)
        //            {
        //                res.Status = EmployeeUpdateEnums.LENGTH_TOO_SHORT;
        //                res.ShortDetail = "Độ dài số điện thoại phải tối thiểu 8 ký tự";
        //                return res;
        //            }
        //            employee.NumberPhone = newData.NumberPhone;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.FacebookUrl != null)
        //        {
        //            employee.FacebookUrl = newData.FacebookUrl;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.SkyUrl != null)
        //        {
        //            employee.SkyUrl = newData.SkyUrl;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.EmployeeLAName != null)
        //        {
        //            employee.EmployeeLAName = newData.EmployeeLAName;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.EmployeeLABirthDay != null)
        //        {
        //            employee.EmployeeLABirthDay = newData.EmployeeLABirthDay;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }
        //        if (newData.EmployeeStatusId != null)
        //        {
        //            if (_context.employeeStatuses.Find(newData.EmployeeStatusId) == null)
        //            {
        //                res.Status = EmployeeUpdateEnums.NOTFOUND;
        //                res.ShortDetail = $"Không tồn tại employee status có id là ${newData.EmployeeStatusId}";
        //                return res;
        //            }
        //            employee.EmployeeStatusId = newData.EmployeeStatusId;
        //            _context.employeeLA.Update(employee);
        //            _context.SaveChanges();
        //        }

        //        transaction.Commit();

        //        res.Status = EmployeeUpdateEnums.SUCCESSFULLY;
        //        res.ShortDetail = "Sửa nhân viên thành công!";
        //        res.Data = employee;
        //        return res;
        //    }

        //}
    }
}
