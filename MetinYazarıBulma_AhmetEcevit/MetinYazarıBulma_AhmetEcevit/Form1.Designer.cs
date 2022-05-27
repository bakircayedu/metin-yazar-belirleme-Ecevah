namespace MetinYazarıBulma_AhmetEcevit
{
    partial class frmVeriYapilari
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFile = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSentence = new System.Windows.Forms.ListBox();
            this.lbWord = new System.Windows.Forms.ListBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnFile.Location = new System.Drawing.Point(219, 67);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(90, 40);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Dosya Seç";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(185, 121);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(90, 40);
            this.btnStack.TabIndex = 1;
            this.btnStack.Text = "Stack Oku";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(306, 121);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(90, 40);
            this.btnTree.TabIndex = 2;
            this.btnTree.Text = "Ağaca Aktar";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnFav
            // 
            this.btnFav.Location = new System.Drawing.Point(429, 121);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(90, 40);
            this.btnFav.TabIndex = 3;
            this.btnFav.Text = "Sık Kullanılanlar";
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(565, 121);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(90, 40);
            this.btnHash.TabIndex = 4;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(185, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSentence
            // 
            this.lbSentence.FormattingEnabled = true;
            this.lbSentence.Location = new System.Drawing.Point(45, 188);
            this.lbSentence.Name = "lbSentence";
            this.lbSentence.Size = new System.Drawing.Size(351, 108);
            this.lbSentence.TabIndex = 6;
            // 
            // lbWord
            // 
            this.lbWord.FormattingEnabled = true;
            this.lbWord.Location = new System.Drawing.Point(429, 188);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(351, 108);
            this.lbWord.TabIndex = 7;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(325, 71);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(293, 32);
            this.txtFile.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(288, 340);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 32);
            this.txtSearch.TabIndex = 9;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(500, 332);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(44, 13);
            this.lblWord.TabIndex = 10;
            this.lblWord.Text = "Kelime: ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(500, 361);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(36, 13);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Sayı : ";
            // 
            // frmVeriYapilari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(841, 431);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.lbSentence);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnFile);
            this.Name = "frmVeriYapilari";
            this.Text = "Metin Yazarı Belirleme";
            this.Load += new System.EventHandler(this.frmVeriYapilari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSentence;
        private System.Windows.Forms.ListBox lbWord;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblNumber;
    }
}

