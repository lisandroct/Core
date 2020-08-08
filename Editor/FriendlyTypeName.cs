using System;
using System.Text;

public static class FriendlyTypeName
{
    public static string GetFriendlyName(this Type type)
    {
        if (type.IsPrimitive)
        {
            if (type == typeof(bool))
            {
                return "Bool";
            }

            if (type == typeof(float))
            {
                return "Float";
            }

            if (type == typeof(int))
            {
                return "Int";
            }

            if (type == typeof(uint))
            {
                return "UInt";
            }

            if (type == typeof(long))
            {
                return "Long";
            }

            if (type == typeof(ulong))
            {
                return "ULong";
            }

            if (type == typeof(short))
            {
                return "Short";
            }

            if (type == typeof(ushort))
            {
                return "UShort";
            }
        }

        if (type.IsArray)
        {
            return $"{GetFriendlyName(type.GetElementType())}Array";
        }

        if (type.IsConstructedGenericType)
        {
            var builder = new StringBuilder();
            foreach (var generic in type.GenericTypeArguments)
            {
                builder.Append(GetFriendlyName(generic));
            }

            builder.Append(type.Name.Split('`')[0]);

            return builder.ToString();
        }

        return type.Name;
    }
}
