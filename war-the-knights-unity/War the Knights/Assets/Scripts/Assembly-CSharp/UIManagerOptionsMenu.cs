using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManagerOptionsMenu : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public CanvasGroup canvas;

		internal void _003COpenOptionsMenu_003Eb__1()
		{
		}
	}

	public bool isOpen;

	public bool isInGame;

	public CanvasGroup optionsCanvas;

	public CanvasGroup previousMenuCanvas;

	public TextMeshProUGUI settingHeader;

	public TextMeshProUGUI settingDescription;

	public CanvasGroup[] settingsCanvases;

	private int currentSettings;

	public AudioMixer audioMixer;

	public UIManagerSound uiSound;

	private static ES3Settings settingsCache;

	private ES3File currentSettingsFile;

	public Slider slider_Controls_MouseSensitivity;

	public TextMeshProUGUI slider_Controls_MouseSensitivity_Text;

	public Slider slider_Controls_MouseSensitivityVehicles;

	public TextMeshProUGUI slider_Controls_MouseSensitivityVehicles_Text;

	public Slider slider_Audio_AllVolume;

	public TextMeshProUGUI slider_Audio_AllVolume_Text;

	private void Awake()
	{
	}

	public void OpenOptionsMenu(bool open)
	{
	}

	public void SaveCurrentSettings()
	{
	}

	public void LoadCurrentSettings()
	{
	}

	public void ResetCurrentSettings()
	{
	}

	public void OpenSettings(int settings)
	{
	}

	public void ShowSettingDescription(ref string description)
	{
	}

	public void Settings_Controls_MouseSensitivity(bool save)
	{
	}

	public void Slider_Update_Controls_MouseSensitivity()
	{
	}

	public void Settings_Controls_MouseSensitivityVehicles(bool save)
	{
	}

	public void Slider_Update_Controls_MouseSensitivityVehicles()
	{
	}

	public void Settings_Audio_AllVolume(bool save)
	{
	}

	public void Slider_Update_Audio_AllVolume()
	{
	}

	private void _003COpenOptionsMenu_003Eb__19_0()
	{
	}
}
