﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewApp
{
    public  class Horses
    {
        public int Id { get; set; }


        public string Name { get; set; }

        public int SamuraiId { get; set; }

        public virtual Samurayi Samurai { get; set; }
    }
}
