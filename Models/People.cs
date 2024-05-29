using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.Models
{
    public class People : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public class User
        {
            public int Id { get; set; }

            private string name;
            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
            private string age;

            public event PropertyChangedEventHandler? PropertyChanged;

            public string Age
            {
                get { return age; }
                set
                {
                    age = value;
                    OnPropertyChanged();
                }
            }

            private string city;
            public string City { get { return city; } set { city = value; OnPropertyChanged(); } }

            private string position;
            public string Position { get { return position; } set { position = value; OnPropertyChanged(); } }

            private string hobby;
            public string Hobby { get { return hobby; } set { position = value; OnPropertyChanged(); } }

            public User()
            {
                Id = 0;
            }

            public User(string sor)
            {
                string[] t = sor.Split(';');
                Name = t[0];
                //Age = t[1];
                City = t[2];
                Position = t[3];
                Hobby = t[4];
            }

            public override string? ToString()
            {
                return $"{Name}, neve a(z) {City} városban lakik, {Position}-ként dolgozik, {Age} éves, hobbija: {Hobby}.";
            }

            private void OnPropertyChanged([CallerMemberName] string name = null)
            {
                if (name != null && PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
