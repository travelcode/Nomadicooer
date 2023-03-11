using System.Collections.Generic;

namespace Nomaidcooer.Universal
{
    public class CodeStringInfo
    {
        private string text;
        private readonly int startLine;
        private readonly int startSpan;
        private readonly int startLineSpan;
        private readonly int endLine;
        private readonly int endLineSpan;
        private readonly int endSpan;
        private readonly IDictionary<string, string> userData;
        public CodeStringInfo() { 
        
        }

        public CodeStringInfo(string text, int startLine, int startSpan, int startLineSpan, int endLine, int endSpan,int endLineSpan)
        {
            this.text = text;
            this.startLine = startLine;
            this.startSpan = startSpan;
            this.startLineSpan = startLineSpan;
            this.endLine = endLine;
            this.endLineSpan = endLineSpan;
            this.endSpan = endSpan;
            this.userData = new Dictionary<string, string>();
        }
        /// <summary>
        /// 搜索到的文本
        /// </summary>

        /// <summary>
        /// 文本所在的行号
        /// </summary>
        public int StartLine => startLine;
        /// <summary>
        /// 文本在文档空间中开始的位置
        /// </summary>
        public int StartSpan => startSpan;
        /// <summary>
        /// 文本在行中开始的位置
        /// </summary>
        public int StartLineSpan => startLineSpan;
        /// <summary>
        /// 文本结束的行
        /// </summary>
        public int EndLine => endLine;
        /// <summary>
        /// 文本在行中结束的位置
        /// </summary>
        public int EndLineSpan => endLineSpan;
        /// <summary>
        ///文本在文档空间结束的位置 
        /// </summary>
        public int EndSpan => endSpan;
        /// <summary>
        /// 用户用于记录数据的字典
        /// </summary>
        public IDictionary<string, string> UserData => userData;
        /// <summary>
        /// 设置或者获取返回的文本
        /// </summary>
        public string Text { get => text; set => text = value; }
    }
}