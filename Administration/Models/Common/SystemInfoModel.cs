﻿using System;
using System.Collections.Generic;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.Common
{
    public partial class SystemInfoModel : BaseNopModel
    {
        public SystemInfoModel()
        {
            this.LoadedAssemblies = new List<LoadedAssembly>();
        }

        [NopResourceDisplayName("Admin.System.SystemInfo.ASPNETInfo")]
        public string AspNetInfo { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.IsFullTrust")]
        public string IsFullTrust { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.NopVersion")]
        public string NopVersion { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.OperatingSystem")]
        public string OperatingSystem { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.ServerLocalTime")]
        public DateTime ServerLocalTime { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.ServerTimeZone")]
        public string ServerTimeZone { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.UTCTime")]
        public DateTime UtcTime { get; set; }

        [NopResourceDisplayName("Admin.System.SystemInfo.LoadedAssemblies")]
        public IList<LoadedAssembly> LoadedAssemblies { get; set; }

        public partial class LoadedAssembly : BaseNopModel
        {
            public string FullName { get; set; }
            public string Location { get; set; }
        }

    }
}