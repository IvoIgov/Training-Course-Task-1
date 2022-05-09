using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{

    public class VideoMaterial : TrainingMaterial, IVersionable
    {
        private string myGuid = string.Empty;
        private string videoContentURI = string.Empty;
        private string splashScreenURI = string.Empty;
        private int videoFormat;


        public VideoMaterial(string textDescription, string videoContentURI, string spashScreenURI, int videoFormat) : base(textDescription)
        {
            myGuid = base.MyGuid;
            this.VideoContentURI = videoContentURI;
            this.SplashScreenURI = splashScreenURI;
            this.VideoFormat = videoFormat;
        }

        public string VideoContentURI
        {
            get
            {
                return this.videoContentURI;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.EmptyVideoURI);
                }
                this.videoContentURI = value;
            }
        }

        public string SplashScreenURI { get; set; }
        public int VideoFormat { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Video material description: ");
            sb.Append(base.TextDescription);
            return sb.ToString();
        }
    }
}
