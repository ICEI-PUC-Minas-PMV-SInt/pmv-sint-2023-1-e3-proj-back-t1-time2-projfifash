﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_crud.Models {
    public class Departamentos {
        public int Id {
            get; set;
        }
        public string Name {
            get; set;
        }
    }
}
