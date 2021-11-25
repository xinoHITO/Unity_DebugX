using UnityEngine;

namespace HitoshiKanno
{
    public static class DebugX
    {
        public static void Log(object obj)
        {
            Log(obj, Color.white);
        }

        public static void Log(object obj, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.Log(string.Format("<color=#{0}>{1}</color>", colorHex, obj));
        }

        public static void Log(object obj, Object context)
        {
            Log(obj, context, Color.white);
        }

        public static void Log(object obj, Object context, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.Log(string.Format("<color=#{0}>{1}</color>", colorHex, obj), context);
        }

        public static void LogWarning(object obj)
        {
            LogWarning(obj, Color.yellow);
        }

        public static void LogWarning(object obj, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.LogWarning(string.Format("<color=#{0}>{1}</color>", colorHex, obj));
        }

        public static void LogWarning(object obj, Object context)
        {
            LogWarning(obj, context, Color.yellow);
        }

        public static void LogWarning(object obj, Object context, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.LogWarning(string.Format("<color=#{0}>{1}</color>", colorHex, obj), context);
        }

        public static void LogError(object obj)
        {
            LogError(obj, Color.red);
        }

        public static void LogError(object obj, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.LogError(string.Format("<color=#{0}>{1}</color>", colorHex, obj));
        }

        public static void LogError(object obj, Object context)
        {
            LogError(obj, context, Color.red);
        }

        public static void LogError(object obj, Object context, Color color)
        {
            if (!IsEnable()) return;
            string colorHex = ColorUtility.ToHtmlStringRGB(color);
            Debug.LogError(string.Format("<color=#{0}>{1}</color>", colorHex, obj), context);
        }

        static bool IsEnable()
        {
            return Debug.isDebugBuild;
        }
    }
}