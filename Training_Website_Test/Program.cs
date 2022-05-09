using Training_Website;

var videoMaterial = new VideoMaterial("description", "www.video.com", "splash.com", EnumVideoFormats.Avi);
Console.WriteLine(videoMaterial.ToString());
var trainingLesson = new TrainingLesson();
trainingLesson.TrainingMaterials.Add(videoMaterial);
string lesson = trainingLesson.TypeOfLesson();
Console.WriteLine(lesson);
