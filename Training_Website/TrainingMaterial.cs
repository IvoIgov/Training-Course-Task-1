using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public abstract class TrainingMaterial
    {
        private string myGuid = null;
        private string textDescription = null;

        protected TrainingMaterial(string textDescription)
        {
            this.MyGuid = GenerateMyGuid();
            this.TextDescription = textDescription;
        }

        public string TextDescription
        {
            get
            {
                return this.textDescription;
            }
            private set
            {
                if (value.Length > 256)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTextDescriptionLength);
                }
                this.textDescription = value;
            }
        }

        public string MyGuid { get; set; } 

        public string GenerateMyGuid()
        {
            myGuid = Guid.NewGuid().ToString();
            return myGuid;
        }
    }
}
