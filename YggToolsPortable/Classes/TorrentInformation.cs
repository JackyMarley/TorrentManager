﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YggToolsPortable.Classes
{
    class TorrentInformation 
    {
        public string Title { get; set; }
        public int Completion { get; set; }
        public String DownSpeed { get; set; }
        public String UpSpeed { get; set; }
    }
}
