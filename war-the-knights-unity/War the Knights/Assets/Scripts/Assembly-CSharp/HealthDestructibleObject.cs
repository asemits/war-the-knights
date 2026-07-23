using System;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class HealthDestructibleObject
{
	public GameObject destructibleObjectContainingMeshes;

	public DestructibleMesh[] destructibleObjectMeshes;

	public GameObject destructibleObjectContainingObstacles;

	public NavMeshObstacle[] destructibleObjectNavmeshObstacles;
}
