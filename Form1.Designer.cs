
namespace FiguresProject
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.drawCirclesButton = new System.Windows.Forms.Button();
            this.typeFigureLabel = new System.Windows.Forms.Label();
            this.drawAllButton = new System.Windows.Forms.Button();
            this.mainComboBox = new System.Windows.Forms.ComboBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addButton);
            this.splitContainer1.Panel2.Controls.Add(this.radiusTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.heightTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.widthTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.yTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.xTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.drawCirclesButton);
            this.splitContainer1.Panel2.Controls.Add(this.typeFigureLabel);
            this.splitContainer1.Panel2.Controls.Add(this.drawAllButton);
            this.splitContainer1.Panel2.Controls.Add(this.mainComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(896, 688);
            this.splitContainer1.SplitterDistance = 578;
            this.splitContainer1.TabIndex = 0;
            // 
            // drawCirclesButton
            // 
            this.drawCirclesButton.Location = new System.Drawing.Point(83, 590);
            this.drawCirclesButton.Name = "drawCirclesButton";
            this.drawCirclesButton.Size = new System.Drawing.Size(151, 63);
            this.drawCirclesButton.TabIndex = 3;
            this.drawCirclesButton.Text = "Нарисовать окружности";
            this.drawCirclesButton.UseVisualStyleBackColor = true;
            this.drawCirclesButton.Click += new System.EventHandler(this.drawCirclesButton_Click);
            // 
            // typeFigureLabel
            // 
            this.typeFigureLabel.AutoSize = true;
            this.typeFigureLabel.Location = new System.Drawing.Point(106, 27);
            this.typeFigureLabel.Name = "typeFigureLabel";
            this.typeFigureLabel.Size = new System.Drawing.Size(102, 20);
            this.typeFigureLabel.TabIndex = 2;
            this.typeFigureLabel.Text = "Тип фигуры:";
            // 
            // drawAllButton
            // 
            this.drawAllButton.Location = new System.Drawing.Point(83, 521);
            this.drawAllButton.Name = "drawAllButton";
            this.drawAllButton.Size = new System.Drawing.Size(151, 50);
            this.drawAllButton.TabIndex = 1;
            this.drawAllButton.Text = "Нарисовать все";
            this.drawAllButton.UseVisualStyleBackColor = true;
            this.drawAllButton.Click += new System.EventHandler(this.drawAllButton_Click);
            // 
            // mainComboBox
            // 
            this.mainComboBox.FormattingEnabled = true;
            this.mainComboBox.Location = new System.Drawing.Point(62, 65);
            this.mainComboBox.Name = "mainComboBox";
            this.mainComboBox.Size = new System.Drawing.Size(185, 28);
            this.mainComboBox.TabIndex = 0;
            this.mainComboBox.SelectedIndexChanged += new System.EventHandler(this.mainComboBox_SelectedIndexChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(147, 141);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 26);
            this.xTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Коорд. Х:";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(147, 201);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 26);
            this.yTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Коорд. Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ширина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Радиус:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(147, 268);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 26);
            this.widthTextBox.TabIndex = 11;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(147, 323);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 26);
            this.heightTextBox.TabIndex = 12;
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(147, 372);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 26);
            this.radiusTextBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(83, 438);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(151, 62);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить фигуру в список";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(21, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 429);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Фигуры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox mainComboBox;
        private System.Windows.Forms.Button drawAllButton;
        private System.Windows.Forms.Label typeFigureLabel;
        private System.Windows.Forms.Button drawCirclesButton;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

