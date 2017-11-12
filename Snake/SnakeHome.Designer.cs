namespace Snake {
   partial class SnakeHome {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.playButton = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.gameMenuTab = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutMenuTab = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.playMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.quitMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // playButton
         // 
         this.playButton.BackColor = System.Drawing.Color.Black;
         this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.playButton.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.playButton.ForeColor = System.Drawing.Color.Lime;
         this.playButton.Location = new System.Drawing.Point(200, 445);
         this.playButton.Name = "playButton";
         this.playButton.Size = new System.Drawing.Size(200, 75);
         this.playButton.TabIndex = 0;
         this.playButton.Text = "P L A Y";
         this.playButton.UseVisualStyleBackColor = false;
         this.playButton.Click += new System.EventHandler(this.playButton_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuTab,
            this.aboutMenuTab});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(600, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // gameMenuTab
         // 
         this.gameMenuTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMenu,
            this.quitMenu});
         this.gameMenuTab.Name = "gameMenuTab";
         this.gameMenuTab.Size = new System.Drawing.Size(50, 20);
         this.gameMenuTab.Text = "Game";
         // 
         // aboutMenuTab
         // 
         this.aboutMenuTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
         this.aboutMenuTab.Name = "aboutMenuTab";
         this.aboutMenuTab.Size = new System.Drawing.Size(52, 20);
         this.aboutMenuTab.Text = "About";
         // 
         // aboutMenu
         // 
         this.aboutMenu.Name = "aboutMenu";
         this.aboutMenu.Size = new System.Drawing.Size(152, 22);
         this.aboutMenu.Text = "About";
         // 
         // playMenu
         // 
         this.playMenu.Name = "playMenu";
         this.playMenu.Size = new System.Drawing.Size(152, 22);
         this.playMenu.Text = "Play";
         // 
         // quitMenu
         // 
         this.quitMenu.Name = "quitMenu";
         this.quitMenu.Size = new System.Drawing.Size(152, 22);
         this.quitMenu.Text = "Quit";
         // 
         // SnakeHome
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::Snake.Properties.Resources.snake_background;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(600, 550);
         this.Controls.Add(this.playButton);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "SnakeHome";
         this.Text = "Snake";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button playButton;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem gameMenuTab;
      private System.Windows.Forms.ToolStripMenuItem playMenu;
      private System.Windows.Forms.ToolStripMenuItem quitMenu;
      private System.Windows.Forms.ToolStripMenuItem aboutMenuTab;
      private System.Windows.Forms.ToolStripMenuItem aboutMenu;
   }
}

