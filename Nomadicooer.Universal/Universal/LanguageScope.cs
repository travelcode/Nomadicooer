namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 语言作用范围
    /// </summary>
    public enum LanguageScope
    {

        /// <summary>
        /// 语系;比如汉语属于汉藏语系
        /// </summary>
        Collective,
        /// <summary>
        /// 母语,民族语,大语言,宏语言。指对语言的一种笼统描述,比如汉语包括繁体也包括简体。
        /// </summary>
        Macrolanguage,
        /// <summary>
        /// 方言,旁支,变体语言。比如四川话、粤语同属于汉语。
        /// </summary>
        Individual,
        /// <summary>
        /// 方言,但是仅仅只有轻微改变,尚不能形成一种独立语言。
        /// </summary>
        Dialects,
        /// <summary>
        /// 本地语言,根据归类自定义的一种语言,定义范围在qaa-qtz之间
        /// </summary>
        Local,
        /// <summary>
        /// 特别语言代码Mis=>未编码的语言 mul=>多语言 und=>待定语言 zxx=>无语言内容,不适用
        /// </summary>
        Special,
        /// <summary>
        /// 包含所有类型
        /// </summary>
        All,
        /// <summary>
        /// 自定义未知
        /// </summary>
        Unkown,
        /// <summary>
        /// 表示不确定,未分类  
        /// </summary>
        None
    }
}
