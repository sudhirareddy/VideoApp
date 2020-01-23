using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMgtSystem
{
    enum TypeOfGenre
    {
        fiction,
        nonfiction,
        kids,
        fantasy,
        thriller
    }
    class Movie
    {
        #region properties
        public int MovieId { get; private set; }
        public string MovieName { get; private set; }
        public string Director { get; private set; }

        public TypeOfGenre GenreType { get;set; }
        public string Price { get; private set; }
        public string Availability{ get; private set; }

        public DateTime DateReleased { get; private set; }
        #endregion

        #region Methods
        public void AddM0vie()
        {

        }
        public void RemoveMovie()
        {

        }
        public void SearchMovie()
        {

        }
        #endregion

    }
}
