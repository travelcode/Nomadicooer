using System;
using System.Collections.Generic;

namespace Nomadicooer.Translator
{
    /// <summary>
    /// 翻译工厂类,用于动态更换翻译平台
    /// </summary>
    public  class TranslateFactory : ITranslator
    {
        
        private static readonly Dictionary<string, Type> registers = new Dictionary<string, Type>();
       
        private static ITranslator Instance;
        /// <summary>
        /// 密封该类,防止外部实例化
        /// </summary>
         private TranslateFactory() { }

        /// <summary>
        /// 获取和注册当前字典
        /// </summary>
        public static Dictionary<string, Type> Registers => registers;

        public ITranslateResponse Translate(string from, string to, params string[] querys)
        {

            throw new System.NotImplementedException();
        }
    }
}
