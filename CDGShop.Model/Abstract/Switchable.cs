﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Model.Abstract
{
   public abstract class Switchable : ISwitchable
    {
        public bool Status { set; get; }
    }
}
