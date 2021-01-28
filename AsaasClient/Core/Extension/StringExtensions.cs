namespace AsaasClient.Core.Extension {
    public static class StringExtensions {

        public static string FirstCharToLower(this string text) {
            return char.ToLowerInvariant(text[0]) + text.Substring(1);
        }

    }
}