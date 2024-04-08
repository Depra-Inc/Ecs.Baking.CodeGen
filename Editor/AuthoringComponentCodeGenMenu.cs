// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.CodeGen.Editor.Pipeline;
using UnityEditor;

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class AuthoringComponentCodeGenMenu
	{
		[MenuItem(nameof(Depra) + "/" + nameof(CodeGen) + "/Generate/Authoring Components")]
		private static void GenerateComponentBakers() => UnityCodeGenUtility.Generate<AuthoringComponentGenerator>();
	}
}