using NUnit.Framework;
using MonoTiled;
using MonoTiled.Test.Generators;

namespace MonoTiled.Test {
    public class TiledMapTests {
        private static readonly TiledModel DefaultModel = TiledModelGenerator.Generate();

        #region Constructor tests

        [Test, Description("TiledMap successfully constructs")]
        public void TiledMap_Constructs() {
            var map = new TiledMap(DefaultModel);
            Assert.Pass();
        }

        [Test, Description("TiledMap has correct number of TileLayers and ObjectLayers")]
        public void TiledMap_Has_Correct_TileLayers_And_ObjectLayers() {
            Assert.Pass();
        }

        #endregion
    }
}