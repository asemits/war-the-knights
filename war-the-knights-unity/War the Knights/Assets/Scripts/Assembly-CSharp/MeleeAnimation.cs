using UnityEngine;

public class MeleeAnimation : ScriptableObject
{
	public RuntimeAnimatorController mainAnimatorController;

	public bool lightAttacksStabInsteadOfSwing;

	public bool heavyAttacksStabInsteadOfSwing;

	public bool lightLeftRightAnimationRandomOrder;

	public bool heavyLeftRightAnimationRandomOrder;

	public AnimationClip attackAnim_Left1;

	public MeleeWeaponCameraMovement camera_Left1;

	public AnimationClip attackAnim_Left2;

	public MeleeWeaponCameraMovement camera_Left2;

	public AnimationClip attackAnim_LeftHeavy;

	public MeleeWeaponCameraMovement camera_LeftHeavy;

	public AnimationClip attackAnim_Right1;

	public MeleeWeaponCameraMovement camera_Right1;

	public AnimationClip attackAnim_Right2;

	public MeleeWeaponCameraMovement camera_Right2;

	public AnimationClip attackAnim_RightHeavy;

	public MeleeWeaponCameraMovement camera_RightHeavy;
}
