// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;

namespace Depra.Ecs.Baking.CodeGen
{
	[AttributeUsage(AttributeTargets.Struct)]
	public sealed class BakingComponentAttribute : Attribute { }
}