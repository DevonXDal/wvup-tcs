﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tcs_service.Models.ViewModels;

namespace tcs_service.Repos.Interfaces
{
    public interface IReportsRepo 
    {
        Task<List<ReportCountViewModel>> WeeklyVisits(DateTime startWeek, DateTime endWeek);
    }
}