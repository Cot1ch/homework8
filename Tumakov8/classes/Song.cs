using System;

namespace Tumakov8
{
    internal class Song
    {
        #region Fields
        private string _Name;
        private string _Author;
        private Song _Previous;
        #endregion

        #region Constructors
        public Song(string name, string author)
        {
            _Author = author;
            _Name = name;
            _Previous = null;
        }
        public Song(string name, string author, Song previous)
        {
            _Name = name;
            _Author = author;
            _Previous = previous;
        }

        public Song() 
        {
            _Name = "Храп Семёна";
            _Author = "Семён Осипов";
            _Previous = null;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public Song Previous
        {
            get { return _Previous; }
            set { _Previous = value; }
        }

        public string Title()
        {
            return Name + " - " + Author;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Сравнивает 2 песни, если это возможно.
        /// </summary>
        /// <returns>Значение типа bool</returns>
        public override bool Equals(object d)
        {
            Song song2 = d as Song;
            if (song2 != null)
            {
                return song2.Name == Name && song2.Author == Author;
            }
            return false;
        }
        #endregion
    }
}
