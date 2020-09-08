using System.Collections.Generic;
using System.Linq;

namespace MonoTiled.Test.Generators {
    public static class TiledModelGenerator {
        public static TiledModel Generate(
            bool infinite = true,
            IEnumerable<MapLayerModel> layers = null,
            IEnumerable<TileSetModel> tileSets = null,
            int tileHeight = 16,
            int tileWidth = 16,
            int mapHeight = 32,
            int mapWidth = 32
        ) => 
            new TiledModel {
                Infinite = infinite,
                Layers = Coalesce<MapLayerModel>(layers),
                TileSets = Coalesce<TileSetModel>(tileSets),
                TileHeight = tileHeight,
                TileWidth = tileWidth,
                MapHeight = mapHeight,
                MapWidth = mapWidth,
            };

        private static IEnumerable<T> Coalesce<T>(
            IEnumerable<T> enumerable
        ) => 
            enumerable != null ? enumerable : Enumerable.Empty<T>();
        
    }
}