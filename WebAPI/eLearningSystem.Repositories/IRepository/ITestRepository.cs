﻿using eLearningSystem.Data.Model;
using eLearningSystem.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearningSystem.Repositories.IRepository
{
    public interface ITestRepository : IGenericRepository<Test>
    {
        Test GetTest(int courseId, int chapterId);
    }
}
