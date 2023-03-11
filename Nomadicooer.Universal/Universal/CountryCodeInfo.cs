
using System;
using System.Text;

namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 国家代码解析结构体,用于提取枚举类CountyCode中的信息
    /// </summary>
    public struct CountryCodeInfo
    {
        private readonly int systemCode;
        private string alpha2;
        private string alpha3;
        private string domain;
        private string countryName;
        private readonly int countryCode;
        private string domainWithoutDot;
        private readonly int phoneAreaCode;
        private readonly bool canAsDomain;
        private readonly bool isIndependent;
        public CountryCodeInfo(CountryCode code)
        {
            systemCode = (int)code;
            //国家代码在前12位直接获取
            countryCode = (int)(systemCode & 0x0FFF);
            //在第13位存储了该国家是否位主权国家标志
            isIndependent = ((systemCode >> 12) & 1) == 1;
            //从第17位到第28位存储了国家电话号码
            phoneAreaCode = (int)(systemCode >> 16 & 0x0FFF);
            //在第29位存储了该国家代号是否可以作为顶级域名
            canAsDomain = ((systemCode >> 28) & 1) == 1;
            string name = code.ToString();
            alpha2 = name.Length == 2 ? name : string.Empty;
            alpha3 = name.Length == 3 ? name : string.Empty;
            countryName = string.Empty;
            domainWithoutDot = canAsDomain && name.Length == 2 ? name.ToLower() : string.Empty;
            domain = domainWithoutDot.Length > 0 ? Chars.Dot + domainWithoutDot : string.Empty;
        }
        /// <summary>
        /// 返回2字符代码
        /// </summary>
        public string Alpha2
        {
            get
            {
                if (alpha2.Length > 0)
                {
                    return alpha2;
                }

                string[] countryCodeNames = Enum.GetNames(typeof(CountryCode));
                foreach (var name in countryCodeNames)
                {
                    CountryCode countryCode = (CountryCode)Enum.Parse(typeof(CountryCode), name);
                    if ((int)countryCode == systemCode && name.Length == 2)
                    {
                        alpha2 = name;
                        return alpha2;
                    }
                }
                return alpha2;
            }
        }
        /// <summary>
        /// 返回3字符代码
        /// </summary>
        public string Alpha3
        {
            get
            {
                if (alpha3.Length > 0)
                {
                    return alpha3;
                }

                string[] countryCodeNames = Enum.GetNames(typeof(CountryCode));
                foreach (var name in countryCodeNames)
                {
                    CountryCode countryCode = (CountryCode)Enum.Parse(typeof(CountryCode), name);
                    if ((int)countryCode == systemCode && name.Length == 3)
                    {
                        alpha3 = name;
                        return alpha3;
                    }
                }
                return alpha3;
            }
        }
        /// <summary>
        /// 返回以点开头的域名,如果不支持代码作为域名返回空
        /// </summary>
        public string Domain
        {
            get
            {
                if (!canAsDomain)
                {
                    return string.Empty;
                }
                if (domain.Length > 0)
                {
                    return domain;
                }

                domain = Chars.Dot + Alpha2.ToLower();
                return domain;
            }
        }
        /// <summary>
        /// 返回无点开头的域名,如果不支持作为域名后缀返回空
        /// </summary>
        public string DomainWithoutDot
        {
            get
            {
                if (!canAsDomain)
                {
                    return string.Empty;
                }
                if (domainWithoutDot.Length > 0)
                {
                    return domainWithoutDot;
                }

                domainWithoutDot = Alpha2.ToLower();
                return DomainWithoutDot;
            }
        }
        /// <summary>
        /// 该国家电话号码区号代码
        /// </summary>
        public int PhoneAreaCode => phoneAreaCode;
        /// <summary>
        /// 判断国家代码是否可以作为顶级域名使用
        /// </summary>
        public bool CanAsDomain => canAsDomain;
        /// <summary>
        /// 返回3位数的国家代码
        /// </summary>
        public int CountryCode => countryCode;
        /// <summary>
        /// 该字段仅作参考
        /// </summary>
        public bool IsIndependent => isIndependent;
        /// <summary>
        /// 在系统中枚举类型存储的值
        /// </summary>
        public int SystemCode => systemCode;
        /// <summary>
        /// 获取到国家名称
        /// </summary>
        public string CountryName
        {
            get
            {
                #region 已经解析,直接返回
                //已经获取并且解析出变量名,直接返回
                if (countryName.Length > 0)
                {
                    return countryName;
                }
                #endregion
                #region 获取到国家名称
                CountryCode country = (CountryCode)systemCode;
                string name = country.ToString();
                //获取到国家变量名
                if (name.Length <= 3)
                {
                    string[] countryCodeNames = Enum.GetNames(typeof(CountryCode));
                    foreach (var codeName in countryCodeNames)
                    {
                        CountryCode countryCode = (CountryCode)Enum.Parse(typeof(CountryCode), codeName);
                        if ((int)countryCode == systemCode && codeName.Length > 3)
                        {
                            name = codeName;
                            break;
                        }
                    }
                }
                #endregion
                #region 解析并格式化国家名称
                StringBuilder newString = new StringBuilder();
                char[] chars = name.ToCharArray();
                newString.Append(chars[0]);
                int wordStart = 0;
                char curChar;
                bool isUpper;
                int wordLen;
                for (short i = 1; i < chars.Length; i++)
                {
                    curChar = chars[i];
                    isUpper = curChar >= Chars.UpperA && curChar <= Chars.UpperZ;
                    if (!isUpper)
                    {
                        newString.Append(curChar);
                        continue;
                    };
                    wordLen = i - wordStart;
                    //可能为Of
                    if (wordLen == 2 && chars[i - 2] == Chars.UpperO && chars[i - 1] == Chars.LowerF)
                    {
                        newString[newString.Length - wordLen] = Chars.LowerO;
                    }
                    //可能为And
                    else if (wordLen == 3 && chars[i - 3] == Chars.UpperA && chars[i - 2] == Chars.LowerN && chars[i - 1] == Chars.LowerD)
                    {
                        newString[newString.Length - wordLen] = Chars.LowerA;
                    }
                    newString.Append(Chars.Space);
                    newString.Append(curChar);
                    wordStart = i;

                }
                countryName = newString.ToString();
                return countryName;
                #endregion
            }
        }

        /// <summary>
        /// 输出系统代码16进制
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return systemCode.ToString("x8");
        }
    }
}
