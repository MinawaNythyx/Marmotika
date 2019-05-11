namespace Marmota
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.caixaNome = new System.Windows.Forms.TextBox();
            this.player1 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.player3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.primeiro = new System.Windows.Forms.TextBox();
            this.segundo = new System.Windows.Forms.TextBox();
            this.terceiro = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(30, 115);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 59);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // caixaNome
            // 
            this.caixaNome.Location = new System.Drawing.Point(30, 63);
            this.caixaNome.Name = "caixaNome";
            this.caixaNome.Size = new System.Drawing.Size(100, 20);
            this.caixaNome.TabIndex = 1;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(502, 154);
            this.player1.Name = "player1";
            this.player1.ReadOnly = true;
            this.player1.Size = new System.Drawing.Size(100, 20);
            this.player1.TabIndex = 2;
            this.player1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(502, 190);
            this.player2.Name = "player2";
            this.player2.ReadOnly = true;
            this.player2.Size = new System.Drawing.Size(100, 20);
            this.player2.TabIndex = 3;
            // 
            // player3
            // 
            this.player3.Location = new System.Drawing.Point(502, 224);
            this.player3.Name = "player3";
            this.player3.ReadOnly = true;
            this.player3.Size = new System.Drawing.Size(100, 20);
            this.player3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "HighScore";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(30, 200);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 66);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // primeiro
            // 
            this.primeiro.Location = new System.Drawing.Point(613, 154);
            this.primeiro.Name = "primeiro";
            this.primeiro.ReadOnly = true;
            this.primeiro.Size = new System.Drawing.Size(24, 20);
            this.primeiro.TabIndex = 7;
            // 
            // segundo
            // 
            this.segundo.Location = new System.Drawing.Point(613, 190);
            this.segundo.Name = "segundo";
            this.segundo.ReadOnly = true;
            this.segundo.Size = new System.Drawing.Size(24, 20);
            this.segundo.TabIndex = 8;
            // 
            // terceiro
            // 
            this.terceiro.Location = new System.Drawing.Point(613, 224);
            this.terceiro.Name = "terceiro";
            this.terceiro.ReadOnly = true;
            this.terceiro.Size = new System.Drawing.Size(24, 20);
            this.terceiro.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(665, 581);
            this.Controls.Add(this.terceiro);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primeiro);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.caixaNome);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox caixaNome;
        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.TextBox player3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox primeiro;
        private System.Windows.Forms.TextBox segundo;
        private System.Windows.Forms.TextBox terceiro;
        private System.Windows.Forms.Timer timer1;
    }
}

