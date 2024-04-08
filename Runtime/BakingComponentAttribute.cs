// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;

namespace Depra.Ecs.Hybrid.CodeGen
{
	[AttributeUsage(AttributeTargets.Struct)]
	public sealed class BakingComponentAttribute : Attribute { }
}