﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.StatsFormManager
{
    public partial class uiRecipeRatingsForm : Form
    {
        GetStatsManager _statsManager;
        public uiRecipeRatingsForm(GetStatsManager gsm)
        {
            _statsManager = gsm;
            InitializeComponent();
        }
    }
}