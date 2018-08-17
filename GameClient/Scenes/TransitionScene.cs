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

namespace GameClient.Scenes
{
    class TransitionScene : DefaultScene
    {
        public UICanvas canvas;
        public Label loadingLBL;
        public int loadingTimer = 0;
        public ITimer loadingSchedule;


        public override void initialize()
        {
            base.initialize();

            setDesignResolution(800, 640, Scene.SceneResolutionPolicy.NoBorderPixelPerfect);
            clearColor = Color.Black;
            Screen.setSize(800, 640);
            

            var skin = Skin.createDefaultSkin();

            canvas = createEntity("ui").addComponent(new UICanvas());
            
            canvas.isFullScreen = true;
            canvas.renderLayer = 999;

            loadingLBL = canvas.stage.addElement(new Label("Loading...", skin));
            loadingLBL.setFontColor(Color.White);
            loadingLBL.setFontScale(3);
            loadingLBL.setPosition(25, Screen.height - 40);

            loadingSchedule = Core.schedule(2, true, new Action<ITimer>(
                (ITimer timer) =>

                loadingTimer += 1
            ));
            

        }

        public override void update()
        {
            base.update();
            Console.WriteLine(loadingTimer);            

            if (loadingTimer == 1)
            {
                loadingLBL.setText("Loading.");
            }

            if (loadingTimer == 2)
            {
                loadingLBL.setText("Loading..");
            }

            if (loadingTimer == 3)
            {
                loadingLBL.setText("Loading...");
                loadingTimer = 0;
            }


        }

        public override void unload()
        {
            base.unload();

            loadingSchedule.stop();
        }
    }
}
