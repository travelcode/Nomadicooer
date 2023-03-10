
using System;
[Serializable]
public class BaiduTransJsonStruct
{
    public string from { get; set; }
    public string to { get; set; }
    public string error_msg { get; set; }
    public string error_code { get; set; }
    public Trans_Result[] trans_result { get; set; }
}
[Serializable]
public class Trans_Result
{
    public string src { get; set; }
    public string dst { get; set; }
}
