using System;
using System.Collections.Generic;
using System.Text;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 代码字符串搜寻对象
    /// </summary>
    public class CodeStringSearcher
    {
        private readonly string code;
        public delegate void CodeStringInfoHandler(object sender, CodeStringInfoEventArgs args);
        /// <summary>
        /// 当准备记录代码搜索到的行的时候,调用该事件
        /// </summary>
        public event CodeStringInfoHandler RecordEvent;
        //当前状态
        private enum RecordStatus
        {
            //正在进行遍历搜索
            Search,
            //准备好开始记录
            ReadyRecord,
            //记录中
            Recording,
            //结束记录
            EndRecord
        }
        /// <summary>
        /// 信息记录器
        /// </summary>
        private struct Recorder
        {
            //当前行
            public int curLine;
            //当前字符在文档空间的字符
            public int curSpan;
            //当前字符在一行代码中的位置
            public int curLineSpan;
            //开始记录时当前所在行
            public int startRecordLine;
            //开始记录时当前在文档中的字符位置
            public int startRecordSpan;
            //开始记录时所在行的字符位置
            public int startRecordLineSpan;
            //行开始在全局的位置
            public int lineStartSpan;
            //行正式开始,可能前面有空白字符
            public bool lineBegin;
            //前一个字符
            public char prevChar;
            //统计反斜杠连续出现的次数,用于记录是否该把该反斜杠视为字符
            public int backSlaskSerialCount;
            //当前状态
            public RecordStatus record;
        }
        public CodeStringSearcher(string code)
        {
            this.code = code;
        }
        /// <summary>
        /// 执行搜索程序
        /// </summary>
        /// <returns>返回搜索的结果列表</returns>
        public List<CodeStringInfo> Search()
        {
            //实例化一个搜索结果,用于记录查找到的字符串
            List<CodeStringInfo> infos = new List<CodeStringInfo>();
            //记录单条字符串结果
            StringBuilder builder = new StringBuilder();
            //初始化信息记录结构
            Recorder recorder = new Recorder
            {
                curLine = 0,
                curSpan = 0,
                curLineSpan = 0,
                startRecordLine = 0,
                startRecordSpan = 0,
                startRecordLineSpan = 0,
                lineStartSpan = 0,
                prevChar = '\0',
                backSlaskSerialCount = 0,
                lineBegin = false,
                record = RecordStatus.Search
            };
            //返回结果开始索引以1还是0开头
            int startIndex = 1;
            //遍历字符
            foreach (var ch in code)
            {
                if (IsReadingRecord(recorder, ch))//准备记录
                {
                    //设置开始信息,因为从下一个字符才开始
                    recorder.startRecordLine = recorder.curLine;
                    //因为要从下一个字符才开始,所以开始记录位置需要加1
                    recorder.startRecordSpan = recorder.curSpan + 1;
                    recorder.startRecordLineSpan = recorder.curLineSpan + 1;
                    recorder.record = RecordStatus.Recording;
                }
                else if (recorder.record == RecordStatus.Recording && ch == Chars.Quote && recorder.prevChar != Chars.BackSlask)//结束记录
                {
                    CodeStringInfo info = new CodeStringInfo(builder.ToString(),
                        recorder.startRecordLine + startIndex,
                        recorder.startRecordSpan + startIndex,
                        recorder.startRecordLineSpan + startIndex,
                        recorder.curLine + startIndex,
                        recorder.curSpan + startIndex,
                        recorder.curLineSpan + startIndex);
                    //通知用户处理数据
                    bool record = true;
                    if (RecordEvent != null)
                    {
                        CodeStringInfoEventArgs e = new CodeStringInfoEventArgs(info);
                        record = e.Record;
                        RecordEvent(this, e);
                    }
                    //将结果信息记录到列表中
                    if (record)
                    {
                        infos.Add(info);
                    }
                    //清除操作
                    builder.Clear();
                    recorder.backSlaskSerialCount = 0;
                    recorder.record = RecordStatus.Search;

                }
                else if (recorder.record == RecordStatus.Recording)//正在记录
                {
                    //设置连续出现反斜杠的数量
                    switch (ch)
                    {
                        case Chars.BackSlask when recorder.prevChar == Chars.BackSlask:
                            recorder.backSlaskSerialCount++;
                            break;
                        case Chars.BackSlask:
                            recorder.backSlaskSerialCount = 1;
                            break;
                        default:
                            recorder.backSlaskSerialCount = 0;
                            break;
                    }
                    //如果该字符不为反斜杠或者是2的整数倍个反斜杠,则将该字符记录到字符串
                    if (ch != Chars.BackSlask || recorder.backSlaskSerialCount % 2 == 0)
                    {
                        builder.Append(ch);
                    }
                }
                else if (recorder.record == RecordStatus.Search && recorder.lineBegin && !char.IsWhiteSpace(ch))
                {
                    //查找一行正式开始位置

                    recorder.lineBegin = false;
                    recorder.lineStartSpan = recorder.curSpan;
                }
                //无论什么情况都需要统计的数据
                recorder.curSpan++;
                recorder.curLineSpan++;
                recorder.prevChar = ch;
                //换行需要记录的数据
                if (ch == Chars.Lf)
                {
                    recorder.curLine++;
                    recorder.curLineSpan = 0;
                    //提示新行开始
                    recorder.lineBegin = true;
                }
            }
            return infos;
        }
        /// <summary>
        /// 是否可以准备记录了
        /// </summary>
        /// <param name="recorder"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        private bool IsReadingRecord(Recorder recorder, char ch)
        {
            //判断是否为引号
            bool condition = ch == Chars.Quote && recorder.prevChar != Chars.BackSlask;
            //判断是否为搜索状态
            condition = condition && recorder.record == RecordStatus.Search;
            //行开头不能为单行或者文档注释
            condition = condition && !(recorder.lineStartSpan < (code.Length - 2) && code[recorder.lineStartSpan] == Chars.Slash && code[recorder.lineStartSpan + 1] == Chars.Slash);
            //行开头不能为多行注释
            condition = condition && code[recorder.lineStartSpan] != Chars.Asterisk;
            return condition;
        }
    }
}
