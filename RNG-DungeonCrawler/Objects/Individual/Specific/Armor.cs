﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG_DungeonCrawler.Objects.Individual.Specific
{
    class Armor
    {
        internal int dropChance, def;
        internal string name;

        public Armor(string aName, int aDef, int aChance)
        {
            name = aName;
            def = aDef;
            dropChance = aChance;
        }
    }
}
