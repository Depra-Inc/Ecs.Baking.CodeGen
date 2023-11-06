using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Depra.Ecs.Components;
using Depra.Ecs.Hybrid.Components;
using Depra.Ecs.Worlds;

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class BakerTemplate
	{
		private const string DOT = ".";
		private const string GET_POOL_METHOD_NAME = nameof(World.Pool);
		private const string ALLOCATE_METHOD_NAME = nameof(IComponentPool.Allocate);
		private const string GET_POOL_METHOD_FORMAT = "world." + GET_POOL_METHOD_NAME + "<{0}>()";
		private const string ALLOCATE_METHOD_FORMAT = GET_POOL_METHOD_FORMAT + DOT + ALLOCATE_METHOD_NAME + "(entity)";

		public static string GenerateDefinition(int componentFieldsCount) => componentFieldsCount switch
		{
			0 => string.Empty,
			_ => @$"
		private readonly {nameof(IAuthoring)} _authoring;

		public Baker({nameof(IAuthoring)} authoring) => _authoring = authoring;
"
		};

		public static string GenerateAllocation(string componentName, string authoringName,
			IReadOnlyList<FieldInfo> componentFields) => componentFields.Count switch
		{
			0 => string.Format(ALLOCATE_METHOD_FORMAT, componentName) + ";",
			1 => string.Format(ALLOCATE_METHOD_FORMAT, componentName) +
			     $".{componentFields[0].Name} = (({authoringName})_authoring).{componentFields[0].Name.ToCamelCaseWithUnderscore()};",
			_ => $"ref var component = ref {string.Format(ALLOCATE_METHOD_FORMAT, componentName)};\n\t\t\t\t" +
			     string.Join("\n\t\t\t\t", componentFields.Select(field =>
				     $"component.{field.Name} = (({authoringName})_authoring).{field.Name.ToCamelCaseWithUnderscore()};"))
		};
	}
}