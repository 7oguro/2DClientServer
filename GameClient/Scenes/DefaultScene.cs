using Nez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClient.Classes;

namespace GameClient.Scenes
{
    class DefaultScene : Scene
    {
        public DefaultScene()
        {
            addRenderer(new DefaultRenderer());
        }

        public override void update()
        {
            base.update();

            SceneController();
        }

        private void SceneController()
        {
            if(Events._sceneList.Count > 0)
            {
                Type nextScene = Events._sceneList.First();
                int indx = Events._sceneList.IndexOf(nextScene);
                Events._sceneList.RemoveAt(indx);
                Core.startSceneTransition(new FadeTransition(() => Activator.CreateInstance(nextScene) as Scene));

            }
        }
    }
}
