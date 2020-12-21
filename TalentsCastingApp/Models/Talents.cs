using System;
using System.Collections.Generic;

namespace TalentsCastingApp.Models
{
    public class Talents
    {
        public string Name         { get; set; }
        public string Picture      { get; set; }
        public string Rating       { get; set; }
        public string RatingNumber { get; set; }
        public string Location     { get; set; }
        public string Age          { get; set; }
        public List<Skills> skills { get; set; }
    }
}
