using System;

namespace Nomadicooer.Core
{
    /// <summary>
    /// 版本平台枚举,包括操作系统和软件平台
    /// </summary>
    [Flags]
    public enum Platform
    {
        /// <summary>
        /// 通用平台
        /// </summary>
        None=0,
        /// <summary>
        /// windows操作系统
        /// </summary>
        Windows=1,
        /// <summary>
        /// 操作系统为 Unix
        /// </summary>
        Unix=2,
        /// <summary>
        /// 一款开源的类UNIX系统,但不是UNIX系统
        /// </summary>
        Linux=4,
        /// <summary>
        /// Linux的一个分支系统,目前主流移动操作系统
        /// </summary>
        Android=8,
        /// <summary>
        /// 一款游戏引擎
        /// </summary>
        Unity=16
    }
}
