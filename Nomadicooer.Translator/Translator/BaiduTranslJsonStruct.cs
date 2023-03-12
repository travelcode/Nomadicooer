
using System;
[Serializable]
#pragma warning disable IDE1006 // 命名样式
internal class BaiduTransJsonStruct
{
    public string from { get; set; }
    public string to { get; set; }
    public string error_msg { get; set; }
    public string error_code { get; set; }
    public Trans_Result[] trans_result { get; set; }
}
[Serializable]
internal class Trans_Result
{
    public string src { get; set; }

    public string dst { get; set; }
}
#pragma warning restore IDE1006 // 命名样式
