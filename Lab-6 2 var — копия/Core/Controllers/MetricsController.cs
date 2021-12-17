﻿using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;
using System.Linq;

namespace Core
{
    class MetricsController
    {
        private readonly UniversityContext universityContext;

        public MetricsController(UniversityContext context)
        {
            universityContext = context;
        }

        public int CountStudentsInGroup(int groupId)
        {
            return universityContext.Groups
                .Include(g => g.Students)
                .First(g => g.Id == groupId)
                .Students
                .Count;
        }

        public string GetCuratourName(int studentId)
        {
            var student = universityContext.Students
                .Include(s => s.Group)
                    .ThenInclude(g => g.Curator)
                .FirstOrDefault(student => student.Id == studentId);

            if (student == null)
            {
                throw new Exception("Student not found");
            }

            if (student.Group.Curator == null)
            {
                throw new Exception("Group does not have curator");
            }

            return student.Group.Curator.Name;
        }

        public double GetAverageAge(int curatorId)
        {
            var curator = universityContext.Curators
                .Include(c => c.Group)
                    .ThenInclude(g => g.Students)
                .FirstOrDefault(curator => curator.Id == curatorId);

            if (curator == null)
            {
                throw new Exception("Curator not found");
            }

            var students = curator.Group.Students;

            if (students.Count == 0)
            {
                throw new Exception("There are no students in group");
            }

            return students.Average(student => student.Age);
        }
    }
}
