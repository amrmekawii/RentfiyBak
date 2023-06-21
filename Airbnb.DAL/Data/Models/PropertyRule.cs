﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAl;

public class PropertyRule
{
    public int RuleId { get; set; }
    public Rule Rule { get; set; } = new();
    public int PropertyId { get; set; }
    public Property Property { get; set; } = new();
}