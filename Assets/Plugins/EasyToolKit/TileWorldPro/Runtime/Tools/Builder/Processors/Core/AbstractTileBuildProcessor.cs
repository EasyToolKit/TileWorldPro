using EasyToolKit.Inspector;
using System;
using UnityEngine;

namespace EasyToolKit.TileWorldPro
{
    [MetroFoldoutGroup("@Label")]
    public abstract class AbstractTileBuildProcessor : ITileBuildProcessor
    {
        [LabelText("名称")]
        [SerializeField] private string _label;
        public string Label => _label;

        public abstract void OnAfterInstantiateTile(AfterTileInstantiateParameters parameters);
        public abstract void OnBeforeInstantiateTile(BeforeTileInstantiateParameters parameters);
    }
}
