﻿using Newtonsoft.Json;
using System;

namespace GSA.UnliquidatedObligations.BusinessLayer.Data.Reporting
{
    public class ReportParameterDescription : IReportItemDescription
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("clrType")]
        public Type ClrType { get; set; }

        [JsonProperty("sqlParameterName")]
        public string SqlParameterName { get; set; }

        [JsonProperty("isHardcoded")]
        public bool IsHardcoded { get; set; }

        [JsonProperty("hardcodedValue")]
        public string HardCodedValue { get; set; }
    }
}
