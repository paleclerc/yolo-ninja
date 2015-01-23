
using UnityEditor;

static public class ConfigMenu 
{
	[MenuItem ("CustomMenu/Config/Create Audio Item")]
	static void CreateAudioItem()
	{
		MenuUtil.CreateAsset<AudioItem>();
	}

	[MenuItem ("CustomMenu/Config/Unique/Create Audio Config")]
	static void CreateAudioConfig () 
	{
		MenuUtil.CreateAsset<AudioConfig>();
	}
}
