namespace Snake {
   partial class SnakeGame {
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.gameFramePictureBox = new System.Windows.Forms.PictureBox();
         this.sideInfoPictureBox = new System.Windows.Forms.PictureBox();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.gameMenuTab = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
         this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
         this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutMenuTab = new System.Windows.Forms.ToolStripMenuItem();
         this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameFramePictureBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sideInfoPictureBox)).BeginInit();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
         this.pictureBox1.Location = new System.Drawing.Point(545, 569);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(60, 60);
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // gameFramePictureBox
         // 
         this.gameFramePictureBox.BackColor = System.Drawing.Color.Black;
         this.gameFramePictureBox.Location = new System.Drawing.Point(5, 29);
         this.gameFramePictureBox.Name = "gameFramePictureBox";
         this.gameFramePictureBox.Size = new System.Drawing.Size(600, 600);
         this.gameFramePictureBox.TabIndex = 1;
         this.gameFramePictureBox.TabStop = false;
         // 
         // sideInfoPictureBox
         // 
         this.sideInfoPictureBox.BackColor = System.Drawing.Color.Black;
         this.sideInfoPictureBox.Location = new System.Drawing.Point(610, 24);
         this.sideInfoPictureBox.Name = "sideInfoPictureBox";
         this.sideInfoPictureBox.Size = new System.Drawing.Size(290, 610);
         this.sideInfoPictureBox.TabIndex = 0;
         this.sideInfoPictureBox.TabStop = false;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuTab,
            this.aboutMenuTab});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(900, 24);
         this.menuStrip1.TabIndex = 3;
         this.menuStrip1.Text = "menu";
         // 
         // gameMenuTab
         // 
         this.gameMenuTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuPause,
            this.menuQuit});
         this.gameMenuTab.Name = "gameMenuTab";
         this.gameMenuTab.Size = new System.Drawing.Size(50, 20);
         this.gameMenuTab.Text = "Game";
         // 
         // menuStart
         // 
         this.menuStart.Name = "menuStart";
         this.menuStart.Size = new System.Drawing.Size(105, 22);
         this.menuStart.Text = "Start";
         // 
         // menuPause
         // 
         this.menuPause.Name = "menuPause";
         this.menuPause.Size = new System.Drawing.Size(105, 22);
         this.menuPause.Text = "Pause";
         // 
         // menuQuit
         // 
         this.menuQuit.Name = "menuQuit";
         this.menuQuit.Size = new System.Drawing.Size(105, 22);
         this.menuQuit.Text = "Quit";
         // 
         // aboutMenuTab
         // 
         this.aboutMenuTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
         this.aboutMenuTab.Name = "aboutMenuTab";
         this.aboutMenuTab.Size = new System.Drawing.Size(52, 20);
         this.aboutMenuTab.Text = "About";
         // 
         // menuAbout
         // 
         this.menuAbout.Name = "menuAbout";
         this.menuAbout.Size = new System.Drawing.Size(107, 22);
         this.menuAbout.Text = "About";
         // 
         // SnakeGame
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gray;
         this.ClientSize = new System.Drawing.Size(900, 634);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.sideInfoPictureBox);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.gameFramePictureBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "SnakeGame";
         this.Text = "SnakeGame";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameFramePictureBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sideInfoPictureBox)).EndInit();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox sideInfoPictureBox;
      private System.Windows.Forms.PictureBox gameFramePictureBox;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem gameMenuTab;
      private System.Windows.Forms.ToolStripMenuItem menuStart;
      private System.Windows.Forms.ToolStripMenuItem menuPause;
      private System.Windows.Forms.ToolStripMenuItem menuQuit;
      private System.Windows.Forms.ToolStripMenuItem aboutMenuTab;
      private System.Windows.Forms.ToolStripMenuItem menuAbout;
   }
}