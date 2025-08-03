namespace projekt_MŻ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.arrowUP = new System.Windows.Forms.Button();
            this.arrowLEFT = new System.Windows.Forms.Button();
            this.arrowDOWN = new System.Windows.Forms.Button();
            this.arrowRIGHT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnAbility = new System.Windows.Forms.Button();
            this.btnWindspell = new System.Windows.Forms.Button();
            this.btnEarthspell = new System.Windows.Forms.Button();
            this.btnWaterspell = new System.Windows.Forms.Button();
            this.btnFirespell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrowUP
            // 
            this.arrowUP.BackColor = System.Drawing.Color.DarkGray;
            this.arrowUP.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowUP.Image = ((System.Drawing.Image)(resources.GetObject("arrowUP.Image")));
            this.arrowUP.Location = new System.Drawing.Point(682, 582);
            this.arrowUP.Name = "arrowUP";
            this.arrowUP.Size = new System.Drawing.Size(95, 47);
            this.arrowUP.TabIndex = 0;
            this.arrowUP.Text = "UP";
            this.arrowUP.UseVisualStyleBackColor = false;
            this.arrowUP.Click += new System.EventHandler(this.arrowUP_Click);
            // 
            // arrowLEFT
            // 
            this.arrowLEFT.BackColor = System.Drawing.Color.DarkGray;
            this.arrowLEFT.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLEFT.Image = ((System.Drawing.Image)(resources.GetObject("arrowLEFT.Image")));
            this.arrowLEFT.Location = new System.Drawing.Point(581, 635);
            this.arrowLEFT.Name = "arrowLEFT";
            this.arrowLEFT.Size = new System.Drawing.Size(95, 47);
            this.arrowLEFT.TabIndex = 1;
            this.arrowLEFT.Text = "LEFT";
            this.arrowLEFT.UseVisualStyleBackColor = false;
            this.arrowLEFT.Click += new System.EventHandler(this.arrowLEFT_Click);
            // 
            // arrowDOWN
            // 
            this.arrowDOWN.BackColor = System.Drawing.Color.DarkGray;
            this.arrowDOWN.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowDOWN.Image = ((System.Drawing.Image)(resources.GetObject("arrowDOWN.Image")));
            this.arrowDOWN.Location = new System.Drawing.Point(682, 635);
            this.arrowDOWN.Name = "arrowDOWN";
            this.arrowDOWN.Size = new System.Drawing.Size(95, 47);
            this.arrowDOWN.TabIndex = 3;
            this.arrowDOWN.Text = "DOWN";
            this.arrowDOWN.UseVisualStyleBackColor = false;
            this.arrowDOWN.Click += new System.EventHandler(this.arrowDOWN_Click);
            // 
            // arrowRIGHT
            // 
            this.arrowRIGHT.BackColor = System.Drawing.Color.DarkGray;
            this.arrowRIGHT.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowRIGHT.Image = ((System.Drawing.Image)(resources.GetObject("arrowRIGHT.Image")));
            this.arrowRIGHT.Location = new System.Drawing.Point(783, 635);
            this.arrowRIGHT.Name = "arrowRIGHT";
            this.arrowRIGHT.Size = new System.Drawing.Size(95, 47);
            this.arrowRIGHT.TabIndex = 2;
            this.arrowRIGHT.Text = "RIGHT";
            this.arrowRIGHT.UseVisualStyleBackColor = false;
            this.arrowRIGHT.Click += new System.EventHandler(this.arrowRIGHT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 99);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 520);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.DarkGray;
            this.btnAttack.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Image = ((System.Drawing.Image)(resources.GetObject("btnAttack.Image")));
            this.btnAttack.Location = new System.Drawing.Point(906, 579);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(100, 50);
            this.btnAttack.TabIndex = 26;
            this.btnAttack.Text = "ATTACK";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnAbility
            // 
            this.btnAbility.BackColor = System.Drawing.Color.DarkGray;
            this.btnAbility.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbility.Image = ((System.Drawing.Image)(resources.GetObject("btnAbility.Image")));
            this.btnAbility.Location = new System.Drawing.Point(906, 635);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(100, 50);
            this.btnAbility.TabIndex = 27;
            this.btnAbility.Text = "ABILITY";
            this.btnAbility.UseVisualStyleBackColor = false;
            this.btnAbility.Click += new System.EventHandler(this.btnAbility_Click);
            // 
            // btnWindspell
            // 
            this.btnWindspell.BackColor = System.Drawing.Color.Azure;
            this.btnWindspell.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindspell.Image = ((System.Drawing.Image)(resources.GetObject("btnWindspell.Image")));
            this.btnWindspell.Location = new System.Drawing.Point(27, 195);
            this.btnWindspell.Name = "btnWindspell";
            this.btnWindspell.Size = new System.Drawing.Size(140, 50);
            this.btnWindspell.TabIndex = 28;
            this.btnWindspell.Text = "WINDSPELL";
            this.btnWindspell.UseVisualStyleBackColor = false;
            // 
            // btnEarthspell
            // 
            this.btnEarthspell.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEarthspell.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarthspell.Image = ((System.Drawing.Image)(resources.GetObject("btnEarthspell.Image")));
            this.btnEarthspell.Location = new System.Drawing.Point(27, 139);
            this.btnEarthspell.Name = "btnEarthspell";
            this.btnEarthspell.Size = new System.Drawing.Size(140, 50);
            this.btnEarthspell.TabIndex = 29;
            this.btnEarthspell.Text = "EARTHSPELL";
            this.btnEarthspell.UseVisualStyleBackColor = false;
            // 
            // btnWaterspell
            // 
            this.btnWaterspell.BackColor = System.Drawing.Color.Blue;
            this.btnWaterspell.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterspell.Image = ((System.Drawing.Image)(resources.GetObject("btnWaterspell.Image")));
            this.btnWaterspell.Location = new System.Drawing.Point(27, 84);
            this.btnWaterspell.Name = "btnWaterspell";
            this.btnWaterspell.Size = new System.Drawing.Size(140, 50);
            this.btnWaterspell.TabIndex = 30;
            this.btnWaterspell.Text = "WATERSPELL";
            this.btnWaterspell.UseVisualStyleBackColor = false;
            // 
            // btnFirespell
            // 
            this.btnFirespell.BackColor = System.Drawing.Color.Red;
            this.btnFirespell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirespell.BackgroundImage")));
            this.btnFirespell.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirespell.Image = ((System.Drawing.Image)(resources.GetObject("btnFirespell.Image")));
            this.btnFirespell.Location = new System.Drawing.Point(27, 28);
            this.btnFirespell.Name = "btnFirespell";
            this.btnFirespell.Size = new System.Drawing.Size(140, 50);
            this.btnFirespell.TabIndex = 31;
            this.btnFirespell.Text = "FIRESPELL";
            this.btnFirespell.UseVisualStyleBackColor = false;
            this.btnFirespell.Click += new System.EventHandler(this.btnFirespell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnFirespell);
            this.groupBox1.Controls.Add(this.btnWaterspell);
            this.groupBox1.Controls.Add(this.btnWindspell);
            this.groupBox1.Controls.Add(this.btnEarthspell);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(783, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 253);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPELLBOOK";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(605, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 730);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbility);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.arrowDOWN);
            this.Controls.Add(this.arrowRIGHT);
            this.Controls.Add(this.arrowLEFT);
            this.Controls.Add(this.arrowUP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arrowUP;
        private System.Windows.Forms.Button arrowLEFT;
        private System.Windows.Forms.Button arrowDOWN;
        private System.Windows.Forms.Button arrowRIGHT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Button btnWindspell;
        private System.Windows.Forms.Button btnEarthspell;
        private System.Windows.Forms.Button btnWaterspell;
        private System.Windows.Forms.Button btnFirespell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

