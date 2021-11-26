using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWeb : MonoBehaviour
{
    public void Open()
    {
        Application.OpenURL("https://news.google.com/topstories?hl=zh-TW&gl=TW&ceid=TW:zh-Hant");
    }
    public void Open_Web()
    {
        //"_blank" 開一個新的瀏覽器
        //"_self" 在原本的瀏覽器開啟網頁(會覆蓋原本的網頁)
        Application.ExternalEval("window.open('https://news.google.com/topstories?hl=zh-TW&gl=TW&ceid=TW:zh-Hant', '_blank')");
    }
}
