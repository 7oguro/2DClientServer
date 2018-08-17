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
    class LoginScene : DefaultScene
    {
        public UICanvas canvas;
        public TextField usernameTF;
        public TextField passwordTF;

        public override void initialize()
        {
            base.initialize();

            setDesignResolution(800, 640, Scene.SceneResolutionPolicy.NoBorderPixelPerfect);
            Screen.setSize(800, 640);

            var skin = Skin.createDefaultSkin();

            canvas = createEntity("ui").addComponent(new UICanvas());
            canvas.isFullScreen = true;
            canvas.renderLayer = 999;

            // tables are very flexible and make good candidates to use at the root of your UI. They work much like HTML tables but with more flexibility.
            var table = canvas.stage.addElement(new Table());
            table.setWidth(200);
            table.setHeight(300);
            table.setPosition(Screen.width / 2 - 100, Screen.height / 2 - 150);
            // tell the table to fill all the available space. In this case that would be the entire screen.
            //table.setFillParent(true);
            table.setBackground(new PrimitiveDrawable(Color.Black));
            var userbameLBL = new Label("Username", skin);
            table.add(userbameLBL);
            table.row();
            usernameTF = new TextField("", skin);
            table.add(usernameTF);
            table.row();

            //SPACER
            table.add(" ");
            table.row();

            var passwordLBL = new Label("Password", skin);
            table.add(passwordLBL);
            table.row();
            passwordTF = new TextField("", skin);
            passwordTF.setPasswordMode(true);
            
            table.add(passwordTF);
            table.row();

            //SPACER
            table.add(" ");
            table.row();

            // if creating buttons with just colors (PrimitiveDrawables) it is important to explicitly set the minimum size since the colored textures created
            // are only 1x1 pixels
            var button = new Button(skin);
            button.add(new Label("Login"));
            button.onClicked += onLoginClick;
            table.add(button).setMinWidth(100).setMinHeight(30);
        }

        public void onLoginClick(Button button)
        {
            
            Console.WriteLine("Client: Login Attempt");
            //Console.WriteLine("User: " + usernameTF.getText());
            //Console.WriteLine("Password: " + passwordTF.getText());
            var username = usernameTF.getText();
            var password = passwordTF.getText();

            //ClientUDP.sendMessage("LoginAttemp", username + ":" + Utility.GerarHashMd5(password));
            ClientUDP.sendMessage("LoginAttempt", username + ":" + Utility.GerarHashMd5(password));

        }
    }
}
