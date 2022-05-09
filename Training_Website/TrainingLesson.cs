using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public class TrainingLesson : IVersionable, ICloneable
    {

        public string TypeOfLesson(string inputLesson)
        {
            string typeOfLesson = string.Empty;
            if (inputLesson.ToLower() == "videolesson")
            {
                typeOfLesson = (string)Enum.Parse(typeof(EnumLessonTypes), "VideoLesson");
            }
            if (inputLesson.ToLower() == "textlesson")
            {
                typeOfLesson = (string)Enum.Parse(typeof(EnumLessonTypes), "TextLesson");
            }

            return typeOfLesson;
        }

        public void AddVersion()
        {
            int[] version = { 0, 0, 0, 0, 0, 0, 0, 1 };
        }

        public void UpdateVersion(int[] version)
        {
            //insert logic here
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
