﻿using Basketball.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball.Models
{
    public class TeamDetails
    {
        public int TeamId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string ConferenceName { get; set; }
        public string Record { get; set; }
        public List<PlayerList> Players { get; set; }
        public List<GameList> AllGames { get; set; }
        // public int Wins { get; set; }
        // public int Losses { get; set; }
        // public List<GameList> HomeGames { get; set; }
        // public List<GameList> AwayGames { get; set; }
    }
}
