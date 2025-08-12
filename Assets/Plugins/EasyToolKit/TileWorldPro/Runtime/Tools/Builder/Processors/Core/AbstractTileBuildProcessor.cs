using System;
using UnityEngine;

namespace EasyToolKit.TileWorldPro
{
    [Serializable]
    public abstract class AbstractTileBuildProcessor : ITileBuildProcessor
    {
        [SerializeField] private string _label;
        public string Label => _label;

        public abstract void OnAfterInstantiateTile(AfterTileInstantiateParameters parameters);
        public abstract void OnBeforeInstantiateTile(BeforeTileInstantiateParameters parameters);
    }
}