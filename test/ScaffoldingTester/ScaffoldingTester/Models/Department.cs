﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ScaffoldingTester.Models
{
    public partial class Department
    {
        public Guid DepartmentId { get; set; }
        public int ClusterKey { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public Guid? SupervisorId { get; set; }
        public string ExtendedName { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public byte[] Timestamp { get; set; }
    }
}