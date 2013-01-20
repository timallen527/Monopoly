﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Player : IPlayer
    {
        private Int32 location;
        private Boolean enabled;
        private Int32 cash;
        public String Name;

        public Player(String name)
        {
            location = 0;
            enabled = true;
            Name = name;
        }

        public Int32 Location
        {
            get { return location; }
            set { this.location = value; }
        }

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public Int32 Cash
        {
            get { return cash; }
            set { cash = value; }
        }
    }
}
