using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass268_0
	{
		public int x2;

		public UIManager _003C_003E4__this;

		internal void _003CSetupCapturePointUI_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass268_1
	{
		public int x;

		public UIManager _003C_003E4__this;

		internal void _003CSetupCapturePointUI_003Eb__1()
		{
		}
	}

	private sealed class _003CShowEndScreen_003Ed__257 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		public bool victory;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowEndScreen_003Ed__257(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CShowEndScreenButContinuePlaying_003Ed__256 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		public bool victory;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowEndScreenButContinuePlaying_003Ed__256(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CSpawnAtStartPointThenOpenEquipmentMenu_003Ed__258 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CapturePoint spawnPoint;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSpawnAtStartPointThenOpenEquipmentMenu_003Ed__258(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CTimerFullscreenShow_003Ed__216 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTimerFullscreenShow_003Ed__216(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Camera firstPersonCam;

	public AudioListener currentAudioListener;

	public AudioListener firstPersonAudioListener;

	public AudioListener thirdPersonCamAudioListener;

	public AudioListener spawnCamAudioListener;

	public Camera currentCamera;

	public Transform currentCameraTransform;

	public Vector3 currentCameraPositionCached;

	public CanvasGroup blackscreenCanvas;

	public CanvasGroup spawnMenuCanvas;

	public CanvasGroup loadoutCanvas;

	public CanvasGroup spawnPointCanvas;

	public CanvasGroup ticketsCanvas;

	public Button startSpawnConfirmButton;

	public TextMeshProUGUI spawnTimerText;

	public CanvasGroup winScreenCanvas;

	public UIFadeDirectional winScreenFade;

	public CanvasGroup winScreenWinTextCanvas;

	public CanvasGroup winScreenLossTextCanvas;

	public CanvasGroup winScreenPointsCanvas;

	public CanvasGroup winScreenMapSelectCanvas;

	public CanvasGroup winScreenOtherButtonsCanvas;

	public TextMeshProUGUI winScreenPointsText;

	public CanvasGroup killFeedCancas;

	public Map[] dragonfieldMaps;

	public Image mapImage;

	public Image mapImage2;

	public TextMeshProUGUI mapText;

	public TextMeshProUGUI mapText2;

	private int mapNumScene;

	private int mapNumScene2;

	private bool winScreen;

	public CanvasGroup killcamCanvas;

	public CanvasGroup respawnInputTip;

	public RawImage killcamImage;

	public EnemyKillcamRenderer killcamRenderer;

	public TextMeshProUGUI killcamName;

	public UIFadeDirectional killcamNameFade;

	public TextMeshProUGUI killcamHealthCount;

	public Image killcamHealthbar;

	public Image killcamBlood1;

	public Image killcamBlood2;

	public Color killcamBloodColorEnemies1;

	public Color killcamBloodColorEnemies2;

	public Color killcamBloodColorAllies1;

	public Color killcamBloodColorAllies2;

	public GameObject killcamHealthParent;

	public CanvasGroup timerFullscreenShow;

	public bool isSpawnAllowed;

	private bool _activeCoroutineFullscreenShow;

	public CanvasGroup canvasPause;

	public CanvasGroup canvasHUD;

	public Button redeployButton;

	public CanvasGroup rifleScope;

	public CanvasGroup rifleScope2;

	public TextMeshProUGUI healthText;

	public Image[] healthBars;

	public Image healthBar;

	public GridLayoutGroup healthBarParent;

	public GameObject healthBarPrefab;

	public CanvasGroup healthBarFlashHeal;

	public CanvasGroup healthBarFlashDamage;

	public CanvasGroup healthBarDangerLoop;

	public Color healthColorDanger;

	public Color healthColorHealthy;

	public Color healthEdgeColorDanger;

	public Color healthEdgeColorHealthy;

	public CanvasGroup redScreenCanvasGroup;

	public KillFeed killFeed;

	public HorizontalLayoutGroup capturePointsParent;

	public Transform capturePointsWorldParent;

	public RectTransform capturePointPrefab;

	public RectTransform capturePointWorldPrefab;

	public RectTransform basePointWorldPrefab;

	public List<Image> capturePointImages;

	public List<Image> capturePointImagesWorld;

	public List<CanvasGroup> capturePointCanvasGroupsWorld;

	public List<CanvasGroup> teamBasePointsWorld;

	public Image currentPointImage;

	public TextMeshProUGUI currentPointText;

	public Color colorAllies;

	public Color colorAlliesNotification;

	public Color colorEnemy;

	public Color colorEnemyNotification;

	public Color colorNeutral;

	public Color colorAlliesCrestBackground;

	public Color colorEnemyCrestBackground;

	public Sprite iconAllies;

	public Sprite iconAlliesBase;

	public Sprite iconAlliesBaseSelected;

	public Sprite iconEnemy;

	public Sprite iconEnemyBase;

	public Sprite iconEnemyBaseSelected;

	public Sprite iconNeutral;

	public Sprite crestAllies;

	public Sprite crestEnemy;

	public CanvasGroup hudPointCanvas;

	public CanvasGroup hudAllyRatioCanvas;

	public Image hudPointImage;

	public Image hudAllyRatioImage;

	public Image hudEnemyRatioImage;

	public int pointToShowOnHud;

	public Image playerTickets;

	public Image playerTicketsFlash;

	public CanvasGroup playerTicketsFlashCanvas;

	public TextMeshProUGUI playerTicketsText;

	public Image enemyTickets;

	public Image enemyTicketsFlash;

	public CanvasGroup enemyTicketsFlashCanvas;

	public TextMeshProUGUI enemyTicketsText;

	public AnimationCurve openingCameraMoveCurve;

	public AnimationCurve spawnCameraMoveCurve;

	public Image spawnPointSelection;

	public CanvasGroup spawnPointSelectionCanvas;

	public CanvasGroup spawnPointSelectionLockInCanvas;

	public Button spawnButton;

	public RectTransform spawnButtonRectTransform;

	public int selectedSpawnPoint;

	public CanvasGroup titleCardCanvas;

	public UIFadeDirectional titleCardFade;

	public CanvasGroup titleCardGameModeCanvas;

	public TextMeshProUGUI titleCardMapNameText;

	public TextMeshProUGUI titleGamemodeNameText;

	public CanvasGroup spawnSideChooseMenuCanvas;

	public Image spawnSideTeam1;

	public Image spawnSideTeam2;

	public Transform spawnSideTeam1Transform;

	public Image spawnSideTeam1Crest;

	public Image spawnFrameTeam1;

	public Image spawnFrameTeam2;

	public Image spawnSideTeam1CrestBackground;

	public Transform spawnSideTeam2Transform;

	public Image spawnSideTeam2Crest;

	public Image spawnSideTeam2CrestBackground;

	public TextMeshProUGUI spawnSide1Name;

	public TextMeshProUGUI spawnSide2Name;

	public Color colorTeam1;

	public Color colorTeam2;

	public CanvasGroup inventoryCanvas;

	public int currentSlot;

	public TextMeshProUGUI headerText;

	public bool inventoryOpen;

	public Transform inventoryItemPrefab;

	public RectTransform inventoryItemParent;

	public Image selectedItemIcon;

	public TextMeshProUGUI selectedItemNameText;

	public TextMeshProUGUI selectedItemCategoryText;

	public TextMeshProUGUI selectedItemDescriptionText;

	public CanvasGroup selectedItemDescriptionCanvas;

	public UIFadeDirectional selectedItemDescriptionFade;

	private Weapon[] currentWeaponsShown;

	public Image[] equipSlotImages;

	public TextMeshProUGUI[] equipSlotItemNames;

	public CanvasGroup buttonMapCanvas;

	public RectTransform buttonMap;

	private float lastTimeSpawnPointClicked;

	public LoadoutItemController loadoutItemController;

	public TextMeshProUGUI gadgetName;

	public CanvasGroup placementCanvas;

	public int currentCategory;

	public Image[] categoryButtons;

	public Color categoryButtonColorEquipped;

	public Color categoryButtonColor;

	public Image[] equippedItemSlotBackgrounds;

	public Sprite itemBarSlotSpriteEquipped;

	public Sprite itemBarSlotSprite;

	public Color itemButton;

	public Color itemButtonDisabled;

	public Color itemButtonEquipped;

	public Vector3 equippedWeaponIconPos;

	public Vector3 unequippedWeaponIconPos;

	public Color gadgetChargingColor;

	public RectTransform[] equipSlotsHud;

	public Image[] equipSlotItemImagesHud;

	public CanvasGroup[] equipSlotSelectionBorders;

	public Image[] hudItems;

	public Image[] equipSlotChargeHud;

	public Image[] gadgetSlotHud;

	public CanvasGroup[] equipSlotChargeBackgroundHud;

	public TextMeshProUGUI[] equipSlotAmmoCountHud;

	public RectTransform[] equipSlotAmmoHud;

	public TextMeshProUGUI equippedName;

	public CanvasGroup equippedNameCanvas;

	public CanvasGroup throwableCanvas;

	public CanvasGroup hudEquipmentCanvas;

	public UIManagerOptionsMenu optionsMenu;

	public UIManagerSound uiSound;

	public DamageIndicator damageIndicator;

	private bool hudToggledOff;

	public Canvas canvasHud;

	public Canvas canvasCrosshair;

	public Canvas canvasTickets;

	public Canvas canvasHitmarker;

	public Canvas canvasKillfeed;

	public Canvas canvasDamageIndicator;

	public static UIManager Instance;

	public ObjectiveNotifications objectiveNotifications;

	public CanvasGroup ammoResupplyIndicatorCanvas;

	private static readonly Vector3 ammoIndicatorStartPos;

	public float healthUIUpdateSpeed;

	private Tween healthBarDangerLoopTween;

	private Tween healthBarDangerStopTween;

	private Vector3 healthBarEdgeRotation;

	private static readonly WaitForSeconds EndScreenDuration;

	private static readonly WaitForSeconds WaitForEndScreenShotFirstPartTimer;

	private static readonly WaitForSeconds WaitForEndScreenShotSecondPartTimer;

	private static readonly WaitForSeconds WaitForEndScreenShotThirdPartTimer;

	private bool capturePointHudSetup;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Rewarded(int index)
	{
	}

	public void ButtonRewarded(int index)
	{
	}

	public void ObjectiveChange(CapturePoint point, bool captured)
	{
	}

	public void ShowKillcam(HealthBase defeatedBy)
	{
	}

	private IEnumerator TimerFullscreenShow()
	{
		return null;
	}

	public void ShowThrowableAmmo(bool use)
	{
	}

	public void ToggleGadgetPlacementUI(string weaponName = null)
	{
	}

	public void ChangeGadgetSlot(bool gadget1, bool show, bool equip)
	{
	}

	public void SetEquippedName(int slot)
	{
	}

	public void SetEquipmentSlotInstantlyAtStart(int slot)
	{
	}

	public void SetGadgetCharge(bool gadget1)
	{
	}

	public void SetThrowableCharge()
	{
	}

	public void ShowAmmoResupplyIndicator()
	{
	}

	public void UpdateAmmoUIPartially()
	{
	}

	public void SetWeaponAmmo(int weapon)
	{
	}

	public void SetupHealthUI()
	{
	}

	public void ShowHealOrDamageUI(bool damage)
	{
	}

	public void UpdateHealthUI(bool damage)
	{
	}

	public void ShowScopes(WeaponScopes scope)
	{
	}

	public void HideScopes()
	{
	}

	public void ButtonUnpauseGame()
	{
	}

	public void ButtonRedeploy()
	{
	}

	public void ButtonOptions()
	{
	}

	public void ButtonRestartMatch()
	{
	}

	public void ButtonMainMenu()
	{
	}

	public void HideInventoryButtonPressed()
	{
	}

	public void ShowInventory(int slot)
	{
	}

	public void ShowInventorySlotSelectSprite(int slot)
	{
	}

	public void ShowInventoryCategory(int category)
	{
	}

	public void HideInventory()
	{
	}

	public void ShowItemInSelection(int index)
	{
	}

	public void HideItemInSelection()
	{
	}

	public void EquipItemInSelection(int index)
	{
	}

	public void SetItemIcons(int index)
	{
	}

	public void SetRewardReceiveds()
	{
	}

	public void QuickStartShowHUD()
	{
	}

	public void ShowTitleCard()
	{
	}

	public void ShowMapSideChooseMenu()
	{
	}

	public void SelectSide(bool side1)
	{
	}

	public void SelectSideQuickStart(bool side1)
	{
	}

	public void SelectSideClick(bool side1)
	{
	}

	private void GetImageMap()
	{
	}

	public void СhangingMap(int num)
	{
	}

	public void ShowEndСhangingMap()
	{
	}

	public IEnumerator ShowEndScreenButContinuePlaying(bool victory)
	{
		return null;
	}

	public IEnumerator ShowEndScreen(bool victory)
	{
		return null;
	}

	private IEnumerator SpawnAtStartPointThenOpenEquipmentMenu(CapturePoint spawnPoint)
	{
		return null;
	}

	public void EquipmentShowButtons()
	{
	}

	public void SpawnAtStart()
	{
	}

	public bool SelectSpawnPoint(int point)
	{
		return false;
	}

	public void DeselectSpawnPoint()
	{
	}

	public void SetBasePointImagePositions(bool disable)
	{
	}

	public void EnableSpawnPointSelection()
	{
	}

	public void UpdateSpawnPointSelection(int point)
	{
	}

	public void DisableSpawnPointSelection()
	{
	}

	public void RespawnAtPoint()
	{
	}

	public void SetupCapturePointUI()
	{
	}

	public void HUDCapturePointShow(bool show, int point)
	{
	}

	public void UpdatePointImageFactions(int point)
	{
	}

	public void UpdateBasePointImageFactions(TeamStatus status, Image image)
	{
	}

	public void SetPointShapeToNeutral(int point)
	{
	}

	public void UpdateTicketAmount(bool team1)
	{
	}

	public void ChangeCamera(Camera newCam = null, AudioListener audioListener = null)
	{
	}

	public void ShowCursor()
	{
	}

	public void HideCursor()
	{
	}

	private void _003CSelectSideClick_003Eb__252_0()
	{
	}

	private void _003CShowEndScreen_003Eb__257_0()
	{
	}

	private void _003CShowEndScreen_003Eb__257_1()
	{
	}
}
