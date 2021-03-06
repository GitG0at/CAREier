﻿using CAREier.Localizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace CAREier.Interfaces {
    public interface IProduct {

        public string Name { get; }
        public LocalizedPrice Price { get; set; }
        public LocalizedWeight Weight { get; }
        public LocalizedDimensions Dimensions { get; }
        public List<string> Tags { get; set; }

    }
}