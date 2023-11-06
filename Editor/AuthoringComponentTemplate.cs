using System.Linq;
using System.Reflection;
using Depra.Ecs.Hybrid.Components;
using UnityEngine;

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class AuthoringComponentTemplate
	{
		public static string GenerateFactory(int componentFieldsCount) => componentFieldsCount == 0
			? @$"
	{nameof(IBaker)} {nameof(IAuthoring)}.{nameof(IAuthoring.CreateBaker)}() => new Baker();
"
			: @$"
	{nameof(IBaker)} {nameof(IAuthoring)}.{nameof(IAuthoring.CreateBaker)}() => new Baker(this);
";

		public static string GenerateFields(FieldInfo[] componentFields)
		{
			var authoringFields = string.Empty;
			if (componentFields.Length <= 0)
			{
				return authoringFields;
			}

			authoringFields += "\n";
			return componentFields.Aggregate(authoringFields, (current, field) => current +
				$"\t[{nameof(SerializeField)}] private {field.FieldType.FullName} {field.Name.ToCamelCaseWithUnderscore()};\n");
		}
	}
}