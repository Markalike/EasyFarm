﻿
/*///////////////////////////////////////////////////////////////////
<EasyFarm, general farming utility for FFXI.>
Copyright (C) <2013 - 2014>  <Zerolimits>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
*/
///////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EasyFarm.Classes
{
    /// <summary>
    /// Contains the data needed to filter out creatures.
    /// </summary>
    public class FilterInfo
    {
        public FilterInfo()
        {
            SetDefaults();
        }

        /// <summary>
        /// Sets the defaults settings for targeting creatures.
        /// </summary>
        private void SetDefaults()
        {
            this.AggroFilter = true;
            this.PartyFilter = true;
            this.UnclaimedFilter = true;

            this.IgnoredMobs = new ObservableCollection<string>();
            this.TargetedMobs = new ObservableCollection<string>();
        }
        
        /// <summary>
        /// Name of the mob to be attacked
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Name of the mob to be ignored
        /// </summary>
        public string IgnoredName { get; set; }

        /// <summary>
        /// Used to filter out aggroed mobs.
        /// </summary>
        public bool AggroFilter { get; set; }
        
        /// <summary>
        /// Used to filter out party claimed mobs.
        /// </summary>
        public bool PartyFilter { get; set; }

        /// <summary>
        /// Used to filter out unclaimed mobs.
        /// </summary>
        public bool UnclaimedFilter { get; set; }

        /// <summary>
        /// A list of mobs that we should ignore.
        /// </summary>
        public ObservableCollection<String> IgnoredMobs { get; set; }

        /// <summary>
        /// A list of mobs that we should only kill.
        /// </summary>
        public ObservableCollection<String> TargetedMobs { get; set; }        
    }
}