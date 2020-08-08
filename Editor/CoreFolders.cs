using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace lisandroct.Core.Editor
{
    public static class CoreFolders
    {
        private const string Assets = "Assets";
        private const string Core = "lisandroct";
        private const string Editor = "Editor";
        private const string Resources = "Resources";

        public static string CorePath => $"{Assets}/{Core}";
        public static string SettingsPath => $"{CorePath}/{Editor}/{Resources}";

        public static void Create()
        {
            if (!AssetDatabase.IsValidFolder(CorePath))
            {
                AssetDatabase.CreateFolder(Assets, Core);
            }
            if (!AssetDatabase.IsValidFolder(SettingsPath))
            {
                AssetDatabase.CreateFolder(CorePath, Editor);
                AssetDatabase.CreateFolder($"{CorePath}/{Editor}", Resources);
            }
        }
    }
}