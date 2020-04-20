﻿using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int x
        {
            get; 
            set;
        }
        private int xy = 10;
        public int XY
        {
            get
            {
                return xy;
            }
            set
            {
                xy = value;
                if (xy == 100)
                {
                    xy = 10;
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Width = XY;
        }
    }
}
