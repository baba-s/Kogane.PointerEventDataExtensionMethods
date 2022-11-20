# Kogane Pointer Event Data Extension Methods

PointerEventData 型の拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;
using UnityEngine.EventSystems;

public sealed class Example :
    MonoBehaviour,
    IPointerClickHandler
{
    void IPointerClickHandler.OnPointerClick( PointerEventData eventData )
    {
        // シングルタップでなければ無視します
        if ( eventData.IsMultiTouch() ) return;

        Debug.Log( "クリックされた" );
    }
}
```