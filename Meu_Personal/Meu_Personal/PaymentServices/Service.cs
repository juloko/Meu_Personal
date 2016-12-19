using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.PaymentServices
{
    class Service
    {
        private String idGym;
        private String idService;
        private String nameService;
        private String description;
        private double valueMonth;
        private String linkPagSeguro;

        

        public Service(String idGym, String nameService, String description, double valueMonth, String linkPagSeguro)
        {
            gerateIdService();
            this.idGym = idGym;
            this.nameService = nameService;
            this.description = description;
        }

        public Service(String idGym, String description, String linkPagSeguro)
        {
            gerateIdService();
        }

        public Service(String idGym, String linkPagSeguro)
        {
            gerateIdService();
        }

        private void gerateIdService()
        {
            idService = Guid.NewGuid().ToString();
        }

        public string IdGym
        {
            get
            {
                return idGym;
            }

            set
            {
                idGym = value;
            }
        }

        public string IdService
        {
            get
            {
                return idService;
            }

            set
            {
                idService = value;
            }
        }

        public string NameService
        {
            get
            {
                return nameService;
            }

            set
            {
                nameService = value;
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

        public double ValueMonth
        {
            get
            {
                return valueMonth;
            }

            set
            {
                valueMonth = value;
            }
        }

        public string LinkPagSeguro
        {
            get
            {
                return linkPagSeguro;
            }

            set
            {
                linkPagSeguro = value;
            }
        }
    }
}
