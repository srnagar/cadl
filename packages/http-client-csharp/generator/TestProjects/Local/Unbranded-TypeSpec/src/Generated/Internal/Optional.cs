// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace UnbrandedTypeSpec
{
    internal static partial class Optional
    {
        /// <param name="collection"> The collection. </param>
        public static bool IsCollectionDefined<T>(IEnumerable<T> collection)
        {
            return !(collection is ChangeTrackingList<T> changeTrackingList && changeTrackingList.IsUndefined);
        }

        /// <param name="collection"> The collection. </param>
        public static bool IsCollectionDefined<TKey, TValue>(IDictionary<TKey, TValue> collection)
        {
            return !(collection is ChangeTrackingDictionary<TKey, TValue> changeTrackingDictionary && changeTrackingDictionary.IsUndefined);
        }

        /// <param name="collection"> The value. </param>
        public static bool IsCollectionDefined<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> collection)
        {
            return !(collection is ChangeTrackingDictionary<TKey, TValue> changeTrackingDictionary && changeTrackingDictionary.IsUndefined);
        }

        /// <param name="value"> The value. </param>
        public static bool IsDefined<T>(T? value)
        where T : struct
        {
            return value.HasValue;
        }

        /// <param name="value"> The value. </param>
        public static bool IsDefined(object value)
        {
            return value != null;
        }

        /// <param name="value"> The value. </param>
        public static bool IsDefined(System.Text.Json.JsonElement value)
        {
            return value.ValueKind != System.Text.Json.JsonValueKind.Undefined;
        }

        /// <param name="value"> The value. </param>
        public static bool IsDefined(string value)
        {
            return value != null;
        }
    }
}
