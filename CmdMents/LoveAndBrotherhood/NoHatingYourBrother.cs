﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdMents.LoveAndBrotherhood
{
    class NoHatingYourBrother : LoveNeighborAsSelf
    {
        public NoHatingYourBrother()
        {
            base.Book = CommandmentBook.Leviticus;
            base.CanBeCarriedOutToday = true;
            base.Chapter = 19;
            base.CommandmentType = CommandmentType.Negative;
            base.FollowedByChristians = true;
            base.FollowedByMessianics = true;
            base.FollowedByObservantJews = true;
            base.Number = 15;
            base.ShortSummary = "No hating others.";
            base.Text = "Do not hate your brother in your heart.";
            base.Verse = 17;
        }
    }
}
