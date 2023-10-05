using Depra.CodeGen.Editor.Pipeline;
using UnityEditor;
using UnityEngine;
using static Depra.Ecs.Baking.CodeGen.Editor.Module;

namespace Depra.Ecs.Baking.CodeGen.Editor
{
	public static class AuthoringComponentCodeGenMenu
	{
		[MenuItem(MODULE_PATH + "Generate Component Bakers")]
		private static void GenerateComponentBakers()
		{
			UnityCodeGenUtility.Generate<AuthoringComponentGenerator>();

			Debug.Log("Component bakers generated.");
		}
	}
}