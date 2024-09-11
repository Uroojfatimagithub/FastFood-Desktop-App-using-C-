namespace FastFoodApp
{
    partial class FirstCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(51, 209);
            label1.Name = "label1";
            label1.Size = new Size(387, 62);
            label1.TabIndex = 0;
            label1.Text = "Cheeseburger";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(51, 23);
            label2.Name = "label2";
            label2.Size = new Size(358, 186);
            label2.TabIndex = 1;
            label2.Text = "$19";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(51, 32);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 2;
            label3.Text = "Only";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(61, 271);
            label4.Name = "label4";
            label4.Size = new Size(422, 25);
            label4.TabIndex = 3;
            label4.Text = "With Onions and Tomato and Ketchup";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(61, 322);
            label5.Name = "label5";
            label5.Size = new Size(404, 126);
            label5.TabIndex = 4;
            label5.Text = "Lorem Ipsum is simply dummy \r\nand typesetting industry.Lorem Ipsum \r\n industry's standard dummy text ever since \r\nthe 1500s, when an unknown printer \r\nand scrambled it to make a  specimen book.\r\n\r\n";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 460);
            button1.Name = "button1";
            button1.Size = new Size(197, 41);
            button1.TabIndex = 5;
            button1.Text = "Order Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FirstCustomControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FirstCustomControl";
            Size = new Size(1018, 530);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
