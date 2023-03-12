using Nomaidcooer.Universal;

namespace Nomadicooer.Xsd
{
    /// <summary>
    /// 名称策略
    /// </summary>
    public abstract class NamingStrategy
    {
        private readonly static NamingStrategy pascal = new PascalNamingStrategy();
        private readonly static NamingStrategy camelcase = new CamelcaseNamingStrategy();
        private readonly static NamingStrategy snake = new SnakeNamingStrategy();
        /// <summary>
        /// 转换为帕斯卡
        /// </summary>
        public static NamingStrategy Pascal => pascal;
        /// <summary>
        /// 转换为驼峰
        /// </summary>
        public static NamingStrategy Camelcase => camelcase;
        /// <summary>
        /// 转换为下划线
        /// </summary>
        public static NamingStrategy Snake => snake;

        private class PascalNamingStrategy : NamingStrategy
        {
            public override string Translate(string name)
            {
                return NamingUtility.ToPascal(name);
            }
        }
        private class CamelcaseNamingStrategy : NamingStrategy
        {
            public override string Translate(string name)
            {
                return NamingUtility.ToCamelcase(name);
            }
        }
        private class SnakeNamingStrategy : NamingStrategy
        {
            public override string Translate(string name)
            {
                return NamingUtility.ToUnderLine(name);
            }
        }
        /// <summary>
        /// 用于派生类写名字策略规则
        /// </summary>
        /// <param name="name">要转化的名称</param>
        /// <returns></returns>
        public abstract string Translate(string name);
    }
}
