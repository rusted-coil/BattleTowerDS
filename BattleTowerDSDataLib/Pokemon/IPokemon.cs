namespace BattleTowerDSDataLib.Pokemon
{
    public interface IPokemon
    {
        /// <summary>
        /// ポケモン名を取得します。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 持ち物名を取得します。
        /// </summary>
        string Item { get; }

        /// <summary>
        /// 性格を取得します。
        /// </summary>
        string Nature { get; }

        /// <summary>
        /// 努力値の振り方を取得します。
        /// </summary>
        string Effort { get; }

        /// <summary>
        /// 技1を取得します。
        /// </summary>
        string Move1 { get; }

        /// <summary>
        /// 技2を取得します。
        /// </summary>
        string Move2 { get; }

        /// <summary>
        /// 技3を取得します。
        /// </summary>
        string Move3 { get; }

        /// <summary>
        /// 技4を取得します。
        /// </summary>
        string Move4 { get; }
    }
}
