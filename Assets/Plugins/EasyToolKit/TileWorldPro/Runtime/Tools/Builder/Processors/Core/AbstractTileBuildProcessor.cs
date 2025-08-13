using EasyToolKit.Inspector;
using System;
using UnityEngine;

namespace EasyToolKit.TileWorldPro
{
    [MetroFoldoutGroup("@_label")]
    [MessageBox("@Help")]
    public abstract class AbstractTileBuildProcessor : ITileBuildProcessor
    {
        [LabelText("名称")]
        [SerializeField] private string _label;

        protected abstract string Help { get; }

        public abstract void OnAfterInstantiateTile(AfterTileInstantiateParameters parameters);
        public abstract void OnBeforeInstantiateTile(BeforeTileInstantiateParameters parameters);
    }
}
