using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameClient.Scenes;
using Nez;
using Nez.Sprites;
using GameClient.Classes;

namespace GameClient
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Nez.Core
    {
        public Game1() : base(width: 800, height: 640, isFullScreen: false, enableEntitySystems: false)
        { }

        protected override void Initialize()
        {
            
            // TODO: Add your initialization logic here

            base.Initialize();

            Window.AllowUserResizing = true;
            ClientUDP.ReceiveMessages();

            // create our Scene with the DefaultRenderer and a clear color of CornflowerBlue
            //var loginScene = new LoginScene();
            var loginScene = new LoginScene();

            // set the scene so Nez can take over
            scene = loginScene;
            
        }
    }
}
