using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public class TrainingLesson : IVersionable, ICloneable
    {
        private string? myGuid = null;
        private int[] version = new int[] { 0, 0, 0, 0, 0, 0, 0, 1 };
        public int[] Version { get; set; }
        public string MyGuid { get; set; }
        public string GenerateMyGuid()
        {
            MyGuid = Guid.NewGuid().ToString();
            return MyGuid;
        }
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

        public List<TrainingMaterial> TrainingMaterials { get; set; } = new List<TrainingMaterial>();

        public void UpdateVersion(int[] version)
        {
            Version = version;
        }

        public override bool Equals(object? obj1)
        {
            return true;
        }

        public object Clone()
        {
            TrainingLesson newLesson = (TrainingLesson)this.MemberwiseClone();
            newLesson.MyGuid = (string)this.MyGuid.Clone();

            return newLesson;
        }
    }
}
