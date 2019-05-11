namespace Marmota
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.playerdisplay = new System.Windows.Forms.Label();
            this.pontodisplay = new System.Windows.Forms.Label();
            this.mole1 = new System.Windows.Forms.PictureBox();
            this.mole2 = new System.Windows.Forms.PictureBox();
            this.mole3 = new System.Windows.Forms.PictureBox();
            this.mole4 = new System.Windows.Forms.PictureBox();
            this.mole5 = new System.Windows.Forms.PictureBox();
            this.mole6 = new System.Windows.Forms.PictureBox();
            this.mole7 = new System.Windows.Forms.PictureBox();
            this.mole8 = new System.Windows.Forms.PictureBox();
            this.mole9 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.começar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole9)).BeginInit();
            this.SuspendLayout();
            // 
            // playerdisplay
            // 
            this.playerdisplay.AutoSize = true;
            this.playerdisplay.Location = new System.Drawing.Point(12, 9);
            this.playerdisplay.Name = "playerdisplay";
            this.playerdisplay.Size = new System.Drawing.Size(35, 13);
            this.playerdisplay.TabIndex = 0;
            this.playerdisplay.Text = "label1";
            // 
            // pontodisplay
            // 
            this.pontodisplay.AutoSize = true;
            this.pontodisplay.Location = new System.Drawing.Point(65, 9);
            this.pontodisplay.Name = "pontodisplay";
            this.pontodisplay.Size = new System.Drawing.Size(35, 13);
            this.pontodisplay.TabIndex = 1;
            this.pontodisplay.Text = "label2";
            // 
            // mole1
            // 
            this.mole1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole1.Image = ((System.Drawing.Image)(resources.GetObject("mole1.Image")));
            this.mole1.Location = new System.Drawing.Point(234, 88);
            this.mole1.Name = "mole1";
            this.mole1.Size = new System.Drawing.Size(100, 50);
            this.mole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole1.TabIndex = 2;
            this.mole1.TabStop = false;
            this.mole1.Click += new System.EventHandler(this.mole1_Click);
            // 
            // mole2
            // 
            this.mole2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole2.Image = ((System.Drawing.Image)(resources.GetObject("mole2.Image")));
            this.mole2.Location = new System.Drawing.Point(401, 88);
            this.mole2.Name = "mole2";
            this.mole2.Size = new System.Drawing.Size(100, 50);
            this.mole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole2.TabIndex = 3;
            this.mole2.TabStop = false;
            this.mole2.Click += new System.EventHandler(this.mole2_Click);
            // 
            // mole3
            // 
            this.mole3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole3.Image = ((System.Drawing.Image)(resources.GetObject("mole3.Image")));
            this.mole3.Location = new System.Drawing.Point(572, 88);
            this.mole3.Name = "mole3";
            this.mole3.Size = new System.Drawing.Size(100, 50);
            this.mole3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole3.TabIndex = 4;
            this.mole3.TabStop = false;
            this.mole3.Click += new System.EventHandler(this.mole3_Click);
            // 
            // mole4
            // 
            this.mole4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole4.Image = ((System.Drawing.Image)(resources.GetObject("mole4.Image")));
            this.mole4.Location = new System.Drawing.Point(234, 184);
            this.mole4.Name = "mole4";
            this.mole4.Size = new System.Drawing.Size(100, 50);
            this.mole4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole4.TabIndex = 5;
            this.mole4.TabStop = false;
            this.mole4.Click += new System.EventHandler(this.mole4_Click);
            // 
            // mole5
            // 
            this.mole5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole5.Image = ((System.Drawing.Image)(resources.GetObject("mole5.Image")));
            this.mole5.Location = new System.Drawing.Point(401, 184);
            this.mole5.Name = "mole5";
            this.mole5.Size = new System.Drawing.Size(100, 50);
            this.mole5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole5.TabIndex = 6;
            this.mole5.TabStop = false;
            this.mole5.Click += new System.EventHandler(this.mole5_Click);
            // 
            // mole6
            // 
            this.mole6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole6.Image = ((System.Drawing.Image)(resources.GetObject("mole6.Image")));
            this.mole6.Location = new System.Drawing.Point(572, 184);
            this.mole6.Name = "mole6";
            this.mole6.Size = new System.Drawing.Size(100, 50);
            this.mole6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole6.TabIndex = 7;
            this.mole6.TabStop = false;
            this.mole6.Click += new System.EventHandler(this.mole6_Click);
            // 
            // mole7
            // 
            this.mole7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole7.Image = ((System.Drawing.Image)(resources.GetObject("mole7.Image")));
            this.mole7.Location = new System.Drawing.Point(234, 287);
            this.mole7.Name = "mole7";
            this.mole7.Size = new System.Drawing.Size(100, 50);
            this.mole7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole7.TabIndex = 8;
            this.mole7.TabStop = false;
            this.mole7.Click += new System.EventHandler(this.mole7_Click);
            // 
            // mole8
            // 
            this.mole8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole8.Image = ((System.Drawing.Image)(resources.GetObject("mole8.Image")));
            this.mole8.Location = new System.Drawing.Point(401, 287);
            this.mole8.Name = "mole8";
            this.mole8.Size = new System.Drawing.Size(100, 50);
            this.mole8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole8.TabIndex = 9;
            this.mole8.TabStop = false;
            this.mole8.Click += new System.EventHandler(this.mole8_Click);
            // 
            // mole9
            // 
            this.mole9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mole9.Image = ((System.Drawing.Image)(resources.GetObject("mole9.Image")));
            this.mole9.Location = new System.Drawing.Point(572, 287);
            this.mole9.Name = "mole9";
            this.mole9.Size = new System.Drawing.Size(100, 50);
            this.mole9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mole9.TabIndex = 10;
            this.mole9.TabStop = false;
            this.mole9.Click += new System.EventHandler(this.mole9_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // começar
            // 
            this.começar.Location = new System.Drawing.Point(413, 29);
            this.começar.Name = "começar";
            this.começar.Size = new System.Drawing.Size(75, 23);
            this.começar.TabIndex = 11;
            this.começar.Text = "Start";
            this.começar.UseVisualStyleBackColor = true;
            this.começar.Click += new System.EventHandler(this.começar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tempo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pontos: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.BackColor = System.Drawing.Color.Transparent;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(45, 261);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(23, 25);
            this.point.TabIndex = 15;
            this.point.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.começar);
            this.Controls.Add(this.mole9);
            this.Controls.Add(this.mole8);
            this.Controls.Add(this.mole7);
            this.Controls.Add(this.mole6);
            this.Controls.Add(this.mole5);
            this.Controls.Add(this.mole4);
            this.Controls.Add(this.mole3);
            this.Controls.Add(this.mole2);
            this.Controls.Add(this.mole1);
            this.Controls.Add(this.pontodisplay);
            this.Controls.Add(this.playerdisplay);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mole9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerdisplay;
        private System.Windows.Forms.Label pontodisplay;
        private System.Windows.Forms.PictureBox mole1;
        private System.Windows.Forms.PictureBox mole2;
        private System.Windows.Forms.PictureBox mole3;
        private System.Windows.Forms.PictureBox mole4;
        private System.Windows.Forms.PictureBox mole5;
        private System.Windows.Forms.PictureBox mole6;
        private System.Windows.Forms.PictureBox mole7;
        private System.Windows.Forms.PictureBox mole8;
        private System.Windows.Forms.PictureBox mole9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button começar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}