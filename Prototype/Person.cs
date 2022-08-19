using System.Text;

namespace Prototype
{
    internal class Person
    {
        private int _age;
        private DateTime _birthDate;
        private string _name;
        private IdInfo _idInfo;

        public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
        {
            _age = age;
            _birthDate = birthDate;
            _name = name;
            _idInfo = idInfo;
        }

        public int Age { get { return _age; } set { _age = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public IdInfo IdInfo { get { return _idInfo; } set { _idInfo = value; } }

        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(_idInfo.IdNumber);
            clone.Name = new StringBuilder(_name).ToString();
            return clone;
        }
    }

    internal class IdInfo
    {
        private int _idNumber;
        public IdInfo(int idNumber)
        {
            _idNumber = idNumber;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
    }
}
