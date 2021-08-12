using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        double cookiesAmount = 0;
        uint oneClickAmount = 1;
        double cookiesPerSecond = 0;
        Image CookieImage = Image.FromFile("images/cookie_PNG13711.png");

        List<int> upgradePrices = new List<int> { 100, 200, 800, 1500, 10000, 50000 };
        List<int> upgradeLevels = new List<int> { 0, 0, 0, 0, 0, 0 };
        List<double> upgradeUpgrades = new List<double> { 0.1, 0.5, 1, 5, 30, 500 };
        
        public Form1()
        {
            InitializeComponent();

            //CookieButton
            CookieButton.Image = CookieImage;
            CookieButton.ImageAlign = ContentAlignment.MiddleCenter;
            CookieButton.TabStop = false;
            CookieButton.FlatStyle = FlatStyle.Flat;
            CookieButton.FlatAppearance.BorderSize = 0;

            Timer alwaysToUpdateTimer = new System.Windows.Forms.Timer();
            alwaysToUpdateTimer.Interval = 50;
            alwaysToUpdateTimer.Tick += new System.EventHandler(always_Update);
            alwaysToUpdateTimer.Enabled = true;

            Timer rarelyToUpdateTimer = new System.Windows.Forms.Timer();
            rarelyToUpdateTimer.Interval = 100;
            rarelyToUpdateTimer.Tick += new System.EventHandler(rarely_Update);
            rarelyToUpdateTimer.Enabled = true;

            Timer perSecond = new System.Windows.Forms.Timer();
            perSecond.Interval = 1000;
            perSecond.Tick += new System.EventHandler(cookiesPerSecond_Update);
            perSecond.Enabled = true;
        }

        private int addPercentsToPrice(int price)
        {
            price = Convert.ToInt32(price + (price * 0.15));
            return price;
        }
        private double addPercentsToUpgrade(double upgrade)
        {
            upgrade = Convert.ToInt32(upgrade + (upgrade * 0.2));
            return upgrade;
        }

        private void always_Update(object source, EventArgs e)
        {
            int cookiesAmountInt = Convert.ToInt32(cookiesAmount);
            CookieAmountText.Text = cookiesAmountInt.ToString();
        }

        private void rarely_Update(object source, EventArgs e)
        {
            CursorPrice.Text = upgradePrices[0].ToString();
            GrandmaPrice.Text = upgradePrices[1].ToString();
            FarmPrice.Text = upgradePrices[2].ToString();
            MinePrice.Text = upgradePrices[3].ToString();
            FactoryPrice.Text = upgradePrices[4].ToString();

            CursorLevel.Text = upgradeLevels[0].ToString();
            GrandmaLevel.Text = upgradeLevels[1].ToString();
            FarmLevel.Text = upgradeLevels[2].ToString();
            MineLevel.Text = upgradeLevels[3].ToString();
            FactoryLevel.Text = upgradeLevels[4].ToString();

            cookiesPerSecondText.Text = cookiesPerSecond.ToString();
        }

        private void cookiesPerSecond_Update(object source, EventArgs e)
        {
            cookiesAmount += cookiesPerSecond;
        }

        private void CookieButton_Click(object sender, EventArgs e)
        {
            cookiesAmount += oneClickAmount;
        }

        // Upgrades
        private void CursorUpgrade_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (cookiesAmount >= upgradePrices[i])
            {                
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        private void GrandmaUpgrade_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (cookiesAmount >= upgradePrices[i])
            {                
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        private void FarmUpgrade_Click(object sender, EventArgs e)
        {
            int i = 2;
            if (cookiesAmount >= upgradePrices[i])
            {                
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        private void MineUpgrade_Click(object sender, EventArgs e)
        {
            int i = 3;
            if (cookiesAmount >= upgradePrices[i])
            {                
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        private void FactoryUpgrade_Click(object sender, EventArgs e)
        {
            int i = 4;
            if (cookiesAmount >= upgradePrices[i])
            {               
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        private void CosmicEmpireUpgrade_Click(object sender, EventArgs e)
        {
            int i = 5;
            if (cookiesAmount >= upgradePrices[i])
            {                
                upgradeLevels[i] += 1;
                cookiesAmount -= upgradePrices[i];
                upgradePrices[i] = addPercentsToPrice(upgradePrices[i]);
                cookiesPerSecond += upgradeUpgrades[i];
                upgradeUpgrades[i] = addPercentsToUpgrade(upgradeUpgrades[i]);
            }
        }

        // Hand Upgrades
        private void BronzeHandButton_Click(object sender, EventArgs e)
        {
            if (cookiesAmount >= 100)
            {
                cookiesAmount -= 100;
                oneClickAmount = 2;
                BronzeHandButton.Enabled = false;
                SilverHandButton.Enabled = true;
            }
        }

        private void SilverHandButton_Click(object sender, EventArgs e)
        {
            if (cookiesAmount >= 500)
            {
                cookiesAmount -= 500;
                oneClickAmount = 5;
                SilverHandButton.Enabled = false;
                GoldHandButton.Enabled = true;
            }
        }

        private void GoldHandButton_Click(object sender, EventArgs e)
        {
            if (cookiesAmount >= 1500)
            {
                cookiesAmount -= 1500;
                oneClickAmount = 10;
                GoldHandButton.Enabled = false;
                BrilliantHandButton.Enabled = true;
            }
        }

        private void BrilliantHandButton_Click(object sender, EventArgs e)
        {
            if (cookiesAmount >= 5000)
            {
                cookiesAmount -= 5000;
                oneClickAmount = 100;
                BrilliantHandButton.Enabled = false;
            }
        }
    }
}
