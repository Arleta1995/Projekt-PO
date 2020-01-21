namespace ProjectShelf
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TittleTextBox = new System.Windows.Forms.TextBox();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TittleLabel = new System.Windows.Forms.Label();
            this.AutorLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.QuestLabel = new System.Windows.Forms.Label();
            this.ShelfImage = new System.Windows.Forms.PictureBox();
            this.OpenBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // TittleTextBox
            // 
            this.TittleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TittleTextBox.Location = new System.Drawing.Point(264, 53);
            this.TittleTextBox.Name = "TittleTextBox";
            this.TittleTextBox.Size = new System.Drawing.Size(237, 26);
            this.TittleTextBox.TabIndex = 1;
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutorTextBox.Location = new System.Drawing.Point(264, 91);
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(237, 26);
            this.AutorTextBox.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusTextBox.Location = new System.Drawing.Point(264, 126);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(237, 26);
            this.StatusTextBox.TabIndex = 3;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypeTextBox.Location = new System.Drawing.Point(264, 162);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(237, 26);
            this.TypeTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchButton.Location = new System.Drawing.Point(551, 175);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(189, 40);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TittleLabel.Location = new System.Drawing.Point(160, 56);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(49, 20);
            this.TittleLabel.TabIndex = 6;
            this.TittleLabel.Text = "Tittle";
            this.TittleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AutorLabel
            // 
            this.AutorLabel.AutoSize = true;
            this.AutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutorLabel.Location = new System.Drawing.Point(160, 94);
            this.AutorLabel.Name = "AutorLabel";
            this.AutorLabel.Size = new System.Drawing.Size(53, 20);
            this.AutorLabel.TabIndex = 7;
            this.AutorLabel.Text = "Autor";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(160, 129);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(62, 20);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypeLabel.Location = new System.Drawing.Point(160, 165);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(47, 20);
            this.TypeLabel.TabIndex = 9;
            this.TypeLabel.Text = "Type";
            // 
            // QuestLabel
            // 
            this.QuestLabel.AutoSize = true;
            this.QuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestLabel.Location = new System.Drawing.Point(250, 9);
            this.QuestLabel.Name = "QuestLabel";
            this.QuestLabel.Size = new System.Drawing.Size(262, 24);
            this.QuestLabel.TabIndex = 10;
            this.QuestLabel.Text = "What\'s on your book shelf?";
            // 
            // ShelfImage
            // 
            this.ShelfImage.Location = new System.Drawing.Point(507, 12);
            this.ShelfImage.Name = "ShelfImage";
            this.ShelfImage.Size = new System.Drawing.Size(292, 157);
            this.ShelfImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShelfImage.TabIndex = 11;
            this.ShelfImage.TabStop = false;
            this.ShelfImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenBook
            // 
            this.OpenBook.Location = new System.Drawing.Point(2, 9);
            this.OpenBook.Name = "OpenBook";
            this.OpenBook.Size = new System.Drawing.Size(152, 206);
            this.OpenBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenBook.TabIndex = 12;
            this.OpenBook.TabStop = false;
            this.OpenBook.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenBook);
            this.Controls.Add(this.ShelfImage);
            this.Controls.Add(this.QuestLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AutorLabel);
            this.Controls.Add(this.TittleLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.AutorTextBox);
            this.Controls.Add(this.TittleTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TittleTextBox;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.Label AutorLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label QuestLabel;
        private System.Windows.Forms.PictureBox ShelfImage;
        private System.Windows.Forms.PictureBox OpenBook;
    }
}

