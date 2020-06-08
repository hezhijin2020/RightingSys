using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.WinForm.AppPublic.AutoService
{
    public class FileUnit
    {
        public string FileName { get; set; }
        public long FileSize { get; set; } = 0;
        public string FileVersion { get; set; } = "1.0.1";
        public string LastTime { get; set; } = "2020-01-01";
        public bool IsFlag { get; set; } = true;
       
    }
}
