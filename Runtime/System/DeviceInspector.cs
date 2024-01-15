using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.Klazapp.Utility
{
    //DeviceInspector checks to see if app is running in editor or not
    //Further checks to see if in editor is running on simulator or not
    public static class DeviceInspector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsMobileDevice()
        {
            //Return true is not editor
            if (!IsApplicationEditor())
                return true;

            //If editor,
            //Check if in game view or simulator view
            if (IsEditorSimulator())
                return true;
            
            if (IsEditorGameView())
                return false;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsApplicationEditor()
        {
            return Application.isEditor;
        }

#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsEditorSimulator()
        {
            //Disable unreachable code warning
#pragma warning disable 0162
#if UNITY_EDITOR
            return UnityEngine.Device.SystemInfo.deviceType != DeviceType.Desktop;
#endif
            return false;
#pragma warning restore 0162
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsEditorGameView()
        {
            //Disable unreachable code warning
#pragma warning disable 0162
#if UNITY_EDITOR
            return UnityEngine.Device.SystemInfo.deviceType == DeviceType.Desktop;
#endif
            return false;
#pragma warning restore 0162
        }
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEditorSimulator()
    {
#if UNITY_EDITOR
        return !Application.isEditor;
#endif
        return false;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEditorGameView()
    {
#if UNITY_EDITOR
        return Application.isEditor;
#endif
        return false;
    }
#endif
    }
}
