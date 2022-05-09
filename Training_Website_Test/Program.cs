using Training_Website;

//2. Return type of training
var videoMaterial = new VideoMaterial("description", "www.video.com", "splash.com", EnumVideoFormats.Avi);
Console.WriteLine(videoMaterial.ToString());
var trainingLesson = new TrainingLesson();
trainingLesson.TrainingMaterials.Add(videoMaterial);
string lesson = trainingLesson.TypeOfLesson();
Console.WriteLine(lesson);

Console.WriteLine("--------------------------------------");

//3. In all created classes the ToString() method must return a text description of the entity (the value of the corresponding property).
Console.WriteLine(videoMaterial.ToString());

Console.WriteLine("--------------------------------------");

//5. Override the Equals() method of entity. Two entities are equal if their unique identifiers match. 
TrainingLesson lesson1 = new TrainingLesson();
var lesson1Guid = lesson1.GenerateMyGuid();
TrainingLesson lesson2 = new TrainingLesson();
var lesson2Guid = lesson2.GenerateMyGuid();
Console.WriteLine($"Lesson1 GUID is: {lesson1Guid}. Lesson 2 GUID is {lesson2Guid}. Equal -> {lesson1Guid.Equals(lesson2Guid)}");

TrainingLesson lesson1Clone = (TrainingLesson) lesson1.Clone();
var lesson1CloneGuid = lesson1Clone.MyGuid;
Console.WriteLine($"Lesson1 GUID is: {lesson1Guid}. Lesson 1 Cloned GUID is {lesson1CloneGuid}. Equal -> {lesson1Guid.Equals(lesson1CloneGuid)}");


//6. The training lesson and the video material (only these) must have a version (an array of exactly eight bytes).
//Create an IVersionable interface implemented by these entities that has methods for reading and setting the version.
int[] newVersion = Console.ReadLine().Split().Select(int.Parse).ToArray();
videoMaterial.UpdateVersion(newVersion);
Console.WriteLine($"The new version is: {String.Join(" ", videoMaterial.Version)}");

//7. Implement the standard ICloneable interface in the class for the training lesson. Warning: cloning should be deep, not surface.

