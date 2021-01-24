using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Concrete;
using GameDemo.KodlamaIO.HW.Abstract;

namespace GameDemo.KodlamaIO.HW.Entities
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public int GameStock { get; set; }
        public bool IsOnSale { get; set; }
    }
}
