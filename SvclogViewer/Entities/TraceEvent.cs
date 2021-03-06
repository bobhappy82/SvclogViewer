﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SvclogViewer.Entities
{
    public class TraceEvent
    {
        public long PositionStart { get; set; }
        public long PositionEnd { get; set; }
        public DateTime TimeCreated { get; set; }
        public string Method { get; set; }
        public string Source { get; set; }
        public Guid ActivityID { get; set; }
        public string To { get; set; }

        public bool ContainsPosition(long position)
        {
            return position >= PositionStart && position <= PositionEnd;
        }
    }
}
