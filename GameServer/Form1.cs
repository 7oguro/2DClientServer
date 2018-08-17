using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameServer.Classes;

namespace GameServer
{
    public partial class formServer : Form
    {
        public formServer()
        {
            InitializeComponent();
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            Program._serverInstance = new Server("HelloWorldGame", 11000);
        }

        private void textServerStatus_Click(object sender, EventArgs e)
        {

        }

        public void updateServerStatusText(Server.serverStatuses serverStatus)
        {
            string nText = "Undefined";
            Color nColor = Color.Violet;

            if (serverStatus == Server.serverStatuses.Online)
            {
                nText = "Online";
                nColor = Color.Green;
            }

            if (serverStatus == Server.serverStatuses.Offline)
            {

                nText = "Offline";
                nColor = Color.DarkRed;
            }

            if (serverStatus == Server.serverStatuses.Initializing)
            {
                nText = "Initializing";
                nColor = Color.Blue;
            }

            if (serverStatus == Server.serverStatuses.Shutting)
            {
                nText = "Shutting";
                nColor = Color.Yellow;
            }

            this.textServerStatus.InvokeIfRequired(s => {
                s.Text = nText;
                s.ForeColor = nColor;
            });

        }

        private void buttonStopServer_Click(object sender, EventArgs e)
        {
            Program._serverInstance.stopServer();
        }

        private void formServer_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gameserverDataSet.users'. Você pode movê-la ou removê-la conforme necessário.
            this.usersTableAdapter.Fill(this.gameserverDataSet.users);            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxSystem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveServer_Click(object sender, EventArgs e)
        {
            gameserverDataSet.usersRow newUsersRow = this.gameserverDataSet.users.NewusersRow();
            newUsersRow.username = "7oguro";
            newUsersRow.password = Utility.GerarHashMd5("12345");
            newUsersRow.status = 1;

            this.gameserverDataSet.users.Rows.Add(newUsersRow);
            this.dataUsersGridView.Refresh();
            this.usersTableAdapter.Update(this.gameserverDataSet.users);

        }
    }
}
