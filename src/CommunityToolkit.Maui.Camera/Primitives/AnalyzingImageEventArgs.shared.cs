namespace CommunityToolkit.Maui.Views;

/// <summary>
/// Event args containing all contextual information related to image analysis event.
/// </summary>
/// <param name="imageData"></param>
/// <param name="width"></param>
/// <param name="height"></param>
/// <param name="rotationDegrees"></param>
public class AnalyzingImageEventArgs(byte[] imageData, int width, int height, int rotationDegrees) : EventArgs
{
	/// <summary>
	/// Image data
	/// </summary>
	public byte[] ImageData { get; } = imageData;

	/// <summary>
	/// Image width
	/// </summary>
	public int Width { get; } = width;

	/// <summary>
	/// Image height
	/// </summary>
	public int Height { get; } = height;

	/// <summary>
	/// Image rotation
	/// </summary>
	public int RotationDegrees { get; } = rotationDegrees;
}