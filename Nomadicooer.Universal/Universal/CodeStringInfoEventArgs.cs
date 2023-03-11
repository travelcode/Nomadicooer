using System;

namespace Nomaidcooer.Universal
{
    public class CodeStringInfoEventArgs : EventArgs
    {
        private readonly CodeStringInfo info;
        private bool record;
        public CodeStringInfoEventArgs(CodeStringInfo info)
        {
            this.info = info;
            this.record = true;
        }
        /// <summary>
        /// 当前字符串对象
        /// </summary>
        public CodeStringInfo Info => info;
        /// <summary>
        /// 是否需要记录
        /// </summary>
        public bool Record { get => record; set => record = value; }
    }
}
