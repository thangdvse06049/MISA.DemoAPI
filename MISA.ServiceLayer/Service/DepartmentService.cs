﻿using MISA.BusinessLayer.Interfaces;
using MISA.Common.Models;
using MISA.DataAccessLayer.interfaces;
using MISA.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BusinessLayer.Service
{
    /// <summary>
    /// Lớp Service của Department
    /// Author: DVTHANG(16/10/2020)
    /// </summary>
    public class DepartmentService : BaseService<Department>, IDepartmentService
    {
        #region declare
        IDepartmentRepository _departmentRepository;
        #endregion

        #region constructor
        public DepartmentService(IDepartmentRepository departmentRepository) : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        #endregion
    }
}
