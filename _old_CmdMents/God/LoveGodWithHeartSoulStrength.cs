﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdMents.God
{
    class LoveGodWithHeartSoulStrength : CommandmentBase
    {
        public LoveGodWithHeartSoulStrength()
        {
            base.AlternateText = null;
            base.Book = CommandmentBook.Deuteronomy;
            base.CanBeCarriedOutToday = true;
            base.CanBeCarriedOutOnlyInIsrael = false;
            base.Chapter = 6;
            base.CommandmentType = CommandmentType.Positive;
            base.FollowedByChristians = CommandmentObedience.Attempted;
            base.FollowedByMessianics = CommandmentObedience.Attempted;
            base.FollowedByObservantJews = CommandmentObedience.Attempted;
            base.Number = 4;
            base.ShortSummary = "Love God with all your being.";
            base.Text = "Love the LORD your God with all your heart and with all your soul and with all your strength.";
            base.Verse = 5;
        }
    }
}
