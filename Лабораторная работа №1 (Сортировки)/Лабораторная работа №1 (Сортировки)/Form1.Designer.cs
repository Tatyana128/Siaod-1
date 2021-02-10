namespace Лабораторная_работа__1__Сортировки_
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.SortClassic = new System.Windows.Forms.RadioButton();
            this.SortFast = new System.Windows.Forms.RadioButton();
            this.SortShella = new System.Windows.Forms.RadioButton();
            this.SortExchange = new System.Windows.Forms.RadioButton();
            this.SortInsert = new System.Windows.Forms.RadioButton();
            this.SortChoice = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.SortClassic);
            this.GroupBox1.Controls.Add(this.SortFast);
            this.GroupBox1.Controls.Add(this.SortShella);
            this.GroupBox1.Controls.Add(this.SortExchange);
            this.GroupBox1.Controls.Add(this.SortInsert);
            this.GroupBox1.Controls.Add(this.SortChoice);
            this.GroupBox1.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(926, 271);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Выберите вид сортировки:";
            // 
            // SortClassic
            // 
            this.SortClassic.AutoSize = true;
            this.SortClassic.Location = new System.Drawing.Point(436, 107);
            this.SortClassic.Name = "SortClassic";
            this.SortClassic.Size = new System.Drawing.Size(438, 43);
            this.SortClassic.TabIndex = 7;
            this.SortClassic.TabStop = true;
            this.SortClassic.Text = "встроенная сортировка ";
            this.SortClassic.UseVisualStyleBackColor = true;
            this.SortClassic.CheckedChanged += new System.EventHandler(this.SortClassic_CheckedChanged);
            // 
            // SortFast
            // 
            this.SortFast.AutoSize = true;
            this.SortFast.Location = new System.Drawing.Point(436, 58);
            this.SortFast.Name = "SortFast";
            this.SortFast.Size = new System.Drawing.Size(387, 43);
            this.SortFast.TabIndex = 6;
            this.SortFast.TabStop = true;
            this.SortFast.Text = "быстрая сортировка ";
            this.SortFast.UseVisualStyleBackColor = true;
            this.SortFast.CheckedChanged += new System.EventHandler(this.SortFast_CheckedChanged);
            // 
            // SortShella
            // 
            this.SortShella.AutoSize = true;
            this.SortShella.Location = new System.Drawing.Point(17, 205);
            this.SortShella.Name = "SortShella";
            this.SortShella.Size = new System.Drawing.Size(342, 43);
            this.SortShella.TabIndex = 3;
            this.SortShella.TabStop = true;
            this.SortShella.Text = "сортировка Шелла";
            this.SortShella.UseVisualStyleBackColor = true;
            this.SortShella.CheckedChanged += new System.EventHandler(this.SortShella_CheckedChanged);
            // 
            // SortExchange
            // 
            this.SortExchange.AutoSize = true;
            this.SortExchange.Location = new System.Drawing.Point(17, 156);
            this.SortExchange.Name = "SortExchange";
            this.SortExchange.Size = new System.Drawing.Size(380, 43);
            this.SortExchange.TabIndex = 2;
            this.SortExchange.TabStop = true;
            this.SortExchange.Text = "сортировка обменом";
            this.SortExchange.UseVisualStyleBackColor = true;
            this.SortExchange.CheckedChanged += new System.EventHandler(this.SortExchange_CheckedChanged);
            // 
            // SortInsert
            // 
            this.SortInsert.AutoSize = true;
            this.SortInsert.Location = new System.Drawing.Point(17, 107);
            this.SortInsert.Name = "SortInsert";
            this.SortInsert.Size = new System.Drawing.Size(391, 43);
            this.SortInsert.TabIndex = 1;
            this.SortInsert.TabStop = true;
            this.SortInsert.Text = "сортировка вставкой";
            this.SortInsert.UseVisualStyleBackColor = true;
            this.SortInsert.CheckedChanged += new System.EventHandler(this.SortInsert_CheckedChanged);
            // 
            // SortChoice
            // 
            this.SortChoice.AutoSize = true;
            this.SortChoice.Checked = true;
            this.SortChoice.Location = new System.Drawing.Point(17, 58);
            this.SortChoice.Name = "SortChoice";
            this.SortChoice.Size = new System.Drawing.Size(394, 43);
            this.SortChoice.TabIndex = 0;
            this.SortChoice.TabStop = true;
            this.SortChoice.Text = "сортировка выбором ";
            this.SortChoice.UseVisualStyleBackColor = true;
            this.SortChoice.CheckedChanged += new System.EventHandler(this.SortChoice_CheckedChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGo.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(264, 317);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(442, 78);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Выполнить сортировку сгенерированной матрицы";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 407);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Сортировки";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton SortFast;
        private System.Windows.Forms.RadioButton SortShella;
        private System.Windows.Forms.RadioButton SortExchange;
        private System.Windows.Forms.RadioButton SortInsert;
        private System.Windows.Forms.RadioButton SortChoice;
        private System.Windows.Forms.RadioButton SortClassic;
    }
}

