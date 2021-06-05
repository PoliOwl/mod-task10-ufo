namespace App
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
            this.field = new System.Windows.Forms.PictureBox();
            this.results = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.x1t = new System.Windows.Forms.TextBox();
            this.x1l = new System.Windows.Forms.Label();
            this.y1l = new System.Windows.Forms.Label();
            this.y1t = new System.Windows.Forms.TextBox();
            this.x2l = new System.Windows.Forms.Label();
            this.x2t = new System.Windows.Forms.TextBox();
            this.y2l = new System.Windows.Forms.Label();
            this.y2t = new System.Windows.Forms.TextBox();
            this.maxNl = new System.Windows.Forms.Label();
            this.maxNt = new System.Windows.Forms.TextBox();
            this.minNl = new System.Windows.Forms.Label();
            this.minNt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.field)).BeginInit();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(12, 144);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(594, 455);
            this.field.TabIndex = 0;
            this.field.TabStop = false;
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.Location = new System.Drawing.Point(631, 144);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(343, 446);
            this.results.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Claculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1t
            // 
            this.x1t.Location = new System.Drawing.Point(68, 26);
            this.x1t.Name = "x1t";
            this.x1t.Size = new System.Drawing.Size(100, 20);
            this.x1t.TabIndex = 3;
            this.x1t.Text = "20";
            // 
            // x1l
            // 
            this.x1l.AutoSize = true;
            this.x1l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.x1l.Location = new System.Drawing.Point(40, 26);
            this.x1l.Name = "x1l";
            this.x1l.Size = new System.Drawing.Size(22, 17);
            this.x1l.TabIndex = 4;
            this.x1l.Text = "x1";
            this.x1l.Click += new System.EventHandler(this.label1_Click);
            // 
            // y1l
            // 
            this.y1l.AutoSize = true;
            this.y1l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.y1l.Location = new System.Drawing.Point(40, 52);
            this.y1l.Name = "y1l";
            this.y1l.Size = new System.Drawing.Size(23, 17);
            this.y1l.TabIndex = 6;
            this.y1l.Text = "y1";
            // 
            // y1t
            // 
            this.y1t.Location = new System.Drawing.Point(68, 52);
            this.y1t.Name = "y1t";
            this.y1t.Size = new System.Drawing.Size(100, 20);
            this.y1t.TabIndex = 5;
            this.y1t.Text = "755";
            // 
            // x2l
            // 
            this.x2l.AutoSize = true;
            this.x2l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.x2l.Location = new System.Drawing.Point(193, 26);
            this.x2l.Name = "x2l";
            this.x2l.Size = new System.Drawing.Size(22, 17);
            this.x2l.TabIndex = 8;
            this.x2l.Text = "x2";
            // 
            // x2t
            // 
            this.x2t.Location = new System.Drawing.Point(221, 26);
            this.x2t.Name = "x2t";
            this.x2t.Size = new System.Drawing.Size(100, 20);
            this.x2t.TabIndex = 7;
            this.x2t.Text = "800";
            this.x2t.TextChanged += new System.EventHandler(this.x2t_TextChanged);
            // 
            // y2l
            // 
            this.y2l.AutoSize = true;
            this.y2l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.y2l.Location = new System.Drawing.Point(193, 52);
            this.y2l.Name = "y2l";
            this.y2l.Size = new System.Drawing.Size(23, 17);
            this.y2l.TabIndex = 10;
            this.y2l.Text = "y2";
            // 
            // y2t
            // 
            this.y2t.Location = new System.Drawing.Point(221, 52);
            this.y2t.Name = "y2t";
            this.y2t.Size = new System.Drawing.Size(100, 20);
            this.y2t.TabIndex = 9;
            this.y2t.Text = "20";
            // 
            // maxNl
            // 
            this.maxNl.AutoSize = true;
            this.maxNl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxNl.Location = new System.Drawing.Point(370, 26);
            this.maxNl.Name = "maxNl";
            this.maxNl.Size = new System.Drawing.Size(47, 17);
            this.maxNl.TabIndex = 12;
            this.maxNl.Text = "Max N";
            // 
            // maxNt
            // 
            this.maxNt.Location = new System.Drawing.Point(422, 25);
            this.maxNt.Name = "maxNt";
            this.maxNt.Size = new System.Drawing.Size(100, 20);
            this.maxNt.TabIndex = 11;
            this.maxNt.Text = "15";
            // 
            // minNl
            // 
            this.minNl.AutoSize = true;
            this.minNl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minNl.Location = new System.Drawing.Point(370, 53);
            this.minNl.Name = "minNl";
            this.minNl.Size = new System.Drawing.Size(44, 17);
            this.minNl.TabIndex = 14;
            this.minNl.Text = "Min N";
            // 
            // minNt
            // 
            this.minNt.Location = new System.Drawing.Point(422, 52);
            this.minNt.Name = "minNt";
            this.minNt.Size = new System.Drawing.Size(100, 20);
            this.minNt.TabIndex = 13;
            this.minNt.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 611);
            this.Controls.Add(this.minNl);
            this.Controls.Add(this.minNt);
            this.Controls.Add(this.maxNl);
            this.Controls.Add(this.maxNt);
            this.Controls.Add(this.y2l);
            this.Controls.Add(this.y2t);
            this.Controls.Add(this.x2l);
            this.Controls.Add(this.x2t);
            this.Controls.Add(this.y1l);
            this.Controls.Add(this.y1t);
            this.Controls.Add(this.x1l);
            this.Controls.Add(this.x1t);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.field);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox field;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox x1t;
        private System.Windows.Forms.Label x1l;
        private System.Windows.Forms.Label y1l;
        private System.Windows.Forms.TextBox y1t;
        private System.Windows.Forms.Label x2l;
        private System.Windows.Forms.TextBox x2t;
        private System.Windows.Forms.Label y2l;
        private System.Windows.Forms.TextBox y2t;
        private System.Windows.Forms.Label maxNl;
        private System.Windows.Forms.TextBox maxNt;
        private System.Windows.Forms.Label minNl;
        private System.Windows.Forms.TextBox minNt;
    }
}

