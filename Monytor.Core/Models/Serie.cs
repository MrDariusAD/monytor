﻿using System;

namespace Monytor.Core.Models {
    public class Serie {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string Group { get; set; }
        public DateTime Time { get; set; }
        public string Value { get; set; }

        public static string CreateId(string tag, string group, DateTime time) {
            return $"{nameof(Serie)}/{group}/{tag}/{time.ToString("yyyy-MM-ddThhmmssfff")}";
        }
    }
}