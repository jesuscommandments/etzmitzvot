﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdMents.God
{
    class ClingToGod : FearGod
    {
        public ClingToGod()
        {
            base.Book = CommandmentBook.Deuteronomy;
            base.CanBeCarriedOutToday = true;
            base.Chapter = 10;
            base.CommandmentType = CommandmentType.Positive;
            base.FollowedByChristians = true;
            base.FollowedByMessianics = true;
            base.FollowedByObservantJews = true;
            base.Number = 13;
            base.ShortSummary = "Cling to God and serve him.";
            base.Text = "Fear the LORD your God and serve him. Hold fast to him and take your oaths in his name.";
            base.Verse = 20;
        }
    }
}