namespace Nomadicooer.Core
{
    /// <summary>
    ///Ascii码
    /// </summary>
    public static class Chars
    {
        /// <summary>
        /// 空字符
        /// </summary>
        public const char Nul = (char)0;
        /// <summary>
        /// 标题开始
        /// </summary>
        public const char Soh = (char)1;
        /// <summary>
        /// 正文开始
        /// </summary>
        public const char Stx = (char)2;
        /// <summary>
        /// 正文结束
        /// </summary>
        public const char Etx = (char)3;
        /// <summary>
        /// 传输结束
        /// </summary>
        public const char Eot = (char)4;
        /// <summary>
        /// 询问
        /// </summary>
        public const char Enq = (char)5;
        /// <summary>
        /// 收到通知
        /// </summary>
        public const char Ack = (char)6;
        /// <summary>
        /// 铃
        /// </summary>
        public const char Bel = (char)7;
        /// <summary>
        /// 退格
        /// </summary>
        public const char Bs = (char)8;
        /// <summary>
        /// 水平制表符
        /// </summary>
        public const char Ht = (char)9;
        /// <summary>
        /// 换行符 \n
        /// </summary>
        public const char Lf = (char)10;
        /// <summary>
        /// 垂直制表符
        /// </summary>
        public const char Vt = (char)11;
        /// <summary>
        /// 换页符
        /// </summary>
        public const char Ff = (char)12;
        /// <summary>
        /// 回车符 \r
        /// </summary>
        public const char Cr = (char)13;
        /// <summary>
        /// 移出
        /// </summary>
        public const char So = (char)14;
        /// <summary>
        /// 移入
        /// </summary>
        public const char Si = (char)15;
        /// <summary>
        /// 数据链路转义
        /// </summary>
        public const char Dle = (char)16;
        /// <summary>
        /// 设备控制 1
        /// </summary>
        public const char Dc1 = (char)17;
        /// <summary>
        /// 设备控制 2
        /// </summary>
        public const char Dc2 = (char)18;
        /// <summary>
        /// 设备控制 3
        /// </summary>
        public const char Dc3 = (char)19;
        /// <summary>
        /// 设备控制 4
        /// </summary>
        public const char Dc4 = (char)20;
        /// <summary>
        /// 拒绝接收
        /// </summary>
        public const char Nak = (char)21;
        /// <summary>
        /// 同步空闲
        /// </summary>
        public const char Syn = (char)22;
        /// <summary>
        /// 传输块结束
        /// </summary>
        public const char Etb = (char)23;
        /// <summary>
        /// 取消
        /// </summary>
        public const char Can = (char)24;
        /// <summary>
        /// 介质中断
        /// </summary>
        public const char Em = (char)25;
        /// <summary>
        /// 替换
        /// </summary>
        public const char Sub = (char)26;
        /// <summary>
        /// 换码符\退出
        /// </summary>
        public const char Esc = (char)27;
        /// <summary>
        /// 文件分隔符
        /// </summary>
        public const char Fs = (char)28;
        /// <summary>
        /// 组分隔符
        /// </summary>
        public const char Gs = (char)29;
        /// <summary>
        /// 记录分离符
        /// </summary>
        public const char Rs = (char)30;
        /// <summary>
        /// 单元分隔符
        /// </summary>
        public const char Us = (char)31;
        /// <summary>
        /// 空格
        /// </summary>
        public const char Space = (char)32;
        /// <summary>
        /// 感叹号 !
        /// </summary>
        public const char Bang = (char)33;
        /// <summary>
        /// 双引号 "
        /// </summary>
        public const char Quote = (char)34;
        /// <summary>
        /// 井号 #
        /// </summary>
        public const char Sharp = (char)35;
        /// <summary>
        /// 美元符 $
        /// </summary>
        public const char Dollar = (char)36;
        /// <summary>
        /// 百分号 %
        /// </summary>
        public const char Percent = (char)37;
        /// <summary>
        /// 与&amp;
        /// </summary>
        public const char And = (char)38;
        /// <summary>
        /// 单引号 '
        /// </summary>
        public const char SingleQuote = (char)39;
        /// <summary>
        /// 左括号 (
        /// </summary>
        public const char OpenParentheses = (char)40;
        /// <summary>
        /// 右括号 )
        /// </summary>
        public const char CloseParentheses = (char)41;
        /// <summary>
        /// 星号 *
        /// </summary>
        public const char Asterisk = (char)42;
        /// <summary>
        /// 加号 +
        /// </summary>
        public const char Plus = (char)43;
        /// <summary>
        /// 逗号 ,
        /// </summary>
        public const char Comma = (char)44;
        /// <summary>
        /// 连字号或减号 -
        /// </summary>
        public const char Dash = (char)45;
        /// <summary>
        /// 句点或小数点 .
        /// </summary>
        public const char Dot = (char)46;
        /// <summary>
        /// 斜杠 /
        /// </summary>
        public const char Slash = (char)47;
        /// <summary>
        /// 0
        /// </summary>
        public const char Num0 = (char)48;
        /// <summary>
        /// 1
        /// </summary>
        public const char Num1 = (char)49;
        /// <summary>
        /// 2
        /// </summary>
        public const char Num2 = (char)50;
        /// <summary>
        /// 3
        /// </summary>
        public const char Num3 = (char)51;
        /// <summary>
        /// 4
        /// </summary>
        public const char Num4 = (char)52;
        /// <summary>
        /// 5
        /// </summary>
        public const char Num5 = (char)53;
        /// <summary>
        /// 6
        /// </summary>
        public const char Num6 = (char)54;
        /// <summary>
        /// 7
        /// </summary>
        public const char Num7 = (char)55;
        /// <summary>
        /// 8
        /// </summary>
        public const char Num8 = (char)56;
        /// <summary>
        /// 9
        /// </summary>
        public const char Num9 = (char)57;
        /// <summary>
        /// 冒号 :
        /// </summary>
        public const char Colon = (char)58;
        /// <summary>
        /// 分号 ;
        /// </summary>
        public const char Semicolon = (char)59;
        /// <summary>
        /// 小于 &lt;
        /// </summary>
        public const char LessThan = (char)60;
        /// <summary>
        /// 等号 =
        /// </summary>
        public const char Equal = (char)61;
        /// <summary>
        /// 大于 >
        /// </summary>
        public const char GreaterThan = (char)62;
        /// <summary>
        /// 问号 ?
        /// </summary>
        public const char QuestionMark = (char)63;
        /// <summary>
        /// 电子邮件符号 @
        /// </summary>
        public const char At = (char)64;
        /// <summary>
        /// 大写字母 A
        /// </summary>
        public const char UpperA = (char)65;
        /// <summary>
        /// 大写字母 B
        /// </summary>
        public const char UpperB = (char)66;
        /// <summary>
        /// 大写字母 C
        /// </summary>
        public const char UpperC = (char)67;
        /// <summary>
        /// 大写字母 D
        /// </summary>
        public const char UpperD = (char)68;
        /// <summary>
        /// 大写字母 E
        /// </summary>
        public const char UpperE = (char)69;
        /// <summary>
        /// 大写字母 F
        /// </summary>
        public const char UpperF = (char)70;
        /// <summary>
        /// 大写字母 G
        /// </summary>
        public const char UpperG = (char)71;
        /// <summary>
        /// 大写字母 H
        /// </summary>
        public const char UpperH = (char)72;
        /// <summary>
        /// 大写字母 I
        /// </summary>
        public const char UpperI = (char)73;
        /// <summary>
        /// 大写字母 J
        /// </summary>
        public const char UpperJ = (char)74;
        /// <summary>
        /// 大写字母 K
        /// </summary>
        public const char UpperK = (char)75;
        /// <summary>
        /// 大写字母 L
        /// </summary>
        public const char UpperL = (char)76;
        /// <summary>
        /// 大写字母 M
        /// </summary>
        public const char UpperM = (char)77;
        /// <summary>
        /// 大写字母 N
        /// </summary>
        public const char UpperN = (char)78;
        /// <summary>
        /// 大写字母 O
        /// </summary>
        public const char UpperO = (char)79;
        /// <summary>
        /// 大写字母 P
        /// </summary>
        public const char UpperP = (char)80;
        /// <summary>
        /// 大写字母 Q
        /// </summary>
        public const char UpperQ = (char)81;
        /// <summary>
        /// 大写字母 R
        /// </summary>
        public const char UpperR = (char)82;
        /// <summary>
        /// 大写字母 S
        /// </summary>
        public const char UpperS = (char)83;
        /// <summary>
        /// 大写字母 T
        /// </summary>
        public const char UpperT = (char)84;
        /// <summary>
        /// 大写字母 U
        /// </summary>
        public const char UpperU = (char)85;
        /// <summary>
        /// 大写字母 DefaultBaseDir
        /// </summary>
        public const char UpperV = (char)86;
        /// <summary>
        /// 大写字母 W
        /// </summary>
        public const char UpperW = (char)87;
        /// <summary>
        /// 大写字母 X
        /// </summary>
        public const char UpperX = (char)88;
        /// <summary>
        /// 大写字母 Y
        /// </summary>
        public const char UpperY = (char)89;
        /// <summary>
        /// 大写字母 Z
        /// </summary>
        public const char UpperZ = (char)90;
        /// <summary>
        /// 左中括号 [
        /// </summary>
        public const char OpenBracket = (char)91;
        /// <summary>
        /// 反斜杠	\
        /// </summary>
        public const char BackSlask = (char)92;
        /// <summary>
        /// 右中括号 ]
        /// </summary>
        public const char CloseBracket = (char)93;
        /// <summary>
        /// 音调符号 ^
        /// </summary>
        public const char Caret = (char)94;
        /// <summary>
        /// 下划线	_
        /// </summary>
        public const char Underline = (char)95;
        /// <summary>
        /// 重音符 `
        /// </summary>
        public const char BackQuote = (char)96;
        /// <summary>
        /// 小写字母 a
        /// </summary>
        public const char LowerA = (char)97;
        /// <summary>
        /// 小写字母 b
        /// </summary>
        public const char LowerB = (char)98;
        /// <summary>
        /// 小写字母 c
        /// </summary>
        public const char LowerC = (char)99;
        /// <summary>
        /// 小写字母 d
        /// </summary>
        public const char LowerD = (char)100;
        /// <summary>
        /// 小写字母 e
        /// </summary>
        public const char LowerE = (char)101;
        /// <summary>
        /// 小写字母 f
        /// </summary>
        public const char LowerF = (char)102;
        /// <summary>
        /// 小写字母 g
        /// </summary>
        public const char LowerG = (char)103;
        /// <summary>
        /// 小写字母 h
        /// </summary>
        public const char LowerH = (char)104;
        /// <summary>
        /// 小写字母 i
        /// </summary>
        public const char LowerI = (char)105;
        /// <summary>
        /// 小写字母 j
        /// </summary>
        public const char LowerJ = (char)106;
        /// <summary>
        /// 小写字母 k
        /// </summary>
        public const char LowerK = (char)107;
        /// <summary>
        /// 小写字母 l
        /// </summary>
        public const char LowerL = (char)108;
        /// <summary>
        /// 小写字母 m
        /// </summary>
        public const char LowerM = (char)109;
        /// <summary>
        /// 小写字母 n
        /// </summary>
        public const char LowerN = (char)110;
        /// <summary>
        /// 小写字母 o
        /// </summary>
        public const char LowerO = (char)111;
        /// <summary>
        /// 小写字母 p
        /// </summary>
        public const char LowerP = (char)112;
        /// <summary>
        /// 小写字母 q
        /// </summary>
        public const char LowerQ = (char)113;
        /// <summary>
        /// 小写字母 r
        /// </summary>
        public const char LowerR = (char)114;
        /// <summary>
        /// 小写字母 s
        /// </summary>
        public const char LowerS = (char)115;
        /// <summary>
        /// 小写字母 t
        /// </summary>
        public const char LowerT = (char)116;
        /// <summary>
        /// 小写字母 u
        /// </summary>
        public const char LowerU = (char)117;
        /// <summary>
        /// 小写字母 v
        /// </summary>
        public const char LowerV = (char)118;
        /// <summary>
        /// 小写字母 w
        /// </summary>
        public const char LowerW = (char)119;
        /// <summary>
        /// 小写字母 x
        /// </summary>
        public const char LowerX = (char)120;
        /// <summary>
        /// 小写字母 y
        /// </summary>
        public const char LowerY = (char)121;
        /// <summary>
        /// 小写字母 z
        /// </summary>
        public const char LowerZ = (char)122;
        /// <summary>
        /// 左大括号{
        /// </summary>
        public const char OpenBrace = (char)123;
        /// <summary>
        /// 垂直线	|
        /// </summary>
        public const char Pipe = (char)124;
        /// <summary>
        /// 右大括号}
        /// </summary>
        public const char CloseBrace = (char)125;
        /// <summary>
        /// 波浪号 ~
        /// </summary>
        public const char Tilde = (char)126;
        /// <summary>
        /// 删除
        /// </summary>
        public const char Del = (char)127;
    }
}
