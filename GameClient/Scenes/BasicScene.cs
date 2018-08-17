using Nez;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace GameClient.Scenes
{
    [SampleScene("Basic Scene", 9999, "Scene with a single Entity. The minimum to have something to show")]
    public class BasicScene : SampleScene
    {
        public override void initialize()
        {
            base.initialize();

            // default to 1280x720 with no SceneResolutionPolicy
            setDesignResolution(800, 640, Scene.SceneResolutionPolicy.NoBorderPixelPerfect);
            Screen.setSize(800, 640);            
        }
    }
}