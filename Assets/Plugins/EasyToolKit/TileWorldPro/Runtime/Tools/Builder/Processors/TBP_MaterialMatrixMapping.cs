using System;
using System.Collections.Generic;
using EasyToolKit.Inspector;
using EasyToolKit.TileWorldPro;
using UnityEngine;

[assembly: RegisterTileBuildProcessor(typeof(TBP_MaterialMatrixMapping), "材质矩阵映射")]
namespace EasyToolKit.TileWorldPro
{
    [Serializable]
    public class MaterialMatrix : List<Material>
    {
        public MaterialMatrix()
        {
        }
    }

    [Serializable]
    public class TBP_MaterialMatrixMapping : AbstractTileBuildProcessor
    {
        private MaterialMatrix _materialMatrix;

        public enum Modes
        {
            [LabelText("根据瓦片坐标")]
            ByTilePosition
        }

        [LabelText("映射模式")]
        public Modes Mode;

        [LabelText("目标瓦片地形规则")]
        public TerrainTileRuleType TargetTileRuleType;

        [LabelText("矩阵大小")]
        public int MatrixSize = 2;

        protected override string Help => "将材质矩阵中定义的材质，按照指定的映射模式，映射到对应瓦片上。";

        public override void OnAfterInstantiateTile(AfterTileInstantiateParameters parameters)
        {
        }

        public override void OnBeforeInstantiateTile(BeforeTileInstantiateParameters parameters)
        {
        }
    }
}
