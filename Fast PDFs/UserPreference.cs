using System;

public class UserPreference
{
    public string ChosenFileName { get; set; }
    public string HeaderText { get; set; }
    public string ContentText { get; set; }
    public string ImageFilePath { get; set; }

    public UserPreference(string fileName, string headerText, string contentText, string imageFilePath)
	{
        ChosenFileName = fileName;
        HeaderText = headerText;
        ContentText = contentText;
        ImageFilePath = imageFilePath;
	}
}
