﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Client_Project.Model
{
    public class Hall
    {
        public int HallId
        {
            get { return HallId; }
            set { HallId = value; }
        }
        public int ShowTime
        {
            get { return ShowTime; }
            set { ShowTime = value; }
        }
        public int MovieId
        {
            get { return MovieId; }
            set { MovieId = value; }
        }
    }
}
