using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleDB
{
    class Elephant
    {
        String name;
        String description;
        String photo;
        String gender;
        DateTime dateAdded;
        String location;

        public Elephant() { }

        public String getName() { return name; }
        public void setName(String name)
        {
            this.name = name;
        }

        public String getDescription() { return description; }
        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getPhoto() { return photo; }
        public void setPhoto(String photo)
        {
            this.photo = photo;
        }

        public String getGender() { return gender; }
        public void setGender(String gender)
        {
            this.gender = gender;
        }

        public DateTime getDateAdded() { return dateAdded; }
        public void setDateAdded(DateTime dateAdded)
        {
            this.dateAdded = dateAdded;
        }

        public String getLocation() { return location; }
        public void setLocation(String location)
        {
            this.location = location;
        }
    }
}
