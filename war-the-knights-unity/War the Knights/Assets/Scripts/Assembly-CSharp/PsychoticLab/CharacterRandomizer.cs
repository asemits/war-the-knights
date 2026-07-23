using System.Collections.Generic;
using UnityEngine;

namespace PsychoticLab
{
	public class CharacterRandomizer : MonoBehaviour
	{
		public bool repeatOnPlay;

		public float shuffleSpeed;

		public Material mat;

		public Color[] primary;

		public Color[] secondary;

		public Color[] metalPrimary;

		public Color[] metalSecondary;

		public Color[] leatherPrimary;

		public Color[] leatherSecondary;

		public Color[] whiteSkin;

		public Color[] brownSkin;

		public Color[] blackSkin;

		public Color[] elfSkin;

		public Color[] whiteHair;

		public Color whiteStubble;

		public Color[] brownHair;

		public Color brownStubble;

		public Color[] blackHair;

		public Color blackStubble;

		public Color[] elfHair;

		public Color elfStubble;

		public Color whiteScar;

		public Color brownScar;

		public Color blackScar;

		public Color elfScar;

		public Color[] bodyArt;

		public List<GameObject> enabledObjects;

		public CharacterObjectGroups male;

		public CharacterObjectGroups female;

		public CharacterObjectListsAllGender allGender;

		private Transform camHolder;

		private float x;

		private float y;

		private void OnGUI()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Randomize()
		{
		}

		private void RandomizeByVariable(CharacterObjectGroups cog, Gender gender, Elements elements, Race race, FacialHair facialHair, SkinColor skinColor, HeadCovering headCovering)
		{
		}

		private void RandomizeColors(SkinColor skinColor)
		{
		}

		private void RandomizeAndSetHairSkinColors(string info, Color[] skin, Color[] hair, Color stubble, Color scar)
		{
		}

		private void RandomizeLeftRight(List<GameObject> objectListRight, List<GameObject> objectListLeft, int rndPercent)
		{
		}

		private void ActivateItem(GameObject go)
		{
		}

		private Color ConvertColor(int r, int g, int b)
		{
			return default(Color);
		}

		private bool GetPercent(int pct)
		{
			return false;
		}

		private void BuildLists()
		{
		}

		private void BuildList(List<GameObject> targetList, string characterPart)
		{
		}
	}
}
