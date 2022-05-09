using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public class TrainingLesson : IVersionable, ICloneable
    {

        public string TypeOfLesson()
        {
            string typeOfLesson = string.Empty;
            return typeOfLesson;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
