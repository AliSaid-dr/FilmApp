namespace FilmApp
{
    partial class AddMovie
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtMovieGenre = new System.Windows.Forms.TextBox();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.txtMovieActors = new System.Windows.Forms.TextBox();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(480, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie name:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(205, 114);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(255, 26);
            this.txtMovieName.TabIndex = 2;
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(205, 195);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(255, 26);
            this.txtMovieGenre.TabIndex = 3;
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(205, 278);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(255, 26);
            this.txtMovieDirector.TabIndex = 4;
            // 
            // txtMovieActors
            // 
            this.txtMovieActors.Location = new System.Drawing.Point(205, 357);
            this.txtMovieActors.Name = "txtMovieActors";
            this.txtMovieActors.Size = new System.Drawing.Size(255, 26);
            this.txtMovieActors.TabIndex = 5;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(205, 429);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(255, 26);
            this.txtMovieYear.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Movie genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Movie actors:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Movie year:";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(205, 32);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(255, 26);
            this.txtMovieId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Movie id:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bookman Old Style", 16F);
            this.btnAdd.Location = new System.Drawing.Point(28, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 73);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Bookman Old Style", 16F);
            this.btnEdit.Location = new System.Drawing.Point(325, 492);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(232, 73);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Bookman Old Style", 16F);
            this.btnRemove.Location = new System.Drawing.Point(616, 492);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(232, 73);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 598);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.txtMovieActors);
            this.Controls.Add(this.txtMovieDirector);
            this.Controls.Add(this.txtMovieGenre);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddMovie";
            this.Text = "AddMovies";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.TextBox txtMovieActors;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}