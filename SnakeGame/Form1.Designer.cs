namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TMRGame = new System.Windows.Forms.Timer(this.components);
            this.PBGame = new System.Windows.Forms.PictureBox();
            this.LBLPontuação = new System.Windows.Forms.Label();
            this.CBDiff = new System.Windows.Forms.ComboBox();
            this.CBModo = new System.Windows.Forms.ComboBox();
            this.BTStartPause = new System.Windows.Forms.Button();
            this.LBLHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBGame)).BeginInit();
            this.SuspendLayout();
            // 
            // TMRGame
            // 
            this.TMRGame.Interval = 1000;
            // 
            // PBGame
            // 
            this.PBGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PBGame.Location = new System.Drawing.Point(12, 31);
            this.PBGame.Name = "PBGame";
            this.PBGame.Size = new System.Drawing.Size(390, 390);
            this.PBGame.TabIndex = 0;
            this.PBGame.TabStop = false;
            // 
            // LBLPontuação
            // 
            this.LBLPontuação.AutoSize = true;
            this.LBLPontuação.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPontuação.ForeColor = System.Drawing.Color.White;
            this.LBLPontuação.Location = new System.Drawing.Point(346, 9);
            this.LBLPontuação.Name = "LBLPontuação";
            this.LBLPontuação.Size = new System.Drawing.Size(52, 15);
            this.LBLPontuação.TabIndex = 1;
            this.LBLPontuação.Text = "Score: 0";
            // 
            // CBDiff
            // 
            this.CBDiff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBDiff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDiff.ForeColor = System.Drawing.Color.White;
            this.CBDiff.FormattingEnabled = true;
            this.CBDiff.Location = new System.Drawing.Point(3, 4);
            this.CBDiff.Name = "CBDiff";
            this.CBDiff.Size = new System.Drawing.Size(55, 21);
            this.CBDiff.TabIndex = 2;
            // 
            // CBModo
            // 
            this.CBModo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CBModo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModo.ForeColor = System.Drawing.Color.White;
            this.CBModo.FormattingEnabled = true;
            this.CBModo.Location = new System.Drawing.Point(64, 4);
            this.CBModo.Name = "CBModo";
            this.CBModo.Size = new System.Drawing.Size(66, 21);
            this.CBModo.TabIndex = 3;
            // 
            // BTStartPause
            // 
            this.BTStartPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTStartPause.FlatAppearance.BorderSize = 0;
            this.BTStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTStartPause.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTStartPause.ForeColor = System.Drawing.Color.White;
            this.BTStartPause.Location = new System.Drawing.Point(136, 4);
            this.BTStartPause.Name = "BTStartPause";
            this.BTStartPause.Size = new System.Drawing.Size(55, 22);
            this.BTStartPause.TabIndex = 4;
            this.BTStartPause.Text = "Start";
            this.BTStartPause.UseMnemonic = false;
            this.BTStartPause.UseVisualStyleBackColor = false;
            this.BTStartPause.Click += new System.EventHandler(this.BTStartPause_Click);
            // 
            // LBLHighScore
            // 
            this.LBLHighScore.AutoSize = true;
            this.LBLHighScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHighScore.ForeColor = System.Drawing.Color.White;
            this.LBLHighScore.Location = new System.Drawing.Point(251, 9);
            this.LBLHighScore.Name = "LBLHighScore";
            this.LBLHighScore.Size = new System.Drawing.Size(78, 15);
            this.LBLHighScore.TabIndex = 5;
            this.LBLHighScore.Text = "HighScore: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 433);
            this.Controls.Add(this.LBLHighScore);
            this.Controls.Add(this.BTStartPause);
            this.Controls.Add(this.CBModo);
            this.Controls.Add(this.CBDiff);
            this.Controls.Add(this.LBLPontuação);
            this.Controls.Add(this.PBGame);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.PBGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TMRGame;
        private System.Windows.Forms.PictureBox PBGame;
        private System.Windows.Forms.Label LBLPontuação;
        private System.Windows.Forms.ComboBox CBDiff;
        private System.Windows.Forms.ComboBox CBModo;
        private System.Windows.Forms.Button BTStartPause;
        private System.Windows.Forms.Label LBLHighScore;
    }
}

