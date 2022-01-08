namespace PokemonAssignment
{
    partial class Form1
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
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblMagic = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtMagic = new System.Windows.Forms.TextBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblJessica = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblBattleEnemy = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMagic = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnAttackBoost = new System.Windows.Forms.Button();
            this.btnMagicBoost = new System.Windows.Forms.Button();
            this.lblMagicPoints = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblHealthPoints = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHealthPoints = new System.Windows.Forms.Label();
            this.lblEnemyMagicPoints = new System.Windows.Forms.Label();
            this.lblBattle = new System.Windows.Forms.Label();
            this.picPlayerBar = new System.Windows.Forms.PictureBox();
            this.picEnemyBar = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picTeemo = new System.Windows.Forms.PictureBox();
            this.picRekSai = new System.Windows.Forms.PictureBox();
            this.picBaron = new System.Windows.Forms.PictureBox();
            this.picIreliaBattle = new System.Windows.Forms.PictureBox();
            this.picAsheBattle = new System.Windows.Forms.PictureBox();
            this.picAshe = new System.Windows.Forms.PictureBox();
            this.picIrelia = new System.Windows.Forms.PictureBox();
            this.picDefeat = new System.Windows.Forms.PictureBox();
            this.picVictory = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblContinue1 = new System.Windows.Forms.Label();
            this.lblContinue2 = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRekSai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIreliaBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsheBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAshe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrelia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Lime;
            this.lblHealth.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(176, 471);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(153, 40);
            this.lblHealth.TabIndex = 1;
            this.lblHealth.Text = "Health:";
            this.lblHealth.Click += new System.EventHandler(this.lblHealth_Click);
            // 
            // lblMagic
            // 
            this.lblMagic.AutoSize = true;
            this.lblMagic.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblMagic.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagic.Location = new System.Drawing.Point(54, 537);
            this.lblMagic.Name = "lblMagic";
            this.lblMagic.Size = new System.Drawing.Size(275, 40);
            this.lblMagic.TabIndex = 2;
            this.lblMagic.Text = "Ability Power:";
            this.lblMagic.Click += new System.EventHandler(this.lblMagic_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.BackColor = System.Drawing.Color.Red;
            this.lblAttack.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(43, 606);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(286, 40);
            this.lblAttack.TabIndex = 3;
            this.lblAttack.Text = "Attack Damage:";
            this.lblAttack.Click += new System.EventHandler(this.lblAttack_Click);
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.BackColor = System.Drawing.Color.Orange;
            this.lblDefense.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefense.Location = new System.Drawing.Point(165, 673);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(164, 40);
            this.lblDefense.TabIndex = 4;
            this.lblDefense.Text = "Armour:";
            this.lblDefense.Click += new System.EventHandler(this.lblDefense_Click);
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.Location = new System.Drawing.Point(345, 470);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(202, 44);
            this.txtHealth.TabIndex = 5;
            // 
            // txtMagic
            // 
            this.txtMagic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMagic.Location = new System.Drawing.Point(345, 536);
            this.txtMagic.Name = "txtMagic";
            this.txtMagic.Size = new System.Drawing.Size(202, 44);
            this.txtMagic.TabIndex = 6;
            // 
            // txtAttack
            // 
            this.txtAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttack.Location = new System.Drawing.Point(345, 605);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(202, 44);
            this.txtAttack.TabIndex = 7;
            // 
            // txtDefense
            // 
            this.txtDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefense.Location = new System.Drawing.Point(345, 671);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(202, 44);
            this.txtDefense.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(86, 31);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Cyan;
            this.lblName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(215, 407);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 40);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(345, 406);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 44);
            this.txtName.TabIndex = 11;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblRules.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(164, 296);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(656, 44);
            this.lblRules.TabIndex = 12;
            this.lblRules.Text = "Click on stat prompts for details";
            // 
            // lblJessica
            // 
            this.lblJessica.AutoSize = true;
            this.lblJessica.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblJessica.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJessica.Location = new System.Drawing.Point(352, 609);
            this.lblJessica.Name = "lblJessica";
            this.lblJessica.Size = new System.Drawing.Size(267, 40);
            this.lblJessica.TabIndex = 15;
            this.lblJessica.Text = "By: Jessica Zhu";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblStart.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(762, 696);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(209, 33);
            this.lblStart.TabIndex = 16;
            this.lblStart.Text = "Start battle!";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblBattleEnemy
            // 
            this.lblBattleEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(109)))));
            this.lblBattleEnemy.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleEnemy.ForeColor = System.Drawing.Color.White;
            this.lblBattleEnemy.Location = new System.Drawing.Point(31, 673);
            this.lblBattleEnemy.Name = "lblBattleEnemy";
            this.lblBattleEnemy.Size = new System.Drawing.Size(462, 50);
            this.lblBattleEnemy.TabIndex = 23;
            this.lblBattleEnemy.Text = "label1";
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Red;
            this.btnAttack.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(522, 626);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(135, 39);
            this.btnAttack.TabIndex = 24;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnMagic
            // 
            this.btnMagic.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMagic.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagic.Location = new System.Drawing.Point(672, 626);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(135, 39);
            this.btnMagic.TabIndex = 25;
            this.btnMagic.Text = "Magic";
            this.btnMagic.UseVisualStyleBackColor = false;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.Lime;
            this.btnHeal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(824, 626);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(135, 39);
            this.btnHeal.TabIndex = 26;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnAttackBoost
            // 
            this.btnAttackBoost.BackColor = System.Drawing.Color.Yellow;
            this.btnAttackBoost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttackBoost.Location = new System.Drawing.Point(526, 678);
            this.btnAttackBoost.Name = "btnAttackBoost";
            this.btnAttackBoost.Size = new System.Drawing.Size(206, 39);
            this.btnAttackBoost.TabIndex = 27;
            this.btnAttackBoost.Text = "Attack Boost";
            this.btnAttackBoost.UseVisualStyleBackColor = false;
            this.btnAttackBoost.Click += new System.EventHandler(this.btnAttackBoost_Click);
            // 
            // btnMagicBoost
            // 
            this.btnMagicBoost.BackColor = System.Drawing.Color.Cyan;
            this.btnMagicBoost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagicBoost.Location = new System.Drawing.Point(747, 678);
            this.btnMagicBoost.Name = "btnMagicBoost";
            this.btnMagicBoost.Size = new System.Drawing.Size(212, 39);
            this.btnMagicBoost.TabIndex = 28;
            this.btnMagicBoost.Text = "Magic Boost";
            this.btnMagicBoost.UseVisualStyleBackColor = false;
            this.btnMagicBoost.Click += new System.EventHandler(this.btnMagicBoost_Click);
            // 
            // lblMagicPoints
            // 
            this.lblMagicPoints.AutoSize = true;
            this.lblMagicPoints.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMagicPoints.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagicPoints.Location = new System.Drawing.Point(758, 523);
            this.lblMagicPoints.Name = "lblMagicPoints";
            this.lblMagicPoints.Size = new System.Drawing.Size(105, 32);
            this.lblMagicPoints.TabIndex = 31;
            this.lblMagicPoints.Text = "label1";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPlayerName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(514, 424);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(105, 32);
            this.lblPlayerName.TabIndex = 32;
            this.lblPlayerName.Text = "label1";
            // 
            // lblHealthPoints
            // 
            this.lblHealthPoints.AutoSize = true;
            this.lblHealthPoints.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHealthPoints.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthPoints.Location = new System.Drawing.Point(757, 453);
            this.lblHealthPoints.Name = "lblHealthPoints";
            this.lblHealthPoints.Size = new System.Drawing.Size(105, 32);
            this.lblHealthPoints.TabIndex = 33;
            this.lblHealthPoints.Text = "label2";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEnemyName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.Location = new System.Drawing.Point(3, 96);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(105, 32);
            this.lblEnemyName.TabIndex = 34;
            this.lblEnemyName.Text = "label1";
            // 
            // lblEnemyHealthPoints
            // 
            this.lblEnemyHealthPoints.AutoSize = true;
            this.lblEnemyHealthPoints.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEnemyHealthPoints.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthPoints.Location = new System.Drawing.Point(203, 94);
            this.lblEnemyHealthPoints.Name = "lblEnemyHealthPoints";
            this.lblEnemyHealthPoints.Size = new System.Drawing.Size(105, 32);
            this.lblEnemyHealthPoints.TabIndex = 35;
            this.lblEnemyHealthPoints.Text = "label1";
            // 
            // lblEnemyMagicPoints
            // 
            this.lblEnemyMagicPoints.AutoSize = true;
            this.lblEnemyMagicPoints.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEnemyMagicPoints.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyMagicPoints.Location = new System.Drawing.Point(203, 120);
            this.lblEnemyMagicPoints.Name = "lblEnemyMagicPoints";
            this.lblEnemyMagicPoints.Size = new System.Drawing.Size(105, 32);
            this.lblEnemyMagicPoints.TabIndex = 36;
            this.lblEnemyMagicPoints.Text = "label1";
            // 
            // lblBattle
            // 
            this.lblBattle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(109)))));
            this.lblBattle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle.ForeColor = System.Drawing.Color.White;
            this.lblBattle.Location = new System.Drawing.Point(31, 625);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(462, 48);
            this.lblBattle.TabIndex = 37;
            this.lblBattle.Text = "label1";
            // 
            // picPlayerBar
            // 
            this.picPlayerBar.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerBar.Image = global::PokemonAssignment.Properties.Resources.PlayerBattleHP;
            this.picPlayerBar.Location = new System.Drawing.Point(442, 404);
            this.picPlayerBar.Name = "picPlayerBar";
            this.picPlayerBar.Size = new System.Drawing.Size(542, 192);
            this.picPlayerBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerBar.TabIndex = 30;
            this.picPlayerBar.TabStop = false;
            // 
            // picEnemyBar
            // 
            this.picEnemyBar.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyBar.Image = global::PokemonAssignment.Properties.Resources.EnemyBattleHP;
            this.picEnemyBar.Location = new System.Drawing.Point(-2, 78);
            this.picEnemyBar.Name = "picEnemyBar";
            this.picEnemyBar.Size = new System.Drawing.Size(509, 127);
            this.picEnemyBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyBar.TabIndex = 29;
            this.picEnemyBar.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.Transparent;
            this.picMenu.Image = global::PokemonAssignment.Properties.Resources.PokemonTextbox;
            this.picMenu.Location = new System.Drawing.Point(-2, 605);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(991, 138);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 22;
            this.picMenu.TabStop = false;
            // 
            // picTeemo
            // 
            this.picTeemo.BackColor = System.Drawing.Color.Transparent;
            this.picTeemo.Image = global::PokemonAssignment.Properties.Resources.teemo;
            this.picTeemo.Location = new System.Drawing.Point(643, 78);
            this.picTeemo.Name = "picTeemo";
            this.picTeemo.Size = new System.Drawing.Size(203, 217);
            this.picTeemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeemo.TabIndex = 21;
            this.picTeemo.TabStop = false;
            // 
            // picRekSai
            // 
            this.picRekSai.BackColor = System.Drawing.Color.Transparent;
            this.picRekSai.Image = global::PokemonAssignment.Properties.Resources.reksai;
            this.picRekSai.Location = new System.Drawing.Point(623, 54);
            this.picRekSai.Name = "picRekSai";
            this.picRekSai.Size = new System.Drawing.Size(280, 239);
            this.picRekSai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRekSai.TabIndex = 20;
            this.picRekSai.TabStop = false;
            // 
            // picBaron
            // 
            this.picBaron.BackColor = System.Drawing.Color.Transparent;
            this.picBaron.Image = global::PokemonAssignment.Properties.Resources.BaronNashor;
            this.picBaron.Location = new System.Drawing.Point(593, -5);
            this.picBaron.Name = "picBaron";
            this.picBaron.Size = new System.Drawing.Size(337, 334);
            this.picBaron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBaron.TabIndex = 19;
            this.picBaron.TabStop = false;
            // 
            // picIreliaBattle
            // 
            this.picIreliaBattle.BackColor = System.Drawing.Color.Transparent;
            this.picIreliaBattle.Image = global::PokemonAssignment.Properties.Resources.ireliaback;
            this.picIreliaBattle.Location = new System.Drawing.Point(0, 287);
            this.picIreliaBattle.Name = "picIreliaBattle";
            this.picIreliaBattle.Size = new System.Drawing.Size(319, 320);
            this.picIreliaBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIreliaBattle.TabIndex = 18;
            this.picIreliaBattle.TabStop = false;
            // 
            // picAsheBattle
            // 
            this.picAsheBattle.BackColor = System.Drawing.Color.Transparent;
            this.picAsheBattle.Image = global::PokemonAssignment.Properties.Resources.asheback;
            this.picAsheBattle.Location = new System.Drawing.Point(0, 286);
            this.picAsheBattle.Name = "picAsheBattle";
            this.picAsheBattle.Size = new System.Drawing.Size(319, 320);
            this.picAsheBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAsheBattle.TabIndex = 17;
            this.picAsheBattle.TabStop = false;
            // 
            // picAshe
            // 
            this.picAshe.BackColor = System.Drawing.Color.Transparent;
            this.picAshe.Image = global::PokemonAssignment.Properties.Resources.ashe;
            this.picAshe.Location = new System.Drawing.Point(50, 176);
            this.picAshe.Name = "picAshe";
            this.picAshe.Size = new System.Drawing.Size(400, 401);
            this.picAshe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAshe.TabIndex = 13;
            this.picAshe.TabStop = false;
            this.picAshe.Click += new System.EventHandler(this.picAshe_Click);
            // 
            // picIrelia
            // 
            this.picIrelia.BackColor = System.Drawing.Color.Transparent;
            this.picIrelia.Image = global::PokemonAssignment.Properties.Resources.irelia;
            this.picIrelia.Location = new System.Drawing.Point(522, 176);
            this.picIrelia.Name = "picIrelia";
            this.picIrelia.Size = new System.Drawing.Size(408, 401);
            this.picIrelia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIrelia.TabIndex = 14;
            this.picIrelia.TabStop = false;
            this.picIrelia.Click += new System.EventHandler(this.picIrelia_Click);
            // 
            // picDefeat
            // 
            this.picDefeat.BackColor = System.Drawing.Color.Transparent;
            this.picDefeat.Image = global::PokemonAssignment.Properties.Resources.defeat;
            this.picDefeat.Location = new System.Drawing.Point(104, -5);
            this.picDefeat.Name = "picDefeat";
            this.picDefeat.Size = new System.Drawing.Size(773, 766);
            this.picDefeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDefeat.TabIndex = 39;
            this.picDefeat.TabStop = false;
            // 
            // picVictory
            // 
            this.picVictory.BackColor = System.Drawing.Color.Transparent;
            this.picVictory.Image = global::PokemonAssignment.Properties.Resources.vistory;
            this.picVictory.Location = new System.Drawing.Point(104, -5);
            this.picVictory.Name = "picVictory";
            this.picVictory.Size = new System.Drawing.Size(773, 766);
            this.picVictory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVictory.TabIndex = 38;
            this.picVictory.TabStop = false;
            // 
            // picTitle
            // 
            this.picTitle.Image = global::PokemonAssignment.Properties.Resources.titlescreen;
            this.picTitle.Location = new System.Drawing.Point(-8, -5);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(997, 748);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            this.picTitle.Click += new System.EventHandler(this.picTitle_Click);
            // 
            // lblContinue1
            // 
            this.lblContinue1.AutoSize = true;
            this.lblContinue1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblContinue1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContinue1.Location = new System.Drawing.Point(821, 696);
            this.lblContinue1.Name = "lblContinue1";
            this.lblContinue1.Size = new System.Drawing.Size(147, 33);
            this.lblContinue1.TabIndex = 40;
            this.lblContinue1.Text = "Continue";
            this.lblContinue1.Click += new System.EventHandler(this.lblContinue1_Click);
            // 
            // lblContinue2
            // 
            this.lblContinue2.AutoSize = true;
            this.lblContinue2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblContinue2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContinue2.Location = new System.Drawing.Point(822, 696);
            this.lblContinue2.Name = "lblContinue2";
            this.lblContinue2.Size = new System.Drawing.Size(147, 33);
            this.lblContinue2.TabIndex = 41;
            this.lblContinue2.Text = "Continue";
            this.lblContinue2.Click += new System.EventHandler(this.lblContinue2_Click);
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPlayAgain.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayAgain.Location = new System.Drawing.Point(802, 696);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(169, 33);
            this.lblPlayAgain.TabIndex = 42;
            this.lblPlayAgain.Text = "Play Again";
            this.lblPlayAgain.Click += new System.EventHandler(this.lblPlayAgain_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblWin.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(249, 78);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(483, 36);
            this.lblWin.TabIndex = 43;
            this.lblWin.Text = "You defeated all the enemies!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 738);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblBattle);
            this.Controls.Add(this.lblEnemyMagicPoints);
            this.Controls.Add(this.lblEnemyHealthPoints);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblHealthPoints);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblMagicPoints);
            this.Controls.Add(this.picPlayerBar);
            this.Controls.Add(this.picEnemyBar);
            this.Controls.Add(this.btnMagicBoost);
            this.Controls.Add(this.btnAttackBoost);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblBattleEnemy);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtDefense);
            this.Controls.Add(this.txtAttack);
            this.Controls.Add(this.txtMagic);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblMagic);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.picAshe);
            this.Controls.Add(this.picIrelia);
            this.Controls.Add(this.lblJessica);
            this.Controls.Add(this.lblContinue1);
            this.Controls.Add(this.lblContinue2);
            this.Controls.Add(this.picDefeat);
            this.Controls.Add(this.picVictory);
            this.Controls.Add(this.picIreliaBattle);
            this.Controls.Add(this.picAsheBattle);
            this.Controls.Add(this.picTeemo);
            this.Controls.Add(this.picRekSai);
            this.Controls.Add(this.picBaron);
            this.Controls.Add(this.picTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRekSai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIreliaBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsheBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAshe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIrelia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVictory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblMagic;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtMagic;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.TextBox txtDefense;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.PictureBox picAshe;
        private System.Windows.Forms.PictureBox picIrelia;
        private System.Windows.Forms.Label lblJessica;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox picAsheBattle;
        private System.Windows.Forms.PictureBox picIreliaBattle;
        private System.Windows.Forms.PictureBox picBaron;
        private System.Windows.Forms.PictureBox picRekSai;
        private System.Windows.Forms.PictureBox picTeemo;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label lblBattleEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnAttackBoost;
        private System.Windows.Forms.Button btnMagicBoost;
        private System.Windows.Forms.PictureBox picEnemyBar;
        private System.Windows.Forms.PictureBox picPlayerBar;
        private System.Windows.Forms.Label lblMagicPoints;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblHealthPoints;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyHealthPoints;
        private System.Windows.Forms.Label lblEnemyMagicPoints;
        private System.Windows.Forms.Label lblBattle;
        private System.Windows.Forms.PictureBox picVictory;
        private System.Windows.Forms.PictureBox picDefeat;
        private System.Windows.Forms.Label lblContinue1;
        private System.Windows.Forms.Label lblContinue2;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Label lblWin;
    }
}

