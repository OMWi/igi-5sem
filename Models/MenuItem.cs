﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953505_Krasovskiy.Models
{
    public class MenuItem
    {
        public bool IsPage { get; set; } = false;
        public string Area { get; set; } = "";
        public string Action { get; set; } = "";
        public string Controller { get; set; } = "";
        public string Page { get; set; } = "";
        public string Active { get; set; } = "";
        public string Text { get; set; } = "";
    }
}
