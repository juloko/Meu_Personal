using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.WorkoutServices
{
    class Exercise
    {
        private String name;
        private String muscleTarget;
        private String descricao;

        public Exercise(String name, String muscleTarget, String descricao)
        {
            this.name = name;
            this.muscleTarget = muscleTarget;
            this.Descricao = descricao;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String nName)
        {
            name = nName;
        }
        public string MuscleTarget
        {
            get
            {
                return muscleTarget;
            }

            set
            {
                muscleTarget = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }
    }
}
