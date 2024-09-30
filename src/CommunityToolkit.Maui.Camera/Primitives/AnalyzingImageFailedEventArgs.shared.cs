namespace CommunityToolkit.Maui.Views;

/// <summary>
/// Event args containing all contextual information related to a image analysis failure event.
/// </summary>
/// <remarks>
/// 
/// </remarks>
/// <param name="failureReason">A string containing the reason why the analysis attempt failed.</param>
public class AnalyzingImageFailedEventArgs(string failureReason) : EventArgs
{

	/// <summary>
	/// Gets the reason why the analysis attempt failed.
	/// </summary>
	public string FailureReason { get; } = failureReason;
}