using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    public class Monster
    {
        public enum EmotionalState 
        {
            happy,
            sad,
            angery,
            bored
        }

        #region FIELDS

        private string _name;
        private int _age;
        private EmotionalState _Attitude;




        #endregion

        #region PROPERTIES

      public EmotionalState Attitude
        {
            get { return _Attitude; }
            set { _Attitude = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region CONSTUCTORS

        public Monster()
        {

        }

        #endregion



    }
}
