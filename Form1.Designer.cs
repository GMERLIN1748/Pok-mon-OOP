namespace Pokemon
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
            button1 = new Button();
            Name_dis = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Type_dis = new Label();
            label3 = new Label();
            Hp_dis = new Label();
            At_dis = new Label();
            Df_dis = new Label();
            Speed_dis = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 54);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 0;
            button1.Text = "Pickachu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Name_dis
            // 
            Name_dis.AutoSize = true;
            Name_dis.Location = new Point(371, 309);
            Name_dis.Name = "Name_dis";
            Name_dis.Size = new Size(70, 20);
            Name_dis.TabIndex = 1;
            Name_dis.Text = "Pokemon";
            Name_dis.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(243, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 226);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 111);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 3;
            button2.Text = "Tentacool";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 165);
            button3.Name = "button3";
            button3.Size = new Size(117, 38);
            button3.TabIndex = 4;
            button3.Text = "Staryu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 219);
            button4.Name = "button4";
            button4.Size = new Size(117, 38);
            button4.TabIndex = 5;
            button4.Text = "Goldeen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(44, 274);
            button5.Name = "button5";
            button5.Size = new Size(117, 34);
            button5.TabIndex = 6;
            button5.Text = "Ditto";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(44, 325);
            button6.Name = "button6";
            button6.Size = new Size(117, 35);
            button6.TabIndex = 7;
            button6.Text = "Wailmer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Type_dis
            // 
            Type_dis.AutoSize = true;
            Type_dis.Location = new Point(563, 111);
            Type_dis.Name = "Type_dis";
            Type_dis.Size = new Size(40, 20);
            Type_dis.TabIndex = 8;
            Type_dis.Text = "Type";
            Type_dis.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 174);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "status :";
            label3.Click += label3_Click;
            // 
            // Hp_dis
            // 
            Hp_dis.AutoSize = true;
            Hp_dis.Location = new Point(563, 208);
            Hp_dis.Name = "Hp_dis";
            Hp_dis.Size = new Size(28, 20);
            Hp_dis.TabIndex = 10;
            Hp_dis.Text = "HP";
            // 
            // At_dis
            // 
            At_dis.AutoSize = true;
            At_dis.Location = new Point(563, 242);
            At_dis.Name = "At_dis";
            At_dis.Size = new Size(51, 20);
            At_dis.TabIndex = 11;
            At_dis.Text = "Attack";
            // 
            // Df_dis
            // 
            Df_dis.AutoSize = true;
            Df_dis.Location = new Point(563, 274);
            Df_dis.Name = "Df_dis";
            Df_dis.Size = new Size(63, 20);
            Df_dis.TabIndex = 12;
            Df_dis.Text = "Defense";
            // 
            // Speed_dis
            // 
            Speed_dis.AutoSize = true;
            Speed_dis.Location = new Point(563, 309);
            Speed_dis.Name = "Speed_dis";
            Speed_dis.Size = new Size(51, 20);
            Speed_dis.TabIndex = 13;
            Speed_dis.Text = "Speed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 309);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Speed_dis);
            Controls.Add(Df_dis);
            Controls.Add(At_dis);
            Controls.Add(Hp_dis);
            Controls.Add(label3);
            Controls.Add(Type_dis);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(Name_dis);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Name_dis;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label Type_dis;
        private Label label3;
        private Label Hp_dis;
        private Label At_dis;
        private Label Df_dis;
        private Label Speed_dis;
        private Label label1;
    }
}
