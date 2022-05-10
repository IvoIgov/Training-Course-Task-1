using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public abstract class TrainingMaterial
    {
        private string? myGuid = null;
        private string? textDescription = null;

        protected TrainingMaterial(string? textDescription = null)
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
                if (value.Length > 255)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTextDescriptionLength);
                }
                this.textDescription = value;
            }
        }

        public override bool Equals(object obj)
        {
            var material = (TrainingMaterial)obj;
            if (obj is TrainingMaterial)
            {
                
            }
            else if (obj is VideoMaterial)
            {
                material = (VideoMaterial)obj;
            }
            else if (obj is TextMaterial)
            {
                material = (TextMaterial)obj;
            }
            else if (obj is NetworkResourceLink)
            {
                material = (NetworkResourceLink)obj;
            }
            else if (obj is TrainingLesson)
            {
                var trainingLesson = (TrainingLesson)obj;
                if (this.myGuid == material.MyGuid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (this.myGuid == material.MyGuid)
            {
                return true;
            }
            else
            {
                return false;
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
