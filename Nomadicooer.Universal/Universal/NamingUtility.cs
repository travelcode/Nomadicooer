using System.Text;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 命名规则
    /// </summary>
    public static class NamingUtility
    {
        /// <summary>
        /// 转化为Pascal,命名需要规范
        /// </summary>
        /// <param name="name">名字</param>
        /// <returns></returns>
        public static string ToPascal(string name)
        {
            char[] chars = name.ToCharArray();
            int len = chars.Length;
            char prevChar = Chars.Nul;
            //将Underline转化为帕斯卡
            char c;
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                //替换掉下划线,使得该字符为null
                if (c == Chars.Underline)
                {
                    chars[i] = Chars.Nul;
                }
                //将该位置字母设置为大写
                if (prevChar == Chars.Underline && c >= Chars.LowerA && c <= Chars.LowerZ)
                {
                    chars[i] = (char)(chars[i] - 32);
                }
                prevChar = c;

            }
            //首字母大写
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                //为空下一个循环
                if (c == Chars.Nul)
                {
                    continue;
                }
                //首字母大写后结束循环
                if (c >= Chars.LowerA && c <= Chars.LowerZ)
                {
                    chars[i] = (char)(chars[i] - 32);
                }
                //无论是否更改成大写字母都应该结束循环
                break;

            }
            //构建字符串
            var sb = new StringBuilder();
            foreach (var ch in chars)
            {
                if (ch != Chars.Nul)
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// 转化成驼峰,命名需要规范
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ToCamelcase(string name)
        {
            char[] chars = name.ToCharArray();
            int len = chars.Length;
            char prevChar = Chars.Nul;
            //将Underline转化为驼峰
            char c;
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                //替换掉下划线,使得该字符为null
                if (c == Chars.Underline)
                {
                    chars[i] = Chars.Nul;
                }
                //将该位置字母设置为大写
                if (prevChar == Chars.Underline && c >= Chars.LowerA && c <= Chars.LowerZ)
                {
                    chars[i] = (char)(chars[i] - 32);
                }
                prevChar = c;

            }
            //首字母小写
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                //为空下一个循环
                if (c == Chars.Nul)
                {
                    continue;
                }
                //首字母小写后结束循环
                if (c >= Chars.UpperA && c <= Chars.UpperZ)
                {
                    chars[i] = (char)(chars[i] + 32);
                }
                //无论是否更改成小写字母都应该结束循环
                break;

            }
            //构建字符串
            var sb = new StringBuilder();
            foreach (var ch in chars)
            {
                if (ch != Chars.Nul)
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// 转化成下划线,命名需要规范
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ToUnderLine(string name)
        {
            var sb = new StringBuilder();
            char[] chars = name.ToCharArray();
            int len = chars.Length;
            char c;
            //首字母改小写
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                //排除首字母是下划线
                if (c == Chars.Underline)
                {
                    continue;
                }
                //首字母小写后结束循环
                if (c >= Chars.UpperA && c <= Chars.UpperZ)
                {
                    chars[i] = (char)(chars[i] + 32);
                }
                //无论是否更改成小写字母都应该结束循环
                break;
            }
            char prevChar = Chars.Nul;
            for (int i = 0; i < len; i++)
            {
                c = chars[i];
                if (c >= Chars.UpperA && c <= Chars.UpperZ)//处理为驼峰的情况规则
                {
                    sb.Append(Chars.Underline);
                    sb.Append((char)(c + 32));
                }
                else if (prevChar == Chars.Underline && c > Chars.LowerA && c < Chars.LowerZ)
                {//处理本身为下划线的情况
                    sb.Append(Chars.Underline);
                    sb.Append(c);
                }
                else if (c != Chars.Underline)//其他情况直接追加
                {
                    sb.Append(c);
                }
                prevChar = c;
            }
            return sb.ToString();
        }
    }
}
