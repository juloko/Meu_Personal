using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.AccountServices
{
    class Profile
    {
        private String name;
        private String description;
        private String level;
        private int age;
        private long id;

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

        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public long Id
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

        public long Id1
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

        public Profile(String name, String description, String level, int age)
        {
            this.name = name;
            this.description = description;
            this.level = level;
            this.age = age;
        }
    }
}
