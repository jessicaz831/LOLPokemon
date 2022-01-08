// Jessica Zhu
// April 13, 2018
// Create a game similar to a Pokemon battle using textboxes, data type conversions, and math. Game allows user to add own stats to character and battle the enemy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonAssignment
{
    public partial class Form1 : Form
    {
        // used to generate the computer's choices and amount of damage
        Random numberGenerator = new Random();

        // saves the textbox contents
        string name;
        int health;
        int healthTotal;
        int heal;
        int magic;
        int magicTotal;
        int attack;
        int attackBase;
        int defense;
        int damage;
        int enemyDamage;
        string enemyName;
        int enemyHealth;
        int enemyHealthTotal;
        int enemyHeal;
        int enemyMagic;
        int enemyMagicTotal;
        int enemyAttack;
        int enemyAttackBase;
        int enemyDefense;

        // saves the computer's ability choice
        int enemyChoice;

        // saves the amount of rounds attack boost can last for
        int rounds;
        int enemyRounds;

        // constants for the different choices the computer can make
        const int ATTACK = 0;
        const int MAGIC = 1;
        const int HEAL = 2;
        const int ATTACK_BOOST = 3;
        const int MAGIC_BOOST = 4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // hides instructions
            lblInfo.Text = "";
            lblRules.Hide();

            // hides all prompts for character's stats
            lblName.Hide();
            lblHealth.Hide();
            lblMagic.Hide();
            lblAttack.Hide();
            lblDefense.Hide();

            // hides all textboxes used to input character's stats
            txtName.Hide();
            txtHealth.Hide();
            txtMagic.Hide();
            txtAttack.Hide();
            txtDefense.Hide();

            // hides characters
            picAshe.Hide();
            picIrelia.Hide();
            picAsheBattle.Hide();
            picIreliaBattle.Hide();

            // hides enemies
            picBaron.Hide();
            picRekSai.Hide();
            picTeemo.Hide();

            // hides start button
            lblStart.Hide();

            // hides battle user interface
            picMenu.Hide();
            lblBattleEnemy.Hide();
            lblBattle.Hide();
            btnAttack.Hide();
            btnMagic.Hide();
            btnHeal.Hide();
            btnAttackBoost.Hide();
            btnMagicBoost.Hide();
            picPlayerBar.Hide();
            picEnemyBar.Hide();
            lblMagicPoints.Text = "";
            lblPlayerName.Text = "";
            lblHealthPoints.Text = "";
            lblEnemyName.Text = "";
            lblEnemyHealthPoints.Text = "";
            lblEnemyMagicPoints.Text = "";
            picVictory.Hide();
            picDefeat.Hide();
            lblContinue1.Hide();
            lblContinue2.Hide();
            lblPlayAgain.Hide();
            lblWin.Hide();
        }

        private void picTitle_Click(object sender, EventArgs e)
        {
            // hides title screen
            picTitle.Hide();
            lblJessica.Hide();

            // shows instructions
            lblInfo.Text = "Choose a champion for battle.";

            // shows character icons for selection
            picAshe.Show();
            picIrelia.Show();
        }

        private void picAshe_Click(object sender, EventArgs e)
        {
            // shows instructions
            lblInfo.Text = "Put in your character's name and stats.\r\nMake sure the sum of all the stats equal to 400.";
            lblRules.Show();

            // hides other character icon option
            picIrelia.Hide();

            // moves character picture box to the bottom right corner of the screen
            picAshe.Location = new Point(589, 380);

            // shows all prompts for character's stats
            lblName.Show();
            lblHealth.Show();
            lblMagic.Show();
            lblAttack.Show();
            lblDefense.Show();

            // shows all textboxes used to input character's stats
            txtName.Show();
            txtHealth.Show();
            txtMagic.Show();
            txtAttack.Show();
            txtDefense.Show();

            // shows start button
            lblStart.Show();
        }

        private void picIrelia_Click(object sender, EventArgs e)
        {
            // shows instructions
            lblInfo.Text = "Put in your champion's name and stats.\r\nMake sure the sum of all the stats equal to 400.";
            lblRules.Show();

            // hides other character icon option
            picAshe.Hide();

            // moves character picture box to the bottom right corner of the screen
            picIrelia.Location = new Point(589, 380);

            // shows all prompts for character's stats
            lblName.Show();
            lblHealth.Show();
            lblMagic.Show();
            lblAttack.Show();
            lblDefense.Show();

            // shows all textboxes used to input character's stats
            txtName.Show();
            txtHealth.Show();
            txtMagic.Show();
            txtAttack.Show();
            txtDefense.Show();

            // shows start button
            lblStart.Show();
        }

        // when player clicks on the prompts, a more detailed description is shown about the prompt
        private void lblName_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Create a name for your champion.";
        }

        private void lblHealth_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "This is the maximum amount of health points (HP) that your champion will have.\r\nEach time your champion is attacked, they will lose HP.\r\nEach time you heal your champion, they will gain HP.\r\nThe number you input will be multiplied by 15 for battle.\r\nYou must have a minimum of 10 HP. \r\nYou will start with full health at the beginning of every round.";
        }

        private void lblMagic_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Ability power (AP) is needed to use spells like healing, attack damage boosting,\r\nor abilities.\r\nEach time a spell is used, AP is reduced.\r\nYou can have a minimum of 0 AP.\r\nYou will start with full AP at the beginning of every round.";
        }

        private void lblAttack_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Attack damage (AD) are points used to calculate the amount of damage your\r\nchampion can deal.\r\nYou can have a minimum of 0 AD.";
        }

        private void lblDefense_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Armour are points used to calulate the amount of damage your champion can\r\nreceive from an enemy's attack.\r\nYou must have a minimum of 1 armour.";
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            // Tries to convert the textbox text into an integer. If it can, saves the converted number into the variable
            int.TryParse(txtHealth.Text, out health);
            int.TryParse(txtHealth.Text, out healthTotal);
            int.TryParse(txtMagic.Text, out magic);
            int.TryParse(txtMagic.Text, out magicTotal);
            int.TryParse(txtAttack.Text, out attack);
            int.TryParse(txtAttack.Text, out attackBase);
            int.TryParse(txtDefense.Text, out defense);

            // save the information if the stats equal 400
            if (txtName.Text != "" && health >= 10 && defense >= 1 && attack >= 0 && magic >= 0 && health + magic + attack + defense == 400)
            {
                // save the information if the player typed in something
                name = txtName.Text;

                // hides instructions
                lblInfo.Text = "";
                lblRules.Hide();

                // hides all prompts for character's stats
                lblName.Hide();
                lblHealth.Hide();
                lblMagic.Hide();
                lblAttack.Hide();
                lblDefense.Hide();

                // hides all textboxes used to input character's stats
                txtName.Hide();
                txtHealth.Hide();
                txtMagic.Hide();
                txtAttack.Hide();
                txtDefense.Hide();

                // hide start button
                lblStart.Hide();

                // changes background to battle background
                this.BackgroundImage = Properties.Resources.summonersrift1;

                // shows battle user interface
                picMenu.Show();
                lblBattleEnemy.Show();
                lblBattle.Show();
                btnAttack.Show();
                btnMagic.Show();
                btnHeal.Show();
                btnAttackBoost.Show();
                btnMagicBoost.Show();
                picPlayerBar.Show();
                picEnemyBar.Show();

                // shows first enemy, Teemo
                picTeemo.Show();

                // set stats for first level enemy
                enemyName = "Teemo";
                enemyHealth = 2250;
                enemyHealthTotal = 2250;
                enemyMagic = 50;
                enemyMagicTotal = 50;
                enemyAttack = 100;
                enemyAttackBase = 100;
                enemyDefense = 100;

                // multiply player's health stats by 15
                health = health * 15;
                healthTotal = healthTotal * 15;

                // display the text "what will Name do?" at the beginning of the first round
                lblBattle.Text = "What will " + name + " do?";
                lblBattleEnemy.Text = "Select a move ->";

                // display player's custom name on bar
                lblPlayerName.Text = name;

                // display enemy's name
                lblEnemyName.Text = enemyName;

                // check if Ashe was chosen as the champion and is currently shown, the picture box for Ashe in the battle screen will show and the icon from before will hide
                if (picAshe.Visible)
                {
                    picAsheBattle.Show();
                    picAshe.Hide();
                }
                // if Ashe is not currently visible, check if Irelia is currently visible. If yes, show the picture box for Irelia in the battle screen and hide the icon from before
                else if (picIrelia.Visible)
                {
                    picIreliaBattle.Show();
                    picIrelia.Hide();
                }
                // display player and enemy's health and magic points
                UpdateLabels();
            }
            else
            {
                // shows error message if requirements for stats aren't met
                lblInfo.Text = "Please ensure all textboxes are filled in and meet the requirements.\r\nAll stats equal to 400.\r\nHealth has a minimum of 10.\r\nArmour has a minimum of 1.\r\nThere are no decimals.";
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // calculate damage player will deal based on their attack, a random number between 100 and 150 and enemy's defense
            damage = numberGenerator.Next(100,151) + attack - enemyDefense;
            // remove enemy health based on amount of damage player dealt
            enemyHealth = enemyHealth - damage;
            lblBattle.Text = name + " used ATTACK for " + damage + "!";
            // remove one round per attack
            rounds = rounds - 1;

            // when rounds are less than one, player's attack returns to original amount
            if (rounds < 1)
            {
                attack = attackBase;
            }

            // run enemy's turn
            EnemyAI();
            // check for win or loss
            CheckWin();
            // update any health or magic points lost or gained for player and enemy
            UpdateLabels();
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            // player must have 20 or more magic points to use magic
            if (magic >= 20)
            {
                // remove enemy health based on amount of magic damage player dealt
                damage = numberGenerator.Next(400, 601);
                enemyHealth = enemyHealth - damage;
                // display how much damage the player dealt
                lblBattle.Text = name + " used MAGIC for " + damage + "!";
                // remove 20 enemy magic points
                magic = magic - 20;
                // run enemy's turn
                EnemyAI();
            }
            // check for win or loss
            CheckWin();
            // update any health or magic points lost or gained for player and enemy
            UpdateLabels();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            // generate random amount of healing between 50 and 200
            heal = numberGenerator.Next(50, 201);
            
            if (health == healthTotal || magic < 10)
            {
                // if health is already maxed out or player has less than 10 magic points display message saying heal cannot be used, do not run enemy's turn
                lblBattle.Text = "You cannot use HEAL right now.";
                lblBattleEnemy.Text = "";
            }
            else if ((health + heal) >= healthTotal && magic >= 10)
            {
                // if the player's health is greater than their maximum amount of health, display player health is maxed
                health = healthTotal;
                // display how much the player healed for
                lblBattle.Text = name + " used HEAL for " + heal + "!";
                // remove 10 player magic points
                magic = magic - 10;
                // run enemy's turn
                EnemyAI();
            }
            else if ((health + heal) < healthTotal && magic >= 10)
            {
                // add random number between 50 and 200 to player's health
                health = health + heal;
                // display how much the player healed for
                lblBattle.Text = name + " used HEAL for " + heal + "!";
                // remove 10 player magic points
                magic = magic - 10;
                // run enemy's turn
                EnemyAI();
            }
            // check for win or loss
            CheckWin();
            // update any health or magic points lost or gained for player and enemy
            UpdateLabels();
        }

        private void btnAttackBoost_Click(object sender, EventArgs e)
        {
            // player must have 5 or more magic points to use attack boost
            if (magic >= 5)
            {
                // add 2 rounds for player's boost
                rounds = rounds + 2;
                // double player's attack
                attack = attack * 2;
                // display that the player used attack boost
                lblBattle.Text = name + " used ATTACK BOOST doubling\r\ntheir attack for 2 rounds!";
                // remove 5 player magic points
                magic = magic - 5;
                // run enemy's turn
                EnemyAI();
            }
            // check for win or loss
            CheckWin();
            // update any health or magic points lost or gained for player and enemy
            UpdateLabels();
        }

        private void btnMagicBoost_Click(object sender, EventArgs e)
        {
            if (magic == magicTotal)
            {
                // if magic is already maxed out display message saying magic boost cannot be used, do not run enemy's turn
                lblBattle.Text = "You cannot use MAGIC BOOST right now.";
                lblBattleEnemy.Text = "";
            }
            else if ((magic + 20) >= magicTotal)
            {
                // if magic points + 20 is greater than total amount of magic points, display magic points as maximum magic points
                magic = magicTotal;
                // display that player used magic boost
                lblBattle.Text = name + " used MAGIC BOOST increasing their magic points by 20!";
                // run enemy's turn
                EnemyAI();
            }
            else if ((magic + 20) < magicTotal)
            {
                // add 20 magic points
                magic = magic + 20;
                // display that player used magic boost
                lblBattle.Text = name + " used MAGIC BOOST increasing their magic points by 20!";
                // run enemy's turn
                EnemyAI();
            }
            // check for win or loss
            CheckWin();
            // update any health or magic points lost or gained for player and enemy
            UpdateLabels();
        }

        private void lblContinue1_Click(object sender, EventArgs e)
        {
            // hide button
            lblContinue1.Hide();

            // hide the victory screen
            picVictory.Hide();

            // shows battle user interface
            picMenu.Show();
            lblBattleEnemy.Show();
            lblBattle.Show();
            btnAttack.Show();
            btnMagic.Show();
            btnHeal.Show();
            btnAttackBoost.Show();
            btnMagicBoost.Show();
            picPlayerBar.Show();
            picEnemyBar.Show();
            lblMagicPoints.Show();
            lblPlayerName.Show();
            lblHealthPoints.Show();
            lblEnemyName.Show();
            lblEnemyHealthPoints.Show();
            lblEnemyMagicPoints.Show();

            // resets the player's stats to everything they inputted in the beginning
            int.TryParse(txtHealth.Text, out health);
            int.TryParse(txtHealth.Text, out healthTotal);
            int.TryParse(txtMagic.Text, out magic);
            int.TryParse(txtMagic.Text, out magicTotal);
            int.TryParse(txtAttack.Text, out attack);
            int.TryParse(txtAttack.Text, out attackBase);
            int.TryParse(txtDefense.Text, out defense);

            // shows second enemy, Rek'Sai
            picRekSai.Show();

            // set stats for second level enemy
            enemyName = "Rek'Sai";
            enemyHealth = 3750;
            enemyHealthTotal = 3750;
            enemyMagic = 50;
            enemyMagicTotal = 50;
            enemyAttack = 50;
            enemyAttackBase = 50;
            enemyDefense = 50;

            // multiply player's health stats by 15
            health = health * 15;
            healthTotal = healthTotal * 15;

            // display the text "what will Name do?" at the beginning of the second round
            lblBattle.Text = "What will " + name + " do?";
            lblBattleEnemy.Text = "Select a move ->";

            // display enemy's name and health
            lblEnemyName.Text = enemyName;

            // move player's champion back to original spot
            picAsheBattle.Location = new Point(0, 287);
            picIreliaBattle.Location = new Point(0, 286);

            // reset all player labels and update enemy labels
            UpdateLabels();
        }

        private void lblContinue2_Click(object sender, EventArgs e)
        {
            // hide button
            lblContinue2.Hide();

            // hide the victory screen
            picVictory.Hide();

            // shows battle user interface
            picMenu.Show();
            lblBattleEnemy.Show();
            lblBattle.Show();
            btnAttack.Show();
            btnMagic.Show();
            btnHeal.Show();
            btnAttackBoost.Show();
            btnMagicBoost.Show();
            picPlayerBar.Show();
            picEnemyBar.Show();
            lblMagicPoints.Show();
            lblPlayerName.Show();
            lblHealthPoints.Show();
            lblEnemyName.Show();
            lblEnemyHealthPoints.Show();
            lblEnemyMagicPoints.Show();

            // reset the player's stats to everything they inputted at the beginning
            int.TryParse(txtHealth.Text, out health);
            int.TryParse(txtHealth.Text, out healthTotal);
            int.TryParse(txtMagic.Text, out magic);
            int.TryParse(txtMagic.Text, out magicTotal);
            int.TryParse(txtAttack.Text, out attack);
            int.TryParse(txtAttack.Text, out attackBase);
            int.TryParse(txtDefense.Text, out defense);

            // shows last enemy, Baron Nashor
            picBaron.Show();

            // set stats for last level enemy
            enemyName = "Baron Nashor";
            enemyHealth = 4500;
            enemyHealthTotal = 4500;
            enemyMagic = 0;
            enemyMagicTotal = 0;
            enemyAttack = 75;
            enemyAttackBase = 75;
            enemyDefense = 25;

            // multiply player's health stats by 15
            health = health * 15;
            healthTotal = healthTotal * 15;

            // display the text "what will Name do?" at the beginning of the first round
            lblBattle.Text = "What will " + name + " do?";
            lblBattleEnemy.Text = "Select a move ->";

            // display enemy's name and health
            lblEnemyName.Text = enemyName;

            // move player's champion back to original spot
            picAsheBattle.Location = new Point(0, 287);
            picIreliaBattle.Location = new Point(0, 286);

            // reset all player labels and update enemy labels
            UpdateLabels();
        }

        private void lblPlayAgain_Click(object sender, EventArgs e)
        {
            // restart the entire application
            Application.Restart();
        }

        void CheckWin()
        {
            if (health <= 0)
            {
                // if player's health is 0 or under, show defeat screen
                picDefeat.Show();

                // hides battle user interface
                picMenu.Hide();
                lblBattleEnemy.Hide();
                lblBattle.Hide();
                btnAttack.Hide();
                btnMagic.Hide();
                btnHeal.Hide();
                btnAttackBoost.Hide();
                btnMagicBoost.Hide();
                picPlayerBar.Hide();
                picEnemyBar.Hide();
                lblMagicPoints.Hide();
                lblPlayerName.Hide();
                lblHealthPoints.Hide();
                lblEnemyName.Hide();
                lblEnemyHealthPoints.Hide();
                lblEnemyMagicPoints.Hide();
                picAsheBattle.Hide();
                picIreliaBattle.Hide();
                
                // show play again button
                lblPlayAgain.Show();
            }

            if (enemyHealth <= 0)
            {
                // if enemy health is 0 or under, show victory screen
                picVictory.Show();

                // hides battle user interface
                picMenu.Hide();
                lblBattleEnemy.Hide();
                lblBattle.Hide();
                btnAttack.Hide();
                btnMagic.Hide();
                btnHeal.Hide();
                btnAttackBoost.Hide();
                btnMagicBoost.Hide();
                picPlayerBar.Hide();
                picEnemyBar.Hide();
                lblMagicPoints.Hide();
                lblPlayerName.Hide();
                lblHealthPoints.Hide();
                lblEnemyName.Hide();
                lblEnemyHealthPoints.Hide();
                lblEnemyMagicPoints.Hide();

                // move player's champion to center of screen to hide
                picAsheBattle.Location = new Point (104, -5);
                picIreliaBattle.Location = new Point(104, -5);

                if (picTeemo.Visible)
                {
                    // if Teemo is currently visible, hide Teemo and display the continue button that leads to the next enemy, Rek'Sai
                    picTeemo.Hide();
                    lblContinue1.Show();
                }
                else if (picRekSai.Visible)
                {
                    // if Rek'Sai is currently visible, hide Rek'Sai and display the continue button that leads to the next enemy, Baron Nashor
                    picRekSai.Hide();
                    lblContinue2.Show();
                }
                else if (picBaron.Visible)
                {
                    // if Baron Nashor is currently visible, hide Baron Nashor and display the play again button
                    picBaron.Hide();
                    lblPlayAgain.Show();
                    lblWin.Show();
                }
            }
        }

        // subprogram that determines enemy's moves
        void EnemyAI()
        {
            // make the computer generate a number between 0 and 4 to choose between attack, magic attack, heal, attack boost, and magic boost
            enemyChoice = numberGenerator.Next(0, 5);

            if (enemyChoice == ATTACK)
            {
                // calculate the amount of damage enemy will deal based on their attack, a random number between 100 and 150 and player's defense
                enemyDamage = numberGenerator.Next(100, 151) + enemyAttack - defense;
                // remove player health based on amount of damage enemy dealt
                health = health - enemyDamage;
                // display how much damage the enemy dealt
                lblBattleEnemy.Text = enemyName + " used ATTACK for " + enemyDamage + "!";
                // remove one round per attack
                enemyRounds = enemyRounds - 1;

                // when rounds are less than 1, enemy's attack returns to original amount
                if (enemyRounds < 1)
                {
                    enemyAttack = enemyAttackBase;
                }
            }

            else if (enemyChoice == MAGIC)
            {
                // enemy must have 20 or more points to use magic
                if (enemyMagic >= 20)
                {
                    // calculate damage enemy will deal based on a random number between 400 and 600
                    enemyDamage = numberGenerator.Next(400, 601);
                    // remove player health based on amount of magic damage enemy dealt
                    health = health - enemyDamage;
                    // display how much damage the enemy dealt
                    lblBattleEnemy.Text = enemyName + " used MAGIC for " + enemyDamage + "!";
                    // remove 20 enemy magic points
                    enemyMagic = enemyMagic - 20;
                }
                else
                {
                    // re-run enemy turn subprogram
                    EnemyAI();
                }
            }

            else if (enemyChoice == HEAL)
            {
                // generate random amount of healing between 50 and 200
                enemyHeal = numberGenerator.Next(50, 201);

                if (enemyHealth == enemyHealthTotal || enemyMagic < 10)
                {
                    // if enemy health is already maxed out or enemy has less than 10 magic points re-run enemy turn subprogram
                    EnemyAI();
                }
                else if ((enemyHealth + enemyHeal) >= enemyHealthTotal && enemyMagic >= 10)
                {
                    // if the enemy's health is greater than their maximum amount of health, display enemy health is maxed
                    enemyHealth = enemyHealthTotal;
                    // display enemy used heal ability
                    lblBattleEnemy.Text = enemyName + " used HEAL for " + enemyHeal + "!";
                    // remove 10 enemy magic points
                    enemyMagic = enemyMagic - 10;
                }
                else if ((enemyHealth + enemyHeal) < enemyHealthTotal && enemyMagic >= 10)
                {
                    // add random number between 50 and 200 to enemy's health
                    enemyHealth = enemyHealth + enemyHeal;
                    // display how much the enemy healed for
                    lblBattleEnemy.Text = enemyName + " used HEAL for " + enemyHeal + "!";
                    // remove 10 enemy magic points
                    enemyMagic = enemyMagic - 10;
                }
            }

            else if (enemyChoice == ATTACK_BOOST)
            {
                if (enemyMagic >= 5)
                {
                    // add 2 rounds for enemy's boost
                    enemyRounds = enemyRounds + 2;
                    // double enemy's attack
                    enemyAttack = enemyAttack * 2;
                    // display that the enemy used attack boost
                    lblBattleEnemy.Text = enemyName + " used ATTACK BOOST doubling\r\ntheir attack for 2 rounds!";
                    // remove 5 enemy magic points
                    enemyMagic = enemyMagic - 5;
                }
                else
                {
                    // re-run enemy turn subprogram
                    EnemyAI();
                }
            }

            else if (enemyChoice == MAGIC_BOOST)
            {
                if (enemyMagic == enemyMagicTotal)
                {
                    // if enemy magic is already maxed out re-run enemy turn subprogram 
                    EnemyAI();
                }
                else if ((enemyMagic + 20) >= enemyMagicTotal)
                {
                    // if enemy magic + 20 magic points is greater than enemy magic total, enemy magic equals total enemy magic
                    enemyMagic = enemyMagicTotal;
                    // display enemy used magic boost
                    lblBattleEnemy.Text = enemyName + " used MAGIC BOOST increasing their magic points by 20!";
                }
                else if ((enemyMagic + 20) < enemyMagicTotal)
                {
                    // if enemy magic + 20 is less than enemy magic total, add 20 to enemy magic
                    enemyMagic = enemyMagic + 20;
                    // display enemy used magic boost
                    lblBattleEnemy.Text = enemyName + " used MAGIC BOOST increasing their magic points by 20!";
                }
            }
        }

        // subprogram that updates player's and enemy's health and magic points for display
        void UpdateLabels()
        {
            // display player and enemy health and magic points out of total amount
            lblHealthPoints.Text = "HP: " + health + "/" + healthTotal;
            lblMagicPoints.Text = "AP: " + magic + "/" + magicTotal;
            lblEnemyHealthPoints.Text = "HP: " + enemyHealth + "/" + enemyHealthTotal;
            lblEnemyMagicPoints.Text = "AP: " + enemyMagic + "/" + enemyMagicTotal;
        }
    }
}
