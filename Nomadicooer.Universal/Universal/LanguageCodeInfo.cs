namespace Nomaidcooer.Universal
{
    public class LanguageCodeInfo
    {
        /// <summary>
        /// 名称
        /// </summary>
        private readonly string name;
        /// <summary>
        /// 编码
        /// </summary>
        private readonly string code;
        /// <summary>
        /// ISO6391标准
        /// </summary>
        private readonly string part1;
        /// <summary>
        /// ISO6392B标准
        /// </summary>
        private readonly string part2B;
        /// <summary>
        /// ISO6392T标准
        /// </summary>
        private readonly string part2T;
        /// <summary>
        /// 语言范围
        /// </summary>
        private readonly string scope;
        /// <summary>
        /// 语言种类
        /// </summary>
        private readonly string kind;
        /// <summary>
        /// 语系
        /// </summary>
        private readonly string collective;
        /// <summary>
        /// 所属大语言
        /// </summary>
        private readonly string macrolanguage;
        /// <summary>
        /// 别名
        /// </summary>
        private readonly string[] alias;

        public LanguageCodeInfo(string name, string code, string part1, string part2B, string part2T, string scope, string kind, string collective, string macrolanguage, string[] alias)
        {
            this.name = name;
            this.code = code;
            this.part1 = part1;
            this.part2B = part2B;
            this.part2T = part2T;
            this.scope = scope;
            this.kind = kind;
            this.collective = collective;
            this.macrolanguage = macrolanguage;
            this.alias = alias;
        }

        public string Name => name;

        public string Code => code;

        public string Part1 => part1;

        public string Part2B => part2B;

        public string Part2T => part2T;

        public string Scope => scope;

        public string Kind => kind;

        public string Collective => collective;

        public string Macrolanguage => macrolanguage;

        public string[] Alias => alias;
    }
}
