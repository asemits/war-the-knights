using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class radialSelection : MonoBehaviour
{
	public MenuButton[] buttons;

	private Vector2 toVector2M;

	public GameObject objectToRotate;

	public int menuItems;

	public int currMenuItem;

	private int oldMenuItem;

	public bool isActivated;

	public TextMeshProUGUI itemNameTxt;

	public TextMeshProUGUI itemDescTxt;

	public Image img1;

	public Image img2;

	public Image img3;

	public Image img4;

	public Image img5;

	public Image img6;

	public Image img7;

	public Image img8;

	public Sprite emptyImage;

	public CanvasGroup canvas;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GetCurrentMenuItem()
	{
	}

	public void ActivateCircle()
	{
	}

	public void DeactivateCircle()
	{
	}

	public void ActivateItemSlot(int slot)
	{
	}
}
