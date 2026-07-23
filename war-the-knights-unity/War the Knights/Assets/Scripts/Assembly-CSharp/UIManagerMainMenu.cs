using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManagerMainMenu : MonoBehaviour
{
	public CanvasGroup gameMenuCanvas;

	public CanvasGroup mainMenuCanvas;

	public CanvasGroup mapMenuCanvas;

	public CanvasGroup mapSettingsCanvas;

	public TMP_InputField ticketsConquestInputField;

	public TMP_InputField respawnTimeInputField;

	public TMP_InputField botCountInputField;

	public Slider botCountRatioSlider;

	public TextMeshProUGUI botCountTeam1;

	public TextMeshProUGUI botCountTeam2;

	public int ticketsConquest;

	public int respawnTime;

	public int botsTotal;

	public int botsTeam1;

	public int botsTeam2;

	public UIManagerOptionsMenu optionsMenu;

	public AudioMixer audioMixer;

	public AudioMixerSnapshot audioSnapshotDefault;

	public bool showOpeningMenu;

	public static UIManagerMainMenu Instance;

	public UIManagerSound uiSound;

	public Map[] dragonfieldMaps;

	public Color mapButtonColor;

	public Color mapButtonSelectedColor;

	public MapSelectionController mapSelectionController;

	public Image selectedMapIcon;

	public TextMeshProUGUI selectedMapNameText;

	public Map[] currentMapsShown;

	public int currentlySelectedMap;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	public void Rewarded(int index)
	{
	}

	public void ButtonRewarded(int index)
	{
	}

	public void OpenGameMenu(bool open)
	{
	}

	public void OpenMap(bool open)
	{
	}

	public void OpenUrl()
	{
	}

	public void SelectMapInSelection(int index)
	{
	}

	public void SetCurrentMap(int index)
	{
	}

	public void StartGame()
	{
	}

	public void SetTickets()
	{
	}

	public void SetRespawnTime()
	{
	}

	public void SetBotCount()
	{
	}

	public void SaveSettings()
	{
	}

	public void LoadSettings()
	{
	}

	public void SetConfigToDefault()
	{
	}

	public void OpenOptionsMenu(bool open)
	{
	}
}
