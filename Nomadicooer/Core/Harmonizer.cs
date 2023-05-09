namespace Nomadicooer.Core
{
    /// <summary>
    /// 管理器聚合类,也是根据具体环境创建各类管理器的实际创建者
    /// </summary>
     public static class Harmonizer
    {
        /// <summary>
        /// 路径管理器实例
        /// </summary>
        public readonly static PathManager PathManager = PathManager.Instance;
    }
}
