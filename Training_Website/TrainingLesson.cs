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
            EnumLessonTypes lesson = 0;
            if (TrainingMaterials.OfType<VideoMaterial>().Any())
            {
                lesson = EnumLessonTypes.VideoLesson;
            }
            if (TrainingMaterials.OfType<TextMaterial>().Any())
            {
                lesson = EnumLessonTypes.TextLesson;
            }
            if (TrainingMaterials.OfType<NetworkResourceLink>().Any())
            {
                lesson = EnumLessonTypes.NetworkResourceLesson;
            }
            return $"Lesson type: {lesson}";
        }

        public void AddVersion()
        {
            int[] version = { 0, 0, 0, 0, 0, 0, 0, 1 };
        }

        public List<TrainingMaterial> TrainingMaterials { get; set; } =new List<TrainingMaterial>();

        public void UpdateVersion(int[] version)
        {
            //add logic here
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
