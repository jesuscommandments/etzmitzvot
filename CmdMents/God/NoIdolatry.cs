﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdMents.God
{
    class NoIdolatry : NoOtherGods
    {
        public NoIdolatry()
        {
            base.Book = CommandmentBook.Leviticus;
            base.CanBeCarriedOutToday = true;
            base.Chapter = 19;
            base.CommandmentType = CommandmentType.Negative;
            base.FollowedByChristians = CommandmentObedience.Obeyed;
            base.FollowedByMessianics = CommandmentObedience.Obeyed;
            base.FollowedByObservantJews = CommandmentObedience.Obeyed;
            base.Number = 24;
            base.ShortSummary = "No idols.";
            base.Text = "Do not turn to idols or make gods of cast metal for yourselves. I am the LORD your God.";
            base.Verse = 4;
        }
    }
}
