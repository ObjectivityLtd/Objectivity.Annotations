namespace Objectivity.Annotations
{
    using System;
    using System.Globalization;

    using JetBrains.Annotations;

    internal static class CoreStrings
    {
        public static string ArgumentPropertyNull([CanBeNull] string property, [CanBeNull] string argument)
        {
            return Current($"The property '{property}' of the argument '{argument}' cannot be null.");
        }

        public static string ArgumentIsNullOrEmpty([CanBeNull] string argumentName)
        {
            return Current($"The string argument '{argumentName}' cannot be null or empty.");
        }

        public static string ArgumentIsEmpty([CanBeNull] string argumentName)
        {
            return Current($"The string argument '{argumentName}' cannot be empty.");
        }

        public static string InvalidEntityType([CanBeNull] Type type, [CanBeNull] string argumentName)
        {
            return Current($"The entity type '{type}' provided for the argument '{argumentName}' must be a reference type.");
        }

        public static string CollectionArgumentIsEmpty([CanBeNull] string argumentName)
        {
            return Current($"The collection argument '{argumentName}' must contain at least one element.");
        }

        public static string Current(FormattableString formattable)
        {
            if (formattable == null)
            {
                throw new ArgumentNullException("formattable");
            }

            return formattable.ToString(CultureInfo.CurrentCulture);
        }
    }
}