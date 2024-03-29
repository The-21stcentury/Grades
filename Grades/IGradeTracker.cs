﻿using System.IO;

namespace Grades
{
    internal interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter doc);
        string Name { get; set; }
    }
}