using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.UserServices
{
    class Gym : User
    {
        private String cnpj;
        private String name;
        private List<Manager> managers;
        private List<Trainer> trainers;
        private List<Customer> clients;

        public Gym(String username, String password, String Email, String Cnpj, String Name) : base(username, password, Email)
        {
            this.cnpj = Cnpj;
            this.name = Name;
        }

        public void addNewTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
        }

        public void rmvTrainerByName(String trainerName)
        {
            foreach(Trainer i in trainers)
            {
                if(i.getUsername().ToLower() == trainerName.ToLower())
                {
                    trainers.Remove(i);
                }
            }
        }
        public void addNewManager(Manager manager)
        {
            managers.Add(manager);
        }

        public void rmvManagerByName(String managerName)
        {
            foreach (Manager i in managers)
            {
                if (i.getUsername().ToLower() == managerName.ToLower())
                {
                    managers.Remove(i);
                }
            }
        }

        public string Cnpj
        {
            get
            {
                return Cnpj;
            }

            set
            {
                Cnpj = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public List<Manager> Managers
        {
            get
            {
                return managers;
            }

            set
            {
                managers = value;
            }
        }

        public List<Trainer> Trainers
        {
            get
            {
                return trainers;
            }

            set
            {
                trainers = value;
            }
        }

        public List<Customer> Clients
        {
            get
            {
                return clients;
            }

            set
            {
                clients = value;
            }
        }
    }
}
