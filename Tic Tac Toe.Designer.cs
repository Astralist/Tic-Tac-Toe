namespace WindowsFormsApplication1
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(16, 28);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(80, 80);
            this.a1.TabIndex = 0;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(102, 114);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(80, 80);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(102, 200);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(80, 80);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(16, 200);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(80, 80);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.button_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(188, 114);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(80, 80);
            this.c2.TabIndex = 4;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.button_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(16, 114);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(80, 80);
            this.a2.TabIndex = 5;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.button_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(188, 28);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(80, 80);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(102, 28);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(80, 80);
            this.b1.TabIndex = 7;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(188, 200);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(80, 80);
            this.c3.TabIndex = 8;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vsPlayerToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // vsPlayerToolStripMenuItem
            // 
            this.vsPlayerToolStripMenuItem.Name = "vsPlayerToolStripMenuItem";
            this.vsPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vsPlayerToolStripMenuItem.Text = "New Game";
            this.vsPlayerToolStripMenuItem.Click += new System.EventHandler(this.vsPlayer);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 298);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsPlayerToolStripMenuItem;
    }
}

