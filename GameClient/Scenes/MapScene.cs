using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClient.Classes;
using Nez.Textures;

namespace GameClient.Scenes
{
    class MapScene : DefaultScene
    {
        public UICanvas canvas;


        public override void initialize()
        {
            base.initialize();

            setDesignResolution(800, 640, Scene.SceneResolutionPolicy.NoBorderPixelPerfect);
            clearColor = Color.Black;
            Screen.setSize(800, 640);

            var simpleSheet = content.Load<Texture2D>("Textures/simple-sheet-1");
            var grass = new Subtexture(simpleSheet, new Rectangle(384, 0, 32, 32));
            var grass2 = new Subtexture(simpleSheet, new Rectangle(416, 0, 32, 32));

            var floorEntity = createEntity("floor");
            for (int r = 0; r < 20; r++)
            {
                for (int c = 0; c < 20; c++)
                {
                    var grassComponent = floorEntity.addComponent(new Sprite(grass2));
                    grassComponent.setOrigin(Vector2.Zero);
                    grassComponent.setLocalOffset(new Vector2(r * 32,  c * 32));
                }
            }
            
            

        }

        public override void update()
        {
            base.update();
            

        }

        public override void unload()
        {
            base.unload();
            
        }
    }
}
