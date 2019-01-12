using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleDB
{
    class Elephant
    {
        private string id;
        private string name;
        private string description;
        private string photo;
        private string alternatePhoto;
        private DateTime dateAdded;
        private string location;
        private string price;
        private string source;
        private string type;
        private string origin;
        private string acquisition;
        private string dimensions;

        public Elephant() { }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
            }
        }

        public string AlternatePhoto
        {
            get
            {
                return alternatePhoto;
            }
            set
            {
                alternatePhoto = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return dateAdded;
            }
            set
            {
                dateAdded = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }

        public string Acquisition
        {
            get
            {
                return acquisition;
            }
            set
            {
                acquisition = value;
            }
        }

        public string Dimensions
        {
            get
            {
                return dimensions;
            }
            set
            {
                dimensions = value;
            }
        }
    
    }
}
