using UnityEngine;

public class EditorObjectManager : MonoBehaviour
{
	public Mesh catapultPreviewMesh;

	public Mesh horsePreviewMesh;

	public Mesh ballistaPreviewMesh;

	public GameObject ladderTopPrefab;

	public GameObject ladderMiddlePrefab;

	public GameObject ladderBottomPrefab;

	private static EditorObjectManager _instance;

	public static EditorObjectManager Instance => null;
}
