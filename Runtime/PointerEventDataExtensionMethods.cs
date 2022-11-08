using UnityEngine.EventSystems;

namespace Kogane
{
    public static class PointerEventDataExtensionMethods
    {
        public static bool IsMultiTouch( this PointerEventData self )
        {
            // https://docs.unity3d.com/ja/2018.4/ScriptReference/EventSystems.PointerEventData-pointerId.html
            // -1: マウスの左クリック
            // -2: マウスの右クリック
            // -3: マウスの中央ボタンクリック
            //  0: シングルタップ
            //  1: ダブルタップ
            //  2: トリプルタップ
            return 0 < self.pointerId;
        }
    }
}