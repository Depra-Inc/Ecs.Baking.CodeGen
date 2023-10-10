using System.Linq;

namespace Depra.Ecs.Baking.CodeGen.Editor
{
	internal static class StringExtensions
	{
		public static string ToCamelCaseWithUnderscore(this string self) =>
			"_" + string.Concat(self.Select((x, i) => i == 0 && char.IsUpper(x)
				? char.ToLower(x).ToString()
				: x.ToString()));
	}
}