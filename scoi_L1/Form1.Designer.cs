﻿namespace scoi_L1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addPhoto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFunction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.channalBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FunctionBox = new System.Windows.Forms.ComboBox();
            this.MaskBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1026, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)" +
    "|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Выбрать файл";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // addPhoto
            // 
            this.addPhoto.Location = new System.Drawing.Point(1142, 607);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(139, 37);
            this.addPhoto.TabIndex = 1;
            this.addPhoto.Text = "Выбрать файлы";
            this.addPhoto.UseVisualStyleBackColor = true;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1026, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(55, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(934, 516);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходное изображение 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1087, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исходное изображение 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Совместное изображение";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(974, 607);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 37);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFunction
            // 
            this.buttonFunction.Location = new System.Drawing.Point(809, 607);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(139, 37);
            this.buttonFunction.TabIndex = 8;
            this.buttonFunction.Text = "Функция";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // channalBox
            // 
            this.channalBox.FormattingEnabled = true;
            this.channalBox.Items.AddRange(new object[] {
            "RGB",
            "R",
            "G",
            "B",
            "RG",
            "RB",
            "GB"});
            this.channalBox.Location = new System.Drawing.Point(167, 584);
            this.channalBox.Name = "channalBox";
            this.channalBox.Size = new System.Drawing.Size(121, 21);
            this.channalBox.TabIndex = 10;
            this.channalBox.SelectedIndexChanged += new System.EventHandler(this.channelBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Каналы";
            // 
            // FunctionBox
            // 
            this.FunctionBox.FormattingEnabled = true;
            this.FunctionBox.Items.AddRange(new object[] {
            "Сумма",
            "Среднее арифметическое",
            "Произведение",
            "Минимум",
            "Максимум",
            "Маска"});
            this.FunctionBox.Location = new System.Drawing.Point(564, 567);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(180, 21);
            this.FunctionBox.TabIndex = 12;
            this.FunctionBox.SelectedIndexChanged += new System.EventHandler(this.FunctionBox_SelectedIndexChanged);
            // 
            // MaskBox
            // 
            this.MaskBox.FormattingEnabled = true;
            this.MaskBox.Items.AddRange(new object[] {
            "круг",
            "квадрат",
            "прямоугольник"});
            this.MaskBox.Location = new System.Drawing.Point(564, 607);
            this.MaskBox.Name = "MaskBox";
            this.MaskBox.Size = new System.Drawing.Size(180, 21);
            this.MaskBox.TabIndex = 13;
            this.MaskBox.Visible = false;
            this.MaskBox.SelectedIndexChanged += new System.EventHandler(this.MaskBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.MaskBox);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.channalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFunction);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addPhoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox channalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FunctionBox;
        private System.Windows.Forms.ComboBox MaskBox;
    }
}

