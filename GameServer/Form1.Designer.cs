namespace GameServer
{
    partial class formServer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.textServerStatus = new System.Windows.Forms.Label();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabSystem = new System.Windows.Forms.TabPage();
            this.TextBoxSystem = new System.Windows.Forms.TextBox();
            this.TabUsers = new System.Windows.Forms.TabPage();
            this.dataUsersGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameserverDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameserverDataSet = new GameServer.gameserverDataSet();
            this.TabMaps = new System.Windows.Forms.TabPage();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.usersTableAdapter = new GameServer.gameserverDataSetTableAdapters.usersTableAdapter();
            this.TabMain.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.TabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameserverDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameserverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(489, 197);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(75, 23);
            this.buttonStartServer.TabIndex = 0;
            this.buttonStartServer.Text = "Start";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.Location = new System.Drawing.Point(489, 226);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(75, 23);
            this.buttonStopServer.TabIndex = 1;
            this.buttonStopServer.Text = "Stop";
            this.buttonStopServer.UseVisualStyleBackColor = true;
            this.buttonStopServer.Click += new System.EventHandler(this.buttonStopServer_Click);
            // 
            // textServerStatus
            // 
            this.textServerStatus.AutoSize = true;
            this.textServerStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textServerStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.textServerStatus.Location = new System.Drawing.Point(527, 21);
            this.textServerStatus.Name = "textServerStatus";
            this.textServerStatus.Size = new System.Drawing.Size(37, 13);
            this.textServerStatus.TabIndex = 2;
            this.textServerStatus.Text = "Offline";
            this.textServerStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textServerStatus.Click += new System.EventHandler(this.textServerStatus_Click);
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Location = new System.Drawing.Point(481, 21);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(40, 13);
            this.labelServerStatus.TabIndex = 3;
            this.labelServerStatus.Text = "Status:";
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabSystem);
            this.TabMain.Controls.Add(this.TabUsers);
            this.TabMain.Controls.Add(this.TabMaps);
            this.TabMain.Location = new System.Drawing.Point(12, 21);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(463, 221);
            this.TabMain.TabIndex = 1;
            // 
            // TabSystem
            // 
            this.TabSystem.Controls.Add(this.TextBoxSystem);
            this.TabSystem.Location = new System.Drawing.Point(4, 22);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.TabSystem.Size = new System.Drawing.Size(455, 195);
            this.TabSystem.TabIndex = 2;
            this.TabSystem.Text = "System";
            this.TabSystem.UseVisualStyleBackColor = true;
            // 
            // TextBoxSystem
            // 
            this.TextBoxSystem.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxSystem.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSystem.Multiline = true;
            this.TextBoxSystem.Name = "TextBoxSystem";
            this.TextBoxSystem.ReadOnly = true;
            this.TextBoxSystem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxSystem.Size = new System.Drawing.Size(455, 195);
            this.TextBoxSystem.TabIndex = 0;
            this.TextBoxSystem.TextChanged += new System.EventHandler(this.TextBoxSystem_TextChanged);
            // 
            // TabUsers
            // 
            this.TabUsers.Controls.Add(this.dataUsersGridView);
            this.TabUsers.Location = new System.Drawing.Point(4, 22);
            this.TabUsers.Name = "TabUsers";
            this.TabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.TabUsers.Size = new System.Drawing.Size(455, 195);
            this.TabUsers.TabIndex = 0;
            this.TabUsers.Text = "Users";
            this.TabUsers.UseVisualStyleBackColor = true;
            // 
            // dataUsersGridView
            // 
            this.dataUsersGridView.AutoGenerateColumns = false;
            this.dataUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataUsersGridView.DataSource = this.usersBindingSource;
            this.dataUsersGridView.Location = new System.Drawing.Point(0, 0);
            this.dataUsersGridView.Name = "dataUsersGridView";
            this.dataUsersGridView.Size = new System.Drawing.Size(449, 192);
            this.dataUsersGridView.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.gameserverDataSetBindingSource;
            // 
            // gameserverDataSetBindingSource
            // 
            this.gameserverDataSetBindingSource.DataSource = this.gameserverDataSet;
            this.gameserverDataSetBindingSource.Position = 0;
            // 
            // gameserverDataSet
            // 
            this.gameserverDataSet.DataSetName = "gameserverDataSet";
            this.gameserverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabMaps
            // 
            this.TabMaps.Location = new System.Drawing.Point(4, 22);
            this.TabMaps.Name = "TabMaps";
            this.TabMaps.Padding = new System.Windows.Forms.Padding(3);
            this.TabMaps.Size = new System.Drawing.Size(455, 195);
            this.TabMaps.TabIndex = 1;
            this.TabMaps.Text = "Maps";
            this.TabMaps.UseVisualStyleBackColor = true;
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.Location = new System.Drawing.Point(489, 168);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveServer.TabIndex = 4;
            this.buttonSaveServer.Text = "Save";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            this.buttonSaveServer.Click += new System.EventHandler(this.buttonSaveServer_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // formServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 269);
            this.Controls.Add(this.buttonSaveServer);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.labelServerStatus);
            this.Controls.Add(this.textServerStatus);
            this.Controls.Add(this.buttonStopServer);
            this.Controls.Add(this.buttonStartServer);
            this.Name = "formServer";
            this.Text = "Game Server v0";
            this.Load += new System.EventHandler(this.formServer_Load);
            this.TabMain.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.TabSystem.PerformLayout();
            this.TabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameserverDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameserverDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonStopServer;
        private System.Windows.Forms.Label textServerStatus;
        private System.Windows.Forms.Label labelServerStatus;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabUsers;
        private System.Windows.Forms.TabPage TabMaps;
        public System.Windows.Forms.TabPage TabSystem;
        public System.Windows.Forms.TextBox TextBoxSystem;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.BindingSource gameserverDataSetBindingSource;
        private gameserverDataSet gameserverDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private gameserverDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataUsersGridView;
    }
}

