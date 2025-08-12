
using System;
using EasyToolKit.TileWorldPro;

[assembly:RegisterTileBuildProcessor(typeof(TBP_RandomMaterialsByTilePosition), "随机材质-根据瓦片位置")]
namespace EasyToolKit.TileWorldPro
{
    [Serializable]
    public class TBP_RandomMaterialsByTilePosition : AbstractTileBuildProcessor
    {
        public override void OnAfterInstantiateTile(AfterTileInstantiateParameters parameters)
        {
        }

        public override void OnBeforeInstantiateTile(BeforeTileInstantiateParameters parameters)
        {
        }
    }
}