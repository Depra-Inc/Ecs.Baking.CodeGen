namespace Depra.Ecs.Baking.CodeGen.Editor
{
	internal static class Module
	{
		public const string MODULE_PATH = FRAMEWORK_NAME + SLASH + MODULE_NAME + SLASH;

		private const string SLASH = "/";
		private const string MODULE_NAME = nameof(Ecs);
		private const string FRAMEWORK_NAME = nameof(Depra);
	}
}