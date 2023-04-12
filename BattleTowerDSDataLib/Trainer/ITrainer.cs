using System;
using System.Collections.Generic;
using BattleTowerDSDataLib.Pokemon;

namespace BattleTowerDSDataLib.Trainer
{
    public interface ITrainer
    {
        /// <summary>
        /// トレーナーの種類を取得します。
        /// </summary>
        string Class { get; }

        /// <summary>
        /// トレーナーの名前を取得します。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 使用するポケモンの列挙子を取得します。
        /// </summary>
        IEnumerable<IPokemon> UsablePokemons { get; }
    }
}
