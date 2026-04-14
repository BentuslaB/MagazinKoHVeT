namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(449, 389);
            button4.Name = "button4";
            button4.Size = new Size(129, 36);
            button4.TabIndex = 25;
            button4.Text = "Загрузить из файла:";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(449, 347);
            button3.Name = "button3";
            button3.Size = new Size(129, 36);
            button3.TabIndex = 24;
            button3.Text = "Сохранить в файл:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(449, 289);
            button2.Name = "button2";
            button2.Size = new Size(129, 52);
            button2.TabIndex = 23;
            button2.Text = "Сортировать по цене:";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(450, 247);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 22;
            button1.Text = "Добавить товар:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(585, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 180);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(534, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(534, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(534, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 18;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(307, 68);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 349);
            listBox3.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(169, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 349);
            listBox2.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(29, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 349);
            listBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 215);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 13;
            label8.Text = "Opisanie:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 152);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "Цena:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 89);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "Imя:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(467, 68);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 10;
            label5.Text = "Добавить товар:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(585, 25);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Кол-во:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(337, 41);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Opisanie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(213, 41);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 14;
            label2.Text = "Цena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "Imя:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
