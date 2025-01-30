﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderGroundArchive_WPF.Models
{
    public class ReportModel
    {
        public int ReportId { get; set; }
        public string ReporterId { get; set; }
        public string ReportedId { get; set; }
        public string ReportMessage { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ReportTypeId { get; set; }
        public bool IsHandled { get; set; }
    }
}
