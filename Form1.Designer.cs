
namespace AlgorytmShow
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_genData = new System.Windows.Forms.Button();
            this.button_bubbleSort = new System.Windows.Forms.Button();
            this.label_items = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.button_SelectionSort = new System.Windows.Forms.Button();
            this.button_QuickSort = new System.Windows.Forms.Button();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_StalinSort = new System.Windows.Forms.Button();
            this.button_IdiotSort = new System.Windows.Forms.Button();
            this.button_zwariowaneSort = new System.Windows.Forms.Button();
            this.pictureBox_powierzchnia = new System.Windows.Forms.PictureBox();
            this.button_GenerujPowierzchnie = new System.Windows.Forms.Button();
            this.button_Symuluj = new System.Windows.Forms.Button();
            this.label_WynikSymulacji = new System.Windows.Forms.Label();
            this.textBox_iloscOsobnikow = new System.Windows.Forms.TextBox();
            this.listBox_Selekcje = new System.Windows.Forms.ListBox();
            this.listBox_Rozmiar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_powierzchnia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(340, 179);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_genData
            // 
            this.button_genData.Location = new System.Drawing.Point(510, 40);
            this.button_genData.Name = "button_genData";
            this.button_genData.Size = new System.Drawing.Size(99, 23);
            this.button_genData.TabIndex = 1;
            this.button_genData.Text = "GENERUJ DANE";
            this.button_genData.UseVisualStyleBackColor = true;
            this.button_genData.Click += new System.EventHandler(this.button_genData_Click);
            // 
            // button_bubbleSort
            // 
            this.button_bubbleSort.Location = new System.Drawing.Point(346, 69);
            this.button_bubbleSort.Name = "button_bubbleSort";
            this.button_bubbleSort.Size = new System.Drawing.Size(89, 23);
            this.button_bubbleSort.TabIndex = 2;
            this.button_bubbleSort.Text = "BUBBLE SORT";
            this.button_bubbleSort.UseVisualStyleBackColor = true;
            this.button_bubbleSort.Click += new System.EventHandler(this.button_bubbleSort_Click);
            // 
            // label_items
            // 
            this.label_items.AutoSize = true;
            this.label_items.Location = new System.Drawing.Point(510, 77);
            this.label_items.Name = "label_items";
            this.label_items.Size = new System.Drawing.Size(13, 15);
            this.label_items.TabIndex = 3;
            this.label_items.Text = "1";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(510, 98);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(13, 15);
            this.label_count.TabIndex = 4;
            this.label_count.Text = "1";
            // 
            // button_SelectionSort
            // 
            this.button_SelectionSort.Location = new System.Drawing.Point(346, 40);
            this.button_SelectionSort.Name = "button_SelectionSort";
            this.button_SelectionSort.Size = new System.Drawing.Size(110, 23);
            this.button_SelectionSort.TabIndex = 5;
            this.button_SelectionSort.Text = "SELECTION SORT";
            this.button_SelectionSort.UseVisualStyleBackColor = true;
            this.button_SelectionSort.Click += new System.EventHandler(this.button_SelectionSort_Click);
            // 
            // button_QuickSort
            // 
            this.button_QuickSort.Location = new System.Drawing.Point(346, 11);
            this.button_QuickSort.Name = "button_QuickSort";
            this.button_QuickSort.Size = new System.Drawing.Size(86, 23);
            this.button_QuickSort.TabIndex = 6;
            this.button_QuickSort.Text = "QUICK SORT";
            this.button_QuickSort.UseVisualStyleBackColor = true;
            this.button_QuickSort.Click += new System.EventHandler(this.button_QuickSort_Click);
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(510, 11);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(99, 23);
            this.textBox_count.TabIndex = 7;
            // 
            // button_StalinSort
            // 
            this.button_StalinSort.Location = new System.Drawing.Point(346, 156);
            this.button_StalinSort.Name = "button_StalinSort";
            this.button_StalinSort.Size = new System.Drawing.Size(82, 23);
            this.button_StalinSort.TabIndex = 8;
            this.button_StalinSort.Text = "STALIN SORT";
            this.button_StalinSort.UseVisualStyleBackColor = true;
            this.button_StalinSort.Click += new System.EventHandler(this.button_StalinSort_Click);
            // 
            // button_IdiotSort
            // 
            this.button_IdiotSort.Location = new System.Drawing.Point(346, 98);
            this.button_IdiotSort.Name = "button_IdiotSort";
            this.button_IdiotSort.Size = new System.Drawing.Size(89, 23);
            this.button_IdiotSort.TabIndex = 9;
            this.button_IdiotSort.Text = "GŁUPIE SORT";
            this.button_IdiotSort.UseVisualStyleBackColor = true;
            this.button_IdiotSort.Click += new System.EventHandler(this.button_IdiotSort_Click);
            // 
            // button_zwariowaneSort
            // 
            this.button_zwariowaneSort.Location = new System.Drawing.Point(346, 127);
            this.button_zwariowaneSort.Name = "button_zwariowaneSort";
            this.button_zwariowaneSort.Size = new System.Drawing.Size(136, 23);
            this.button_zwariowaneSort.TabIndex = 10;
            this.button_zwariowaneSort.Text = "ZWARIOWANE SORT";
            this.button_zwariowaneSort.UseVisualStyleBackColor = true;
            this.button_zwariowaneSort.Click += new System.EventHandler(this.button_zwariowaneSort_Click);
            // 
            // pictureBox_powierzchnia
            // 
            this.pictureBox_powierzchnia.Location = new System.Drawing.Point(0, 185);
            this.pictureBox_powierzchnia.Name = "pictureBox_powierzchnia";
            this.pictureBox_powierzchnia.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_powierzchnia.TabIndex = 11;
            this.pictureBox_powierzchnia.TabStop = false;
            // 
            // button_GenerujPowierzchnie
            // 
            this.button_GenerujPowierzchnie.Location = new System.Drawing.Point(306, 185);
            this.button_GenerujPowierzchnie.Name = "button_GenerujPowierzchnie";
            this.button_GenerujPowierzchnie.Size = new System.Drawing.Size(167, 23);
            this.button_GenerujPowierzchnie.TabIndex = 12;
            this.button_GenerujPowierzchnie.Text = "GENERUJ POWIERZCHNIE";
            this.button_GenerujPowierzchnie.UseVisualStyleBackColor = true;
            this.button_GenerujPowierzchnie.Click += new System.EventHandler(this.button_GenerujPowierzchnie_Click);
            // 
            // button_Symuluj
            // 
            this.button_Symuluj.Location = new System.Drawing.Point(479, 185);
            this.button_Symuluj.Name = "button_Symuluj";
            this.button_Symuluj.Size = new System.Drawing.Size(75, 23);
            this.button_Symuluj.TabIndex = 13;
            this.button_Symuluj.Text = "SYMULUJ";
            this.button_Symuluj.UseVisualStyleBackColor = true;
            this.button_Symuluj.Click += new System.EventHandler(this.button_Symuluj_Click);
            // 
            // label_WynikSymulacji
            // 
            this.label_WynikSymulacji.AutoSize = true;
            this.label_WynikSymulacji.Location = new System.Drawing.Point(479, 211);
            this.label_WynikSymulacji.Name = "label_WynikSymulacji";
            this.label_WynikSymulacji.Size = new System.Drawing.Size(111, 15);
            this.label_WynikSymulacji.TabIndex = 14;
            this.label_WynikSymulacji.Text = "WYNIK SYMULACJI:";
            // 
            // textBox_iloscOsobnikow
            // 
            this.textBox_iloscOsobnikow.Location = new System.Drawing.Point(306, 229);
            this.textBox_iloscOsobnikow.Name = "textBox_iloscOsobnikow";
            this.textBox_iloscOsobnikow.Size = new System.Drawing.Size(100, 23);
            this.textBox_iloscOsobnikow.TabIndex = 15;
            // 
            // listBox_Selekcje
            // 
            this.listBox_Selekcje.FormattingEnabled = true;
            this.listBox_Selekcje.ItemHeight = 15;
            this.listBox_Selekcje.Location = new System.Drawing.Point(306, 273);
            this.listBox_Selekcje.Name = "listBox_Selekcje";
            this.listBox_Selekcje.Size = new System.Drawing.Size(120, 214);
            this.listBox_Selekcje.TabIndex = 16;
            // 
            // listBox_Rozmiar
            // 
            this.listBox_Rozmiar.FormattingEnabled = true;
            this.listBox_Rozmiar.ItemHeight = 15;
            this.listBox_Rozmiar.Location = new System.Drawing.Point(479, 273);
            this.listBox_Rozmiar.Name = "listBox_Rozmiar";
            this.listBox_Rozmiar.Size = new System.Drawing.Size(120, 214);
            this.listBox_Rozmiar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "MAX OSOBNIKÓW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "RODZAJ SELEKCJI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "ILOŚĆ OSOBNIKÓW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Rozmiar);
            this.Controls.Add(this.listBox_Selekcje);
            this.Controls.Add(this.textBox_iloscOsobnikow);
            this.Controls.Add(this.label_WynikSymulacji);
            this.Controls.Add(this.button_Symuluj);
            this.Controls.Add(this.button_GenerujPowierzchnie);
            this.Controls.Add(this.pictureBox_powierzchnia);
            this.Controls.Add(this.button_zwariowaneSort);
            this.Controls.Add(this.button_IdiotSort);
            this.Controls.Add(this.button_StalinSort);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.button_QuickSort);
            this.Controls.Add(this.button_SelectionSort);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_items);
            this.Controls.Add(this.button_bubbleSort);
            this.Controls.Add(this.button_genData);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_powierzchnia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_genData;
        private System.Windows.Forms.Button button_bubbleSort;
        private System.Windows.Forms.Label label_items;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_SelectionSort;
        private System.Windows.Forms.Button button_QuickSort;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_StalinSort;
        private System.Windows.Forms.Button button_IdiotSort;
        private System.Windows.Forms.Button button_zwariowaneSort;
        private System.Windows.Forms.PictureBox pictureBox_powierzchnia;
        private System.Windows.Forms.Button button_GenerujPowierzchnie;
        private System.Windows.Forms.Button button_Symuluj;
        private System.Windows.Forms.Label label_WynikSymulacji;
        private System.Windows.Forms.TextBox textBox_iloscOsobnikow;
        private System.Windows.Forms.ListBox listBox_RodzajeSelekcji;
        private System.Windows.Forms.ListBox listBox_Selekcje;
        private System.Windows.Forms.ListBox listBox_Rozmiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

