
namespace homework8
{
    internal abstract class Employee
    {
        #region Fields
        string _Name;
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        #endregion
    }
}
