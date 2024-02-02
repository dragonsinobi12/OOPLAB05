namespace LAB005
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pokemon = new Label();
            enemy = new Label();
            pk1 = new Button();
            pk2 = new Button();
            pk3 = new Button();
            pk4 = new Button();
            pk5 = new Button();
            pk6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(70, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(500, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pokemon
            // 
            pokemon.AutoSize = true;
            pokemon.Location = new Point(116, 220);
            pokemon.Name = "pokemon";
            pokemon.Size = new Size(87, 15);
            pokemon.TabIndex = 2;
            pokemon.Text = "Your_Pokemon";
            // 
            // enemy
            // 
            enemy.AutoSize = true;
            enemy.Location = new Point(573, 220);
            enemy.Name = "enemy";
            enemy.Size = new Size(43, 15);
            enemy.TabIndex = 3;
            enemy.Text = "Enemy";
            enemy.Click += label1_Click;
            // 
            // pk1
            // 
            pk1.BackColor = SystemColors.ControlLightLight;
            pk1.Location = new Point(27, 272);
            pk1.Name = "pk1";
            pk1.Size = new Size(149, 23);
            pk1.TabIndex = 4;
            pk1.Text = "Load Pokemon";
            pk1.UseVisualStyleBackColor = false;
            pk1.Click += pk1_Click;
            // 
            // pk2
            // 
            pk2.BackColor = SystemColors.ControlLightLight;
            pk2.Location = new Point(192, 272);
            pk2.Name = "pk2";
            pk2.Size = new Size(149, 23);
            pk2.TabIndex = 5;
            pk2.Text = "Load Pokemon";
            pk2.UseVisualStyleBackColor = false;
            pk2.Click += pk2_Click;
            // 
            // pk3
            // 
            pk3.BackColor = SystemColors.ControlLightLight;
            pk3.Location = new Point(27, 312);
            pk3.Name = "pk3";
            pk3.Size = new Size(149, 23);
            pk3.TabIndex = 6;
            pk3.Text = "Load Pokemon";
            pk3.UseVisualStyleBackColor = false;
            pk3.Click += pk3_Click;
            // 
            // pk4
            // 
            pk4.BackColor = SystemColors.ControlLightLight;
            pk4.Location = new Point(192, 312);
            pk4.Name = "pk4";
            pk4.Size = new Size(149, 23);
            pk4.TabIndex = 7;
            pk4.Text = "Load Pokemon";
            pk4.UseVisualStyleBackColor = false;
            pk4.Click += pk4_Click;
            // 
            // pk5
            // 
            pk5.BackColor = SystemColors.ControlLightLight;
            pk5.Location = new Point(27, 351);
            pk5.Name = "pk5";
            pk5.Size = new Size(149, 23);
            pk5.TabIndex = 8;
            pk5.Text = "Load Pokemon";
            pk5.UseVisualStyleBackColor = false;
            pk5.Click += pk5_Click;
            // 
            // pk6
            // 
            pk6.BackColor = SystemColors.ControlLightLight;
            pk6.Location = new Point(192, 351);
            pk6.Name = "pk6";
            pk6.Size = new Size(149, 23);
            pk6.TabIndex = 9;
            pk6.Text = "Load Pokemon";
            pk6.UseVisualStyleBackColor = false;
            pk6.Click += pk6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pk6);
            Controls.Add(pk5);
            Controls.Add(pk4);
            Controls.Add(pk3);
            Controls.Add(pk2);
            Controls.Add(pk1);
            Controls.Add(enemy);
            Controls.Add(pokemon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label pokemon;
        private Label enemy;
        private Button pk1;
        private Button pk2;
        private Button pk3;
        private Button pk4;
        private Button pk5;
        private Button pk6;
    }
}
