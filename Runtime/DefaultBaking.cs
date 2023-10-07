// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using System;

namespace Depra.Ecs.Baking.CodeGen.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	public sealed class DefaultBaking : Attribute { }
}